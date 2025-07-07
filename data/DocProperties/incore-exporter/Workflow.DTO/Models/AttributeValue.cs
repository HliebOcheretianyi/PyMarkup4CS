using System;

namespace Workflow.DTO.Models
{
    public class AttributeValue
    {
        public static readonly Guid InsuranceSumTypeNonAggregate = new Guid("BA3FB523-3EFC-4973-9A0C-1D080A5CC347");
        public static readonly Guid InsuranceSumTypeAggregate = new Guid("2E75B637-6B9E-4B02-919D-9C865150DDDC");

        public static readonly Guid CostOfRepairProprietaryStations = new Guid("A33D732C-9E39-4D72-9EA6-5646F51E42DA");
        public static readonly Guid CostOfRepairAverageCommissioner = new Guid("1273DF54-130F-4D6E-9CA8-54CD7E564190");

        public static readonly Guid BakiSigortaTypeOfHouseBrick = new Guid("B3C1DA03-2AAF-4837-8940-5E1AF0F6F53B");
        public static readonly Guid BakiSigortaTypeOfHousePanel = new Guid("7DCF3FE1-D594-495F-ABCA-8AAECC7EE131");
        public static readonly Guid BakiSigortaTypeOfHouseMonolithic = new Guid("1FF227A8-43FA-4A63-85A8-D217365246B1");

        public static readonly Guid BakiSigortaMaterialOfWallsAndCeilingWooden = new Guid("E6BB5207-E7D1-47BD-9928-9CEBBE85296A");
        public static readonly Guid BakiSigortaMaterialOfWallsAndCeilingConcrete = new Guid("7626CB93-FB83-492E-B0AE-A41F82A0D9B1");
        public static readonly Guid BakiSigortaMaterialOfWallsAndCeilingOther = new Guid("3CACEE08-A961-4681-8E73-F676BA607F53");

        public static readonly Guid BakiSigortaPaymentTypeCash = new Guid("E64137CC-E170-4A52-A260-A08962222992");

        public static readonly Guid BakiSigortaPhisicalTypePhisical = new Guid("3CF2808D-2A56-4B15-9146-4A0DF1292A92");

        public static readonly Guid DominantaTripPurposeTourist = new Guid("64E53A65-8431-4B50-B5F9-CA50DA2AB036");
        public static readonly Guid DominantaTripPurposeActivities = new Guid("23D64411-F4BC-42D4-82BF-61974B8B0618");
        public static readonly Guid DominantaTripPurposeAlpineSkiing = new Guid("653B486D-A5BB-4010-B27C-3ADF29ECE33B");
        public static readonly Guid DominantaTripPurposeIncreasedRisk = new Guid("AB308FFE-D8F2-4F91-A307-C6A9E80C4EF0");

        public static readonly Guid Age71to75 = new Guid("FD26C991-60FD-4036-840F-F6BE984ABA14");
        public static readonly Guid Age65to70 = new Guid("66D5981B-D34C-4C22-B5E1-80A656267618");
        public static readonly Guid Age3to64 = new Guid("ABA8903C-B56A-41AA-94C7-4969BAA458E6");
        public static readonly Guid Age1to3 = new Guid("EFE9382F-E069-46E7-86FF-3BABCA82C804");

        public static readonly Guid Franchise300 = new Guid("5B8EAC6F-B9AD-4EC9-AB14-2CB070A1A936");
        public static readonly Guid Franchise200 = new Guid("40192B49-A428-4193-BCEB-40DBA6E0AB9B");
        public static readonly Guid Franchise100 = new Guid("9CF608E9-7D32-4B19-8497-2F13AF7525EB");
        public static readonly Guid FranchiseNone = new Guid("0E295483-110D-472E-937E-C4BF26F316A4");

        public static readonly Guid RiskGroupNone = new Guid("DFD369A9-E957-4AB0-9331-11C5B7911AD8");
        public static readonly Guid RiskGroupWork = new Guid("70E79072-DD8A-444F-B0CB-096462D2A09B");
        public static readonly Guid RiskGroupExtreme = new Guid("D7E9DE7C-BB2F-4399-A6D0-07AB895C1571");
        public static readonly Guid RiskGroupActive = new Guid("750E614D-12F4-47F9-A7CE-8F945303C985");

        public static readonly Guid TasAntiTheftSystemYes = new Guid("1EC0853B-E71C-420E-A45E-E1194BD616E0");
        public static readonly Guid TasPaymentReimbursement = new Guid("3536D09B-2E7E-4215-9B73-E85C2854E2FE");

        public static readonly string Universalna_ValidationLevel_Disabled_Code = "Disabled";
        public static readonly string Universalna_ValidationLevel_DisabledWithSystemCommissions_Code = "DisabledWithSystemCommissions";
        public static readonly string Universalna_ValidationLevel_Full_Code = "Full";
    }
}
