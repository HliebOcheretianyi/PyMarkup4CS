using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Виводить на друк параметр, який може бути використаний для заповнення анкети
    /// </summary>


    [DocumentationContract]
    public class AgentApplicationQuestionnaireParameter : IdentityPersistentEntity
    {

        public Guid AgentApplicationQuestionnaireGID { get; set; }


        public Guid ParameterGID { get; set; }


        public object ParameterValue
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

        public ObjectData ValueData
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
    }
}
