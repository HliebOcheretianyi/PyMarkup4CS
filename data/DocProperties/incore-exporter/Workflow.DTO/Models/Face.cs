using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про фізичні та юридичні особи
    /// </summary>











    [DocumentationContract]
    public partial class Face : Object
    {
        /// <summary>
        /// Ідентифікатор типу особи (фізична або юридична)
        /// </summary>


        [DocumentationMember]
        public Int64 PersonTypeID { get; set; }

        /// <summary>
        /// Назва або ім'я особи
        /// </summary>


        [DocumentationMember]
        public String Name { get; set; }

        /// <summary>
        /// Повне ім'я особи англійською мовою
        /// </summary>


        [DocumentationMember]
        public String FullNameEnglish { get; set; }

        /// <summary>
        /// Ідентифікаційний код фізичної особи
        /// </summary>


        [DocumentationMember]
        public String IdentificationCode { get; set; }

        /// <summary>
        /// Професія фізичної особи
        /// </summary>


        [DocumentationMember]
        public String Profession { get; set; }

        /// <summary>
        /// Юридична адреса особи, що використовується для офіційних цілей
        /// </summary>


        [DocumentationMember]
        public String Address { get; set; }

        /// <summary>
        /// Фактична адреса проживання або розташування особи
        /// </summary>


        [DocumentationMember]
        public String ActualAddress { get; set; }

        /// <summary>
        /// Номер телефону особи
        /// </summary>


        [DocumentationMember]
        public String PhoneNumber { get; set; }

        /// <summary>
        /// Факсовий номер особи
        /// </summary>


        [DocumentationMember]
        public String Fax { get; set; }



        public String AdditionalContactInfo { get; set; }

        /// <summary>
        /// Адреса електронної пошти особи
        /// </summary>


        [DocumentationMember]
        public String Email { get; set; }


        /// <summary>
        /// Додатковий номер телефону особи
        /// </summary>


        [DocumentationMember]
        public String PhoneNumberAdditional { get; set; }

        /// <summary>
        /// Номер мобільного телефону особи
        /// </summary>


        [DocumentationMember]
        public String MobilePhoneNumber { get; set; }



        /// <summary>
        /// Список банківських рахунків особи, що включає детальну інформацію про кожен рахунок
        /// </summary>


        [DocumentationMember]
        public List<Account> Accounts { get; set; }

        /// <summary>
        /// Об'єкт, що Виводить на друк поштову адресу особи
        /// </summary>


        [DocumentationMember]
        public PostAddress PostAddressObject { get; set; }

        /// <summary>
        /// Об'єкт, що Виводить на друк фактичну адресу особи
        /// </summary>


        [DocumentationMember]
        public PostAddress PostActualAddressObject { get; set; }

        /// <summary>
        /// Ім'я фізичної особи
        /// </summary>


        [DocumentationMember]
        public String Firstname { get; set; }

        /// <summary>
        /// По батькові фізичної особи
        /// </summary>


        [DocumentationMember]
        public String Secondname { get; set; }

        /// <summary>
        /// Прізвище фізичної особи
        /// </summary>


        [DocumentationMember]
        public String Lastname { get; set; }

        /// <summary>
        /// Вказує, чи є фізична особа чоловічої статі
        /// </summary>


        [DocumentationMember]
        public Boolean? IsMan { get; set; }

        /// <summary>
        /// Дата народження фізичної особи
        /// </summary>


        [DocumentationMember]
        public DateTime? Birthdate { get; set; }

        /// <summary>
        /// Дата початку водійського стажу фізичної особи
        /// </summary>


        [DocumentationMember]
        public Int32? DriverFrom { get; set; }

        /// <summary>
        /// Ім'я особи в родовому відмінку
        /// </summary>


        [DocumentationMember]
        public String GenitiveName { get; set; }

        /// <summary>
        /// Посада особи в родовому відмінку
        /// </summary>


        [DocumentationMember]
        public String GenitivePost { get; set; }

        /// <summary>
        /// Повне ім'я особи, включаючи всі компоненти імені
        /// </summary>


        [DocumentationMember]
        public String FullName { get; set; }


        /// <summary>
        /// Код ЄДРПОУ юридичної особи
        /// </summary>


        [DocumentationMember]
        public String EDRPOU { get; set; }


        private bool? _IsResident;

        [DocumentationMember]
        public async Task<bool> GetIsResident()
        {
            return _IsResident.HasValue && _IsResident.Value;
        }


        /// <summary>
        /// Ідентифікаційний код фізичної особи або ЄДРПОУ
        /// </summary>

        [DocumentationMember]
        public string IdentificationCodeEDRPOU { get; set; }

        /// <summary>
        /// Посада або роль особи в організації
        /// </summary>


        [DocumentationMember]
        public string Post { get; set; }




        /// <summary>
        /// Державне (комунальне) підприємство
        /// </summary>

        [DocumentationMember]
        public bool IsMunicipal { get; set; }

        [DocumentationMember]
        /// <summary>
        /// Вказує, чи є об'єкт фізичною особою
        /// </summary>
        public bool IsPerson
        {
            get
            {
                return PersonTypeID == Constants.PersonType_Person || PersonTypeID == Constants.PersonType_Entrepreneur;
            }
        }

        [DocumentationMember]
        /// <summary>
        /// Вказує, чи є особа юридичною особою
        /// </summary>
        public bool IsJuridicalPerson
        {
            get
            {
                return PersonTypeID == Constants.PersonType_JuridicalPerson || PersonTypeID == Constants.PersonType_Entrepreneur;
            }
        }

    }
}