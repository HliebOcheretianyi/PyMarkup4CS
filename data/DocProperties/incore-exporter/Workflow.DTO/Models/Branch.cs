using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про відділення
    /// </summary>


    [DocumentationContract]
    public class Branch : Workflow.DTO.Models.IdentityPersistentEntity
    {

        /// <summary>
        /// Назва відділення, що використовується для ідентифікації конкретного підрозділу
        /// </summary>

        [DocumentationMember]
        public string Name { get; set; }

        /// <summary>
        /// Код відділення, що використовується для ідентифікації конкретного підрозділу
        /// </summary>

        [DocumentationMember]
        public string BranchCode { get; set; }

        /// <summary>
        /// Унікальний ідентифікатор сутності юридичної особи, яка представляє собою поточний підрозділ
        /// </summary>
        [DocumentationMember]

        public Guid? OrganizationGID { get; set; }

    }
}