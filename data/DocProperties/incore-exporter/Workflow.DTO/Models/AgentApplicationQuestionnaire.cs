using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Виводить на друк анкету фінансового моніторингу, яка містить інформацію про агента на якого створено запит на включення до штату.
    /// </summary>


    [DocumentationContract]
    public class AgentApplicationQuestionnaire : IdentityPersistentEntity
    {
        /// <summary>
        /// Дата, коли анкета була створена.
        /// </summary>


        [DocumentationMember]
        public DateTime CreateDate { get; set; }


        /// <summary>
        /// Дата, коли анкета була останній раз відредагована.
        /// </summary>


        [DocumentationMember]
        public DateTime LastModifiedDate { get; set; }



        [DocumentationMember]
        public Guid? FileGID { get; set; }



        [DocumentationMember]
        public string FileName { get; set; }

        /// <summary>
        /// Колекція параметрів, пов'язаних з цією анкетою.
        /// </summary>


        [DocumentationMember]
        public List<AgentApplicationQuestionnaireParameter> Parameters { get; set; }
    }
}
