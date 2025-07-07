namespace Workflow.DTO.Models
{



    public partial class BlanksOrder : Workflow.DTO.Models.IdentityPersistentEntity
    {
        #region ProtoMember




        public Guid StatusGID { get; set; }




        public Guid CreatorGID { get; set; }




        public string Comment { get; set; }




        public Guid BranchGID { get; set; }




        public DateTime CreateDate { get; set; }




        public Guid? BranchSenderGID { get; set; }




        public Guid? WorkflowGID { get; set; }




        public List<BlanksOrderItem> BlanksOrderItems { get; set; }




        public List<BlanksOrderFile> BlanksOrderFiles { get; set; }

        #endregion

        #region Cache Details

        #endregion
    }
}
