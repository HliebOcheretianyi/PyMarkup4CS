using Common.Documentation;

namespace Workflow.DTO.Models
{



    public partial class Air : Object
    {



        public String Name { get; set; }




        public String StateAndRegistrationMarks { get; set; }




        public Int32? ProducedDate { get; set; }




        public String SerialNumber { get; set; }




        public String AirportBased { get; set; }


        /// <summary>
        /// Глобальний унікальний ідентифікатор власника
        /// </summary>

        [DocumentationMember]
        public Guid? OwnerGID { get; set; }



        public Guid? OperatorGID { get; set; }




        public Int32? MaximumPassengers { get; set; }




        public Decimal? MaximumTakeOffWeight { get; set; }




        public Decimal? MaximumCapacity { get; set; }




        public Decimal? Cost { get; set; }



        public Face Owner { get; set; }



        public Face Operator { get; set; }




        public string OwnerName { get; set; }




        public string OperatorName { get; set; }

    }
}