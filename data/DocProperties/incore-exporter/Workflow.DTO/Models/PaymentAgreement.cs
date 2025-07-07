using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workflow.DTO.Models
{
    public partial class PaymentAgreement
    {
        public string BlankSeries { get; set; }

        public string PolisNumber { get; set; }

        public DateTime SigningDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal? PlanedPaymentSum { get; set; }

        public decimal? RealPaymentSum { get; set; }

        public DateTime? LastPaymentDate { get; set; }
    }
}
