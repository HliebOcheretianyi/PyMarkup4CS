
using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про нерухомість
    /// </summary>


    [DocumentationContract]
    public partial class Estate : Object
    {
        /// <summary>
        /// Назва нерухомості, яка використовується для її ідентифікації
        /// </summary>


        [DocumentationMember]
        public String Name { get; set; }

        /// <summary>
        /// Глобальний унікальний ідентифікатор власника
        /// </summary>

        [DocumentationMember]
        public Guid? OwnerGID { get; set; }

        /// <summary>
        /// Адреса нерухомості, включаючи вулицю, місто, штат/область та поштовий індекс
        /// </summary>


        [DocumentationMember]
        public String Address { get; set; }

        /// <summary>
        /// Вартість нерухомості, виражена у відповідній валюті
        /// </summary>


        [DocumentationMember]
        public Decimal? Cost { get; set; }

        /// <summary>
        /// Причина набуття нерухомості (наприклад, покупка, спадщина, дарування)
        /// </summary>


        [DocumentationMember]
        public String AcquisitionReason { get; set; }

        /// <summary>
        /// Поштова адреса, пов'язана з нерухомістю, що включає всі необхідні контактні дані
        /// </summary>


        [DocumentationMember]
        public PostAddress PostAddressObject { get; set; }

        /// <summary>
        /// Ім'я або назва власника нерухомості
        /// </summary>


        [DocumentationMember]
        public string OwnerName { get; set; }


    }
}