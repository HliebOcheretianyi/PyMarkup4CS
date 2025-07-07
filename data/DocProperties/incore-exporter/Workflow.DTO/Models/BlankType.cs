using System;

namespace Workflow.DTO.Models
{
    public class BlankType
    {
        public static readonly Guid[] OrantaGreenCardBlankTypes = new Guid[]
        {
            new Guid("06FBE235-A498-48B3-BCB3-60A4A981D46C"),
            new Guid("6E4356C2-D10F-4EF2-9485-CDAFECC3EEAA"),
        };

        public static readonly Guid FullProtection = new Guid("9E61E9CA-D1FC-454B-AC17-9BC00A51A63F");
        public static readonly Guid[] Discounts = new Guid[]
        {
            new Guid("D0E5AE6F-D8CE-420A-BF8C-B92979BED8A2")
        };

        public static readonly Guid DiginsKeychain = new Guid("C51F4D32-7BA9-4B99-A0BB-E8D40371B37C");
        public static readonly Guid DiginsSticker = new Guid("00BAA012-2942-475B-9C9A-1BC240942D56");
        public static readonly Guid DiginsKeychainNT = new Guid("5496A4D9-A93B-4BF1-B6B9-BB193B35B379");
        public static readonly Guid DiginsStickerNT = new Guid("A0644679-22E2-4111-B4BE-A442DEA13502");
        public static readonly Guid TasSticker = new Guid("FCB9B0F7-6A20-404E-A34D-5D57CC660CE3");
        public static readonly Guid DiginsKeychainZP = new Guid("0CBD0130-7B02-4B60-8F13-C4154CB25284");
        public static readonly Guid DiginsStickerZP = new Guid("4A68AD18-E8DE-4BE1-AE84-A9DC8031A45E");
        public static readonly Guid DiginsStickerZPL = new Guid("6675C44B-8B79-4226-BBFD-1105C7D1DEE0");
        public static readonly Guid DiginsKeychainZLV = new Guid("6EEF5F00-5C87-4D66-9E53-2222A4BC057D");
        public static readonly Guid DiginsStickerZLV = new Guid("4E9C5ABF-07A4-43C2-B081-33C44AE96408");

        public static readonly Guid OrantaDTBlank = new Guid("B3D4BEB0-F75C-48B2-8A21-5166605B5E2C");
        public static readonly Guid OrantaUniversal7 = new Guid("9BB3E953-5665-449C-9445-E183B521278A");

        public static readonly Guid[] OrantaSticker = new Guid[]
        {
            new Guid("8D3EC969-71D5-4BFB-9269-66175914760F"),
            new Guid("03F70EF4-D2D3-46A7-8F17-BF444342FC3C"),
            new Guid("6059470D-DFB1-42C6-BE81-672816550493")
        };
    }
}
