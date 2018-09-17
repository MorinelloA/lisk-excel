using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskExcel
{
    public class Meta
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int count { get; set; }
    }

    public class Asset
    {
        public List<string> votes { get; set; }
    }

    public class Tran
    {
        public string id { get; set; }
        public long height { get; set; }
        public string blockId { get; set; }
        public int type { get; set; }
        public long timestamp { get; set; }
        public string senderPublicKey { get; set; }
        public string senderId { get; set; }
        public string recipientId { get; set; }
        public string recipientPublicKey { get; set; }
        public long amount { get; set; }
        public long fee { get; set; }
        public string signature { get; set; }
        public List<object> signatures { get; set; }
        public long confirmations { get; set; }
        public Asset asset { get; set; }
    }

    public class Links
    {
    }

    public class Trans
    {
        public Meta meta { get; set; }
        public List<Tran> data { get; set; }
        public Links links { get; set; }
    }
}
