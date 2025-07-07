using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.DTO.Models
{
    public class ParticipantType
    {
        public static readonly Guid Victim = new Guid("45553847-9E15-44FF-A510-63E9B16A3CAC");
        public static readonly Guid DriverOfInsuredVehicle = new Guid("B5465024-5E93-4E1A-B865-65F7D445CA3F");
        public static readonly Guid VehicleOfAnotherParticipant = new Guid("6C42F048-C05E-4341-A41E-7C31D9BB5071");
        public static readonly Guid Responsible = new Guid("0D0B23FB-D70C-4F41-9E54-A1F24DFBE043");
        public static readonly Guid Guilty = new Guid("93AF8654-4791-471A-92AF-B1EA91F120EB");
        public static readonly Guid DriverOfAnotherParticipant = new Guid("A5D76FFA-81D3-4876-87FA-B4CEF7DF620B");
        public static readonly Guid Bystander = new Guid("E1AF318A-1EC7-4CEE-BC46-E3EF381A961C");
        public static readonly Guid Expert = new Guid("E278CC57-2641-4D6A-9031-81924A119379");
        public static readonly Guid Beneficiar = new Guid("133b1973-3a6a-4572-a0e9-beae4291bd2e");
        public static readonly Guid Commissar = new Guid("2FC4AC98-B747-46BD-8605-075DBB43692F");
    }
}
