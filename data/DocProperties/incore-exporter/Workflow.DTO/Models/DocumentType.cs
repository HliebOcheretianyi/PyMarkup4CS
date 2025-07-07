using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.DTO.Models
{
    public class DocumentType
    {
        public static readonly Guid Passport = new Guid("357bed28-00fc-479a-b3ab-a8fc8b2de094");
        public static readonly Guid IdPassport = new Guid("F17BBB99-3948-47C2-AC87-E3A16B123D22");
        public static readonly Guid BiometricPassport = new Guid("A6139EB6-6AFE-4B32-93AF-E300ED28680B");
        public static readonly Guid ForeignerPassport = new Guid("7BC04105-8BB0-4C80-9FC3-1308E2F19EDC");
        public static readonly Guid CertificateOfRegistration = new Guid("0F9DB819-6A8F-493F-9AC5-CDD3629F4E80");
        public static readonly Guid RecordOfRegistration = new Guid("A25B3090-CA87-4FF0-80C8-D7B096C1185E");
        public static readonly Guid CertificateOfSingleTaxPayment = new Guid("187A70A5-96DE-4468-9608-29941ED4028D");
        public static readonly Guid SupplementaryAgreement = new Guid("CA8156C4-0C5A-4C80-8767-A3D9C216AB5C");
        public static readonly Guid ForeignPassport = new Guid("477E6EAE-2C56-4B62-AB39-1C8EFCF5796F");
        public static readonly Guid TaxationCertificate = new Guid("0CB6A77F-644A-4B2C-8CA1-C869F2579690");
        public static readonly Guid RegistrationCatalog = new Guid("525E624B-7303-4FF1-AD42-ACDC002BB1A8");
        public static readonly Guid DriverLicense = new Guid("7ACAE121-776B-467C-8FDC-C47F09C184EE");
        public static readonly Guid ForeignerDriverLicense = new Guid("546A57F8-5462-41F2-BEF6-94EC499BE8BB");
        public static readonly Guid ContractBuySell = new Guid("87A94AEE-081E-4FE3-BEF1-5E381D9E6105");
        public static readonly Guid InsuranceSystemCode = new Guid("35F9E735-3DE8-409B-A97F-89D5823BCEB2");
        public static readonly Guid AttorneyDocument = new Guid("5015525B-4914-49E1-81BF-18A910BAA204");
        public static readonly Guid Warrant = new Guid("5015525B-4914-49E1-81BF-18A910BAA204");
        public static readonly Guid SaleBill = new Guid("C8CD3854-CF59-4e1b-AC9E-299E92981D31");
        public static readonly Guid OtherDocument = new Guid("131809A0-60B1-4666-AA19-81ED4866C208");
        public static readonly Guid BirthCertificate = new Guid("77B435F7-5D8D-449F-9222-A46ABF0E4CE0");
        public static readonly Guid TechPassport = new Guid("948CEF6F-932B-4B45-A349-D9209D222D91");
        public static readonly Guid AttorneyForVehicle = new Guid("1369FF9C-0110-4119-AA98-68A8AEBB682A");
        public static readonly Guid SertificateOfStateRegistration = new Guid("E83B9CA4-330E-4435-86C7-0EDFC7101678");
        public static readonly Guid Transport = new Guid("894A1D82-6794-426C-AF24-4E297600DC47");
        public static readonly Guid CargoCost = new Guid("2DCB5089-38B3-4A7A-A291-B25D6D09A5AF");
        public static readonly Guid Pension = new Guid("4757E7FA-250E-4101-ACD6-B306375DE68A");
        public static readonly Guid AgreementIKU = new Guid("563A9FE3-008C-49AA-B054-DBF6D29028D0");
        public static readonly Guid AgreementAuthorizationPhisical = new Guid("E0879D23-DB3E-4A8B-90DF-B39905B8B05A");
        public static readonly Guid AgreementAuthorizationJuridical = new Guid("B79955CE-8318-4673-87CE-E7B8BD23707A");
        public static readonly Guid AgentPermission = new Guid("774BE033-8F92-4AFB-A631-970D9A30F538");
        public static readonly Guid BranchLevel = new Guid("BE2D4A35-A36B-4a93-99DD-F2F1D9DDB2BE");
        public static readonly Guid Branch = new Guid("3B6338FE-BE9E-4BC7-93F3-4B4A11AFDF00");

        public static readonly Guid OrantaWarVeteran = new Guid("C5404060-E485-42F3-A613-147E991779C1");
        public static readonly Guid OrantaDisabled = new Guid("3D2DAF1B-E70B-4401-B952-C2ED01C62C0E");
        public static readonly Guid OrantaChernobyl = new Guid("3857A5E3-8BA8-4DE7-9185-06FFE838199C");

        public static readonly Guid Product = new Guid("451C49E0-D095-4226-A344-5B54FCFBBB85");
        public static readonly Guid Contract = new Guid("05C218E2-24C0-493E-A001-4950BCE05EBC");
        public static readonly Guid Claim = new Guid("DD09BC5C-AC58-431B-978F-0709979BB434");
        public static readonly Guid Notification = new Guid("593E4A32-F7D3-4DAF-A667-F31624CD0C8C");
        public static readonly Guid Ticket = new Guid("D29BD3AC-710F-495F-A1E5-E11D02C333FE");
        public static readonly Guid InsuranceAct = new Guid("1e12e710-fb81-4c97-87b3-969fef831e8e");

        public static readonly Guid RequestGACasco = new Guid("01994B73-E4A3-48B9-9885-C6452E55798F");
        public static readonly Guid RequestGAOsagoInsured = new Guid("82531750-CF7B-4DDC-B76D-6DB7B85D03DD");
        public static readonly Guid RequestGAOsagoVictim = new Guid("0BF28D83-8B03-4075-88CF-2B694005F2F8");
        public static readonly Guid DirectionToSRT = new Guid("0ACD6E83-3AE8-4389-A7D5-3984908114B4");
        public static readonly Guid RequestToBank = new Guid("B7D796A0-EC79-4031-8A3A-BE2C052363FA");

        public static readonly Guid CascoCalculation = new Guid("20458AAD-6B20-4A5D-82F4-E95CBC74DB1B");
        public static readonly Guid OsagoVehicleCalculation = new Guid("CC5656A1-DD50-4DFF-BD00-8B49E30F35DB");
        public static readonly Guid OsagoHealthCalculation = new Guid("9163ED2E-94F3-4B1C-BD4E-4AC2ABA5E809");
        public static readonly Guid OsagoAssetCalculation = new Guid("7A8941C4-A6D3-413C-BE57-545ACAD1AE65");
        public static readonly Guid AccidentCalculation = new Guid("29E23D66-137A-43C1-9A14-3ED1CED0EEB3");
        public static readonly Guid AssetCalculation = new Guid("A734D895-E1F7-4BAA-9FAA-BCC4B4025C95");

        public static readonly Guid SRTCalculation = new Guid("FFF4A975-D5C6-49F5-A66E-F2D12502B9B1");
        public static readonly Guid AccountsCenterCalculation = new Guid("45626D2C-0623-4A89-ABC2-E9EB60FAB99A");
        public static readonly Guid IndependentCalculation = new Guid("C2083432-80E7-470C-91DD-643245AB48B2");

        public static readonly Guid CalculationDigitalCopy = new Guid("0754C394-69F9-4CB2-9940-516E76C8B931");

        public static readonly Guid MarketResearchApproverProtocol = new Guid("E6CD64BA-CE0F-4774-A8C5-D425B03BDE9E");
        public static readonly Guid Appendix2AndConductOnlineAuctionLetter = new Guid("F6C75367-A3DB-465D-9BB0-0F37E20BFF16");
        public static readonly Guid Appendix2AndConductOnlineAuctionLetterApproved = new Guid("472600D8-08A7-455E-A8D8-98B98218DCA2");
        public static readonly Guid InsuranceActNotification = new Guid("27E4C875-C9AB-42C6-B144-7AC572316A2E");

        public static readonly Guid CalculationCascoTotal = new Guid("50111458-BE2A-456A-A639-964B85D6E3BD");
        public static readonly Guid CalculationCascoResidues = new Guid("B974C316-01F5-4859-A3DB-18A36A214FCF");
        public static readonly Guid ActAppraisal = new Guid("9BFC8FB4-D58E-4E63-B9F3-B3DABD7B2892");

        public static readonly Guid Certificate = new Guid("F5EA99CC-14C1-4577-875F-6603F596BD75");
        public static readonly Guid ActApproval = new Guid("C90380C7-9D09-4C98-A6C3-1679956234A0");

        public static readonly Guid CascoActTotal = new Guid("0AF21DDA-9941-4ABE-A4C1-08100183271C");
        public static readonly Guid LossCalculationAct = new Guid("4D4DCBFF-41D5-4A37-A34B-FFA1053C553E");
        public static readonly Guid UnderinsuranceAct = new Guid("E3F85B38-52EC-435F-871D-22BFF7B5179F");

        public static readonly Guid VehicleInspectionAct = new Guid("FB28D39F-E5DB-4BA9-B01C-D18BB2696CB4");
    }
}
