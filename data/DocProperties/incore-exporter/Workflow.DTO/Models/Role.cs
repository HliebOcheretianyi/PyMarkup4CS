namespace Workflow.DTO.Models
{



    public class Role : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        public static readonly Guid Admin = new Guid("14B1F2FF-BB37-4652-8EE1-03336A45035E");
        public static readonly Guid Operator = new Guid("B379EE46-E4FF-45AD-8AD3-88420B792433");
        public static readonly Guid Shtat = new Guid("38189969-8B61-4582-B091-F6F38E6B4839");
        public static readonly Guid CallCenterOperator = new Guid("B379EE46-E4FF-45AD-8AD3-88420B792433");
        public static readonly Guid CallCenterManager = new Guid("6043D5A8-B6EF-4A19-979B-C5F7A18D4AF1");
        public static readonly Guid InternetShopOperator = new Guid("99F4FE1E-F6C3-4640-9B02-B10DCCD20B05");
        public static readonly Guid AgentPhisical = new Guid("6C57C206-183F-4338-A714-9810285968C7");
        public static readonly Guid PartnerSeller = new Guid("DFC18AED-E0F6-44F9-BA2F-485BC29D4E54");
        public static readonly Guid LongationResponsible = new Guid("58EB7B99-A7D8-41A9-8396-579EFEBB8113");

        public static readonly Guid TasDirector = new Guid("50E6EF5E-D434-4231-A3A6-344DBB4963D7");
        public static readonly Guid TasSubDirector = new Guid("E3230C47-19C2-4C6D-8D01-2B4D5B23FAE1");

        public string Name { get; set; }
    }
}
