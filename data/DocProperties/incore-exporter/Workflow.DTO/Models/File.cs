namespace Workflow.DTO.Models
{



    public class File : Workflow.DTO.Models.IdentityPersistentEntity
    {



        public string Name { get; set; }




        public bool IsImage { get; set; }




        public int? Width { get; set; }




        public int? Height { get; set; }




        public DateTime CreationDate { get; set; }




        public byte[] Value { get; set; }




        public Guid? ParentGID { get; set; }




        public bool success { get; set; }


        public List<FileTag> FileInfo { get; set; }
    }
}
