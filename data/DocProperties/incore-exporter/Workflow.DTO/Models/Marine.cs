using Common.Documentation;

namespace Workflow.DTO.Models
{



    public partial class Marine : Object
    {



        public String Name { get; set; }




        public String RegistrationNumber { get; set; }




        public String Port { get; set; }




        public DateTime? ProducedDate { get; set; }




        public Int32? CrewCount { get; set; }




        public Int32? PassengersCount { get; set; }




        public Decimal? Height { get; set; }




        public Decimal? Width { get; set; }




        public String Manufacturer { get; set; }


        /// <summary>
        /// Глобальний унікальний ідентифікатор власника
        /// </summary>

        [DocumentationMember]
        public Guid? OwnerGID { get; set; }




        public Decimal? Cost { get; set; }



        public Face Owner { get; set; }




        public PostAddress PostAddressObject { get; set; }




        public string OwnerName { get; set; }

    }
}