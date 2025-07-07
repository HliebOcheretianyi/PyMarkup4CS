using System;

namespace Workflow.DTO.Models
{
    public class ObjectType
    {
        #region PrintableProduct Properties

        public static readonly Guid Flat = new Guid("98EDFEAF-A7D4-43C7-A21B-D3ADCDD05C8E");
        public static readonly Guid Building = new Guid("CC998277-EAA9-4225-A5BB-57CFAC253FEC");

        public static readonly Guid VehicleA1 = new Guid("DD46D723-7BC0-4CFE-A45E-779DBE3558E9");
        public static readonly Guid VehicleA2 = new Guid("E4563250-D64D-4365-8FB0-A7E6690A28BC");
        public static readonly Guid VehicleB1 = new Guid("96106DBF-1817-4136-A06C-E7FF47E5A993");
        public static readonly Guid VehicleB2 = new Guid("81F6A0CE-A7D4-47B7-A38F-D7A1B0E77799");
        public static readonly Guid VehicleB3 = new Guid("D1256677-0BBF-457C-A714-FC5B94F1DCE6");
        public static readonly Guid VehicleB4 = new Guid("890380A5-9623-42AB-B425-653CD22392CB");
        public static readonly Guid VehicleB41 = new Guid("59EF162E-A8DB-4517-A733-9A0C1C4DBB80");
        public static readonly Guid VehicleC1 = new Guid("04EFDDD8-7301-48CB-B821-42BFCEB68B02");
        public static readonly Guid VehicleC2 = new Guid("0014B12B-7683-447D-87E9-5D162336B755");
        public static readonly Guid VehicleD1 = new Guid("FB8D05E8-A6A4-4899-BD76-69E44AED50CC");
        public static readonly Guid VehicleD2 = new Guid("45726E9F-E5CF-4696-A3AA-B284EDB3FF9A");
        public static readonly Guid VehicleE0 = new Guid("5DE53ED6-CBA4-4844-BF5C-8969C60691E5");
        public static readonly Guid VehicleF0 = new Guid("1E3BEB6E-0E4B-45F4-8AC8-DBF2D9EEDC0A");
        public static readonly Guid VehicleB5 = new Guid("C74293A3-CB4A-4E74-8811-CF292FE85C51");

        public static readonly Guid TasVehicleA1 = new Guid("E524A197-7CDD-4CDE-A926-40EFD3353054");
        public static readonly Guid TasVehicleA2 = new Guid("2DD3286A-B795-4940-B771-F3B48F4C533B");
        public static readonly Guid TasVehicleB1 = new Guid("F99B6C2C-8A25-4D57-9654-D49AACAD8824");
        public static readonly Guid TasVehicleB2 = new Guid("DCF86592-1A22-4378-A70C-B28530CB2071");
        public static readonly Guid TasVehicleB3 = new Guid("DED8D04F-ADA8-49FE-857F-A308161A030D");
        public static readonly Guid TasVehicleB3Full = new Guid("DBE6DAC1-5A4F-44F1-87D3-33073D9084E9");
        public static readonly Guid TasVehicleB4 = new Guid("F30087DA-01D7-493E-A0DC-FB51C28DD350");
        public static readonly Guid TasVehicleC1 = new Guid("4CE42131-C7D0-4D54-9EE7-8FE7BAB0A266");
        public static readonly Guid TasVehicleC2 = new Guid("7FE1A7B8-B189-45A8-97F8-B8DEDE1FFA3A");
        public static readonly Guid TasVehicleD1 = new Guid("9B1B23C3-DE51-49BA-98B3-FCA3DD0AF540");
        public static readonly Guid TasVehicleD2 = new Guid("E2931504-8D08-4457-A4A9-2767782A9C27");
        public static readonly Guid TasVehicleE0 = new Guid("4DF86001-FFF7-4331-AD73-2EF8FB546E97");
        public static readonly Guid TasVehicleF0 = new Guid("E8A651AD-DD7D-4A4B-9020-6BAA3FF56731");
        public static readonly Guid TasCostOfBuilding = new Guid("CC998277-EAA9-4225-A5BB-57CFAC253FEC");
        public static readonly Guid TasMovingEstate = new Guid("9BA8AA11-A0BD-4D3E-AFEE-61638DCA211E");
        public static readonly Guid TasBuildingHousehold = new Guid("7D1E3BA6-27A8-44F4-9FCA-39404F9A8243");

        public static readonly Guid TasAnimal1 = new Guid("4E02B29D-A56C-47D1-BEAC-026653D44257");
        public static readonly Guid TasAnimal2 = new Guid("CAAB95B5-026D-491F-B5DB-F9ED193F5A10");
        public static readonly Guid TasAnimal3 = new Guid("4D054644-AF1B-4C19-A764-F2E46E56D2D2");

        public static readonly Guid VehicleA = new Guid("8F9AACA3-E67F-43EA-8892-E8E375F6B483");
        public static readonly Guid VehicleB = new Guid("87DF8F2F-FAE7-469C-886A-8AF86BCFE13D");
        public static readonly Guid VehicleC = new Guid("4AB2C0F2-0A64-4225-99D9-DB02D99B48D1");
        public static readonly Guid VehicleCKasko = new Guid("76AE2EF9-DBAB-44CA-8361-21662FACC126");
        public static readonly Guid VehicleCm = new Guid("17F4F1CC-831D-47F8-B06F-E9F6544E1C90");
        public static readonly Guid VehicleD = new Guid("F8D2C33F-EDE8-48A9-A26F-BD676D80909F");
        public static readonly Guid VehicleE = new Guid("5DE53ED6-CBA4-4844-BF5C-8969C60691E5");
        public static readonly Guid VehicleE1Sub = new Guid("0E6CE8D2-4373-4238-A01F-2F54700BCC73");
        public static readonly Guid VehicleE2Sub = new Guid("F48C61F0-947E-4323-955F-6827FBEDAB6E");
        public static readonly Guid VehicleF = new Guid("1E3BEB6E-0E4B-45F4-8AC8-DBF2D9EEDC0A");

        public static readonly Guid VehicleK = new Guid("7FA502D8-5857-4B5E-8C96-2D549B4D8C76");
        public static readonly Guid VehicleK1 = new Guid("781159A6-F3FA-4739-81A0-4AECF587DD0C");
        public static readonly Guid VehicleKob = new Guid("FFF5497C-57DD-4D6C-9000-AF63423600BC");
        public static readonly Guid VehicleT = new Guid("71FEBB7B-EEED-406F-93FD-42AD5E93BC93");
        public static readonly Guid VehicleS1 = new Guid("ED75C5EB-841E-4EFE-9F7C-7B10055CC77E");
        public static readonly Guid VehicleS2 = new Guid("8425D8FA-5C09-4529-8B4F-92A8BBB3913C");

        public static readonly Guid VehicleGK_A = new Guid("5A1711CC-5F3D-4939-80B7-73D7EF020CA7");
        public static readonly Guid VehicleGK_B = new Guid("A54804BD-5E03-4672-B8E8-ABB9DB54E7D6");
        public static readonly Guid VehicleGK_C = new Guid("2227FA65-30C8-4186-B2F6-7345EDD4CF78");
        public static readonly Guid VehicleGK_E = new Guid("276E2948-627C-4E90-BD99-FA3290EB3A41");
        public static readonly Guid VehicleGK_F = new Guid("7281B552-303E-4869-BBED-26BF91F51EAE");
        public static readonly Guid VehicleGK_D = new Guid("1F9989B8-C41E-4C2F-9C58-7E763022E73B");
        public static readonly Guid VehicleGK_X = new Guid("994B885F-1125-4807-9958-EF18F7EADB9A");

        public static readonly Guid VehicleGK_ATAS = new Guid("D9EC7566-9196-4102-B42D-9E93B13D1D1E");
        public static readonly Guid VehicleGK_ETAS = new Guid("393D2F30-72D1-4D34-9A99-489112805C0A");
        public static readonly Guid VehicleGK_CTAS = new Guid("EB02D46B-692B-4E86-9133-DAAF27F7DAFC");
        public static readonly Guid VehicleGK_FTAS = new Guid("8944AC2F-3606-43F4-AF75-AB5388508E3C");
        public static readonly Guid VehicleGK_F1TAS = new Guid("744B91C7-3C32-4E38-A631-4FDAAF64E430");
        public static readonly Guid VehicleGK_F2TAS = new Guid("2F80F2E9-9403-4B2B-A716-9554A8902B47");
        public static readonly Guid VehicleGK_BTAS = new Guid("13477A52-3111-45D5-BC2A-4E4170C9DBBE");
        public static readonly Guid VehicleGK_Motocycle = new Guid("1fd8d2a1-e762-4385-a1e9-bb1435377a2f");

        public static readonly Guid TasVehicleV2_A1 = new Guid("903D45E2-B414-45BD-B9EE-6359EA7EDCF6");
        public static readonly Guid TasVehicleV2_A2 = new Guid("773C9B13-D1AE-4E74-BD1A-196753248B41");
        public static readonly Guid TasVehicleV2_B1 = new Guid("9416201D-B962-4971-BDD9-EF4596AC0B53");
        public static readonly Guid TasVehicleV2_B2 = new Guid("93CB28A5-D390-4CA5-A6CB-7ECA851DA64E");
        public static readonly Guid TasVehicleV2_B3 = new Guid("E9FBBC35-17A1-461B-86ED-ECEF31604C00");
        public static readonly Guid TasVehicleV2_B4 = new Guid("9E7D65BB-36B4-468A-90A2-AB8050425D4A");
        public static readonly Guid TasVehicleV2_B5 = new Guid("A7A430A1-D047-4FFD-9652-D36E0213D0FC");
        public static readonly Guid TasVehicleV2_C0 = new Guid("F97248FD-AE31-46F3-8A10-8E0DA3B96629");
        public static readonly Guid TasVehicleV2_C1 = new Guid("DC2668C9-02F9-4298-9A07-06A0CD87EF80");
        public static readonly Guid TasVehicleV2_C2 = new Guid("860DE2D3-6635-4C6D-9143-14CECFB71BED");
        public static readonly Guid TasVehicleV2_D1 = new Guid("17F7D2B6-5B69-4151-9FF6-30CB789F934B");
        public static readonly Guid TasVehicleV2_D2 = new Guid("CCA206C9-A7CF-4DBD-A956-DF40C3D2EDF6");
        public static readonly Guid TasVehicleV2_D3 = new Guid("59AE1CDD-27D2-4516-90FD-44E66C79874B");
        public static readonly Guid TasVehicleV2_D4 = new Guid("58D0FEA8-B3A8-452A-8F19-464438F35CFA");
        public static readonly Guid TasVehicleV2_E = new Guid("794843AE-9236-4C65-872F-51272889D075");
        public static readonly Guid TasVehicleV2_F = new Guid("A8E881EC-2F93-48C7-A4FA-0D9A89EBA95B");
        public static readonly Guid TasVehicleV2_G1 = new Guid("02312A7F-1DCF-4417-97F5-3C0111185CFD");
        public static readonly Guid TasVehicleV2_G2 = new Guid("B4663F4B-6470-4249-9FBF-B1BAB852F22E");
        public static readonly Guid TasVehicleV2_G3 = new Guid("3926CE27-1194-4167-B7CE-ECB8ECE96743");
        public static readonly Guid TasVehicleV2_H1 = new Guid("10DBE59A-4534-421D-9A46-E09FDFD72F26");
        public static readonly Guid TasVehicleV2_H2 = new Guid("317884B1-F804-4E79-9CF6-5A206A4C2D79");
        public static readonly Guid TasVehicleV2_H3 = new Guid("29FE45F1-370F-43D2-8EB8-F245CB96A344");

        public static readonly Guid Responsible = new Guid("0EE01F41-F152-4DB8-8C93-3C21D3B4E167");
        public static readonly Guid Animals = new Guid("8B69781B-31F1-4428-947D-3E28BAD1D9DF");
        public static readonly Guid Agricultures = new Guid("BCBF5D36-5FED-4BD4-9235-44DCB2843A91");
        public static readonly Guid ConstructionLoading = new Guid("A259AC6E-2CE6-4755-B9AF-49527E849057");
        public static readonly Guid LegalPersons = new Guid("16005583-CAD6-4E5F-A17D-2425AB00FFAA");
        public static readonly Guid Cargos = new Guid("499458FC-B271-4A21-8FEB-5ABAD9CBF346");
        public static readonly Guid Marines = new Guid("F3087A0A-5A5F-455D-A14B-92A92CDB8731");
        public static readonly Guid Vehicles = new Guid("18A5EF42-366B-4353-BAEA-99B529FB1356");
        public static readonly Guid PhisicalPersons = new Guid("F12DBCE8-2196-49A3-A316-A490072B62B9");
        public static readonly Guid RailRoadObjects = new Guid("FB8853B3-D87C-49C1-BADC-A8C73AA82BE8");
        public static readonly Guid Airs = new Guid("A28AB0D3-3A76-4952-8E22-AD75D030572F");
        public static readonly Guid Estates = new Guid("ACFA289E-50D9-4978-B0E1-AEEE86A7F42D");

        public static readonly Guid ZlagodaDriver = new Guid("7F468DC8-BCE3-41C5-83E6-816F80BF3335");
        public static readonly Guid ZlagodaHeadstone = new Guid("4f488e0d-1dd3-4530-a424-a7ccdf60bfad");
        public static readonly Guid ZlagodaOtherEstateOnArea = new Guid("f7ecbea1-34c2-457f-8db0-b137740942b0");
        public static readonly Guid ZlagodaMovableEstate = new Guid("a68a6ab1-d0a0-4485-84a1-7cc8c286ec66");
        public static readonly Guid ZlagodaEquipment = new Guid("59efc2a5-bf34-4853-bfd7-53034967e897");
        public static readonly Guid ZlagodaConstructive = new Guid("238635a3-0715-44b9-bf02-2949b5ecd9bc");
        public static readonly Guid ZlagodaEquipmentAndCommunication = new Guid("0cfa2130-2da2-4a0d-b254-88be6a388368");
        public static readonly Guid ZlagodaContent = new Guid("81307928-ed86-48e8-a603-7fcd7f932c2d");
        public static readonly Guid ZlagodaSupportingStructures = new Guid("5bb46f79-e54f-4ba1-be80-014ec0b40450");

        public static readonly Guid ZlagodaClearingTerritory = new Guid("133c7b75-3ae2-4e28-8887-28e22871e3a3");
        public static readonly Guid ZlagodaCostOfBuilding = new Guid("a7427b74-ab0e-4c47-b0cb-2b626833ec12");
        public static readonly Guid ZlagodaEquipmentConstructionSite = new Guid("95737a19-4dbe-4705-af6d-2bba3c9b2805");
        public static readonly Guid ZlagodaConstructionMachinery = new Guid("b63f8d5e-6237-4a8d-a4d4-46838897a254");
        public static readonly Guid ZlagodaEstateLocatedOnTheConstruction = new Guid("bac85a19-929d-4487-b27e-46f16d1771ce");
        public static readonly Guid ZlagodaCompensation = new Guid("4b444a81-d2ae-4164-ac9b-a895b4f50550");
        public static readonly Guid ZlagodaCostOfConstructionLoading = new Guid("e27da847-8821-46a1-a4e5-c4902448cfc3");
        public static readonly Guid ZlagodaWarrantyObligations = new Guid("f9bf17f2-28b2-4b1b-92f0-faa25d59ee22");

        public static readonly Guid BakiSigortaRealEstate = new Guid("54A02D65-30F5-432A-ADC0-9D15C95369C9");
        public static readonly Guid BakiSigortaPersonalEstate = new Guid("CEF77D1A-3441-4937-88B0-A8BF0810340B");
        public static readonly Guid BakiSigortaHouseholdAppliances = new Guid("DE6D79B7-47BA-4E78-A513-A6AD5583A1AD");
        public static readonly Guid BakiSigortaFurniture = new Guid("A9690021-B941-45C9-A9C3-CD83D4718A5F");
        public static readonly Guid BakiSigortaContent = new Guid("9E32D82E-CE69-423D-85EB-FE75B68B142C");
        public static readonly Guid BakiSigortaMachineryOffice = new Guid("5B85F536-86A0-4530-AB75-853834540C69");
        public static readonly Guid BakiSigortaMachineryPlant = new Guid("355CD9F1-9E48-4B0A-B9B8-080352029A3D");
        public static readonly Guid BakiSigortaGlass = new Guid("81719E4A-A641-4BF8-A97B-F0CB70385182");
        public static readonly Guid BakiSigortaFinance = new Guid("BA60DC05-F329-4761-B3F3-11DF28E20AD2");
        public static readonly Guid BakiSigortaWarehouse = new Guid("087F2488-9F78-431C-A9AE-84C77D344D10");
        public static readonly Guid BakiSigortaListOfStock = new Guid("8D705B5F-94A4-4AB0-8EE9-05948988A1B9");
        public static readonly Guid BakiSigortaFinishedProducts = new Guid("36BD9E5B-4FD8-4735-B2F2-B5B2C4FB01D4");
        public static readonly Guid BakiSigortaWorkInProgress = new Guid("2D72A24E-0568-42E4-8F53-61997E3D7DA1");
        public static readonly Guid BakiSigortaRawMaterials = new Guid("7B018A0D-A035-4A50-A1CB-5F2A1C278EC1");
        public static readonly Guid BakiSigortaFlat = new Guid("BA43DE5F-BAB5-4CA1-A848-4AB3F6CB603C");
        public static readonly Guid BakiSigortaHouse = new Guid("72EC76F7-707E-4982-BFC8-EA1D41347A84");
        public static readonly Guid BakiSigortaResidentalEstate = new Guid("40DE36C8-5903-4884-9837-37B197EFE8DD");
        public static readonly Guid BakiSigortaFlatAndHouse = new Guid("4E705E5E-8EB5-4EAA-BC1B-0A431BD6CEDA");

        public static readonly Guid DiginsMoveable = new Guid("81714fc6-baac-432e-a9a0-b0b3714055ad");
        public static readonly Guid DiginsTrim = new Guid("48cb4db9-76fb-4d18-8f59-590533dfbfb5");
        public static readonly Guid DiginsConstructive = new Guid("7d9cbd99-27b6-4b0e-b2d0-02fef4e4beee");

        public static readonly Guid SludgePonds = new Guid("EDC85DE5-A985-4B5D-89AD-0F4554FAD373");
        public static readonly Guid Waterworks = new Guid("EEE477EF-B595-4023-A24F-5E04F7776DCD");

        public static readonly Guid TasAdditionalEquipment = new Guid("20664ED0-7F19-474D-B656-40140AB048C9");

        #region Zlagoda estate object types

        public static readonly Guid ZlagodaBuild = new Guid("3C77ABB2-4F51-469B-8157-BDD1740825F6");
        public static readonly Guid ZlagodaDecko = new Guid("0CFA2130-2DA2-4A0D-B254-88BE6A388368");
        public static readonly Guid ZlagodaMoveableAndEquipment = new Guid("D1732494-73F9-4FA9-9C98-0FDEE1DE6AF0");
        public static readonly Guid ZlagodaFinishedGoods = new Guid("7A435F52-6F03-4F7E-A50B-B06C93507E6B");
        public static readonly Guid ZlagodaSpecialEstate = new Guid("4FCAAA18-B5F2-41CD-9325-24032E1679ED");

        #endregion

        #endregion
    }
}
