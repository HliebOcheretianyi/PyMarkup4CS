using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про агентські канали
    /// </summary>


    [DocumentationContract]
    public class AgentChannel : Workflow.DTO.Models.IdentityPersistentEntity
    {
        /// <summary>
        /// Унікальний код агентського каналу
        /// </summary>

        [DocumentationMember]
        public string Code { get; set; }

        /// <summary>
        /// Повна назва агентського каналу
        /// </summary>


        [DocumentationMember]
        public string Name { get; set; }

    }
}