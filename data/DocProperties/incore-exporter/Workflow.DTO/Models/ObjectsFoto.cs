namespace Workflow.DTO.Models
{


    public partial class ObjectsFoto : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public Guid ObjectGID { get; set; }


        public Guid FileGID { get; set; }



        public String Name { get; set; }


        public Boolean IsImage { get; set; }


        public Int32? Width { get; set; }


        public Int32? Height { get; set; }


        public Guid ObjectFotoSiteGID { get; set; }


        public Guid? DocumentGID { get; set; }


        public DateTime? CreatedDate { get; set; }


        public Guid? OriginalGID { get; set; }

    }
}