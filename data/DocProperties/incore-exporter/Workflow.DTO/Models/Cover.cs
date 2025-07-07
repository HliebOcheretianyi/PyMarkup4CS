using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про покриття
    /// </summary>


    [DocumentationContract]
    public partial class Cover : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        /// <summary>
        /// Ліміт покриття, що визначає максимальну суму, яку можна отримати за покриття
        /// </summary>


        [DocumentationMember]
        public Decimal? CoverLimit { get; set; }

        /// <summary>
        /// Франшизи покриття, що визначають умови та обмеження покриття
        /// </summary>


        [DocumentationMember]
        public List<Franchise> Franchises { get; set; }

        private string _RiskName;

        [DocumentationMember]
        public async Task<string> GetRiskName()
        {
            return _RiskName;
        }

    }
}