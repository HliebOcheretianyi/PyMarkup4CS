namespace Workflow.DTO.Models
{



    public partial class ActFile : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public Guid ActGID { get; set; }



        public Guid FileGID { get; set; }




        public String Name { get; set; }




        public String Description { get; set; }



        public Guid TypeGID { get; set; }



        public Guid SourceTypeGID { get; set; }
    }
}
