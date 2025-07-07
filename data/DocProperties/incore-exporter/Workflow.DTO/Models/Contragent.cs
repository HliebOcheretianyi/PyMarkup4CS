namespace Workflow.DTO.Models
{


    public class Contragent
    {
        #region ProtoMember

        public int id { get; set; }


        public Guid gid { get; set; }


        public Guid AgentGID { get; set; }


        public Guid ContragentGID { get; set; }


        public Guid CommissionTypeGID { get; set; }



        public bool IsPrimary { get; set; }


        public bool Deleted { get; set; }


        public Guid? AuthorGID { get; set; }

        #endregion

    }
}