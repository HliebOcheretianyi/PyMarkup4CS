using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про агентів
    /// </summary>
    [DocumentationContract]
    public class Agent : Face
    {
        public Guid? PrimaryBranchGID { get; set; }

        /// <summary>
        /// Перелік агентських каналів, до яких належить агент
        /// </summary>
        [DocumentationMember]
        public List<AgentChannel> AgentChannels { get; set; }

        /// <summary>
        /// Унікальний код, що використовується для ідентифікації агента в системі
        /// </summary>
        [DocumentationMember]
        public string Code { get; set; }


        private string _PrimaryBranchName;

        [DocumentationMember]
        public async Task<string> GetPrimaryBranchName()
        {
            return _PrimaryBranchName;
        }

        private string _PrimaryBranchCode;

        [DocumentationMember]
        public async Task<string> GetPrimaryBranchCode()
        {
            return _PrimaryBranchCode;
        }
    }
}