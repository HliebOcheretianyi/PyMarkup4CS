using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про об'єкти
    /// </summary>

    [DocumentationContract]
    public partial class Object : Workflow.DTO.Models.IdentityPersistentEntity
    {

        public Guid? CountryGID { get; set; }

        /// <summary>
        /// Список документів, пов'язаних з об'єктом
        /// </summary>


        [DocumentationMember]
        public List<Document> Documents { get; set; }


        /// <summary>
        /// Атрибути об'єкта, що описують його характеристики та властивості
        /// </summary>
        [DocumentationMember]
        public List<EntityAttribute> EntityAttributes { get; set; }

        public Guid? CitizenshipCountryGID { get; set; }

        /// <summary>
        /// Додаткові коментарі або примітки до об'єкта
        /// </summary>
        [DocumentationMember]
        public String Comment { get; set; }

        private string _CountryName;

        [DocumentationMember]
        public async Task<string> GetCountryName()
        {
            return _CountryName;
        }

        private string _CitizenshipCountryName;

        [DocumentationMember]
        public async Task<string> GetCitizenshipCountryName()
        {
            return _CitizenshipCountryName;
        }



        //public string Name { get; set; }
        #region Cache Details
        private string _ObjectTypeName;

        [DocumentationMember]
        public async Task<string> GetObjectTypeName()
        {
            return _ObjectTypeName;
        }


        #endregion


    }
}