namespace Workflow.DTO.Models
{


    public class FinMonApplicationStatusChange : Workflow.DTO.Models.IdentityPersistentEntity
    {


        public long FinMonApplicationID { get; set; }



        public long StatusID { get; set; }



        public string AuthorName { get; set; }



        public DateTime Date { get; set; }



        public string StatusName { get; set; }



        public List<FinMonStatusChangeParameterValue> ParameterValues { get; set; }
    }
}
