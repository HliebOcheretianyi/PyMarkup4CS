namespace Workflow.DTO.Models
{


    public partial class ProductType : Workflow.DTO.Models.IdentityPersistentEntity
    {
        public static readonly Guid CaskoMIC = new Guid("7391C338-ED1B-4A6A-A1E2-9466970B1EAD");
        public static readonly Guid CaskoMICHalliburton = new Guid("48923891-A73E-4ABD-A8B2-027F3BBA4F1C");
        public static readonly Guid ProductTypeAccidentStandart = new Guid("90B02DB7-895E-4B59-9311-B0B6771A6D23");
        public static readonly Guid ProductTypeAccidentWithoutInjures = new Guid("C87C5FA7-4871-4952-ACCF-459E5BDE9A08");
        public static readonly Guid ProductTypeAccidentSchool = new Guid("C1A28A0A-3628-44FE-8702-DF88FD4BF7CF");
        public static readonly Guid ProductTypeAccidentBank = new Guid("DEC1ADEC-C9F3-45A6-9160-796AB38F941F");
        public static readonly Guid ProductTypeAccidentAirport = new Guid("3FA9B3C1-02D3-4467-8EB7-96B2BF55D163");
        public static readonly Guid ProductTypeAccidentSchoolExemption = new Guid("11792A6A-4992-432D-8181-FF9A0023BD37");
        public static readonly Guid ProductTypeCaskoStandart = new Guid("1B799C3D-DD88-4F6D-9615-DFE47BE5A0B0");
        public static readonly Guid ProductTypeCaskoPark = new Guid("0DEDAC75-BFDB-4026-80C5-D90994119316");
        public static readonly Guid ProductTypeCaskoVIP = new Guid("6F1C7CDE-76B4-4A6D-9B9A-5475829A074A");
        public static readonly Guid ProductTypeCaskoPA = new Guid("9DDAFC28-C85B-4F91-BF69-852830C98E24");
        public static readonly Guid ProductTypeEstateCursed = new Guid("1AD1B622-88F1-4992-9BF8-A0E4809A90D2");
        public static readonly Guid ProductTypeEstateManor = new Guid("92C276FB-E919-41AC-9B06-83AD40126309");
        public static readonly Guid ProductTypeEstatePalace = new Guid("F2BE3706-3DCA-4229-A96D-5BB563ED3EB4");
        public static readonly Guid ProductTypeEstateJuridical = new Guid("CCA13879-3F7A-46E1-BD9C-7061A4E2E662");
        public static readonly Guid ProductTypeConstructionLoading = new Guid("55FD8BDC-17E2-4940-B6E3-BFA9EBC67999");
        public static readonly Guid ProductTypeEstateHeadstone = new Guid("87DCFF8F-3149-47F0-9FD2-B4D88026961F");
        public static readonly Guid ProductTypeEstateBank = new Guid("FFFEF5C5-EE34-4F82-BB10-357F8A54727B");
        public static readonly Guid ProductTypeDangerousCargoAppendix = new Guid("F336AFC0-414E-4300-97C4-67EA82564116");
        public static readonly Guid ProductTypeDangerousCargo = new Guid("A826F871-8E45-446F-8B8B-DCA55A50A3EC");
        public static readonly Guid ProductTypeResponsibleStandart = new Guid("9FC6538D-A740-4A61-9C4C-4BA4B93E61BD");
        public static readonly Guid ProductTypeResponsibleBroker = new Guid("25FF9AED-44C7-43A8-85B2-EC54D80E69C4");
        public static readonly Guid ProductTypeResponsibleNotary = new Guid("DDE4605B-F004-4433-9AF7-485AAE3F4BA3");
        public static readonly Guid ProductTypeResponsibleHotel = new Guid("DEAB78F4-AC44-4082-BCCC-686474917CE9");
        public static readonly Guid ProductTypeResponsibleAirport = new Guid("0F8C3E90-6AF3-4D4F-AF75-F4E4F95FA63D");
        public static readonly Guid ProductTypeResponsibleArena = new Guid("3AEB3482-4076-4E20-81CB-36F31F84FD0A");
        public static readonly Guid ProductTypeResponsibleTenderGranty = new Guid("BFE90E8F-695D-49A0-8724-6A5D28ABB1AF");
        public static readonly Guid ProductTypeResponsibleTenderDuty = new Guid("0669ED5C-C861-49BF-886C-0BDB165FE68B");
        public static readonly Guid ProductTypeBakiSigortaTurboKaskoPhisical = new Guid("83EFF780-CC1C-4718-A351-2E0B38F3D554");
        public static readonly Guid ProductTypeBakiSigortaTurboKaskoLegal = new Guid("32C9A884-4CAC-4B66-80C3-A7C678368B9E");
        public static readonly Guid ProductTypeBakiSigortaMiniKaskoPhisical = new Guid("5E5F4B20-4FFD-4382-A3FD-D77C529DC90A");
        public static readonly Guid ProductTypeBakiSigortaMiniKaskoLegal = new Guid("E61C8FC6-2D4C-4607-901D-FF6D31CBBBD6");
        public static readonly Guid ProductTypeBakiSigortaLizingAvto = new Guid("FFB9FF09-9E6D-42A2-994E-9F3F3B27A754");
        public static readonly Guid ProductTypeBakiSigortaEkoLizing = new Guid("0FC0AAE6-30F0-4434-BB41-A10469D14653");
        public static readonly Guid ProductTypeBakiSigortaAnsarLizing = new Guid("FEE10DB2-B294-4DBF-AE22-37F97D7752B3");
        public static readonly Guid ProductTypeBakiSigortaOkeanAvto = new Guid("31D1E0FD-2E53-4B92-B83F-8ED47E7F56A1");
        public static readonly Guid ProductTypeBakiSigortaCascoPTA = new Guid("64910899-48DB-4C3A-A34D-B086B3FBE7E2");
        public static readonly Guid ProductTypeBakiSigortaEstatePTA = new Guid("E4478923-5761-4C61-B14F-CE1DBCDD2D9F");
        public static readonly Guid ProductTypeBakiSigortaMIP = new Guid("B27CC6B1-853C-42B7-AFEF-BEB62F06B994");
        public static readonly Guid ProductTypeBakiSigortaPIPDP = new Guid("0019D2CD-090D-4D73-9AB6-91E4BEE5548F");
        public static readonly Guid ProductTypeBakiSigortaPICDP = new Guid("AA99A054-C3FA-4218-A95D-C6562228C156");
        public static readonly Guid ProductTypeBakiSigortaPIP = new Guid("DD84D6BF-3A6D-424C-8B58-8A3E0CB0C554");
        public static readonly Guid ProductTypeBakiSigortaKaskoNotGuiltyPhisical = new Guid("A4E17332-1E10-4ACF-B3F0-2CC87C6FA8DD");
        public static readonly Guid ProductTypeBakiSigortaKaskoNotGuiltyLegal = new Guid("BFF8150E-ABA2-4A5F-A422-AF3DCFD9095F");
        public static readonly Guid ProductTypeBakiSigortaKaskoNotGuiltyPhisicalInternet = new Guid("FECCEA9C-A51D-48F7-B776-8732B11EA332");
        public static readonly Guid ProductTypeTasGreenCardInternet = new Guid("82DE01A4-9ED2-4888-BCBB-3BB13E032EE5");
        public static readonly Guid ProductTypeTasEstateInternet = new Guid("96031CA3-50EA-4D66-8AC8-796E32FCF6B4");
        public static readonly Guid ProductTypeTasCascoInternet = new Guid("8912030E-ADC2-475D-91E2-3AC44063BB80");
        public static readonly Guid ProductTypeTasTravel = new Guid("07A7702C-C284-4493-8C83-8DCC9782D2CC");
        public static readonly Guid ProductTypeTasTravel180 = new Guid("67FF8FC2-2C07-4149-9179-0C2F7163EE96");
        public static readonly Guid ProductTypeTasTravelInDollar = new Guid("B6C5B730-507C-4845-95FE-05BD1CF35DA8");
        public static readonly Guid ProductTypeTasTravel150 = new Guid("EB7BB71B-2AAF-4BDC-8428-3742B0FDA264");
        public static readonly Guid ProductTypeTasTravelSpecialConditions = new Guid("94DFB57E-8B53-44D2-8756-C83D87306BCA");
        public static readonly Guid ProductTypeTasTravelSpecialConditions2 = new Guid("C218D21A-13D6-457D-A71F-5B78902E31AD");
        public static readonly Guid ProductTypeTasTravelSpecialConditions3 = new Guid("FBBBB2F1-C047-451C-A0AD-37A6F14688CC");
        public static readonly Guid ProductTypeTasTravelSpecialConditions4 = new Guid("5E9FF9B1-3112-4A12-ACEF-74346139408E");
        public static readonly Guid ProductTypeTasTravel25Percents = new Guid("E1E7FA60-3E3C-4AFF-A2B1-3EA03CAD5EB0");
        public static readonly Guid ProductTypeTasTravelSpecialConditions5 = new Guid("6DE84672-1691-41A6-A630-611FF9428988");
        public static readonly Guid ProductTypeTasTravelSpecialConditions6 = new Guid("0CC79BE0-0D1C-4EF3-9E03-198C1604783B");
        public static readonly Guid ProductTypeTasTravelSpecialConditions7 = new Guid("AAB6824F-0DF1-4346-93DF-0C3405D8B033");
        public static readonly Guid ProductTypeTasTravelSpecialConditions8 = new Guid("2AD2652D-CFE7-4F44-97AF-4C096AEDE310");
        public static readonly Guid ProductTypeTasTravelSpecialConditions9 = new Guid("97D6384D-5AE5-428B-8CD6-00D7FE0C1576");
        public static readonly Guid ProductTypeTasTravelSpecialConditions10 = new Guid("4E8D5CDB-0669-4DDC-8820-E98CE3156F6E");
        public static readonly Guid ProductTypeTasTravelSpecialConditions11 = new Guid("3A7460F7-0858-44F4-AD46-4A04FEA6E30A");
        public static readonly Guid ProductTypeTasTravelSpecialConditions9829 = new Guid("76724C9B-84A6-43BE-BB8A-B7E6E7DBD197");
        public static readonly Guid ProductTypeTasTravelSpecialConditions9830 = new Guid("4F7F3375-3FE0-4B13-925A-5595BC425ECF");
        public static readonly Guid ProductTypeTasTravelSpecialConditions9831 = new Guid("AC65C40F-AE27-4E5F-B8DB-45B1EB1A833B");
        public static readonly Guid ProductTypeTasTravelPlatinum = new Guid("89D5C2EB-153E-45FC-86CF-70F3D594C5C9");
        public static readonly Guid ProductTypeTasTravelGold = new Guid("0E775D4F-393B-4DF1-999A-B024CA091174");
        public static readonly Guid ProductTypeTasTravelWorldElite = new Guid("D38BFDCC-A8CD-4E7C-9390-2C359623D2DE");
        public static readonly Guid ProductTypeTasTravelStandart3 = new Guid("4DF8D76C-6EC5-4A52-9CA0-81E644121049");
        public static readonly Guid ProductTypeTasTravelStandart4 = new Guid("148A02B4-8C10-4613-B09E-3DB636FDA2F3");
        public static readonly Guid ProductTypeTasTravelSpecialConditions3DJ = new Guid("BD893443-3AE2-4F49-AB59-3D0BF2662736");
        public static readonly Guid ProductTypeTasFullAutoProtection = new Guid("973C6A91-9715-4C0B-A701-C709B01F2AA4");
        public static readonly Guid ProductTypeDiginsBRSD = new Guid("3A05B6AD-FACA-4053-993C-A9F2722FEFA8");
        public static readonly Guid[] ProductTypeBakiSigortaBankResublikaKasko = new Guid[]
        {
            new Guid("EA2391C5-65E0-4668-839A-75659CDD9B09"),
            new Guid("276B10C3-6355-41E9-8760-69FCD1DE3300"),
            new Guid("F8F79926-2A7E-4729-BC0C-29687C58B5FC"),
            new Guid("57DAB24A-FF56-479B-AA20-0DB092B96C0F"),
            new Guid("D9FED48E-7C5A-4094-91A5-17DC63BDCEAF"),
            new Guid("1DF4F37C-650E-4AA9-8216-01DCB44EB588"),
            new Guid("5A30524C-C026-4A45-8561-76D02AC4A0D1"),
            new Guid("FD199052-29A7-43E5-80CB-F495E77F7AD0"),
            new Guid("58B48131-01E8-45DE-8C76-97F69682111C"),
            new Guid("076E67C1-371E-4B5E-A6E3-D111DF617E38"),
            new Guid("2695042B-C298-4198-8C2E-FB3BF8D3C57D"),
            new Guid("2DDAC85A-2FBD-44C5-B7E8-6AF0204A985A"),
            new Guid("874EDC63-0825-4771-8228-1A34C5201E3D"),
            new Guid("DBD011F0-0C13-4F46-919A-4628D972DA7E"),
            new Guid("10088E8E-FC8A-4B1B-8B1E-833FA740C866"),
            new Guid("38B871A4-B3CD-4159-91E8-29754719EC90")
        };
        public static readonly Guid ProductTypeOrantacomplexMTPLPhisical = new Guid("BFA0A759-BEDE-4E43-9514-DDC21A2E7B88");
        public static readonly Guid ProductTypeOrantacomplexMTPLJuridical = new Guid("355B3704-5CBE-4847-A64D-D0EFF25505C9");
        public static readonly Guid[] OrantaGreenCardMaskProductTypes = new Guid[]
        {
            new Guid("11BB4B6B-F762-4E2A-8268-35D78CA91C4E"),
            new Guid("CEAE43B6-ECBE-405A-B5D0-52EB45417B7C"),
        };
        public static readonly Guid ProductTypeEuroInsKACKOClassic = new Guid("1E399EF8-4D2A-48CC-B1A2-72EAC34A54C7");

        public string Code { get; set; }



        public string Name { get; set; }


        public string NameLocalized { get; set; }


        public string FullName { get; set; }
        public Guid? ProductTypeGroupGID { get; set; }
        public string TemplateName { get; set; }
        public bool SignPrintout { get; set; }

    }
}