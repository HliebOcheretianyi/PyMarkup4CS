namespace Workflow.DTO.Models
{


    public partial class ContractApplicationStatusChangeParameterValue : Workflow.DTO.Models.IdentityPersistentEntity
    {

        public Guid ContractApplicationStatusChangeGID { get; set; }


        public Guid ContractApplicationStatusParameterGID { get; set; }


        public object ContractApplicationStatusParameterValue
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