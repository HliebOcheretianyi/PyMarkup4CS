using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про заявки агентів
    /// </summary>

    [DocumentationContract]
    public class AgentApplication
    {
        /// <summary>
        /// Агент, пов'язаний із заявкою
        /// </summary>
        [DocumentationMember]
        public Face Agent { get; set; }

        /// <summary>
        /// Статус авторизації заявки
        /// </summary>
        [DocumentationMember]
        public Face Authorized { get; set; }


        [DocumentationMember]
        public List<AgentChannel> AgentChannels { get; set; }


        [DocumentationMember]
        public string Code { get; set; }
    }
}