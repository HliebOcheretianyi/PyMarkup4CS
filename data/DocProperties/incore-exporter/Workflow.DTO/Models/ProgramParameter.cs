using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.DTO.Models
{
    public class ProgramParameter
    {
        public static readonly Guid MtplType = new Guid("42E4AB3E-536B-42E2-8EFB-495BE93A1E23");
        public static readonly Guid ZoneOfUsage = new Guid("AF37DC18-E364-4A84-87B1-2554FE4ACC69");
        public static readonly Guid Discount = new Guid("3DEB4004-BAF2-459F-9C8C-48187B6DF028");
        public static readonly Guid DriverCount = new Guid("92EC78AC-9736-4E7D-B810-236BBFC29191");
        public static readonly Guid Privilege = new Guid("5A76C4D5-9951-4584-9D3B-FBB73901C495");
        public static readonly Guid BonusMalus = new Guid("D3CC1D06-C28E-47D3-8180-61921FFCBE84");
        public static readonly Guid InsuranceSumUSD = new Guid("26910D0E-3652-4329-A262-BD31F79E82B7");
        public static readonly Guid InsuranceSumEUR = new Guid("CBC29A69-C59C-424B-BA1E-3A8E19EA529B");
        public static readonly Guid InsurancePaymentUSD = new Guid("A3AF66C9-9E03-4CAB-A4F0-1E5743D0F1A1");
        public static readonly Guid InsurancePaymentEUR = new Guid("93BBF1C8-C513-495B-893F-264E8E20347E");
        public static readonly Guid CoverAgeType = new Guid("087C903F-BAE2-449D-B51E-B928593E6569");
        public static readonly Guid CoveragePeriod = new Guid("2F9DD0E9-9F2F-47FB-BFD2-6235D71363DE");
        public static readonly Guid TypeOfContract = new Guid("220b260f-f5b4-4250-8d00-dd8b8102ba79");
        public static readonly Guid PersonsCount = new Guid("1388B04C-97B0-4E1D-B697-E363D009293E");
        public static readonly Guid ProgramType = new Guid("6054f62b-3931-467a-8cd2-4dffa573ab47");
        public static readonly Guid IncludeWear = new Guid("85F19683-3722-4FB7-B310-7AF00E18124F");//Врахування зносу
        public static readonly Guid FullYears = new Guid("29B442EA-B250-4DC5-A5D6-5BDE69E07BB3");
        public static readonly Guid VehiclesCount = new Guid("C2C90252-A580-4A6C-930A-85F48E78AA31");
        public static readonly Guid DriverAge = new Guid("6DA6927C-6BB6-4453-A6F3-0CDA151D696E");
        public static readonly Guid ModeOfUsage = new Guid("B9AAB147-0891-486D-B7AA-BCF1658844E4");//Умови експлуатації ТЗ
        public static readonly Guid DriverAgeMin = new Guid("6DA6927C-6BB6-4453-A6F3-0CDA151D696E");
        public static readonly Guid DriverExpirienceYears = new Guid("E681EBF3-B5A1-436E-852F-AB1C288B8A0B");

        public static readonly Guid OrantaMonthOfUsage = new Guid("979A05AB-3CAB-4E63-B777-DCD3DDB50739");
        public static readonly Guid OrantaVehicleUsage = new Guid("B9AAB147-0891-486D-B7AA-BCF1658844E4");
        public static readonly Guid OrantaExperience = new Guid("0C65CBBB-5895-48B9-9A28-B820853A71C7");
        public static readonly Guid OrantaOTKDate = new Guid("D42F6AA7-09B6-4B64-A43D-3C241B41C202");
        public static readonly Guid OrantaIsOTK = new Guid("8855ECEF-0EA1-4B8A-9EC8-B03800437A73");
        public static readonly Guid OrantaRegistrationPlace = new Guid("45E78A7B-C915-4C37-845F-2F91451F5F43");
        public static readonly Guid OrantaLoadWithDelayGID = new Guid("DA8C3B37-5006-4B73-A4EB-CC2EACECC5FE");

        public static readonly Guid EIMonthOfUsage = new Guid("4F8A985A-B769-437B-80C7-270085B2665A");

        public static readonly Guid TasCoverageTime = new Guid("963DB2DF-C65F-4287-A32B-49C63A6D49B9");
        public static readonly Guid TasIncuranceCoverage = new Guid("452075EA-C323-4D6A-A0E3-6E1A8F5F7248");
        public static readonly Guid TasAccidentRiskInjuries = new Guid("AF4C8024-6640-485B-9076-32375D5E87AC");
        public static readonly Guid TasAccidentRiskTemporaryIncapacity = new Guid("2D84B167-3C18-466B-B583-CA5321341692");
        public static readonly Guid TasPlaceOfPolisAction = new Guid("D6D29279-6653-4D95-B49C-AE26278B9146");
        public static readonly Guid TasKindOfActivity = new Guid("CCFEF757-2142-4F3E-970C-B06878A6E9E1");
        public static readonly Guid FranchiseEURO = new Guid("A44EB33F-92E0-4A90-A414-260892DC7ED4");
        public static readonly Guid TasTrevelZone = new Guid("D55AF3EB-7470-45AF-9FC7-F20D2C035731");
        public static readonly Guid TasIsOTK = new Guid("2A46C1F7-AABE-402F-95C4-0F31104CE5A4");
        public static readonly Guid TasVehicleUsage = new Guid("F68B1C34-8FF2-4A3B-A925-EC743024F814");
        public static readonly Guid TasExperience = new Guid("CEEC0066-8445-4412-862B-8E5C247489A0");
        public static readonly Guid TasOTKDate = new Guid("2D15ACB3-8766-4867-AF24-D7A3A2BA3124");
        public static readonly Guid TasMonthOfUsage = new Guid("B252A755-CBCF-436B-B0AE-DFD7C90A4CDC");
        public static readonly Guid TasCascoOption = new Guid("4B4B720A-8CCD-4957-A77A-9B1B419DE0CF");
        public static readonly Guid TasCascoAmortization = new Guid("422B05DD-4E7B-443F-9291-C345E0F3E9E5");
        public static readonly Guid TasDriversCount = new Guid("BDA51577-3ED8-4C9A-8BDC-8BBFBA3F60C3");
        public static readonly Guid TasPriviledgeDocument = new Guid("2C3DDC93-7178-461B-BB68-5A67E62EEBA8");
        public static readonly Guid TasIsPriviledged = new Guid("E3CF2B57-8886-4821-B1F5-9FD236A7538A");
        public static readonly Guid TasProgramType = new Guid("C2EA75F7-60D5-4B08-ADFC-A3608F4EA4A5");
        public static readonly Guid TasNumberOfPeople = new Guid("357A8A14-A727-4801-B7B4-6BADEBF25143");
        public static readonly Guid TasAgeOfInsured = new Guid("A85B5960-C9AC-47A3-973B-7A4BCF70FBFF");
        public static readonly Guid TasKindOfTravel = new Guid("0A182339-72DA-417A-B0F1-11E227C98729");
        public static readonly Guid TasPeriodForTravel = new Guid("0b257241-041e-49a2-b902-e931e0a16439");
        public static readonly Guid TasPeriodTermForTravel = new Guid("A476B770-0951-4B6F-87C4-76E58F551A9F");

        public static readonly Guid TasExpressNewZone = new Guid("71E53301-EC29-41B5-AEF1-CB3ED7E24147");

        public static readonly Guid WorkerCategory = new Guid("FC4C91AD-D44C-473F-8BFE-31801D54B8DA");

        public static readonly Guid TasLimitWithoutCertificate = new Guid("41723231-9323-483C-9BEF-1492DEF36DF6");
        public static readonly Guid TasCompensationTow = new Guid("0CEBB0E9-24D9-4B6F-9D71-1F6CEBE3FF4C");
        public static readonly Guid TasConditionsOfUse = new Guid("4BEECEA9-EB12-437F-B16A-FAF6D51C2902");
        public static readonly Guid TasFranchiseOnGlass = new Guid("15E9C54F-4E14-4477-AC3F-945BB8698971");
        public static readonly Guid TasAdmittedPersons = new Guid("DBBD14DE-76D9-4AAC-BC6F-8AA7EF2FE1A1");
        public static readonly Guid TasAccountingDepreciation = new Guid("422B05DD-4E7B-443F-9291-C345E0F3E9E5");
        public static readonly Guid TasBeneficiaryLaw = new Guid("1072E3B7-3081-4C07-BD9D-43B3738B3DEA");
        public static readonly Guid TasRegistrationPlace = new Guid("019FDE88-83F1-46D7-A030-75E2F71A53F4");
        public static readonly Guid TasCountryVZR = new Guid("2105F49A-F8F7-46D9-B33C-0F329E93A7AE");

        public static readonly Guid ZlagodaDriverAgeMin = new Guid("21B87093-3F94-4F6D-BB37-3051806CD61F");
        public static readonly Guid ZlagodaDriverAgeMax = new Guid("88F67891-6525-4003-BEF2-BC1D4C0F433D");
        public static readonly Guid ZlagodaDriverAllExperiences = new Guid("25CA73F6-AC91-4843-8C29-5F0F56E222BE");
        public static readonly Guid ZlagodaDriverExperienceMin = new Guid("48903760-D3BE-4F5E-B107-A3D373FC8B8A");
        public static readonly Guid ZlagodaTypeInsuranceSum = new Guid("AB2B16F1-020A-43DC-B421-FA2A09EF6DD9");
        public static readonly Guid ZlagodaPlaceOfPolisAction = new Guid("9C22FCDD-1465-427D-9E9F-39A53389DB94");
        public static readonly Guid ZlagodaRepairs = new Guid("935976DE-5057-4BCF-88E9-69F8F0B50E72");
        public static readonly Guid ZlagodaIncludeWear = new Guid("040C75C0-666A-469D-9ACA-31CF845634F9");
        public static readonly Guid ZlagodaNSSystemOfSeats = new Guid("18F7CFF3-2895-4B72-ABA0-D4EBF45AB492");
        public static readonly Guid ZlagodaNSPaushal = new Guid("6BBEB466-FED3-4AC3-8D63-B8656D985ADE");
        public static readonly Guid ZlagodaNSInsuranceSumPerson = new Guid("B8E1A3D7-11ED-4A1C-9119-9E35D58F28A8");
        public static readonly Guid ZlagodaNSInsuranceRate = new Guid("FF86C69D-F305-46F3-AA3D-10195BBE6824");
        public static readonly Guid ZlagodaNSCountOfSeats = new Guid("568A97F5-3E2B-4D8E-B511-AAFEF45A3A0F");
        public static readonly Guid ZlagodaCountOfVehicles = new Guid("DC323BB0-4CE4-4F4C-9BD6-9B37571D9D05");
        public static readonly Guid ZlagodaKindOfUsage = new Guid("0BA04D87-ED15-4861-886D-155C0F7B5470");
        public static readonly Guid ZlagodaActivities = new Guid("a9ef046b-859f-4bfb-b2c1-be066f85b0ca");
        public static readonly Guid ZlagodaDestination = new Guid("4068a7e2-b994-4179-a8ab-131a5697711b");
        public static readonly Guid ZlagodaTypeOfConveyor = new Guid("479be075-7ea6-4fe2-bf31-1673e63a4e8b");
        public static readonly Guid ZlagodaNumberOfClassification = new Guid("c6b94292-fedc-4e92-95ed-6aef93ccbdca");
        public static readonly Guid ZlagodaDeparture = new Guid("37c6edb8-0bd6-4fd3-8187-eb886c6f23ab");
        public static readonly Guid ZlagodaLoadVolume = new Guid("f0c179a4-4057-4d90-b578-a075370a12b0");
        public static readonly Guid ZlagodaVehicleTransportation = new Guid("c6c6b05b-8933-4b45-a1e7-997373797e73");
        public static readonly Guid ZlagodaDateOfDeparture = new Guid("82a8703b-28fd-462c-8047-c9803bf2e707");
        public static readonly Guid ZlagodaDateOfObtain = new Guid("7a009fcf-9f14-496f-b1c5-c53bb0704e6a");

        public static readonly Guid BakiSigortaPayment = new Guid("2C4A6758-85D6-4EA0-824F-5295EEEC8857");
        public static readonly Guid BakiSigortaCountOfSeats = new Guid("CEB0D53B-7250-49E9-BF15-7DB9A2DC30D3");
        public static readonly Guid BakiSigortaMedicalService = new Guid("19CCDB7A-D3A1-49CB-A4E2-235005425DB2");
        public static readonly Guid BakiSigortaMaximumPaymentPerPerson = new Guid("13091E28-B8DB-4105-8637-BEA46554BE14");

        public static readonly Guid BakiSigortaMedicalServicePerPerson = new Guid("74E50355-8E82-41DD-AA82-A894E4F8121D");
        public static readonly Guid BakiSigortaInsurancePaymentByPerson = new Guid("7c2d2421-5dcb-4fa5-a463-bca5be79a663");
        public static readonly Guid BakiSigortaDeathPaymentByPerson = new Guid("22c02999-c6a5-4639-bff7-0b3aa734e5f6");

        public static readonly Guid BakiSigortaCurrency = new Guid("A7485574-3269-4AC4-AACD-C4962A1970B4");
        public static readonly Guid BakiSigortaCountOfDaysAbroad = new Guid("2F471F60-D6B7-420D-895C-55C93CEDB1C2");
        public static readonly Guid BakiSigortaTravelCountry = new Guid("3405C869-1D54-4887-A3E9-E1852555E25C");
        public static readonly Guid BakiSigortaDrivertByOrder = new Guid("FD052100-05B3-4D34-9D25-CD80E756D48C");
        public static readonly Guid BakiSigortaKindOfUsage = new Guid("e6b553f7-5204-4950-897b-e03f22726df0");
        public static readonly Guid BakiSigortaTravelAbroad = new Guid("558B292D-5D45-4715-A1DF-A4F11A124448");
        public static readonly Guid BakiSigortaPlaceOfPolisAction = new Guid("6a6d273b-41d1-4405-8552-64b5dbc033e3");
        public static readonly Guid BakiSigortaKindOfUsageAdditional = new Guid("a5ddaf8a-7e05-41fb-bd37-14d04043d4f0");
        public static readonly Guid BakiSigortaDiscount = new Guid("B144865E-9386-4EA9-87E0-475A582A01F5");
        public static readonly Guid BakiSigortaRepairServiceDefine = new Guid("9856B467-37A8-49F7-AF54-7CB41CB7DD4A");
        public static readonly Guid BakiSigortaSpecFranchise = new Guid("7BC288A3-4502-4191-8166-77657C1A7ED0");

        public static readonly Guid BakiSigortaObjectDescription = new Guid("6F38200C-DF76-430C-B41E-0A3A8E6FEB75");

        public static readonly Guid BakiSigortaAmortization = new Guid("DEC2BE5D-62E9-476B-ADC9-45910BF49B0F");

        public static readonly Guid ZlagodaContractAction = new Guid("C9C32F3D-3FCF-4E66-8D6E-ABA843A51394");

        public static readonly Guid ZlagodaRiskPackage = new Guid("60FD66DC-48F0-4667-9A58-DEDDEE3D5943");

        public static readonly Guid ZlagodaInsuredCount = new Guid("d63fe03d-a64f-4b5b-bda0-00fba06fe5f8");
        public static readonly Guid ZlagodaVZRProgram = new Guid("38cb9059-5b8b-47c9-b238-6b0bc959f100");
        public static readonly Guid ZlagodaFranchise = new Guid("4cff70b2-a6d6-4944-9f09-1d21541a004c");
        public static readonly Guid ZlagodaCountry = new Guid("bbcb0ea4-af2e-49dc-b42b-2c8774466a86");
        public static readonly Guid ZlagodaGoalForTravel = new Guid("2dfe8fd5-5052-4286-a4d6-7e0c57845cc4");
        public static readonly Guid ZlagodaInsuranceSum = new Guid("48aa2589-a754-481f-b147-5d40d7b35dce");
        public static readonly Guid ZlagodaInsuranceTerm = new Guid("1839bcf5-8ee5-4813-903b-ea8b88fbd06e");
        public static readonly Guid ZlagodaCurrency = new Guid("51244f3d-8630-4069-8c1a-a0a792ad8649");

        public static readonly Guid TasFullProptectionType = new Guid("4C920445-DA8B-4C81-B1EF-E8F314AE0A37");
        public static readonly Guid TasFullProptectionTypeDGO = new Guid("D050B60D-1390-4971-8DCF-5C79DDF8700B");
        public static readonly Guid TasOptionType = new Guid("61360E04-5D41-4C21-9E70-432BEDF866EC");

        public static readonly Guid DominantaProgram = new Guid("CFC83F9D-2737-4BC4-AAA9-A9F5840250DB");
        public static readonly Guid DominantaCountry = new Guid("35018415-C6FF-4657-8DA7-5023A24F9560");
        public static readonly Guid DominantaLocale = new Guid("1058C523-A975-4503-8ED4-D1E03552F002");
        public static readonly Guid DominantaCurrencyExchange = new Guid("1891B809-B1D1-4A2D-8AF2-98196B8C3F32");
        public static readonly Guid DominantaTripDuration = new Guid("1D1FC306-7620-489A-A976-5CB3548FD802");
        public static readonly Guid DominantaCurrency = new Guid("23B33B87-F520-4380-954D-D265F14168DE");


        public static readonly Guid DominantaInsuranceSumCurrency = new Guid("74D55D2F-5F4C-4874-871B-1B22B12D358C");

        public static readonly Guid DiginsSalesReceiptDate = new Guid("2C7F1B33-13B5-4F62-8FBA-30E08CCB32E6");
        public static readonly Guid DiginsSalesReceiptNumber = new Guid("ACB0AC2C-9461-47B9-BA33-76DAF4EBA7E7");
        public static readonly Guid DiginsRiskReplacementPhone = new Guid("B4D98E3C-34EC-4383-A0D5-1C52DA9A52F2");
        public static readonly Guid DiginsRiskProtectBuying = new Guid("2EFCC188-4B58-4DED-BD1A-432B96A3AF78");
        public static readonly Guid DiginsRiskRecoveryKey = new Guid("C5A7DD25-CBBE-4A61-A931-7962750FA86A");
        public static readonly Guid DiginsRiskRecoveryDocument = new Guid("F14A4856-F0FC-4742-94D1-54DD67D3EDFE");
        public static readonly Guid DiginsProgram = new Guid("5C6621F6-1E8F-4020-A6EC-1B052F7AA81E");
        public static readonly Guid DiginsPackageDoctorIsNear = new Guid("13351FF4-6CB6-42C8-AE05-BEED98342B45");

        public static readonly Guid TasFullHomeProtectExclusive = new Guid("5375F532-B02D-48DE-B224-7875A0112529");
        public static readonly Guid TasFullHomeProtectFirstAid = new Guid("11B3CA3C-B42F-4401-9902-8921442121F3");
        public static readonly Guid TasFullHomeProtectRepairs = new Guid("3B7102A6-5ADE-45F1-8CB3-C00763041DAD");
        public static readonly Guid TasFullHomeProtectPressureSnow = new Guid("D4D01792-64C6-4401-83E7-BCE442F8F008");
        public static readonly Guid TasFullHomeProtectValuables = new Guid("F9DD206F-8BBD-4AF0-85EA-11E138F3EC4B");
        public static readonly Guid TasFullHomeProtectOSAGONum = new Guid("EDC49C6B-38F9-4DF7-BB15-0BC983299F82");
        public static readonly Guid TasFullHomeProtectOSAGOSeries = new Guid("BC72C4A3-7FF5-4CFC-8FD5-C09B06A8D7EB");

        public static readonly Guid TasFullHomeProtectAppointment = new Guid("69517339-C1C3-459E-B8AD-DE4D7A967742");
        public static readonly Guid TasFullHomeProtectFranchise = new Guid("EE50F54D-F547-40F1-85A3-9B2CD9A598D0");

        public static readonly Guid TasFullHomeProtectInsuranceSumHome = new Guid("1008EFDE-0A2A-4AF4-B662-280BE0626E83");
        public static readonly Guid TasFullHomeProtectContent = new Guid("7B4B5288-9A84-44C5-9CF3-E871D4A7599C");
        public static readonly Guid TasFullHomeProtectResponsibility = new Guid("59D91A58-9C2F-491E-AECD-EC4E13D913A1");
        public static readonly Guid TasFullHomeProtectOutbuildings = new Guid("2227CB30-7D68-4A53-8B07-1854DBA45504");

        public static readonly Guid TasSocialPackage = new Guid("2228B522-DE2C-4734-B120-2E413BC8533E");

        public static readonly Guid EIAMonthOfUsage = new Guid("4F8A985A-B769-437B-80C7-270085B2665A");
        public static readonly Guid EIAIsOTK = new Guid("B1DDFE23-D80B-42A6-8F08-589CFB726582");
        public static readonly Guid EIAOTKDate = new Guid("E068D4E8-553F-418C-8CAC-32F672EF164C");
        public static readonly Guid EIAPriviledgeDocument = new Guid("4A5E7F6D-1241-4567-82DF-B05F4CE84F35");
        public static readonly Guid EIAIsPriviledged = new Guid("264C537F-4A8F-4BBB-9609-C342023DBB9F");
        public static readonly Guid EIAVehicleUsage = new Guid("5C3E83F0-17DF-4F7C-B955-A5675757EDE5");

        //TasTravel
        public static readonly Guid TasTravelZone = new Guid("D463A211-CF68-49A5-8EC9-39CDD4CE5680");
        public static readonly Guid TasTravelFirstCountry = new Guid("D84CF7AC-B181-4953-970C-3484C979C2E8");
        public static readonly Guid TasTravelAgency = new Guid("82BDE524-F4AF-480D-8CB4-1E7F00FE3310");
        public static readonly Guid TasTravelInsuranceSum = new Guid("060069DD-53A9-4C96-B808-18292BF045E9");
        public static readonly Guid TasTravelProgram = new Guid("6FF09E4E-2C48-4B31-9717-1058BE1947B9");
        public static readonly Guid TasTravelLimitDays = new Guid("A172A539-A2CB-46AF-8895-99E654D8B0F8");

        public static readonly Guid TasCurrencyCorridor = new Guid("EF8CB380-B0AC-4578-ACBB-64FBEB8CA217");
        public static readonly Guid TasSTORepairType = new Guid("901AF2C2-D06B-4CEF-8A48-5B72D1B7A8BE");
        public static readonly Guid TasSTO = new Guid("6F62F300-6E27-4255-89B9-04FA4ABD0549");

        public static readonly Guid OrantaCasco95ProgramType = new Guid("D52E7EF7-9659-47D9-89BD-B6D81CE4B760");

        public static readonly Guid TasCasco5StarsPackage = new Guid("6D9F5CF9-0F39-47E0-A811-608A3624E29D");

        public static readonly Guid TasDrivingExperience = new Guid("36F4B4D0-A230-40A1-92C8-5EA82F42F7B9");

        public static readonly Guid TasOption = new Guid("F8C80392-C4B1-449D-9358-96A435138805");
        public static readonly Guid TasEstateType = new Guid("03AB52D6-0380-4699-B538-3E66EC31BBB2");
        public static readonly Guid TasGreenCardNotOnline = new Guid("671BF430-C1E7-4BE7-A036-C7E374403FD7");

        public static readonly Guid AlfaMonthOfUsage = new Guid("E50F06A6-F991-47E9-8C09-1BAEC5C445B0");
        public static readonly Guid AlfaIsOTK = new Guid("E0411F2C-EAE8-4AE5-A929-F913EB1F2358");
        public static readonly Guid AlfaOTKDate = new Guid("D5E2B018-8294-44B9-8242-9692B5B3DDF2");
        public static readonly Guid AlfaPriviledgeDocument = new Guid("798A11FA-775A-4D3E-B7A9-4D3968FED33B");
        public static readonly Guid AlfaIsPriviledged = new Guid("FAD9DB79-8ADE-46C0-B92B-EA71D57E4999");
        public static readonly Guid AlfaVehicleUsage = new Guid("DE8B1796-0A8E-4BCB-8C90-532795F36462");
    }
}
