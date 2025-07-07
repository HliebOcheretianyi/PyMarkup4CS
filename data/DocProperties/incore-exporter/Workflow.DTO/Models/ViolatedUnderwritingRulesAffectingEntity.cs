namespace Workflow.DTO.Models
{


    public partial class ViolatedUnderwritingRulesAffectingEntity : Workflow.DTO.Models.IdentityPersistentEntity
    {

        public Guid ViolatingUnderwritingRuleGID { get; set; }


        public Guid DependentEntityTypeGID { get; set; }


        public Guid? DependentEntityGID { get; set; }


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
    }
}