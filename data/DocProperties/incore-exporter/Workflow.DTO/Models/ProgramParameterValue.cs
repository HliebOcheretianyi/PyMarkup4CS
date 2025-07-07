using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про параметри значень програм
    /// </summary>


    [DocumentationContract]
    public partial class ProgramParameterValue : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        public static readonly Guid MtplFirst = new Guid("3D788AC8-10AB-4289-A745-740612A06285");
        public static readonly Guid MtplSecond = new Guid("246A740A-25D6-4615-8C98-22093B590321");
        public static readonly Guid MtplThird = new Guid("B2F90B9C-7D99-4A9B-86FE-42A657E405CA");
        public static readonly Guid PrivilegeNoPrivilege = new Guid("0912E312-D43F-4486-8EC7-7A0240C54A2B");
        public static readonly Guid IncludeWear = new Guid("B5E32EF6-FB4C-45D8-A5B1-CF228138B6B9");
        public static readonly Guid BakiSigortaIsUSD = new Guid("558D5B1E-8D17-464B-B23C-91D77BDCFEF6");
        public static readonly Guid BakiSigortaIsEURO = new Guid("4D3E1537-9520-4FC0-B4A9-37EDF57557AC");
        public static readonly Guid ZlagodaContractActionInCar = new Guid("4F8DF4FA-E699-457A-A7F4-0DED0E13950A");
        public static readonly Guid ZlagodaContractAction24Hours = new Guid("316E045D-C2B8-4E49-9C2B-511630D7E511");
        public static readonly Guid ZlagodaContractActionOnCompetition = new Guid("669785DC-A457-45E2-BDF4-5255D5D970AA");
        public static readonly Guid ZlagodaContractActionDuty = new Guid("E60BA483-94B6-4A7A-B2DC-57084A18AB0C");
        public static readonly Guid ZlagodaTypeInsuranceSumAgregat = new Guid("10A334C9-0CD2-48A1-B6F7-927DF142DBCD");
        public static readonly Guid ZlagodaTypeInsuranceSumNotAgregat = new Guid("C3E97317-39AD-4869-A713-CFFCB0D13FD5");
        public static readonly Guid ZlagodaTypeOfConveyorRecipient = new Guid("f671d4eb-a79c-4cc5-89a8-50ebf0c1fd0a");
        public static readonly Guid ZlagodaTypeOfConveyorSender = new Guid("35e5b9a2-5e31-4959-b2fe-646c870abdcf");
        public static readonly Guid ZlagodaTypeOfConveyorCarrier = new Guid("c289978f-fdfd-4c24-8672-1f66b90b4c8b");
        public static readonly Guid BakiSigortaKindOfUsageTaxi = new Guid("21a0ec52-dbcf-4f01-a7d6-370ff1c1e393");
        public static readonly Guid BakiSigortaKindOfUsagePrivate = new Guid("efaea238-460e-4ff6-b041-7e67b76b2a3b");
        public static readonly Guid BakiSigortaKindOfUsageWork = new Guid("f286a0db-ba50-4b57-868e-bc018dfa805a");
        public static readonly Guid BakiSigortaKindOfUsageOther = new Guid("cae8892d-7b5b-4080-90a0-e4aa970feffa");
        public static readonly Guid BakiSigortaKindOfUsageRentACar = new Guid("1CFEBB79-EBAC-4B88-93E2-068CEDE97E82");
        public static readonly Guid BakiSigortaKindOfUsageBus = new Guid("B963581F-BE27-400F-85D2-381B4CF5DF76");
        public static readonly Guid BakiSigortaKindOfUsageCargo = new Guid("54239F66-A167-40DF-8869-1807AACE58E6");
        public static readonly Guid BakiSigortaKindOfUsagePersonal = new Guid("EFAEA238-460E-4FF6-B041-7E67B76B2A3B");
        public static readonly Guid BakiSigortaTravelAbroadYes = new Guid("B24EA975-AC3B-4606-B2B3-A060B9EE556E");
        public static readonly Guid BakiSigortaRepairServiceDefineInsurer = new Guid("23E842B1-5B50-4F40-B6AC-1DE09E2D7EEF");
        public static readonly Guid BakiSigortaRepairServiceDefineInsuranceCompany = new Guid("E407273B-5F73-4008-ADA6-DEDE7C8C4BDF");
        public static readonly Guid BakiSigortaRepairServiceTypeOfficial = new Guid("ED6CD294-DDFF-4454-A687-7EF2B124416F");
        public static readonly Guid BakiSigortaRepairServiceTypeNotOfficial = new Guid("713EF147-50B4-405C-99CF-96BE0CEDE5BC");
        public static readonly Guid ZlagodaGoalForTravelWork = new Guid("2b6b6568-a91e-4699-a3d9-bc4f0e7c4001");
        public static readonly Guid ZlagodaGoalForTravelWithoutRisk = new Guid("d119cb02-1ff8-4a00-b56c-0e5426326bad");
        public static readonly Guid TasFullHomeProtectAppointmentHome = new Guid("DA32DE8B-0ED8-4901-A5AB-9643664CE370");
        public static readonly Guid TasFullHomeProtectAppointmentFlat = new Guid("79CF0CC7-B777-4E47-997B-AF9D910FA2D0");
        public static readonly Guid TasFullHomeProtectFranchise0 = new Guid("DE26FD7A-4E12-4D2C-958D-767B79119CA2");
        public static readonly Guid TasFullHomeProtectFranchise500 = new Guid("7BDF38DC-8AA2-425E-AB22-2D59560A8FC7");
        public static readonly Guid TasSTORepairTypeInsuranceCompany = new Guid("11C9BE5B-ECF4-4BDF-87D0-C8722A90FBDA");
        public static readonly Guid OrantaProgramTypeEconom = new Guid("EE93502C-33B1-4E23-9BE3-B0B5847533A9");
        public static readonly Guid OrantaProgramTypeBussiness = new Guid("45F63941-766C-4DF4-AA7F-E6E2430708FC");
        public static readonly Guid OrantaCasco95ProgramTypeVariantA = new Guid("ABEFAD22-57BF-4D0C-88B1-17D7DA0FDC6E");
        public static readonly Guid OrantaCasco95ProgramTypeVariantB = new Guid("FA7D1DAE-2F0E-4A1C-B8B3-EACAFA732D03");
        public static readonly Guid TasCasco5StarsPackage1Steal = new Guid("DDB8D33A-9CEF-4FFB-89C6-8431D76FDF47");
        public static readonly Guid TasCasco5StarsPackage1Total = new Guid("01D177DB-9DBC-43EB-B312-FCABF059EA37");
        public static readonly Guid TasCasco5StarsPackage2 = new Guid("88476B96-C254-457A-8D75-13BE23BC6EAB");
        public static readonly Guid TasCasco5StarsPackage3 = new Guid("BC513E76-5F6D-46EB-A242-0FF80B6C6B2B");
        public static readonly Guid TasCasco5StarsPackage4 = new Guid("08E543FF-1D7B-4D6C-8705-0F455072E2E4");
        public static readonly Guid TasCasco5StarsPackage5 = new Guid("4C07A44D-F3A6-4219-A28D-EC05D41E9277");
        public static readonly Guid TasDrivingExperienceNoLimits = new Guid("770E876F-3589-4E3F-9CC2-0398940ED8C3");
        public static readonly Guid TasDrivingExperienceFrom3To10 = new Guid("F85192F7-1FE2-4314-9AAD-0509ECD3CBF7");
        public static readonly Guid TasDrivingExperienceFrom1To3 = new Guid("9B25A6EA-6AC7-482E-8F2A-99B0F0A3BDDD");
        public static readonly Guid TasDrivingExperienceTo1 = new Guid("57982D69-76C2-4903-BA5B-A069A753C93C");
        public static readonly Guid TasDrivingExperienceFrom10 = new Guid("6FAB3DA0-0BFC-4E05-AACA-A41F316D0FAA");
        public static readonly Guid EIAVehicleUsageAsTaxi = new Guid("E6CB1833-2538-481B-8565-049B339D76D1");
        #region PrintableProduct Properties
        public static readonly Guid ZoneOfUsage1 = new Guid("8BA2CED9-C5CC-4479-A68E-44C23CC12544");
        public static readonly Guid ZoneOfUsage2 = new Guid("CD1BFFC9-1EBC-DF11-9EBF-001CC0FB0098");
        public static readonly Guid ZoneOfUsage3 = new Guid("5D429FD3-1EBC-DF11-9EBF-001CC0FB0098");
        public static readonly Guid ZoneOfUsage4 = new Guid("2F25B9DC-1EBC-DF11-9EBF-001CC0FB0098");
        public static readonly Guid ZoneOfUsage5 = new Guid("BDD2DFE3-1EBC-DF11-9EBF-001CC0FB0098");
        public static readonly Guid ZoneOfUsage6 = new Guid("DD2C21EB-1EBC-DF11-9EBF-001CC0FB0098");
        public static readonly Guid ZoneOfUsage7 = new Guid("433CD1F1-1EBC-DF11-9EBF-001CC0FB0098");
        public static readonly Guid CoveragePeriod = new Guid("08781E9A-9C00-4A3B-B729-B81D6AF7EC6F");
        public static readonly Guid OrantaIsOTKYes = new Guid("CAE0DB7F-8E08-475B-91C0-0EFDA6036E01");
        public static readonly Guid OrantaVehicleUsageAsTaxi = new Guid("F61771FE-082A-4D49-AA4B-061785328B6A");
        public static readonly Guid OrantaExperienceAbove3 = new Guid("B228E36F-020F-4849-9A75-3EA023248F89");
        public static readonly Guid Oranta1MonthOfUsage = new Guid("FEBDCAFC-B091-4C5D-B57C-23C22CCC2668");
        public static readonly Guid Oranta2MonthOfUsage = new Guid("B4BD362B-F84D-4E04-8C78-733863B0D6B0");
        public static readonly Guid Oranta3MonthOfUsage = new Guid("CC22D3AF-1AFB-401C-B7F0-5644993AA7E8");
        public static readonly Guid Oranta4MonthOfUsage = new Guid("A3EFA11B-718F-4EB9-A4CE-5BF92275FA48");
        public static readonly Guid Oranta5MonthOfUsage = new Guid("F3DD57F8-E9D6-4566-9F0A-F5E4532D09D9");
        public static readonly Guid Oranta6MonthOfUsage = new Guid("967B27B1-6653-45E6-96F0-2DDC60E7453D");
        public static readonly Guid Oranta7MonthOfUsage = new Guid("7A8FA023-7737-40F9-8CF9-069800879586");
        public static readonly Guid Oranta8MonthOfUsage = new Guid("85247AEF-CEA1-4C18-8FE0-FBB1A46113C0");
        public static readonly Guid Oranta9MonthOfUsage = new Guid("0C1E84EA-0785-4AF5-84E1-951D6B85D7E0");
        public static readonly Guid Oranta10MonthOfUsage = new Guid("33EC3C81-A617-4F7B-9757-FD6AE747C5DF");
        public static readonly Guid Oranta11MonthOfUsage = new Guid("AFA2F77C-0057-4754-9BC3-969FF90C1450");
        public static readonly Guid Oranta12MonthOfUsage = new Guid("AB2D5B7D-3E76-4E9A-B51B-0AA4A5C875DD");
        public static readonly Guid TasAccidentRisk1groupDisability = new Guid("14BE1204-B9B3-431D-B470-C19ED319FC6C");
        public static readonly Guid TasAccidentRisk2groupDisability = new Guid("DEF4CDCC-6C41-4A6E-AACB-CB9F94C23B7B");
        public static readonly Guid TasAccidentRisk3groupDisability = new Guid("B3243255-291C-4CA5-A18D-5B72E413D819");
        public static readonly Guid TasAccidentAreaCoverageUkraine = new Guid("6B08A2F3-C78B-4F3B-B4C4-61F533871FE7");
        public static readonly Guid TasAccidentAreaCoverageWorld = new Guid("89BA48DD-E5E2-4815-8D59-6E7C7B0FCB95");
        public static readonly Guid TasAccidentAreaCoverageUkraineAndEurope = new Guid("1A9F725F-115E-4191-8477-718AB727EA48");
        public static readonly Guid TasAccidentAreaCoverageUkraineAndSIC = new Guid("AA962529-A8B8-47F4-ACFF-B3C4EBD6B462");
        public static readonly Guid TasKindOfActivityHighRiskWork = new Guid("45C988CD-EB83-4EDC-AB37-765EFCC22B91");
        public static readonly Guid TasKindOfActivitySkiing = new Guid("0F91A29E-B641-42F5-9052-C63F98D71D1A");
        public static readonly Guid TasKindOfActivityActive = new Guid("97F9DFF3-4CFB-4864-A0CC-466B768521DA");
        public static readonly Guid TasKindOfActivityHighRiskSport = new Guid("6CE3F902-FCBA-4EC3-810F-6F7A132D58CC");
        public static readonly Guid TasKindOfActivityLowRisk = new Guid("F08E078B-8780-4975-98F5-3E0D6C2E131D");
        public static readonly Guid TasCoverage24h = new Guid("5DBF1CCE-3A7C-45CF-99AA-5144723D9A4F");
        public static readonly Guid TasCoverageDuringSport = new Guid("60081E02-D17E-438E-B9F4-C034755394A4");
        public static readonly Guid TasCoverageOutOfWorkOrStudy = new Guid("1265F942-62E0-41D3-B47B-650E26228365");
        public static readonly Guid TasCoverageDuringWorkOrStudy = new Guid("52B634E0-5BB6-4423-AC8F-E5F9766D4719");
        public static readonly Guid TasIsOTKYes = new Guid("48E2CC40-2556-4F44-A548-66E0B9AA4315");
        public static readonly Guid TasVehicleUsageAsTaxi = new Guid("8EB74EE3-5CD6-48F3-B1AE-1069A802B6D1");
        public static readonly Guid TasExperienceAbove3 = new Guid("4A5EC716-F4E7-44AC-9361-8C2DD8FD1054");
        public static readonly Guid TasOTKDate = new Guid("4BF7C4B6-6187-448A-B97A-C6AAB57F0F4C");
        public static readonly Guid Tas1MonthOfUsage = new Guid("96DCD761-4B3C-4041-AF73-849FFDDB444C");
        public static readonly Guid Tas2MonthOfUsage = new Guid("BF9EDBEF-7B22-4075-B1FF-52CEDB90AD47");
        public static readonly Guid Tas3MonthOfUsage = new Guid("8EE31FC1-6BCD-4656-B4A8-84E49C4AF261");
        public static readonly Guid Tas4MonthOfUsage = new Guid("7AF685C5-2F36-4EEC-9E31-423D3906E6EB");
        public static readonly Guid Tas5MonthOfUsage = new Guid("5CD1A21D-9F14-44F3-9E1B-118566FE51E6");
        public static readonly Guid Tas6MonthOfUsage = new Guid("C490FD43-789B-48E0-9FE9-EBBD44856A06");
        public static readonly Guid Tas7MonthOfUsage = new Guid("6A1EE41D-D10A-4AEC-A366-32A29BE389FE");
        public static readonly Guid Tas8MonthOfUsage = new Guid("1C4780CF-E36B-4437-9AC5-A2B0FE8E469B");
        public static readonly Guid Tas9MonthOfUsage = new Guid("0F52C314-F2D9-4655-BF8B-DAA6BDDD8D91");
        public static readonly Guid Tas10MonthOfUsage = new Guid("426CB168-9CCD-4CDB-A2FE-7567B9AD9F16");
        public static readonly Guid Tas11MonthOfUsage = new Guid("492F8A02-002C-4632-8DCA-FC071A1CF989");
        public static readonly Guid Tas12MonthOfUsage = new Guid("45E0E307-8109-45D7-8918-4E288FEBE25F");
        public static readonly Guid TasCascoElit = new Guid("5ABD774C-CB14-43B7-B059-77A3AC57EC11");
        public static readonly Guid TasCascoStandard = new Guid("2998C1F3-FBF6-4677-AE65-ED5656FE9488");
        public static readonly Guid TasCascoPrestige = new Guid("A03E4281-9EAA-4F4A-8445-F63494A1903F");
        public static readonly Guid TasCascoWithoutAmortization = new Guid("AC18B9CC-8522-49BF-A0CC-D0DC961EF328");
        public static readonly Guid TasCascoUpto2Drivers = new Guid("AD3E96F1-20F4-41E7-99F6-6A65455CBA0C");
        public static readonly Guid TasCascoUnlimitedDrivers = new Guid("7C57BF3C-1BCF-4B49-80ED-F778762251AD");
        public static readonly Guid TasIsPriviledgedYes = new Guid("364991E2-D4E8-45D7-8935-1B38B4D630C4");
        public static readonly Guid EIAIsOTKYes = new Guid("5A0CE558-772C-43C8-808B-C1CF5F9B8732 ");
        public static readonly Guid EIAOTKDate = new Guid("A70FE033-0E64-4E7E-868F-EFFA9A9539B7");
        public static readonly Guid EIAIsPriviledgedYes = new Guid("C0FB2477-66F0-4EF4-B57A-52BCF51AB174");
        public static readonly Guid EIA1MonthOfUsage = new Guid("B87FB97D-B4BD-494B-A692-1CE2A8D983D1");
        public static readonly Guid EIA2MonthOfUsage = new Guid("D52A436B-997B-4175-9D66-24D6A8AF29DF");
        public static readonly Guid EIA3MonthOfUsage = new Guid("B6C1B0DE-41C3-4659-8A3C-268D267B3B44");
        public static readonly Guid EIA4MonthOfUsage = new Guid("FFF6A697-F52E-4E80-B99A-19790F83C156");
        public static readonly Guid EIA5MonthOfUsage = new Guid("CBC16E87-D62F-4A0F-A13A-D26D77AF2FBC");
        public static readonly Guid EIA6MonthOfUsage = new Guid("DD22B570-E16A-4095-8F37-421F76CD5CBF");
        public static readonly Guid EIA7MonthOfUsage = new Guid("3269F8FC-4369-4920-A5F1-7BC72BB0AA43");
        public static readonly Guid EIA8MonthOfUsage = new Guid("FD92F102-1ADB-4367-9D67-347FB35DE300");
        public static readonly Guid EIA9MonthOfUsage = new Guid("2B3049F5-D159-4207-B35D-E84E9C9798A5");
        public static readonly Guid EIA10MonthOfUsage = new Guid("7572820D-F815-4B45-BB25-D0C7A1CFCD96");
        public static readonly Guid EIA11MonthOfUsage = new Guid("0383A0D2-F0DD-49D6-9BCE-0ED11ED5A545");
        public static readonly Guid EIA12MonthOfUsage = new Guid("C8FA6F6A-3798-4148-BFF0-16165BBC76F9");
        public static readonly Guid TasAgeOfInsuredFrom1To3 = new Guid("E2B8D389-D438-4ED4-ADCB-E41C7CDE543F");
        public static readonly Guid TasAgeOfInsuredFrom71To75 = new Guid("085BCA59-AB45-4F51-8430-F72A460E6527");
        public static readonly Guid TasAgeOfInsuredFrom76 = new Guid("D2940E9E-3D07-453B-927D-F69527B8B0C0");
        public static readonly Guid TasAgeOfInsuredFrom65To70 = new Guid("56FAA9AD-FB2B-47CA-A55B-FC530A2D2347");
        public static readonly Guid TasAgeOfInsuredTo1 = new Guid("FD066481-9192-450F-BAC4-A08FE5018F74");
        public static readonly Guid TasAgeOfInsuredFrom4To64 = new Guid("D7B5EC35-104F-4B8B-A690-3EAEDA253857");
        public static readonly Guid TasNumberOfPeopleTo10 = new Guid("052F990E-C95A-4380-B9BA-25DEC39A952A");
        public static readonly Guid TasNumberOfPeopleFrom10To20 = new Guid("8D30B000-F0E5-4A81-A4B9-6EB662E782E2");
        public static readonly Guid TasNumberOfPeopleFrom51 = new Guid("17150061-645E-408C-BC30-D263F0448EB7");
        public static readonly Guid TasNumberOfPeopleFrom31To50 = new Guid("3642A0D5-0635-4710-8451-B22CE25C78E3");
        public static readonly Guid TasNumberOfPeopleFrom21To30 = new Guid("79B6636D-FA9C-45AB-8709-865BF573B0A0");
        public static readonly Guid TasExpressNewZone1 = new Guid("9987A59A-4B1B-4329-8F16-E5FA3AF8023F");
        public static readonly Guid TasExpressNewZone2 = new Guid("53833DCF-902E-4520-AF31-BBAC5F1A4229");
        public static readonly Guid TasProgramTypeStandart = new Guid("8AFBE3A7-6E95-454F-8518-16BC94411784");
        public static readonly Guid TasProgramTypeClassic = new Guid("BCDE4E40-F8CE-4CB4-A326-8010C1D4C968");
        public static readonly Guid TasProgramTypeVIP = new Guid("57AF24A4-3453-486F-8D3A-BC13B4F61D3E");
        public static readonly Guid TasProgramTypeV = new Guid("66A87D25-C8C8-485B-9856-FF1C02741744");
        public static readonly Guid TasReusableKindOfTravel = new Guid("2AD2F426-176B-4051-8C09-4554C387C637");
        public static readonly Guid TasLimitWithoutCertificate2on1 = new Guid("8D8C5ECD-719E-452C-A03E-138DB295EDE7");
        public static readonly Guid TasLimitWithoutCertificate2on2 = new Guid("D75B4780-5F85-485C-851D-F230656774B2");
        public static readonly Guid TasLimitWithoutCertificate3on1 = new Guid("ED8B255F-DF8C-4A8B-A807-0EB10063A33F");
        public static readonly Guid TasLimitWithoutCertificate3on2 = new Guid("290447B2-8048-4CF5-8AE1-111E9E8ED3EC");
        public static readonly Guid TasLimitWithoutCertificate5on1 = new Guid("F34FDBED-D241-459D-B4A4-E36D01A14B18");
        public static readonly Guid TasLimitWithoutCertificate5on2 = new Guid("03C51A57-E39C-4BD2-9D94-EC4CCD31EA0B");
        public static readonly Guid TasCompensationTow800 = new Guid("CEEC2B5B-5CCC-45CA-A9E9-2744F0C8B075");
        public static readonly Guid TasCompensationTow1000 = new Guid("726B9527-A92D-43CD-A00F-C6932993085A");
        public static readonly Guid TasCompensationTow1500 = new Guid("4BB22DC2-0E7C-4856-B093-B535DAA4C2BB");
        public static readonly Guid TasConditionsOfUseRent = new Guid("DB5A882C-3147-4F01-A678-2F46FD29629F");
        public static readonly Guid TasConditionsOfUsePrivate = new Guid("EABAE73C-A3E0-466A-A0F6-3665DC322B0E");
        public static readonly Guid TasConditionsOfUseCommerce = new Guid("C792FB50-72FC-4FB1-9473-5F76FFDF6E1E");
        public static readonly Guid TasConditionsOfUseTaxi = new Guid("CD910B82-BBE3-4A98-958D-8488208E4420");
        public static readonly Guid TasConditionsOfUseLeasing = new Guid("D7501F22-6AEB-4756-92F9-99ABBEAE9CDF");
        public static readonly Guid TasConditionsOfUseHire = new Guid("F6E2608A-2081-42B4-91BE-FF3D5A3D7072");
        public static readonly Guid TasConditionsOfUseTestDrive = new Guid("710EA5A7-7928-4698-844C-80AC91314B28");
        public static readonly Guid TasConditionOfUseOther = new Guid("35418EED-05C6-4286-945F-8839F3CEBE08");
        public static readonly Guid TasWithAccountDepriciation = new Guid("FB445134-875C-411E-92D3-C2D94A9A6FC6");
        public static readonly Guid TasWithoutAccountDepriciation = new Guid("AC18B9CC-8522-49BF-A0CC-D0DC961EF328");
        public static readonly Guid TasAddmittedAny = new Guid("EBFF8555-D944-4BB5-B56D-6545DC3A8486");
        public static readonly Guid TasAddmittedFrom1 = new Guid("B9B4375A-CB60-4322-83E1-F3CF387BB9CC");
        public static readonly Guid TasAddmittedFrom3 = new Guid("E070D926-2F66-4EC8-BBEE-4D0F41CA90FB");
        public static readonly Guid TasAddmittedFrom5 = new Guid("215D0CC3-F9E5-47E3-8767-A75F012AF28D");
        public static readonly Guid TasAddmittedFrom10 = new Guid("D3307338-7D63-4296-A486-40680E76AEBF");
        public static readonly Guid TasAddmittedFrom21To60 = new Guid("C6E2E404-CE92-4061-8AAD-6FCDA80F34C6");
        public static readonly Guid ZlagodaRepairGarant = new Guid("837D5FC0-3768-4D50-8462-C0B56812C6DB");
        public static readonly Guid ZlagodaRepairCommisar = new Guid("EE3F11EE-2CE5-4D3D-AC02-81BA68697FF1");
        public static readonly Guid ZlagodaRiskPackage1 = new Guid("AF30A57A-17FD-40AD-AAC5-7BACA4085C8E");
        public static readonly Guid ZlagodaRiskPackage2 = new Guid("0477428C-7F98-49C3-8A1F-3D8FCC674358");
        public static readonly Guid ZlagodaRiskPackage3 = new Guid("E2784940-36BD-4E02-8BD6-B80740DBB8F5");
        public static readonly Guid ZlagodaRiskPackage4 = new Guid("90B3D534-22F7-4020-B75C-B7A0E3D2401D");
        public static readonly Guid Alfa1MonthOfUsage = new Guid("641643BE-BC19-4E9E-89E4-7DC9653F9847");
        public static readonly Guid Alfa2MonthOfUsage = new Guid("FA5E4FCF-FA24-4A10-BEE4-9FBFE86738D6");
        public static readonly Guid Alfa3MonthOfUsage = new Guid("FCF1F355-E32B-4156-BEC8-82683314C6FE");
        public static readonly Guid Alfa4MonthOfUsage = new Guid("827BB59B-5148-4E89-AEC4-A501C8F030B5");
        public static readonly Guid Alfa5MonthOfUsage = new Guid("CC6D67E5-34A9-411B-8C40-ACE39F8BC47F");
        public static readonly Guid Alfa6MonthOfUsage = new Guid("B75281B2-3E1F-4BF3-B0FC-9BE838A6ED01");
        public static readonly Guid Alfa7MonthOfUsage = new Guid("D5F63888-654E-4F66-B092-DD6ED43222FA");
        public static readonly Guid Alfa8MonthOfUsage = new Guid("2061220A-C318-4DBA-9EAA-73378F2AC27E");
        public static readonly Guid Alfa9MonthOfUsage = new Guid("CC4510FA-14B2-4512-B7B3-BA23DEE2B0FE");
        public static readonly Guid Alfa10MonthOfUsage = new Guid("E50F06A6-F991-47E9-8C09-1BAEC5C445B0");
        public static readonly Guid Alfa11MonthOfUsage = new Guid("9F26BE5A-BF2F-4024-B5B5-13887747FEC7");
        public static readonly Guid Alfa12MonthOfUsage = new Guid("0BEB3AE9-6D51-4DF7-AEAC-FEDAAF1C77E6");
        public static readonly Guid AlfaIsOTKYes = new Guid("FA92CD4E-8A89-4D95-8B6D-4CB76E51DD9D");
        public static readonly Guid AlfaVehicleUsageAsTaxi = new Guid("DC0F80DC-8490-4649-AA1D-68A20B1DC9C2");
        public static readonly Guid AlfaVehicleUsageAsTaxi2 = new Guid("65F3858D-B851-4271-B8A8-009387430165");
        public static readonly Guid[] TasFullProptectionTypeStandart = new Guid[]
        {
            new Guid("A35B2BC7-182A-4D69-BA63-130169E2A312"),
            new Guid("E48213D5-B995-4BAC-89D2-D6D399F4364C")
        };
        public static readonly Guid[] TasFullProptectionTypeLight = new Guid[]
        {
            new Guid("22FB7620-B932-4DC3-914E-2EA2FE7B7764"),
            new Guid("7FCDDD8C-61A1-44CB-93BF-682E9AC1A60A")
        };
        public static readonly Guid[] TasFullProptectionTypeService = new Guid[]
        {
            new Guid("9293BC8E-EFE3-4186-9FD8-19DD5F7848EF"),
            new Guid("7FCDDD8C-61A1-44CB-93BF-682E9AC1A60A"),
            new Guid("E48213D5-B995-4BAC-89D2-D6D399F4364C")
        };
        public static readonly Guid[] TasFullProptectionTypeStandartDGO = new Guid[]
        {
            new Guid("43F2B92C-676E-4C58-98DC-BB036FC2EBE0"),
            new Guid("E40996EC-EB45-4A38-9380-4EA1F30F13BA")
        };
        public static readonly Guid[] TasFullProptectionTypeLightDGO = new Guid[]
        {
            new Guid("51154E70-5ECC-4329-8D56-4711B9325D43"),
            new Guid("8E8B8CB4-1265-4169-A8BD-931F072898DC")
        };
        public static readonly Guid[] TasFullProptectionTypeServiceDGO = new Guid[]
        {
            new Guid("9E59E498-3B17-4776-93DC-CA7CD82F0A3C"),
            new Guid("E40996EC-EB45-4A38-9380-4EA1F30F13BA"),
            new Guid("8E8B8CB4-1265-4169-A8BD-931F072898DC")
        };
        public static readonly Guid TasOptionType1 = new Guid("A98837E1-BE3C-4116-89F2-4F776C45BE0B");
        public static readonly Guid TasOptionType12 = new Guid("95A17F65-8E71-403F-91EE-EEFFA353A60B");
        public static readonly Guid TasOptionType123 = new Guid("1B309129-EBF2-414A-BE06-613A0B4768D9");
        public static readonly Guid EI1MonthOfUsage = new Guid("B87FB97D-B4BD-494B-A692-1CE2A8D983D1");
        public static readonly Guid EI2MonthOfUsage = new Guid("D52A436B-997B-4175-9D66-24D6A8AF29DF");
        public static readonly Guid EI3MonthOfUsage = new Guid("B6C1B0DE-41C3-4659-8A3C-268D267B3B44");
        public static readonly Guid EI4MonthOfUsage = new Guid("FFF6A697-F52E-4E80-B99A-19790F83C156");
        public static readonly Guid EI5MonthOfUsage = new Guid("CBC16E87-D62F-4A0F-A13A-D26D77AF2FBC");
        public static readonly Guid EI6MonthOfUsage = new Guid("DD22B570-E16A-4095-8F37-421F76CD5CBF");
        public static readonly Guid EI7MonthOfUsage = new Guid("3269F8FC-4369-4920-A5F1-7BC72BB0AA43");
        public static readonly Guid EI8MonthOfUsage = new Guid("FD92F102-1ADB-4367-9D67-347FB35DE300");
        public static readonly Guid EI9MonthOfUsage = new Guid("2B3049F5-D159-4207-B35D-E84E9C9798A5");
        public static readonly Guid EI10MonthOfUsage = new Guid("7572820D-F815-4B45-BB25-D0C7A1CFCD96");
        public static readonly Guid EI11MonthOfUsage = new Guid("0383A0D2-F0DD-49D6-9BCE-0ED11ED5A545");
        public static readonly Guid EI12MonthOfUsage = new Guid("C8FA6F6A-3798-4148-BFF0-16165BBC76F9");
        #endregion

        public Guid ProgramGID { get; set; }

        /// <summary>
        /// Значення параметра програми
        /// </summary>

        [DocumentationMember]
        public object ParameterValue
        {
            get
            {
                return ValueData.Get();
            }

            set
            {
                ValueData.Set(value);
            }
        }

        private ObjectData _ValueData;

        public Workflow.DTO.Models.ObjectData ValueData
        {
            get
            {
                if (_ValueData == null)
                {
                    _ValueData = new ObjectData();
                }

                return _ValueData;
            }

            set
            {
                _ValueData = value;
            }
        }


        public Guid ParameterGID { get; set; }


        public bool IsHidden { get; set; }

        private object _ParameterValueCaption;

        [DocumentationMember]
        public async Task<object> GetParameterValueCaption()
        {
            return _ParameterValueCaption;
        }

        private string _ParameterName;

        [DocumentationMember]
        public async Task<string> GetParameterName()
        {
            return _ParameterName;
        }

    }
}