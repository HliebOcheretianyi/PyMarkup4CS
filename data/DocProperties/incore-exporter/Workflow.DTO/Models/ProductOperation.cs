namespace Workflow.DTO.Models
{

    public partial class ProductOperation : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {

        public Guid ProductGID { get; set; }


        public DateTime? Date { get; set; }


        public string Operation { get; set; }


        public string Description { get; set; }
    }
}