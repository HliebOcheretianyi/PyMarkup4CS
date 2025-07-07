using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про документи
    /// </summary>


    [DocumentationContract]
    public partial class Document : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        public Guid? DocumentTypeGID { get; set; }

        /// <summary>
        /// Номер документа, що використовується для його ідентифікації
        /// </summary>


        [DocumentationMember]
        public String Number { get; set; }

        /// <summary>
        /// Дата початку дії документа
        /// </summary>


        [DocumentationMember]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Дата завершення дії документа або терміну його чинності
        /// </summary>


        [DocumentationMember]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Дата видачі документа
        /// </summary>


        [DocumentationMember]
        public DateTime? IssuedDate { get; set; }

        /// <summary>
        /// Назва організації або особи, що видала документ
        /// </summary>


        [DocumentationMember]
        public String IssuedBy { get; set; }

        /// <summary>
        /// Вказує, чи є документ активним (дійсним)
        /// </summary>


        [DocumentationMember]
        public bool IsActive { get; set; }

        private string _DocumentTypeName;

        [DocumentationMember]
        public async Task<string> GetDocumentTypeName()
        {
            return _DocumentTypeName;
        }

    }
}