using System;

namespace Workflow.DTO.Models
{
    public class InsuranceType
    {
        public static readonly Guid OrantaMtpl = new Guid("4EFB1FF8-995B-47F0-844F-930648933896");

        public static readonly Guid TasVZR = new Guid("481B0919-B363-493F-ADD9-9BB39DD3B89D");
        public static readonly Guid TasAccident = new Guid("1B3FB7AE-639E-4038-A196-AC027A06906E");
        public static readonly Guid TasCasko = new Guid("E5CA5213-3889-44D4-990E-5777785E5C1C");
        public static readonly Guid TasEstate = new Guid("FBD5E1A4-72DB-43CF-B741-57E4073C1A08");

        public static readonly Guid ZlagodaCasko = new Guid("42CD0413-FD03-451E-AC64-930C70873B22");
        public static readonly Guid ZlagodaAccident = new Guid("99FAE442-9E6F-4637-8C9E-59112B38E8B9");

        public static readonly Guid ZlagodaEstate = new Guid("64CEE051-F024-45CB-8002-E506B577311D");
        public static readonly Guid ZlagodaEstateForFire = new Guid("16CEB9E4-6D02-4356-9154-F2D86C22C3F5");
        public static readonly Guid[] ZlagodaEstates = new Guid[] { ZlagodaEstate, ZlagodaEstateForFire };

        public static readonly Guid ZlagodaResponsible = new Guid("D5559EA9-E580-4535-B3BF-3626CA9326D2");
        public static readonly Guid ZlagodaDangerousCargo = new Guid("e7dc4ec1-e5ca-47c6-83cf-4c77666efdaf");

        public static readonly Guid ZlagodaFireMan = new Guid("4B9D81F9-B72F-45B0-85D9-D216D319AB0D");

        public static readonly Guid BakiSigortaCasko = new Guid("DB71094D-B74B-4185-B6E8-95F64CF658E3");
        public static readonly Guid BakiSigortaEstate = new Guid("C5AB4B87-0296-4C77-80B6-295B2C803A58");
        public static readonly Guid BakiSigortaAccident = new Guid("4D162EDD-8BE2-4592-B062-81B465F6885A");
        public static readonly Guid BakiSigortaCivilLiability = new Guid("9DF82DB0-2844-4A76-AED4-B3AA57C37DDF");
        public static readonly Guid BakiSigortaTravel = new Guid("456F11EA-E04A-4D60-9B1D-5754082AB7F8");
        public static readonly Guid BakiSigortaThirdPartyLiability = new Guid("3FF456E3-7119-478A-AE29-15519C23D909");
        public static readonly Guid BakiSigortaGlass = new Guid("ACDD9AAF-85F5-48AF-97D1-9282F237316E");
        public static readonly Guid BakiSigortaElectricEquipment = new Guid("95F4D512-66A8-49AD-B6CD-31E041067A98");
        public static readonly Guid BakiSigortaEquipmentBreaking = new Guid("D95A62C2-8E1C-4CEC-872D-4D585152E427");
        public static readonly Guid BakiSigortaStolen = new Guid("C7185FE9-24A2-4E60-9E19-CB1C4C3520A9");

        public static readonly Guid DiginsEstate = new Guid("77cd6b22-8d7a-40f9-83a4-a5eadfe0cc5c");

        public static readonly Guid ZlagodaDangerousObjects = new Guid("3EFCFE8A-7A34-4B34-83E8-922C01384ECE");
        public static readonly Guid ZlagodaMedicalSpending = new Guid("94293ccd-4553-420e-9300-2e65d3711f6e");

        public static readonly Guid TasDGOPlus = new Guid("E34E54D3-AABF-4186-969E-01DF878EC877");
        public static readonly Guid TasEasyCasco = new Guid("E5CA5213-3889-44D4-990E-5777785E5C1C");
        public static readonly Guid TasAmulet = new Guid("475E8039-EF78-4835-A7E8-78FE748F28D5");
        public static readonly Guid TasOSACO = new Guid("0B469C3F-7127-4D9A-98B9-9703CAED60B4");

        public static readonly Guid TasAnimal = new Guid("300788E3-7347-4496-BD79-86B4E38A82FC");

        public static readonly Guid OrantaMed = new Guid("1AC80605-92F9-43FF-837C-B4667624DE10");
        public static readonly Guid OrantaAccident = new Guid("78E4CA1C-0DA3-4A0A-91D5-63E7DA3F8907");

        public static readonly Guid EIAOSAGO = new Guid("35BA99DB-0B6F-4C4F-AD4B-8951F7A591C8");
        public static readonly Guid AlfaOSAGO = new Guid("A2505857-07D2-4C2A-AA69-C42A3CCF91D3");
    }
}
