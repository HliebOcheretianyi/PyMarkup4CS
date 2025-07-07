using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про порушені правила андерайтингу
    /// </summary>


    [DocumentationContract]
    public partial class ViolatedUnderwritingRule : Workflow.DTO.Models.IdentityPersistentEntity
    {

        public Guid UnderwritingRuleGID { get; set; }


        public Guid? ObjectTypeGID { get; set; }


        public Guid? ObjectGID { get; set; }



        public String Name { get; set; }



        public DateTime? UnderwritingDate { get; set; }


        public Guid? UnderwriterGID { get; set; }


        public Guid PermissionGID { get; set; }


        public List<ViolatedUnderwritingRulesAffectingEntity> ViolatedUnderwritingRulesAffectingEntities { get; set; }


        public Guid ProgramViolatedUnderwritingRuleGID { get; set; }


        public bool IsActive { get; set; }


        public string UnderwriterName { get; set; }


        public Guid ProgramGID { get; set; }

        #region Cache Details
        private string _UnderwritingRuleName;

        [DocumentationMember]
        public async Task<string> GetUnderwritingRuleName()
        {
            return _UnderwritingRuleName;
        }

        private bool? _IsInformation;

        [DocumentationMember]
        public async Task<bool> GetIsInformation()
        {
            return _IsInformation.Value;
        }

        #endregion

    }
}