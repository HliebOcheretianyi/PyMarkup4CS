namespace Workflow.DTO.Models
{


    public class FinMonApplicationProcess : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public long FinMonApplicationID { get; set; }


        public long ProcessID { get; set; }


        public List<InformationProviderResult> ProvidersResults { get; set; }


        public DateTime CreateDate { get; set; }


        public FinMonProcess Process { get; set; }
    }
}
