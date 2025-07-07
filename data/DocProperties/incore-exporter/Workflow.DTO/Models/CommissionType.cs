using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.DTO.Models
{
    public class CommissionType
    {
        public static readonly Guid Agent = new Guid("8CC6A11E-9E88-48A3-9C8C-3F3EC92E16AD");
        public static readonly Guid Seller = new Guid("307AE0E6-5D38-42B8-A576-6C9619837AF9");
        public static readonly Guid Responsible = new Guid("88F6A0ED-47CD-4998-BE42-341FBA29E36D");
        public static readonly Guid Contragent = new Guid("A966B6DD-CA78-4A30-B558-64A2383B85CE");

        public static readonly Guid AzSigortaSeller = new Guid("8B31A025-0997-47D8-8363-8A1045EF7A9A");
        public static readonly Guid AzSigortaAgent = new Guid("C1D9AA18-6896-46DA-B6FA-0D398D4AC7B0");
    }
}
