using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.DTO.Models
{
    public class LimitType
    {
        public static readonly Guid CommissionPercent = new Guid("EC709329-414E-49E5-8335-86B6B1915523");

        public static readonly Guid InsuranceSumProduct = new Guid("5b362ffb-f050-45d0-a2dc-77ae36118f01");
        public static readonly Guid InsuranceSumObject = new Guid("82b97538-c527-41c2-ac21-81cc06932d71");

        public static readonly Guid CommissionCurrency = new Guid("68A2C3D5-C233-4FD0-B778-A43C00365E8C");
        public static readonly Guid CommissionRemainder = new Guid("8BC3AC15-A06C-49E6-984C-3FEC18FC74D7");
        public static readonly Guid CommissionInsuranceSumPercent = new Guid("39EE10B5-1E23-416A-9327-4AA5E237A511");

        public static readonly Guid IKPCommission = new Guid("AEC5BA80-82B9-4B22-B8C7-76D9F66B8746");
        public static readonly Guid DirectorCommission = new Guid("B626A4BD-5DF9-41DA-81BA-8470DFC63474");
        public static readonly Guid SubDirectorCommission = new Guid("1087B853-214F-4940-8C56-78275F4A2799");
        public static readonly Guid RTS_TSPCommission = new Guid("0AC2A537-00D3-49C0-8604-18AE9E767D36");

        public static readonly Guid CAB_DefaultComission = new Guid("0DC54F43-2C1A-4F4B-99E1-9655B39FEC9A");
    }
}
