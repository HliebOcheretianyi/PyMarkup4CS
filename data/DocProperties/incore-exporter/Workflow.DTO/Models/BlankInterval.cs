using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про інтервали бланків
    /// </summary>


    [DocumentationContract]
    public partial class BlankInterval : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        /// <summary>
        /// Серія бланків в інтервалі
        /// </summary>


        [DocumentationMember]
        public string Seria { get; set; }

        /// <summary>
        /// Початковий номер бланка в інтервалі
        /// </summary>


        [DocumentationMember]
        public long StartNumber { get; set; }

        /// <summary>
        /// Кінцевий номер бланка в інтервалі
        /// </summary>


        [DocumentationMember]
        public long EndNumber { get; set; }



        public Guid TypeGID { get; set; }



        public Guid StatusGID { get; set; }



        public Guid? BranchGID { get; set; }



        public Guid? AgentGID { get; set; }

        #region Cache Details

        private string _BlankTypeName;

        [DocumentationMember]
        public async Task<string> GetBlankTypeName()
        {
            return _BlankTypeName;
        }

        private int? _BlankTypeNumberCount;

        [DocumentationMember]
        public async Task<int?> GetBlankTypeNumberCount()
        {
            return _BlankTypeNumberCount;
        }

        #endregion
    }
}