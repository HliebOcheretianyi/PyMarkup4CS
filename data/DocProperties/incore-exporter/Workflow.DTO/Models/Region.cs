namespace Workflow.DTO.Models
{



    public partial class Region : Workflow.DTO.Models.IdentityPersistentEntity
    {
        public static readonly Guid RegionKyiv = new Guid("0a5ccc3c-51b9-485b-bb6d-38ba9d1e0215");
        public static readonly Guid RegionSevastopol = new Guid("738d55bf-4bd2-4e8c-8962-2d6e77321a43");

        public static readonly Guid TasRegionCrimea = new Guid("C1B4406B-712F-462B-B337-614AA034AB3A");
        public static readonly Guid TasRegionVinnytsia = new Guid("D9D8EF12-A1B5-47C5-88E2-4BA619BDBE87");
        public static readonly Guid TasRegionVolyn = new Guid("CD222381-5386-46DD-8A69-592F54C0422B");
        public static readonly Guid TasRegionDnipropetrovsk = new Guid("6F392DF6-B0C3-41F7-BDBD-5B7D41FC8B66");
        public static readonly Guid TasRegionDonetsk = new Guid("FC2A7F63-08B5-49EE-A10C-368ED6EBB78D");
        public static readonly Guid TasRegionZhytomyr = new Guid("B4828645-5610-4F4A-8D03-5A71396035B5");
        public static readonly Guid TasRegionZacarpatian = new Guid("ECA8C534-30F3-46AC-80F0-08A570AC34E2");
        public static readonly Guid TasRegionZaporozhye = new Guid("24314A76-24D4-413C-856F-AC65BFCE36BD");
        public static readonly Guid TasRegionIvanoFrankivsk = new Guid("ACFD89BD-391B-402B-9EDC-2A68F56ACBA0");
        public static readonly Guid TasRegionKiev = new Guid("5F371E62-0A26-4A66-B3A8-0B4F80FB8EE5");
        public static readonly Guid TasRegionKirovohrad = new Guid("8A04EF68-CD08-4BFB-BF59-9DDB2046098A");
        public static readonly Guid TasRegionLugansk = new Guid("FFC7069A-3C96-4F45-AAA2-8BAF57FB47D8");
        public static readonly Guid TasRegionLviv = new Guid("285CD93C-5182-4197-9D05-6BAE646E1201");
        public static readonly Guid TasRegionNikolaev = new Guid("E3D12EBA-86BF-4AF1-851A-2946B15FA9BA");
        public static readonly Guid TasRegionOdessa = new Guid("4310CFBF-4CFF-429E-BCA7-1D2B85724500");
        public static readonly Guid TasRegionPoltava = new Guid("2214A88B-BE7B-429D-AFB1-B341B1687174");
        public static readonly Guid TasRegionRivne = new Guid("715D2694-A1C5-40A0-8B06-5EEBD1E1F4C2");
        public static readonly Guid TasRegionSumy = new Guid("A259CB38-845B-4DB9-ABF0-7402A6FFBECC");
        public static readonly Guid TasRegionTernopil = new Guid("E4695FCE-1C7F-4BA7-B626-6347623BA1C9");
        public static readonly Guid TasRegionKharkov = new Guid("5B5C44A4-AE55-4CD9-A6F4-20DB366077E5");
        public static readonly Guid TasRegionKherson = new Guid("2F7A4C80-F51E-4F14-A2AF-6BA77006BCF2");
        public static readonly Guid TasRegionKhmelnytsky = new Guid("D067DB3B-77DD-4A93-ACD6-CEF0B24A4040");
        public static readonly Guid TasRegionCherkasy = new Guid("D7168D52-A803-4EED-862B-8F696C003C2A");
        public static readonly Guid TasRegionChernivtsi = new Guid("8CFD8832-121C-4EB7-8CE2-E9C66F419514");
        public static readonly Guid TasRegionChernihiv = new Guid("8428B30F-0D8A-4AD0-8F55-D418A2F3982A");




        public string Name { get; set; }




        public string NameLocalized { get; set; }



        public Guid RegionTypeGID { get; set; }



        public Guid? ParentGID { get; set; }



        public Guid CountryGID { get; set; }



        public Guid? MainSettlementGID { get; set; }




        public string Code { get; set; }




        public bool Active { get; set; }

    }
}
