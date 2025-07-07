
using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про транспортні засоби
    /// </summary>


    [DocumentationContract]
    public partial class Vehicle : Object
    {
        #region ProtoMember

        public Guid ModelGID { get; set; }


        public Guid ManufacturerGID { get; set; }


        public Guid? ColorGID { get; set; }


        public Guid? ColorTypeGID { get; set; }

        /// <summary>
        /// Глобальний унікальний ідентифікатор власника
        /// </summary>

        [DocumentationMember]
        public Guid? OwnerGID { get; set; }

        /// <summary>
        /// Номер кузова транспортного засобу
        /// </summary>


        [DocumentationMember]
        public String BodyNumber { get; set; }

        /// <summary>
        /// Реєстраційний номер транспортного засобу
        /// </summary>


        [DocumentationMember]
        public String RegistrationNumber { get; set; }

        /// <summary>
        /// Дата виготовлення транспортного засобу
        /// </summary>


        [DocumentationMember]
        public Int32? ProducedDate { get; set; }



        public String RegistrationCertificate { get; set; }

        /// <summary>
        /// Дата реєстрації транспортного засобу
        /// </summary>


        [DocumentationMember]
        public DateTime? RegistrationDate { get; set; }

        /// <summary>
        /// Вартість транспортного засобу
        /// </summary>


        [DocumentationMember]
        public Decimal? Cost { get; set; }

        /// <summary>
        /// Кількість місць у транспортному засобі
        /// </summary>


        [DocumentationMember]
        public Int32? NumberOfSeats { get; set; }

        /// <summary>
        /// Антикрадіжний пристрій, встановлений на транспортному засобі
        /// </summary>


        [DocumentationMember]
        public String AnticreepDevice { get; set; }

        /// <summary>
        /// Додаткове обладнання, встановлене на транспортному засобі
        /// </summary>


        [DocumentationMember]
        public String AdditionalEquipment { get; set; }



        public String AuthorizedToManage { get; set; }



        public String SpecialConditions { get; set; }

        /// <summary>
        /// Місце реєстрації транспортного засобу
        /// </summary>


        [DocumentationMember]
        public String RegistrationPlace { get; set; }

        /// <summary>
        /// Пробіг транспортного засобу
        /// </summary>


        [DocumentationMember]
        public Decimal? Mileage { get; set; }

        /// <summary>
        /// Місткість транспортного засобу
        /// </summary>


        [DocumentationMember]
        public Decimal? Capacity { get; set; }

        /// <summary>
        /// Технічна модель транспортного засобу за документами
        /// </summary>


        [DocumentationMember]
        public String TechDocModel { get; set; }


        public Guid? SettlementGID { get; set; }


        public Guid? BodyTypeGID { get; set; }


        public Guid? EngineTypeGID { get; set; }


        public Guid? TransmissionTypeGID { get; set; }



        public Face Owner { get; set; }

        /// <summary>
        /// Ім'я або назва власника транспортного засобу
        /// </summary>


        [DocumentationMember]
        public string OwnerName { get; set; }

        /// <summary>
        /// Об'єкт населеного пункту, пов'язаний з транспортним засобом
        /// </summary>


        [DocumentationMember]
        public Settlement SettlementObject { get; set; }



        public Guid? TypeGID { get; set; }



        public String EngineNumber { get; set; }



        public String ChasisNumber { get; set; }


        public string OwnerIdentificationCodeEDRPOU { get; set; }

        /// <summary>
        /// Адреса, пов'язана з транспортним засобом
        /// </summary>


        [DocumentationMember]
        public String Address { get; set; }


        public Guid? PostAddressGID { get; set; }

        /// <summary>
        /// Поштова адреса, пов'язана з транспортним засобом
        /// </summary>


        [DocumentationMember]
        public PostAddress PostAddressObject { get; set; }

        /// <summary>
        /// Повна маса, кг
        /// </summary>


        [DocumentationMember]
        public decimal? MaxWeight { get; set; }

        /// <summary>
        /// Маса без навантаження, кг
        /// </summary>


        [DocumentationMember]
        public decimal? UnladenWeight { get; set; }

        /// <summary>
        /// Потужність, кВт
        /// </summary>


        [DocumentationMember]
        public decimal? EngineKw { get; set; }

        /// <summary>
        /// Походження з Америки?
        /// </summary>


        [DocumentationMember]
        public bool? IsUSAOrigin { get; set; }

        /// <summary>
        /// Тип гібриду
        /// </summary>


        [DocumentationMember]
        public Guid? HybridTypeGID { get; set; }

        /// <summary>
        /// Тип приводу
        /// </summary>


        [DocumentationMember]
        public Guid? DriveTypeGID { get; set; }

        /// <summary>
        /// Ємність батараеї
        /// </summary>


        [DocumentationMember]
        public decimal? BatteryCapacity { get; set; }

        #endregion
        public string SettlementValue { get; set; }

        private string _VehicleBodyTypeName;

        [DocumentationMember]
        public async Task<string> GetVehicleBodyTypeName()
        {
            return _VehicleBodyTypeName;
        }

        private string _VehicleBodyTypeCaption;

        public async Task<string> GetVehicleBodyTypeCaption()
        {
            return _VehicleBodyTypeCaption;
        }

        private string _VehicleEngineTypeName;

        [DocumentationMember]
        public async Task<string> GetVehicleEngineTypeName()
        {
            return _VehicleEngineTypeName;
        }

        private string _VehicleManufacturerName;

        [DocumentationMember]
        public async Task<string> GetVehicleManufacturerName()
        {
            return _VehicleManufacturerName;
        }

        private string _VehicleModelName;

        [DocumentationMember]
        public async Task<string> GetVehicleModelName()
        {
            return _VehicleModelName;
        }
        private string _VehicleTypeName;

        [DocumentationMember]
        public async Task<string> GetVehicleTypeName()
        {
            return _VehicleTypeName;
        }


        private string _ColorTypeName;

        [DocumentationMember]
        public async Task<string> GetColorTypeName()
        {
            return _ColorTypeName;
        }
    }
}