namespace Workflow.DTO.Models
{


    public partial class FranchiseParameter : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {

        public Guid FranchiseGID { get; set; }


        public Guid FranchiseTypeParameterGID { get; set; }


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