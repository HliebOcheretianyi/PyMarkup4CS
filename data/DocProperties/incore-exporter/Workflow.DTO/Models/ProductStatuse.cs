using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.DTO.Models
{
    public class ProductStatuse
    {
        public static readonly Guid Draft = new Guid("6219F747-7A24-47E8-AEDC-E2CA63472E31");
        public static readonly Guid Signed = new Guid("28892BDB-1642-4293-B37D-660511A936EA");
        public static readonly Guid Approved = new Guid("805C973D-FE3F-44A3-8229-8CF3A29CCD23");
        public static readonly Guid NotFullData = new Guid("79f6ac22-feaa-4098-a2e5-a9feab64e738");
        public static readonly Guid Verification = new Guid("C7A338C5-7892-4CCD-8B9A-B1A2817CCB73");
        public static readonly Guid Exported = new Guid("C75FF95F-A75C-414F-B97C-5975256E7319");
        public static readonly Guid ExportError = new Guid("28F83E49-E16B-4de2-9C83-7C9DC98FA06B");
        public static readonly Guid OriginalReturned = new Guid("F59A2E02-63D9-4FD8-A133-A34A4D9F6969");
        public static readonly Guid OriginalReturnedEIA = new Guid("971A4CEB-5628-47C3-84F2-641DDCA18E97");
        public static readonly Guid Stoped = new Guid("F7DCBA9B-5512-4174-A6A6-E64496BB60A6");
        public static readonly Guid StopFromStartDate = new Guid("41233E2C-1295-4B54-AB06-AD0FE744DD9D");
        public static readonly Guid Canceled = new Guid("5E72E5B0-4CC1-40FD-8A3F-F12C67F4E44F");
        public static readonly Guid Terminated = new Guid("7422C0A2-9D40-4AEA-921F-65BBD4222B94");
        public static readonly Guid Pending = new Guid("1ED54EF8-C478-4C77-9D26-9C850CD3A7E4");
        public static readonly Guid Output = new Guid("4AFF7D05-2C34-431C-9E4C-1BEF5F025BD7");
        public static readonly Guid NotExported = new Guid("318E30C3-8BC4-48BB-B891-B06B0063A37A");

        public static readonly Guid Concluded = new Guid("858000D9-BABC-4A3F-BD9C-FAE73986840A");

        public static readonly Guid Dublikat = new Guid("C04A0C6D-E25C-4D09-A254-38FA552188A5");
        public static readonly Guid Renovations = new Guid("309C997D-F1B8-4458-BF87-6B5C9244916C");
    }
}
