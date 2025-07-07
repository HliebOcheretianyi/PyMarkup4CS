using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про банки
    /// </summary>


    [DocumentationContract]
    public partial class Bank : Face
    {
        /// <summary>
        /// Міжнародний фінансовий код банку (МФО), використовується для ідентифікації банку у фінансових транзакціях
        /// </summary>


        [DocumentationMember]
        public String MFO { get; set; }
    }
}