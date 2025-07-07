namespace Workflow.DTO.Models
{



    public partial class ObjectRelation : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        public ObjectRelation()
        {

        }

        public static readonly Guid ObjectRelationTypeBeneficiar = new Guid("4D0E46D1-7A06-4E76-B9DB-A9C4A63755BC");
        public static readonly Guid ObjectRelationTypeOfficial = new Guid("9670A0FF-99B7-4810-8115-B2616B068A7A");



        public Guid ObjectGID { get; set; }


        public Guid RelationObjectGID { get; set; }


        public Guid RelationTypeGID { get; set; }



        public string RelationObjectName { get; set; }



        public virtual Object RelationObject { get; set; }


        public virtual Object Object { get; set; }


        public User Author { get; set; }

        public Guid? OriginalGID { get; set; }
    }
}
