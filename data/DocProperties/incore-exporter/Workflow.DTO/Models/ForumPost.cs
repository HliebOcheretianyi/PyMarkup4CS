namespace Workflow.DTO.Models
{



    public class ForumPost : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {



        public string Text { get; set; }




        public DateTime CreatedDate { get; set; }




        public Guid TopicGID { get; set; }



        public Guid? ParentGID { get; set; }




        public string AuthorName { get; set; }




        public List<ForumPost> ForumPosts { get; set; }




        public List<ForumPostsFile> ForumPostsFiles { get; set; }
    }
}
