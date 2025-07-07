using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.DTO.Models
{
    public class ActType
    {
        public static readonly Guid Returns = new Guid("3F335D31-808C-40AD-B8B4-B7897604F3E2");
        public static readonly Guid Allocation = new Guid("D72E5BCD-25C7-4928-A85E-999BE3482A4E");
        public static readonly Guid Damage = new Guid("7D426742-7A07-47EE-9E3A-A847A9CDAB83");
        public static readonly Guid Lose = new Guid("4609C84D-8570-4196-B34E-BE7CE34AD7E0");
    }
}
