namespace Workflow.DTO.Models
{



    public partial class BlanksOrderFile : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public Guid BlanksOrderGID { get; set; }



        public Guid FileGID { get; set; }




        public String Name { get; set; }




        public String Description { get; set; }



        public Guid TypeGID { get; set; }
    }
}