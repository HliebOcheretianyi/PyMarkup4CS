namespace Workflow.DTO.Models
{



    public partial class RegionType : Workflow.DTO.Models.IdentityPersistentEntity
    {
        public static readonly Guid Region = new Guid("DB688E7C-534C-4A40-85E1-76DC80253174");
        public static readonly Guid District = new Guid("E4CB5212-1FEC-4A63-B00B-523BA9B62DF0");




        public string Name { get; set; }




        public Guid CountryGID { get; set; }




        public Guid? ParentGID { get; set; }




        public Guid? Value { get; set; }



        public string ValueCaption { get; set; }



        public int RegionsCount { get; set; }




        public string NameLocalized { get; set; }


        public bool HasRegionWithSameParent { get; set; }


        public Guid? KatottgCategoryGID { get; set; }
    }
}
