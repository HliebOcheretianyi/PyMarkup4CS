namespace Workflow.DTO.Models
{


    public class FinMonStatusChangeParameterValue : Workflow.DTO.Models.IdentityPersistentEntity
    {


        public long StatusChangeID { get; set; }



        public long StatusParameterID { get; set; }



        public string StatusParameterValue { get; set; }



        public string ParameterName { get; set; }
    }
}
