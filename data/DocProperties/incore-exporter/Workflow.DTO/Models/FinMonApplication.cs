namespace Workflow.DTO.Models
{



    public class FinMonApplication : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public string ExternalClientID { get; set; }



        public long TypeID { get; set; }



        public long StatusID { get; set; }



        public DateTime CreateDate { get; set; }



        public string CreateAuthorName { get; set; }



        public DateTime LastModifiedDate { get; set; }



        public string LastModifiedAuthorName { get; set; }



        public Guid WorkflowGID { get; set; }



        public DateTime ExpireDate { get; set; }



        public int Hash { get; set; }



        public string Name { get; set; }



        public DateTime? BirthDate { get; set; }



        public string IdentCodeEDRPOU { get; set; }

        private bool _Processed { get; set; }


        public bool Processed
        {
            get { return _Processed; }
            set
            {
                _Processed = value;

                if (ProcessedDate == null && _Processed)
                {
                    ProcessedDate = DateTime.Now;
                }
            }
        }



        public bool? IsPEP { get; set; }



        public bool? IsSanction { get; set; }



        public long? RiskGroupID { get; set; }



        public int? ExternalClientHash { get; set; }



        public List<FinMonApplicationProcess> FinMonApplicationProcesses { get; set; }



        public long? CategoryPEPID { get; set; }



        public string JobPEP { get; set; }



        public DateTime? DatePEP { get; set; }



        public bool? IsFinMonSuspicion { get; set; }


        public long? ClientCategoryPEPID { get; set; }



        public string ProcessedUserName { get; set; }



        public bool? IsRussian { get; set; }



        public bool? IsBilorussian { get; set; }



        public string Comment { get; set; }



        public bool? IsKBVSanction { get; set; }



        public string SerializedFounders { get; set; }



        public string ReasonDescription { get; set; }



        public bool? IsNoProfit { get; set; }



        public DateTime? DateEndPEP { get; set; }



        public DateTime? ProcessedDate { get; set; }
    }
}
