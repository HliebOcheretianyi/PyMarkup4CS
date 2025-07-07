using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про франшизи
    /// </summary>


    [DocumentationContract]
    public partial class Franchise : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        private ObjectData _ValueData;

        public Workflow.DTO.Models.ObjectData ValueData
        {
            get
            {
                if (_ValueData == null)
                {
                    _ValueData = new ObjectData();
                }

                return _ValueData;
            }

            set
            {
                _ValueData = value;
            }
        }

        /// <summary>
        /// Умови франшизи, що визначають її дію
        /// </summary>


        [DocumentationMember]
        public Int32 Conditional { get; set; }

        private object _FranchiseValueCaption;

        [DocumentationMember]
        public async Task<object> GetFranchiseValueCaption()
        {
            return _FranchiseValueCaption;
        }

        private string _FranchiseTypeName;

        [DocumentationMember]
        public async Task<string> GetFranchiseTypeName()
        {
            return _FranchiseTypeName;
        }

        private string _CurrencyAbbr;

        [DocumentationMember]
        public async Task<string> GetCurrencyAbbr()
        {

            return _CurrencyAbbr;
        }
    }
}