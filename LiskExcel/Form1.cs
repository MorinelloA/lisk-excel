using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiskExcel
{
    public partial class Form1 : Form
    {
        string node = ConfigurationManager.AppSettings["NodeUrl"];

        public Form1()
        {
            InitializeComponent();
        }

        private bool isValidAddress(string address)
        {
            if(address.Length < 2)
            {
                return false;
            }
            else if(address.Substring(address.Length - 1, 1) != "L")
            {
                return false;
            }
            else
            {
                long n;
                bool isNumeric = long.TryParse(address.Substring(0, address.Length - 1), out n);
                return isNumeric;
            }
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            if (txtSenderAddress.Text != "" && !isValidAddress(txtSenderAddress.Text.Trim()))
            {
                MessageBox.Show("Invalid Sender Address Entered");
            }
            else if (txtRecipientAddress.Text != "" && !isValidAddress(txtRecipientAddress.Text.Trim()))
            {
                MessageBox.Show("Invalid Recipient Address Entered");
            }
            else if (txtBothAddress.Text != "" && !isValidAddress(txtBothAddress.Text.Trim()))
            {
                MessageBox.Show("Invalid Sender Or Recipient Address Entered");
            }
            else
            {
                DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                epoch = epoch.AddSeconds(1464109200);

                DateTime startdt = dtpStart.Value;
                long start = (long)(startdt.ToUniversalTime() - epoch).TotalSeconds;
                string strStart = "&fromTimestamp=" + start;

                DateTime enddt = dtpEnd.Value;
                long end = (long)(enddt.ToUniversalTime() - epoch).TotalSeconds;
                string strEnd = "&toTimestamp=" + end;

                long min = (long)(nudMin.Value * 100000000);
                long max = (long)(nudMax.Value * 100000000);

                if (start > end)
                {
                    MessageBox.Show("Start time comes after End time");
                }
                else if(min > max)
                {
                    MessageBox.Show("Min value greater than Max value");
                }
                else
                {
                    string strMin = "&minAmount=" + min;
                    string strMax = "";
                    //Account for an error in API when looking for 0 as a Max value
                    if(max > 0)
                    {
                        strMax = "&maxAmount=" + max;
                    }

                    string address = txtSenderAddress.Text.Trim();

                    string transType = "";
                    if (cboType.Text == "Transfer(Type 0)")
                    {
                        transType = "&type=0";
                    }
                    else if (cboType.Text == "Vote(Type 3)")
                    {
                        transType = "&type=3";
                    }

                    string senderAddress = txtSenderAddress.Text;
                    if (senderAddress != "")
                    {
                        senderAddress = "&senderId=" + senderAddress;
                    }

                    string recipientAddress = txtRecipientAddress.Text;
                    if (recipientAddress != "")
                    {
                        recipientAddress = "&recipientId=" + recipientAddress;
                    }

                    string bothAddress = txtBothAddress.Text;
                    if (bothAddress != "")
                    {
                        bothAddress = "&senderIdOrRecipientId=" + bothAddress;
                    }

                    string s;
                    
                    Trans trans = new Trans();

                    using (WebClient client = new WebClient())
                    {
                        string url = node + "/api/transactions?offset=0" + senderAddress + recipientAddress + bothAddress + strStart + strEnd + strMin + strMax + transType + "&limit=1";
                        s = client.DownloadString(url);
                    }
                    trans = JsonConvert.DeserializeObject<Trans>(s);

                    if ((MessageBox.Show("This request will process " + trans.meta.count + " transactions. Do you wish to proceed?", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                    {
                        this.Enabled = false;
                        int i = 0;

                        List<Tran> allTrans = new List<Tran>();
                        do
                        {
                            Console.WriteLine(i);

                            using (WebClient client = new WebClient())
                            {
                                string url = node + "/api/transactions?offset=" + i + senderAddress + recipientAddress + bothAddress + strStart + strEnd + strMin + strMax + transType + "&limit=100";
                                s = client.DownloadString(url);
                            }
                            trans = JsonConvert.DeserializeObject<Trans>(s);
                            foreach (Tran tr in trans.data)
                            {
                                allTrans.Add(tr);
                            }
                            i += 100;
                        } while (trans.meta.count > i - 100);

                        ExcelPackage ep = new ExcelPackage();

                        var ws = ep.Workbook.Worksheets.Add("Transactions");
                        ws.Cells["A1"].Value = "Tx ID";
                        ws.Cells["B1"].Value = "From";
                        ws.Cells["C1"].Value = "To";
                        ws.Cells["D1"].Value = "Amount";
                        ws.Cells["E1"].Value = "Fee";
                        ws.Cells["F1"].Value = "Datetime";
                        ws.Cells["G1"].Value = "Timestamp";
                        ws.Cells["H1"].Value = "Height";

                        for (int ii = 0; ii < allTrans.Count; ii++)
                        {
                            if (radYes.Checked)
                            {
                                ws.Cells["A" + (ii + 2)].Formula = "HYPERLINK(\"https://explorer.lisk.io/tx/" + allTrans[ii].id + "\",\"" + allTrans[ii].id + "\")";
                                ws.Cells["B" + (ii + 2)].Formula = "HYPERLINK(\"https://explorer.lisk.io/address/" + allTrans[ii].senderId + "\",\"" + allTrans[ii].senderId + "\")";
                                ws.Cells["C" + (ii + 2)].Formula = "HYPERLINK(\"https://explorer.lisk.io/address/" + allTrans[ii].recipientId + "\",\"" + allTrans[ii].recipientId + "\")";
                            }
                            else
                            {
                                ws.Cells["A" + (ii + 2)].Value = allTrans[ii].id;
                                ws.Cells["B" + (ii + 2)].Value = allTrans[ii].senderId;
                                ws.Cells["C" + (ii + 2)].Value = allTrans[ii].recipientId;
                            }

                            ws.Cells["D" + (ii + 2)].Value = (decimal)allTrans[ii].amount / 100000000;
                            ws.Cells["E" + (ii + 2)].Value = (decimal)allTrans[ii].fee / 100000000;

                            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                            dateTime = dateTime.AddSeconds(allTrans[ii].timestamp + 1464109200);
                            ws.Cells["F" + (ii + 2)].Value = dateTime.ToString("MM/dd/yyyy HH:mm");
                            ws.Cells["G" + (ii + 2)].Value = allTrans[ii].timestamp;
                            ws.Cells["H" + (ii + 2)].Value = allTrans[ii].height;
                        }

                        try
                        {
                            sfd.Filter = "Excel File|*.xlsx";
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                ep.SaveAs(new FileInfo(sfd.FileName));
                                MessageBox.Show("File Saved");
                            }
                            else
                            {
                                MessageBox.Show("Cancelled");
                            }
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show(ee.ToString());
                        }
                        finally
                        {
                            this.Enabled = true;
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cmdEpoch_Click(object sender, EventArgs e)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            epoch = epoch.AddSeconds(1464109200);
            dtpStart.Value = epoch;
        }

        private void cmdNow_Click(object sender, EventArgs e)
        {
            dtpEnd.Value = DateTime.Now;
        }

        private void grpAddresses_Enter(object sender, EventArgs e)
        {

        }

        private void cmdZero_Click(object sender, EventArgs e)
        {
            nudMin.Value = 0;
        }

        private void cmdMax_Click(object sender, EventArgs e)
        {
            nudMax.Value = 100000000;
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by TonyT908\n\nwww.tonyt908.com\n\nEmail: MorinelloA@gmail.com\nLisk.chat: TonyT908\nReddit: TonyT908\nTwitter: @SupportLisk\nGitHub: MorinelloA\n\nIf you find this tool useful, please consider a vote for me :)", "About");
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- All three address field may be left blank\n- Start time must be earlier than End time\n- Min Amount must be greater than or equal to Max Amount\n- Entering a max value of 0 will effectively query all amounts from the Min entered upwards", "Help");
        }
    }
}
