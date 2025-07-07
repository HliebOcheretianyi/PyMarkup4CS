using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.DTO.Models
{
    
    public class FileTag
    {
        public const string CreateDate = "CreateDate";
        public const string ModifiedDate = "ModifiedDate";
        public const string UploadDate = "UploadDate";
        public const string CameraMaker = "CameraMaker";
        public const string CameraModel = "CameraModel";
        public const string Size = "Size";
        public const string Gps = "Gps";

        
        public string Name { get; set; }

        
        public string Value { get; set; }
    }
}
