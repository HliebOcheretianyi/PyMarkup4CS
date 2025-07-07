namespace Workflow.DTO.Models
{



    public class RelatedCommission : Workflow.DTO.Models.IdentityPersistentEntity
    {

        public string Name { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Comment { get; set; }

        public Guid CreaterUserGID { get; set; }

        public List<CommissionLimit> CommissionLimits { get; set; }
    }
}
