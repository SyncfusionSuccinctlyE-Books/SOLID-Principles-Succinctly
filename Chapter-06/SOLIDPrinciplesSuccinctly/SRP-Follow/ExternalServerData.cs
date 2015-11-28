using System;

namespace SRP_Follow
{
    public class ExternalServerData
    {

        public int Id { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }
        public int OrderNumber { get; set; }
        public bool IsDirty { get; set; }
        public string IP { get; set; }
        public int Type { get; set; }
        public int RecordIdentifier { get; set; }

    }
}