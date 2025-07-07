namespace Workflow.DTO
{
    public class Constants
    {
        public const int EntityCostValueValidTermInDays = 30;
        public const decimal EntityCostValueValidCostDifference = (decimal)0.05;

        public const string Impersonate = "Impersonate";

        public static readonly Guid UkraineCountryGID = new Guid("0F52ADF4-F544-42D6-BEA6-AD656AB683DF");
        public static readonly Guid AssociatedOperation_HideOption = new Guid("AE1B4CA7-6536-42CD-9F84-3D431319C5E9");
        public static readonly Guid AssociatedOperation_HideAll = new Guid("3D57047A-2B80-450B-B659-AFD0A474E0DF");
        public static readonly Guid AssociatedOperation_SetValue = new Guid("54C5374D-5B05-4BE2-81CB-E18E90F0591D");
        public static readonly Guid AssociatedOperation_Validate = new Guid("19C96246-9327-42E4-8FD1-F54BC123E03A");

        public static readonly Guid DependentEntityType_Action = new Guid("90118371-96CF-4E19-9BB1-613ADA77947F");
        public static readonly Guid DependentEntityType_Address = new Guid("70869DF9-8798-4116-B5CC-E5023DCEE416");
        public static readonly Guid DependentEntityType_OwnerAddress = new Guid("BF66EFD9-566D-4C6A-A6A9-82865E5CE00E");
        public static readonly Guid DependentEntityType_Attribute = new Guid("d4a42869-3e15-4604-b63e-8bed810ef2cc");
        public static readonly Guid DependentEntityType_BeginingDate = new Guid("AB810BB4-1B58-43D5-8B80-E0D86D843BBE");
        public static readonly Guid DependentEntityType_Coefficient = new Guid("775B89CA-14F2-4D3D-94DC-37BED8386672");
        public static readonly Guid DependentEntityType_Commission = new Guid("a51aff50-ff8f-4c52-8022-2340674935f3");
        public static readonly Guid DependentEntityType_Constant = new Guid("25EFBBB0-6C0C-4914-A854-A64263586354");
        public static readonly Guid DependentEntityType_Document = new Guid("7768F900-9CB0-4F85-89F2-2DB4B5355510");
        public static readonly Guid DependentEntityType_EndingDate = new Guid("9DB7AD9D-71A3-4111-8132-32F203DF6682");
        public static readonly Guid DependentEntityType_Expression = new Guid("5E508FB0-6269-4F26-9402-6B35E9B40416");
        public static readonly Guid DependentEntityType_Franchise = new Guid("E5E07E0A-F176-4506-BBAC-0429D2342813");
        public static readonly Guid DependentEntityType_InsuranceSum = new Guid("F571BB39-F887-439F-9FF7-EBBA3D222ED3");
        public static readonly Guid DependentEntityType_InsurerType = new Guid("b362b5c4-0500-42d0-826f-52f141b3314b");
        public static readonly Guid DependentEntityType_MinimalPayment = new Guid("161E7474-E52F-4943-9F7F-3E7526084805");
        public static readonly Guid DependentEntityType_ObjectFotoSite = new Guid("1730AAE4-B77B-4716-A6A1-F6D6F7B879DF");
        public static readonly Guid DependentEntityType_ObjectType = new Guid("C1D423A8-0CD5-4D6A-AD30-520ABE9EB089");
        public static readonly Guid DependentEntityType_Parameter = new Guid("D748B620-FD4B-4E98-82EF-35DE7B6B89AE");
        public static readonly Guid DependentEntityType_PaymentCount = new Guid("3877A925-C970-40A3-B847-932A50A2A4F6");
        public static readonly Guid DependentEntityType_RegisteredDate = new Guid("90914659-893A-492A-BD84-8ADA496F993A");
        public static readonly Guid DependentEntityType_ReinsuranceRate = new Guid("5FBFAB70-BC1A-46D4-8849-E4B714FDF6BB");
        public static readonly Guid DependentEntityType_Risk = new Guid("05296110-9B75-441C-894E-8E685D46C368");
        public static readonly Guid DependentEntityType_SaleType = new Guid("EC177D9A-E391-4D01-8EAA-343EEDBC8276");
        public static readonly Guid DependentEntityType_SubExpression = new Guid("FC29318A-3FAE-44DF-92DE-C71ABE86F210");
        public static readonly Guid DependentEntityType_Term = new Guid("73585B86-0405-4F0D-A56B-39C2BDE7B3DE");
        public static readonly Guid DependentEntityType_UnEqualPayments = new Guid("8E8A9CC7-B98C-454A-BF79-1565D8492017");
        public static readonly Guid DependentEntityType_VehicleManufacturer = new Guid("D6BE4347-39D6-4DC7-86D7-1939EDE087D5");
        public static readonly Guid DependentEntityType_VehicleModel = new Guid("51230B89-95C0-4980-BE1A-21CE75A03757");


        public static readonly Guid Attribute_IdentificationCode = new Guid("81BFD5BA-7E37-4E00-B5BF-6FFBAD266DF7");
        public static readonly Guid Attribute_VehicleRegistrationNumber = new Guid("91AA2DD7-53D5-4239-8962-9320A1431739");
        public static readonly Guid Attribute_BodyNumber = new Guid("6E6382F7-B325-489A-851D-455C94FA12FF");
        public static readonly Guid Attribute_BranchLevel = new Guid("DD1D318A-281C-40c0-8996-D81CB5B87806");

        public static readonly Guid CommissionType_Agent = new Guid("8CC6A11E-9E88-48A3-9C8C-3F3EC92E16AD");
        public static readonly Guid CommissionType_IKP = new Guid("BEDED8D6-159C-4DEC-869C-25416FCAD1FF");

        public static readonly Guid ObjectType_PhisicalPersons = new Guid("F12DBCE8-2196-49A3-A316-A490072B62B9");
        public static readonly Guid ObjectType_LegalPersons = new Guid("16005583-CAD6-4E5F-A17D-2425AB00FFAA");
        public static readonly Guid ObjectType_Vehicles = new Guid("18A5EF42-366B-4353-BAEA-99B529FB1356");
        public static readonly Guid ObjectType_Animal = new Guid("8B69781B-31F1-4428-947D-3E28BAD1D9DF");
        public static readonly Guid ObjectType_Agriculture = new Guid("BCBF5D36-5FED-4BD4-9235-44DCB2843A91");
        public static readonly Guid ObjectType_ConstructionLoadingWork = new Guid("A259AC6E-2CE6-4755-B9AF-49527E849057");
        public static readonly Guid ObjectType_Cargo = new Guid("499458FC-B271-4A21-8FEB-5ABAD9CBF346");
        public static readonly Guid ObjectType_Marine = new Guid("F3087A0A-5A5F-455D-A14B-92A92CDB8731");
        public static readonly Guid ObjectType_RailRoadObject = new Guid("FB8853B3-D87C-49C1-BADC-A8C73AA82BE8");
        public static readonly Guid ObjectType_Air = new Guid("A28AB0D3-3A76-4952-8E22-AD75D030572F");
        public static readonly Guid ObjectType_Estate = new Guid("ACFA289E-50D9-4978-B0E1-AEEE86A7F42D");


        public static readonly Guid InsuranceObjectType_Insurer = new Guid("F04095A3-1A45-4889-AD9F-11EF777FA009");
        public static readonly Guid InsuranceObjectType_Representative = new Guid("E16F4BF8-846E-4426-895C-3BDB103D65F3");
        public static readonly Guid InsuranceObjectType_Assured = new Guid("D6254D77-3B88-443A-B407-10A3E4F60F01");


        public static readonly Guid ReinsuranceType_Proportional = new Guid("4723a2aa-15e1-467a-9d53-5795e9acc17e");
        public static readonly Guid ReinsuranceType_EkscendentOfLoss = new Guid("3fe943b0-ab1b-4dbe-9754-3cdb73bdb0cb");
        public static readonly Guid ReinsuranceType_EkscendentOfSum = new Guid("c4aec32f-6783-4e5a-a7b3-372635f0fe13");

        public static readonly Guid Template_Contract = new Guid("35A40066-743E-437B-A03C-5B9C5FE268D7");
        public static readonly Guid Template_Polis = new Guid("3DB54FED-F4FB-4D89-9F24-BC391EC50079");
        public static readonly Guid Template_Cancel = new Guid("5C59BB07-5B2B-48F4-BBD8-FA379F1457E6");
        public static readonly Guid Template_AgentAct = new Guid("2A96AEF4-3DE0-4979-8722-B37B73AB283E");
        public static readonly Guid Template_AgentApplicationQuestionnaire = new Guid("47AF4A70-1A6C-4432-8F55-6EB4E4F65B84");

        public static readonly Guid FileType_ElectronicSignature = new Guid("2D58D33C-C703-4683-97B6-CCEF31FADBB7");

        public static readonly Guid DocumentType_BranchLevel = new Guid("BE2D4A35-A36B-4a93-99DD-F2F1D9DDB2BE");

        public static readonly Guid OtherDocumentTypeGID = new Guid("1471DD49-0DE4-496F-9565-D307A15A1834");

        public const long PersonType_Person = 1;
        public const long PersonType_JuridicalPerson = 2;
        public const long PersonType_Entrepreneur = 3;

        public const int SupplementaryAgreementType_New = 0;
        public const int SupplementaryAgreementType_Edit = -1;
        public const int SupplementaryAgreementType_Copy = -2;

        public const string SupplementaryAgreementEditablePropertiesPolisNumberField = "PolisNumber";
        public const string SupplementaryAgreementEditablePropertiesPolisNumberSecondField = "PolisNumberSecond";
        public const string SupplementaryAgreementEditablePropertiesProductActionField = "ProductAction";
        public const string SupplementaryAgreementEditablePropertiesBeginingDate = "BeginingDate";
        public const string SupplementaryAgreementEditablePropertiesTextBoxBeginingDateTime = "TextBoxBeginingDateTime";
        public const string SupplementaryAgreementEditablePropertiesEndingDate = "EndingDate";
        public const string SupplementaryAgreementEditablePropertiesSupplementaryAggrementEndingDate = "SupplementaryAggrementEndingDate";
        public const string SupplementaryAgreementEditablePropertiesInsuranceSumUkr = "InsuranceSumUkr";
        public const string SupplementaryAgreementEditablePropertiesBranchName = "BranchName";
        public const string SupplementaryAgreementEditablePropertiesSalesChannel = "SalesChannel";
        public const string SupplementaryAgreementEditablePropertiesRegisteredDate = "RegisteredDate";
        public const string SupplementaryAgreementEditablePropertiesResponsibleField = "ResponsibleGID";
        public const string SupplementaryAgreementEditablePropertiesCommentField = "Comment";

        public const string ProductTypeFieldsForum = "Forum";

        public static readonly Guid InsuranceApplicationStatusNew = new Guid("5E110BCA-C940-4A93-ABA1-B7E3C2B2AE09");

        public const string INNPersonValidFormat1 = @"^0[1-9]{1}\d{8}$";
        public const string INNPersonValidFormat2 = @"^[1-9]{1}\d{9}$";
        public const string INNPersonValidFormat3 = @"^([Ff][АБВГДЕЁЖЗІЇИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЄЭЮЯабвгдеёжзіїийклмнопрстуфхцчшщъыьєэюя]{2}\d{6}0|[Ff]\d{9})$";
        public const string INNJuridicalPersonValidFormat = @"^\d{8}$";


        public const string SaveUserProcess = "Збереження користувача";
        public const string UserSaveEvent = "UserSave";

        public static readonly Guid BlackIceDocumentTypeClaim = new Guid("DD09BC5C-AC58-431B-978F-0709979BB434");
        public static readonly Guid BlackIceDocumentTypeProduct = new Guid("CC6F6458-9691-4A68-86AC-3D3A4ED65D97");

        public static readonly Guid AgentStatusFiredGID = new Guid("7AE7CC83-F465-496E-A584-72AF685991BD");

        public static readonly Guid PhysicalPersonFileEntityTypeGID = new Guid("63CCF2F7-9EF0-4CAE-8BA3-588BF1BF06C6");
        public static readonly Guid JuridicalPersonFileEntityTypeGID = new Guid("02A93190-A936-4300-8590-7ECB492BACC9");
        public static readonly Guid VehicleFileEntityTypeGID = new Guid("8C5271EA-B079-4339-A707-A5B6CD03D17E");
        public static readonly Guid CaseFileEntityTypeGID = new Guid("33E49AE1-15E1-48A8-BE3E-988DA9BCEF46");
        public static readonly Guid ProductFileEntityTypeGID = new Guid("F3C6E883-1B27-4F69-89E4-1CFA18201A9D");

        public static readonly Guid Attribute_Universalna_APIValidationLevel_GID = new Guid("9722FFEF-A61F-47E8-92BE-2CA969876411");
        public static readonly Guid Attribute_Universalna_FrontValidationLevel_GID = new Guid("4E9B31CA-F743-4FA2-B4BE-6E33BB0324D1");
    }
}
