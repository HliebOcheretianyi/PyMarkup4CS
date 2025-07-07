using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про дозволи на продукти
    /// </summary>


    [DocumentationContract]
    public partial class ProductPermission : Workflow.DTO.Models.IdentityPersistentEntity
    {


        public String Number { get; set; }



        public DateTime? Date { get; set; }



        public List<ViolatedUnderwritingRule> ViolatedUnderwritingRules { get; set; }



        public Guid? AgentPermissionGID { get; set; }


        public Guid ProductToProductPermissionGID { get; set; }

        private string _AgentPermissionNumber;

        [DocumentationMember]
        public async Task<string> GetAgentPermissionNumber()
        {
            return _AgentPermissionNumber;
        }

        public void ResetAgentPermissionGID()
        {
            _AgentPermissionNumber = null;
        }
    }
}