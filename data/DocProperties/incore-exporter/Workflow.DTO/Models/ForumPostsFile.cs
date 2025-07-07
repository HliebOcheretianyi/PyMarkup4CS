namespace Workflow.DTO.Models
{



    public class ForumPostsFile : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {



        public Guid FileGID { get; set; }




        public string Name { get; set; }




        public Guid ForumPostGID { get; set; }




        public string AuthorName { get; set; }
    }
}
