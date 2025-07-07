namespace Workflow.DTO.Models
{



    public partial class BlanksOrderItem : Workflow.DTO.Models.IdentityPersistentEntity
    {
        #region ProtoMember




        public Guid BlankTypeGID { get; set; }




        public long BlanksCount { get; set; }




        public Guid BlanksOrderGID { get; set; }




        public long EmploeeRemains { get; set; }




        public long BranchRemains { get; set; }




        public long Rate { get; set; }




        public string BlankSeries { get; set; }

        #endregion
    }
}
