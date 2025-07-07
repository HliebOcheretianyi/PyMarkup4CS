using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про поштові адреси
    /// </summary>


    [DocumentationContract]
    public partial class PostAddress : Workflow.DTO.Models.IdentityPersistentEntity
    {
        /// <summary>
        /// Поштовий індекс в адресі
        /// </summary>


        [DocumentationMember]
        public String PostCode { get; set; }


        public Guid? SettlementGID { get; set; }

        /// <summary>
        /// Назва вулиці в поштовій адресі
        /// </summary>


        [DocumentationMember]
        public String Street { get; set; }

        /// <summary>
        /// Номер будинку в поштовій адресі
        /// </summary>


        [DocumentationMember]
        public String House { get; set; }

        /// <summary>
        /// Номер квартири в поштовій адресі
        /// </summary>


        [DocumentationMember]
        public String Flat { get; set; }


        public Guid? StreetTypeGID { get; set; }


        private string _FullSettlementName;


        [DocumentationMember]
        public async Task<string> GetFullSettlementName()
        {
            return _FullSettlementName;
        }

        private string _RegionName;

        [DocumentationMember]
        public async Task<string> GetRegionName()
        {
            return _RegionName;
        }

        private string _ParentRegionName;

        [DocumentationMember]
        public async Task<string> GetParentRegionName()
        {
            return _ParentRegionName;
        }


        private string _StreetTypeName;

        [DocumentationMember]
        public async Task<string> GetStreetTypeName()
        {

            return _StreetTypeName;
        }


        private string _FullAddress;
        [DocumentationMember]
        public async Task<string> GetFullAddress()
        {
            return _FullAddress;
        }

        private string _SettlementName;

        [DocumentationMember]
        public async Task<string> GetSettlementName()
        {
            return _SettlementName;
        }


    }
}