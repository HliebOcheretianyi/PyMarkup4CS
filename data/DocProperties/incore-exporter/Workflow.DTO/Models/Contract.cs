using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про контракти
    /// </summary>


    [DocumentationContract]
    public partial class Contract : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {

        public Guid ContragentGID { get; set; }

        /// <summary>
        /// Унікальний номер генерального договору, що використовується для його ідентифікації
        /// </summary>


        [DocumentationMember]
        public String ContractNumber { get; set; }


        public Guid BranchGID { get; set; }


        public Guid? ContractTypeGID { get; set; }

        /// <summary>
        /// Дата початку дії генерального договору, з якої він стає чинним
        /// </summary>


        [DocumentationMember]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// Дата завершення дії генерального договору, після якої він втрачає чинність
        /// </summary>


        [DocumentationMember]
        public DateTime? EndDate { get; set; }



        public Decimal? Sum { get; set; }


        public Guid? ResponsibleGID { get; set; }


        public String Comment { get; set; }


        public List<Blank> Blanks { get; set; }


        public int InitialProductsCount { get; set; }


        public List<ContractFile> ContractFiles { get; set; }


        public DateTime? CreateDate { get; set; }


        public Guid? CreatorUserGID { get; set; }


        public DateTime? LastModifiedDate { get; set; }


        public Guid? LastModifiedAuthorGID { get; set; }



        public Guid? WorkflowGID { get; set; }

        /// <summary>
        /// Контрагент за генеральним договором, що є стороною угоди
        /// </summary>


        [DocumentationMember]
        public Signer Contragent { get; set; }

        /// <summary>
        /// Відповідальна особа за генеральним договором, яка підписує його зі сторони страхової компанії
        /// </summary>


        [DocumentationMember]
        public Signer Responsible { get; set; }


        public Guid StatusGID { get; set; }


        public Guid? ParentGID { get; set; }



        public int? ObjectsCount { get; set; }



        public Guid? OwnerGID { get; set; }



        public bool? IsUnrestrictedTerm { get; set; }
        public string ContragentName { get; set; }



    }
}