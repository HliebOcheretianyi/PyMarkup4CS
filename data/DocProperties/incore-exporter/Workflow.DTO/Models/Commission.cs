using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про комісії
    /// </summary>





    [DocumentationContract]
    public partial class Commission : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {

        /// <summary>
        /// Назва агента комісії, що використовується для ідентифікації агента
        /// </summary>


        [DocumentationMember]
        public string AgentName { get; set; }

        /// <summary>
        /// Агент комісії, відповідальний за виконання певних дій або процесів у межах комісії
        /// </summary>


        [DocumentationMember]
        public Face Agent { get; set; }



        public DateTime? DateTo { get; set; }

        private string _CommissionTypeName;


        [DocumentationMember]
        public async Task<string> GetCommissionTypeName()
        {
            return _CommissionTypeName;
        }
    }
}