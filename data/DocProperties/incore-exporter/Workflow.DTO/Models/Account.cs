using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про банківський рахунок
    /// </summary>

    [DocumentationContract]
    public partial class Account : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        public Guid TypeGID { get; set; }

        /// <summary>
        /// Унікальний ідентифікаційний номер банківського рахунку, що призначений для ідентифікації рахунку клієнта в банківській системі
        /// </summary>
        [DocumentationMember]
        public String AccountNumber { get; set; }

        /// <summary>
        /// Міжнародний фінансовий код банку (МФО), який використовується для ідентифікації банку, що обслуговує рахунок
        /// </summary>
        [DocumentationMember]
        public string BankMFO { get; set; }

        /// <summary>
        /// Назва банківської установи, в якій відкрито рахунок клієнта
        /// </summary>
        [DocumentationMember]
        public string BankName { get; set; }
        private string _AccountTypeName;

        [DocumentationMember]
        public async Task<string> GetAccountTypeName()
        {
            return _AccountTypeName;
        }
    }
}