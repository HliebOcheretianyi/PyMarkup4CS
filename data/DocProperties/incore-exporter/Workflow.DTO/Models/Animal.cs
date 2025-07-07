using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про тварин
    /// </summary>


    [DocumentationContract]
    public partial class Animal : Object
    {
        /// <summary>
        /// Ім'я тварини
        /// </summary>


        [DocumentationMember]
        public String Name { get; set; }

        /// <summary>
        /// Вік тварини
        /// </summary>


        [DocumentationMember]
        public String Age { get; set; }

        /// <summary>
        /// Прикмети та ознаки тварини
        /// </summary>


        [DocumentationMember]
        public String SuitAndSigns { get; set; }



        public Decimal? Weight { get; set; }



        public Decimal? Cost { get; set; }



        public String Address { get; set; }

        /// <summary>
        /// Глобальний унікальний ідентифікатор власника
        /// </summary>

        [DocumentationMember]
        public Guid? OwnerGID { get; set; }


        public Guid? PostAddressGID { get; set; }


        public Face Owner { get; set; }

        /// <summary>
        /// Поштова адреса об'єкта, пов'язаного з твариною
        /// </summary>


        [DocumentationMember]
        public PostAddress PostAddressObject { get; set; }

        /// <summary>
        /// Ім'я власника тварини
        /// </summary>


        [DocumentationMember]
        public string OwnerName { get; set; }
    }
}