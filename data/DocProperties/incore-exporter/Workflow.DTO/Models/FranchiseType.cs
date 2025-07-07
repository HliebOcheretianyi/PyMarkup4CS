using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.DTO.Models
{
    public class FranchiseType
    {
        public static readonly Guid AssetFranchise = new Guid("0A661876-8224-4278-9FA0-88C5275AB420");
        public static readonly Guid UniversalFranchise = new Guid("67206141-D124-4B34-9998-680D7349928F");

        public static readonly Guid Stealing = new Guid("13AC60FE-7AE3-4F00-A429-C3530499B71E");
        public static readonly Guid Damage = new Guid("58CECE95-85F2-4326-9322-DAA305503857");

        public static readonly Guid TasCascoStealing = new Guid("66A9C0E6-7C00-44C7-8E62-C8FC971A094C");
        public static readonly Guid TasCasoDamage = new Guid("FE31197E-02B3-4BD4-AA12-FEE67A03880D");

        public static readonly Guid TasFranchiseMedicalEURO = new Guid("0CA01DCB-5078-48FD-9F22-B82FE155699F");

        public static readonly Guid ZlagodaCascoDamage = new Guid("131e8c2c-5e72-4510-908f-5f38d5523b2e");
        public static readonly Guid ZlagodaCascoStealing = new Guid("3bac4820-fbda-4160-aca8-d59a28549a4a");
        public static readonly Guid ZlagodaByVehicle = new Guid("3b36b8ca-6c46-4116-ac1b-0f5aa9b6abe9");
        public static readonly Guid ZlagodaDamageToLifeOrPropertyOfThirdPerson = new Guid("210b7eda-fa87-48ec-9a14-b674b89bd600");

        public static readonly Guid BakiSigortaDamage = new Guid("31BC0EEC-27D5-4E1D-A4FC-29C6A38C2F8C");
        public static readonly Guid BakiSigortaTotal = new Guid("A12B7A01-8FC9-4633-8FD3-11C35DDC0EF4");

        public static readonly Guid BakiSigortaEarthquake = new Guid("F1F5F29A-6167-4ECD-8BC9-7B2E0886BE75");
        public static readonly Guid BakiSigortaEstateWithoutEathquake = new Guid("9FA69F68-8F2F-4296-ACFD-34822EC9CE54");
        public static readonly Guid BakiSigortaTravel = new Guid("9EA7E05A-FA3F-4F3C-8265-BBD1BB60D0D3");
        public static readonly Guid BakiSigortaUniversal = new Guid("6D2B164E-0AC7-4712-A18C-1C9031902D46");
    }
}
