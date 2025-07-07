namespace Workflow.DTO.Models
{


    public partial class InsuranceApplicationStatusChange : Workflow.DTO.Models.IdentityPersistentEntity
    {


        public Guid InsuranceApplicationGID { get; set; }



        public Guid StatusGID { get; set; }


        public Guid CreatorUserGID { get; set; }



        public DateTime CreatedDate { get; set; }



        public List<StatusChangeParameterValue> StatusChangeParameterValues { get; set; }


        public Guid? VariantGID { get; set; }



        public Guid? ProductGID { get; set; }


        public Guid? RegionGID { get; set; }



        public string Comment { get; set; }


        public string CreatorUserName { get; set; }



        public string PermissionNumber { get; set; }



        public DateTime? PermissionDate { get; set; }

    }
}