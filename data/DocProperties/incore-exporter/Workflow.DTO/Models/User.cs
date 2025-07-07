
using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про користувачів
    /// </summary>


    [DocumentationContract]
    public class User : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public string UserName { get; set; }



        public string Email { get; set; }

        /// <summary>
        /// Прізвище користувача
        /// </summary>


        [DocumentationMember]
        public string LastName { get; set; }



        public string FirstName { get; set; }



        public string SecondName { get; set; }



        public Guid? BranchGID { get; set; }



        public Guid? PersonGID { get; set; }



        public string Password { get; set; }



        public DateTime? StartDate { get; set; }



        public DateTime? EndDate { get; set; }



        public Guid? WorkflowGID { get; set; }


        public string FullNameEnglish { get; set; }


        public Role[] UserRoles { get; set; }


        public Permission[] Permissions { get; set; }



        public bool IsValidateNeeded { get; set; }



        public bool IsDomainUser { get; set; }



        public bool IsPasswordChangeNeeded { get; set; }



        public int FailCounter { get; set; }



        public bool IsLocked { get; set; }



        public bool IsTestNeeded { get; set; }



        public bool TwoFactorEnabled { get; set; }



        public bool TwoFactorVerified { get; set; }



        public DateTime? NextPasswordChangeDate { get; set; }


        public string Roles { get; set; }

        /// <summary>
        /// Ідентифікатор автора користувача
        /// </summary>


        [DocumentationMember]
        public Guid? CreatorUserGID { get; set; }

    }
}