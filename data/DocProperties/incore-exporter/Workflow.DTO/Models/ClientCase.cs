using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workflow.DTO.Models
{
    public partial class ClientCase
    {
        public string CaseNumber { get; set; }

        public DateTime RegisteredDate { get; set; }

        public DateTime? EventDate { get; set; }

        public decimal? PayableSum { get; set; }

        public DateTime? LastPayableDate { get; set; }
    }
}
