using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workflow.DTO.Models
{
    public partial class ClientSMS
    {
        public float id { get; set; }

        public string MessageText { get; set; }

        public DateTime SendDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public string Phone { get; set; }
    }
}
