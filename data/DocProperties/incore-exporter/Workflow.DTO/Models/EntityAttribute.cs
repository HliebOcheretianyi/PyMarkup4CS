using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про атрибути об'єктів
    /// </summary>


    [DocumentationContract]
    public partial class EntityAttribute : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {
        public const string RegistrationCode = "RegistrationCode";
        public const string PolicyDirectLink = "PolicyDirectLink";
        public const string ErrorString = "ErrorString";
        public static readonly Guid TemporaryPolicyNumberAttributeGID = new Guid("0E5F2806-4388-4504-9A35-560DDA189234");

        /// <summary>
        /// Значення атрибута, що може бути будь-якого типу залежно від контексту
        /// </summary>

        [DocumentationMember]
        public object Value
        {
            get
            {
                return ValueData.Get();
            }

            set
            {
                ValueData.Set(value);
            }
        }

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


        private string _AttributeName;

        [DocumentationMember]
        public async Task<string> GetAttributeName()
        {
            return _AttributeName;
        }

        private string _AttributeCaption;

        [DocumentationMember]
        public async Task<string> GetAttributeCaption()
        {
            return _AttributeCaption;
        }

        private object _ValueName;

        [DocumentationMember]
        public async Task<object> GetValueName()
        {

            return _ValueName;
        }
    }
}