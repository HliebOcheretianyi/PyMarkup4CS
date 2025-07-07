namespace Workflow.DTO.Models
{



    public class Country : Workflow.DTO.Models.IdentityPersistentEntity
    {



        public string Name { get; set; }




        public string NameLocalized { get; set; }




        public string Abbreviation { get; set; }




        public bool IsPrimary { get; set; }




        public string Code { get; set; }
    }
}
