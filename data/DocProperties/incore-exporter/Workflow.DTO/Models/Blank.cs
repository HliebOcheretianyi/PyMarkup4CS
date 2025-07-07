using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про бланки
    /// </summary>


    [DocumentationContract]
    public partial class Blank : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        #region ProtoMember
        /// <summary>
        /// Унікальний номер бланка, що використовується для його ідентифікації
        /// </summary>


        [DocumentationMember]
        public String Number { get; set; }


        public Guid? BranchGID { get; set; }


        public Guid? AgentGID { get; set; }


        public Guid TypeGID { get; set; }


        public Guid StatusGID { get; set; }


        public bool IsPrimary { get; set; }

        #endregion
        #region Cache Details
        private string _BlankStatusName;

        public async Task<string> GetBlankStatusName()
        {
            return _BlankStatusName;
        }

        private string _BlankStatusCaption;

        public async Task<string> GetBlankStatusCaption()
        {
            return _BlankStatusCaption;
        }

        private string _BlankTypeName;

        [DocumentationMember]
        public async Task<string> GetBlankTypeName()
        {
            return _BlankTypeName;
        }

        #endregion
    }
}