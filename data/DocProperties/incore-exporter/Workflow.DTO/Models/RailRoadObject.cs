using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про залізничні об'єкти
    /// </summary>


    [DocumentationContract]
    public partial class RailRoadObject : Object
    {


        public String Name { get; set; }



        public String SerialNumber { get; set; }

        /// <summary>
        /// Вартість залізничного об'єкта
        /// </summary>


        [DocumentationMember]
        public Decimal? Cost { get; set; }

        /// <summary>
        /// Глобальний унікальний ідентифікатор власника
        /// </summary>

        [DocumentationMember]
        public Guid? OwnerGID { get; set; }



        public Int32? Count { get; set; }


        public Face Owner { get; set; }



        public PostAddress PostAddressObject { get; set; }



        public string OwnerName { get; set; }
    }
}