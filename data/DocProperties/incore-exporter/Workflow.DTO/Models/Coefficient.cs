using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про коефіцієнти
    /// </summary>


    [DocumentationContract]
    public partial class Coefficient : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {

        public Guid? ProgramGID { get; set; }

        /// <summary>
        /// Значення коефіцієнта, що визначає його величину
        /// </summary>


        [DocumentationMember]
        public Decimal Value { get; set; }


        public Guid? ProgramCoefficientGID { get; set; }


        public Guid? InsuranceObjectGID { get; set; }


        public bool IsFixed { get; set; }



        public Decimal? CalculatedValue { get; set; }

        private int? _CoefficientNumber;

        [DocumentationMember]
        public async Task<int?> GetCoefficientNumber()
        {
            return _CoefficientNumber;
        }

        private string _CoefficientName;

        [DocumentationMember]
        public async Task<string> GetCoefficientName()
        {
            return _CoefficientName;
        }

        private string _CoefficientCode;


        [DocumentationMember]
        public async Task<string> GetCoefficientCode()
        {
            return _CoefficientCode;
        }
    }
}