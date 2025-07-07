using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про вантаж
    /// </summary>


    [DocumentationContract]
    public partial class Cargo : Object
    {
        /// <summary>
        /// Назва вантажу, що використовується для його ідентифікації
        /// </summary>


        [DocumentationMember]
        public String Name { get; set; }

        /// <summary>
        /// Об'єм вантажу, виражений у відповідних одиницях виміру
        /// </summary>


        [DocumentationMember]
        public String Valume { get; set; }



        public Boolean? IsPacked { get; set; }

        /// <summary>
        /// Назва пакування вантажу, що описує його упаковку або контейнер
        /// </summary>


        [DocumentationMember]
        public String PackName { get; set; }


        public Guid? TransportationVehicleGID { get; set; }

        /// <summary>
        /// Назва транспортного засобу, що перевозить вантаж
        /// </summary>


        [DocumentationMember]
        public String TransportationVehicleName { get; set; }

        /// <summary>
        /// Дата відправлення вантажу з місця відправлення
        /// </summary>


        [DocumentationMember]
        public DateTime? SendDate { get; set; }

        /// <summary>
        /// Дата отримання вантажу на місці призначення
        /// </summary>


        [DocumentationMember]
        public DateTime? ReceiveDate { get; set; }

        /// <summary>
        /// Глобальний унікальний ідентифікатор власника
        /// </summary>

        [DocumentationMember]
        public Guid? OwnerGID { get; set; }

        /// <summary>
        /// Документ, що супроводжує вантаж під час перевезення
        /// </summary>


        [DocumentationMember]
        public String TransportDocument { get; set; }



        public String TransportationRoute { get; set; }



        public Decimal? UnitCost { get; set; }

        /// <summary>
        /// Кількість місць вантажу, що описує кількість окремих пакунків або одиниць
        /// </summary>


        [DocumentationMember]
        public Int32? SeatsNumber { get; set; }

        /// <summary>
        /// Вартість вантажу
        /// </summary>


        [DocumentationMember]
        public Decimal? Cost { get; set; }


        public Face Owner { get; set; }



        public string OwnerName { get; set; }

    }
}