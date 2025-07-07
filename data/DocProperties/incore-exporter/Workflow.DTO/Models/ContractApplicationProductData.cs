namespace Workflow.DTO.Models
{


    public class ContractApplicationProductData
    {

        public Int64 id { get; set; }


        public Guid gid { get; set; }



        public Guid ProductTypeGID { get; set; }



        public Guid ProgramTypeGID { get; set; }



        public List<ProgramParameterValue> Parameters { get; set; }



        public List<Program> Programs { get; set; }

        public Dictionary<string, object> ProductExtensions
        {
            get
            {
                return ProductExtensionsData.ToDictionary(e => e.Key, e => e.Value.Get());
            }

            set
            {
                if (value != null)
                {
                    ProductExtensionsData = value.ToDictionary(e => e.Key, e => new ObjectData(e.Value));
                }
            }
        }

        private Dictionary<string, ObjectData> _ProductExtensionsData;

        public Dictionary<string, ObjectData> ProductExtensionsData
        {
            get
            {
                if (_ProductExtensionsData == null)
                {
                    _ProductExtensionsData = new Dictionary<string, ObjectData>();
                }

                return _ProductExtensionsData;
            }

            set
            {
                _ProductExtensionsData = value;
            }
        }

    }
}