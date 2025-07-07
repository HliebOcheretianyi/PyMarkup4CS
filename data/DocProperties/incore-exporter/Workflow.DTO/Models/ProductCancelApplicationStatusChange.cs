namespace Workflow.DTO.Models
{


    public partial class ProductCancelApplicationStatusChange : Workflow.DTO.Models.IdentityPersistentEntity
    {


        public Guid ProductCancelApplicationGID { get; set; }



        public Guid StatusGID { get; set; }



        public string Comment { get; set; }

    }
}