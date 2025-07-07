namespace Workflow.DTO.Models
{


    public partial class ProductCancelReturn : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public Guid ProductCancelGID { get; set; }



        public Guid? ProductGID { get; set; }



        public string PolisNumber { get; set; }



        public Guid? ObjectGID { get; set; }



        public Guid? DocumentGID { get; set; }



        public Guid? AccountGID { get; set; }


        public Guid? ReturnTypeGID { get; set; }



        public string Comment { get; set; }



        public string Description { get; set; }



        public Guid? LastModifiedAuthorGID { get; set; }



        public DateTime? LastModifiedDate { get; set; }



        public Guid? CreatorUserGID { get; set; }



        public DateTime? CreateDate { get; set; }



        public Object Object { get; set; }



        public List<EntityAttribute> EntityAttributes { get; set; }



        public Product Product { get; set; }



        public Decimal ReturnSum { get; set; }



        public Guid? ObjectVersionGID { get; set; }

    }
}