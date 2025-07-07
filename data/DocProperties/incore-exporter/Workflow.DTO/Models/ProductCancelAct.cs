namespace Workflow.DTO.Models
{


    public partial class ProductCancelAct : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public String ActNum { get; set; }


        public Guid BranchGID { get; set; }



        public DateTime SignDate { get; set; }


        public Guid ProductCancelTypeGID { get; set; }

    }
}