namespace Workflow.DTO.Models
{


    public class ContractApplication : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {

        public Guid ContragentGID { get; set; }



        public String ContractNumber { get; set; }


        public Guid BranchGID { get; set; }


        public Guid? ContractTypeGID { get; set; }



        public DateTime? BeginDate { get; set; }



        public DateTime? EndDate { get; set; }



        public Decimal? Sum { get; set; }


        public Guid? ResponsibleGID { get; set; }


        public String Comment { get; set; }


        public List<Blank> Blanks { get; set; }


        public int InitialProductsCount { get; set; }


        public List<ContractFile> ContractApplicationFiles { get; set; }



        public DateTime? CreateDate { get; set; }



        public Guid? CreatorUserGID { get; set; }


        public DateTime? LastModifiedDate { get; set; }


        public Guid? LastModifiedAuthorGID { get; set; }



        public Guid? WorkflowGID { get; set; }



        public Signer Contragent { get; set; }



        public Signer Responsible { get; set; }


        public Guid StatusGID { get; set; }


        public Guid? ParentGID { get; set; }



        public int? ObjectsCount { get; set; }



        public Guid? OwnerGID { get; set; }


        public Guid? ForumTopicGID { get; set; }



        public List<ContractApplicationProductData> ProductDatas { get; set; }



        public List<ForumPost> ForumPosts { get; set; }


        public Guid? ContractGID { get; set; }


        public DateTime RegisteredDate { get; set; }


        public Guid? SalesChannelGID { get; set; }


        public Guid? SubSalesChannelGID { get; set; }


        public Guid? AgentPermissionGID { get; set; }


        public Guid ContragentFaceGID { get; set; }


        public string ContragentFaceName { get; set; }


        public long ContragentFacePersonTypeID { get; set; }



        public Guid? UnderwriterGID { get; set; }



        public DateTime? UnderwritingDate { get; set; }



        public List<ContractApplicationStatusChange> ContractApplicationStatusChanges { get; set; }



        public bool? IsUnrestrictedTerm { get; set; }

    }
}