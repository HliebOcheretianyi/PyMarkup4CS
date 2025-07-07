using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.DTO.Models
{
    public class Risk
    {
        public static readonly Guid LifeDamage = new Guid("C1133FB1-BCE1-4AEC-B544-E00870602AFF");
        public static readonly Guid AssetDamage = new Guid("CAEBC7AB-9DD5-45E6-9ADC-A0FF3BDE6B0E");
        public static readonly Guid DeathDamage = new Guid("A9CE32E9-8478-49D8-8683-CB993EA5BBD7");
        public static readonly Guid InjuiryDamage = new Guid("87679418-3087-4F2E-9B64-E0A3AE544341");
        public static readonly Guid TemporaryDisabilityDamage = new Guid("20D69C9A-8ACD-4A83-A7EA-F0BA630C2F63");
        public static readonly Guid FireDamage = new Guid("52C26E1D-4A01-4F0E-91D0-1B9C37AF6BD3");
        public static readonly Guid DisasterDamage = new Guid("08725557-3FA4-4A0A-93E9-915628C8E4D7");
        public static readonly Guid LiquidDamage = new Guid("47E7AD71-4084-4F69-916C-E68480696A60");
        public static readonly Guid ThirdPersonDamage = new Guid("93C2020C-EF58-4AA9-8BBA-8F6EDCE5E369");
        public static readonly Guid StealingDamage = new Guid("44720F84-103C-4855-A568-C2FED8FA36DA");

        public static readonly Guid FullKasko = new Guid("E45C2173-0B10-4A81-A789-0D0888FD3DD0");
        public static readonly Guid Damage = new Guid("5E66ADA9-E895-4A13-9498-B9FC0BD785C9");

        public static readonly Guid ProgramD = new Guid("6D3A5DAB-79B1-4838-BC51-AEC6BA5A8A79");

        public static readonly Guid TasLifeDamage = new Guid("68CF6B4C-FFCE-4CBE-836D-FAD3E8536197");
        public static readonly Guid TasAssetDamage = new Guid("05F1686C-DF4D-44DF-881B-36F13632DBC7");
        public static readonly Guid TasFire = new Guid("966291DB-783B-4148-A77E-9989F10E5F52");
        public static readonly Guid TasFireNaturalDisasters = new Guid("0A2A36CC-4A39-4FC2-8690-7EB850D1AD8C");
        public static readonly Guid TasFullRisks = new Guid("3AF8A89D-2DCD-4759-9D84-38CE6D1483E3");
        public static readonly Guid TasFullAnimalRisks = new Guid("6310A76C-6E75-4612-9C95-EEDA63108864");

        public static readonly Guid TasFireNew = new Guid("29404FA6-2BC6-482D-9A0A-AF700597A5E6");
        public static readonly Guid TasFireDisastersNew = new Guid("BB760A26-E3C0-4937-B8E7-D4D04A856B33");
        public static readonly Guid TasFullNew = new Guid("07765446-1581-4D9B-BF66-01DBB6EA99C0");

        public static readonly Guid TasFullCasco = new Guid("F836F685-1DA0-4CB9-9232-D6B5D67B79A9");
        public static readonly Guid TasCascoWithoutTheft = new Guid("CBAAE3A5-5166-4DBC-9C13-B21D51DE0C23");

        public static readonly Guid TasFullCasco90 = new Guid("AD4AF2DD-F413-4079-8CF6-820B2988C360");
        public static readonly Guid TasCrach90 = new Guid("81402508-C375-424D-B697-C2FB717FF733");
        public static readonly Guid TasCascoWithoutTheft90 = new Guid("A2A7C4B3-29B1-4E38-BD8D-9D8C50292821");
        public static readonly Guid TasCascoWithoutFire90 = new Guid("FB2442CF-0519-4855-B1DA-6996508248CE");

        public static readonly Guid ZlagodaFullCasco = new Guid("4122df12-d75b-46fe-8aeb-929c738fb8fc");
        public static readonly Guid ZlagodaCascoWithoutTheft = new Guid("d5132faf-ffee-4fe6-b33b-92b1d3e8452b");

        public static readonly Guid ZlagodaCascoAccident = new Guid("FE484A46-9C34-4143-AA46-05210DEDB1E3");
        public static readonly Guid ZlagodaCascoFire = new Guid("08385ABB-9D06-438F-BB76-9CD9114BF7CC");
        public static readonly Guid ZlagodaCascoFull = new Guid("4122DF12-D75B-46FE-8AEB-929C738FB8FC");
        public static readonly Guid ZlagodaCascoDisaster = new Guid("6B59E79A-A93A-41D8-8D89-6AB99715A5FF");
        public static readonly Guid ZlagodaCascoThirdPerson = new Guid("2F97F28E-C02C-4671-9CFB-91DB27E0E9C8");
        public static readonly Guid ZlagodaCascoStealing = new Guid("7B360A39-FC7A-430A-BA32-006392B3FAC9");
        public static readonly Guid ZlagodaCascoOther = new Guid("965CFCEA-6D7B-4D45-8EA6-A6BC0647BBA4");
        public static readonly Guid ZlagodaCascoAccidentStealing = new Guid("084cdb84-3816-4f04-b0f1-75d976eacacf");
        public static readonly Guid ZlagodaCascoAccidentFireDisaster = new Guid("13a3cc74-b37a-4734-8ff2-835c1fbe7c5b");
        public static readonly Guid ZlagodaCascoAccidentFireDisasterThirdPerson = new Guid("0c6d60e7-a393-4443-88e2-723b0229ede8");
        public static readonly Guid ZlagodaCascoFireDisaster = new Guid("7aed4ce6-7052-41bc-a325-9e8ad38973dd");
        public static readonly Guid ZlagodaCascoFireDisasterThirdPerson = new Guid("fe21d357-53a5-486d-9963-40df986593f6");

        public static readonly Guid ZlagodaDisabilityFirst = new Guid("C9D11189-E8DD-49FF-A5A8-34B1129ACFD6");
        public static readonly Guid ZlagodaDisabilitySecond = new Guid("0D84C9F8-5E75-4873-8FBA-AE0C6D44FBED");
        public static readonly Guid ZlagodaDisabilityThird = new Guid("D43F6063-A6CA-4678-B268-A71B9324D2C6");
        public static readonly Guid ZlagodaDisabilityFirstAndSecond = new Guid("6E2DAA21-44C5-424A-8296-9D2746BDFEFA");
        public static readonly Guid ZlagodaDisabilityFirstAndSecondAndThird = new Guid("996EB8C4-541F-4C33-B435-4700FAEB7581");

        public static readonly Guid ZlagodaDeath = new Guid("a0e4c43d-256e-4e34-a528-6c7e9f933088");
        public static readonly Guid ZlagodaTemporaryLossOfWorkingCapacity = new Guid("7ee52025-57b3-4856-8ae5-66036dee7327");
        public static readonly Guid ZlagodaTraumaticInjury = new Guid("96b84b3c-74e4-42f2-b84b-a23cb5b881dd");
        public static readonly Guid ZlagodaExplosion = new Guid("cebbb8c6-de96-44a4-8e2f-8032c940bf6f");
        public static readonly Guid ZlagodaLoose = new Guid("45c197d9-7a1c-46ac-a07a-bf4bc631afd5");
        public static readonly Guid ZlagodaWater = new Guid("1474fba9-37b4-4d96-ae3c-ca41f8d568fe");
        public static readonly Guid ZlagodaIncursion = new Guid("8027ca18-8dfe-4caa-95ca-753e86067e02");
        public static readonly Guid ZlagodaMechanicalImproperInfluence = new Guid("074F54AA-771C-4FBF-9224-F60060677DD7");
        public static readonly Guid ZlagodaFall = new Guid("b6ecb137-1ff6-45ee-b071-70ac4ea6a843");
        public static readonly Guid ZlagodaTechnicalRisks = new Guid("092905ce-c060-4bf8-916a-03a55253ad0e");
        public static readonly Guid ZlagodaFire = new Guid("08385ABB-9D06-438F-BB76-9CD9114BF7CC");
        public static readonly Guid ZlagodaLightning = new Guid("49140971-ad7f-4bd9-8d95-9af7b8024788");
        public static readonly Guid ZlagodaNaturalForcesAndDisasters = new Guid("4e91abff-efc8-4cc4-a627-e5341dec75a3");
        public static readonly Guid ZlagodaFireRisksAndNaturalDisasters = new Guid("0e9d6f41-048b-45e2-bdd6-f4580a9b7c9f");
        public static readonly Guid ZlagodaEstateBurglary = new Guid("12835597-f147-464a-91c6-77563bd5cb24");
        public static readonly Guid ZlagodaDefectiveMaterials = new Guid("2b5794ee-0b4b-4f03-83cc-133de6590cdb");
        public static readonly Guid ZlagodaIndustrialAccidents = new Guid("2c75bf20-7a0c-43b6-8904-24c613f13462");
        public static readonly Guid ZlagodaOtherRandomEvents = new Guid("9bd0851a-62c3-4c1f-aa64-1cd711faf014");

        public static readonly Guid ZlagodaDamageToLifeAndHealth = new Guid("4060094e-b3bc-4c32-96df-3a509e7951cf");
        public static readonly Guid ZlagodaDamageToLifeAndHealthByEvent = new Guid("5ca68811-6d36-42e3-af7e-357143592d88");
        public static readonly Guid ZlagodaDamageToLifeAndHealthByEventOnPerson = new Guid("b10a9978-0eee-479c-a6ae-cd61d28e939c");
        public static readonly Guid ZlagodaDamageToProperty = new Guid("d8fce294-2986-454d-843f-88082620693c");
        public static readonly Guid ZlagodaDamageToPropertyByEvent = new Guid("75414017-d724-48d4-a68e-fe9288fe441b");
        public static readonly Guid ZlagodaDamageToPropertyByEventOnPerson = new Guid("e6c048dd-0414-46e5-89d6-b658334535ba");
        public static readonly Guid ZlagodaLossToTheAircraft = new Guid("42f82307-1097-4b15-b806-ce4397f78422");
        public static readonly Guid ZlagodaDamageToPropertyThirdPersons = new Guid("c1732258-d43c-4d24-8d23-fa1031fffdc4");
        public static readonly Guid ZlagodaDamageToLifeOrPropertyByAirport = new Guid("5fd42098-b809-4d01-b4c3-e7b077f7fa1a");
        public static readonly Guid ZlagodaDamageToParckedVehicle = new Guid("b8d6ed3b-1c87-4e5b-bce3-d576c97ad129");
        public static readonly Guid ZlagodaDamageToEnviroment = new Guid("4ef128f3-a791-4796-b3d2-b42cea082d56");

        public static readonly Guid BakiSigortaEarthQuake = new Guid("9B1F5AD4-A602-4D01-84BA-311EF9D0DC90");
        public static readonly Guid BakiSigortaStormAndHurricane = new Guid("305DE262-4811-445D-9A95-D069106759CE");
        public static readonly Guid BakiSigortaFlood = new Guid("6A281C0E-0152-44A3-BB61-E519712D1C95");
        public static readonly Guid BakiSigortaInternalFlooding = new Guid("C3FC11AC-03C5-4980-8AD8-4DF3815F1571");
        public static readonly Guid BakiSigortaFireLightingExplosion = new Guid("4D4242BA-8E79-4F25-BA9D-B7FCAE932AF9");
        public static readonly Guid BakiSigortaTerrorism = new Guid("E773FE8E-F2D2-404F-A297-64BD7860E23C");
        public static readonly Guid BakiSigortaSnowDrift = new Guid("09A0CB22-79EB-448D-8F18-D8A76D72DA35");
        public static readonly Guid BakiSigortaLandslide = new Guid("92E92FB3-2213-4E94-88F6-BCB4D0AA739A");
        public static readonly Guid BakiSigortaSoot = new Guid("ACCAC560-9E49-40FA-96A4-CAF6236A6802");
        public static readonly Guid BakiSigortaMotorVehicleCollision = new Guid("64F69872-0DC4-4A9A-B9E2-3AF06F306A62");
        public static readonly Guid BakiSigortaSeaVehicleCollision = new Guid("415BA935-E6D3-4478-9FF6-8533C57B7E3A");
        public static readonly Guid BakiSigortaAviaCollision = new Guid("058B536F-F957-4B2E-AA70-ECE627549721");
        public static readonly Guid BakiSigortaStrikes = new Guid("1C9831D4-A5DC-4433-83CC-0E85A467C24D");
        public static readonly Guid BakiSigortaBurglary = new Guid("9F792117-7746-4E29-B79C-4FF67F2E59E7");
        public static readonly Guid BakiSigortaMaliciousOfThirdParties = new Guid("0B9C4C1B-7E42-47CE-84CB-E9C3ECFDC18F");

        public static readonly Guid BakiSigortaBrokenGlass = new Guid("88063B68-F442-4605-B045-4B377844961D");

        public static readonly Guid ZlagodaDeathDueToTrafficAccident = new Guid("8422B7B5-0E39-4781-A88F-003E96D9F845");
        public static readonly Guid ZlagodaInsuredInjuryDisability1 = new Guid("FC38C787-5910-46B7-8944-9C94AF6E88CB");
        public static readonly Guid ZlagodaInsuredInjuryDisability2 = new Guid("D90804EC-4CFD-4A9C-A58E-226305CF81D1");
        public static readonly Guid ZlagodaInsuredInjuryDisability3 = new Guid("753F8F83-DE11-4315-9BCC-9419A50745C0");
        public static readonly Guid ZlagodaTemporaryLossOfDisability = new Guid("A7D6EE5A-C4D6-45F8-9051-0AEF30C73B7A");

        public static readonly Guid ZlagodaSingleCargoOtherRisk1 = new Guid("6038BB45-A2F9-433A-B810-FD94609DFC59");
        public static readonly Guid ZlagodaSingleCargoOtherRisk2 = new Guid("D70B50E9-8C18-4CF6-B720-8A704526BA10");
        public static readonly Guid ZlagodaSingleCargoOtherRisk3 = new Guid("624D4795-1E87-45B3-8F3A-742C9FDE951F");
        public static readonly Guid ZlagodaSingleCargoOtherRisk4 = new Guid("1DA21BEA-8F65-48D4-B860-61217FFB3B47");
        public static readonly Guid ZlagodaSingleCargoOtherRisk5 = new Guid("F6C8BF41-55E5-4310-A522-A44C470E4276");
        public static readonly Guid ZlagodaSingleCargoOtherRisk6 = new Guid("E60EBF15-AD15-42E5-944C-5DBF92A7CBDF");
        public static readonly Guid ZlagodaSingleCargoOtherRisk7 = new Guid("1E796392-2671-4993-9F69-B36DE6073E68");

        public static readonly Guid ZlagodaPackage4Risk1 = new Guid("267585EA-13E0-458F-ABBA-2D871A2E1F6A");
        public static readonly Guid ZlagodaPackage4Risk2 = new Guid("CC329645-D227-4724-AB07-33489383977D");
        public static readonly Guid ZlagodaPackage4Risk3 = new Guid("27B7BBE4-5C74-4AE4-A8D5-5D22DBE30DFB");
        public static readonly Guid ZlagodaPackage4Risk4 = new Guid("20DF17FD-77D3-43AF-89EC-750E5B8CDDE7");
        public static readonly Guid ZlagodaPackage4Risk5 = new Guid("2F97F28E-C02C-4671-9CFB-91DB27E0E9C8");
        public static readonly Guid ZlagodaPackage4Risk6 = new Guid("219905D5-E22B-4F43-A134-988FA5E27531");
        public static readonly Guid ZlagodaPackage4Risk7 = new Guid("08385ABB-9D06-438F-BB76-9CD9114BF7CC");
        public static readonly Guid ZlagodaPackage4Risk8 = new Guid("E314D4F3-1433-47C1-9F9A-A54730DE75AA");
        public static readonly Guid ZlagodaPackage4Risk9 = new Guid("4B1F06FE-8205-4018-9831-C55FCAE5A50E");
        public static readonly Guid ZlagodaPackage4Risk10 = new Guid("837183BA-3CFE-4700-9937-CEECF1F9CDC3");
        public static readonly Guid ZlagodaPackage4Risk11 = new Guid("51ADA140-F413-47E8-BFFB-D168B224ABF2");
        public static readonly Guid ZlagodaPackage4Risk12 = new Guid("C14AEDEB-1DB9-45F9-881E-DAD336667603");

        public static readonly Guid OrantaThief = new Guid("A7F30688-6AD2-479D-ACD9-8759BEFB80DE");
        public static readonly Guid OrantaDamageInsurerGuilty = new Guid("7EA2B408-089D-4AD8-8BF9-384FF6F8356D");
        public static readonly Guid OrantaDamageInsurerNotGuilty = new Guid("3053EBE6-2C03-4C6D-A363-BA6156EBC35D");
    }
}
