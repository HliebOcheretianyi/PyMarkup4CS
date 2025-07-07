
using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про населені пункти
    /// </summary>


    [DocumentationContract]
    public partial class Settlement : Workflow.DTO.Models.IdentityPersistentEntity
    {
        /// <summary>
        /// Назва населеного пункту
        /// </summary>


        [DocumentationMember]
        public String Name { get; set; }


        public Guid ParentRegionGID { get; set; }


        public Guid RegionGID { get; set; }


        private string _FullSettlementName;


        public String NameLocalized { get; set; }


        public List<RegionType> RegionTypes { get; set; }



        public String Code { get; set; }



        public String RegulatorID { get; set; }



        public bool Active { get; set; }



        public List<SettlementCode> SettlementCodes { get; set; }


        public Guid? KatottgCategoryGID { get; set; }
    }
}