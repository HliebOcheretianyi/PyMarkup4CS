using Common.Documentation;

namespace Workflow.DTO.Models
{



    public partial class ConstructionLoadingWork : Object
    {



        public String Name { get; set; }




        public String Purpose { get; set; }




        public String Location { get; set; }




        public Decimal? Cost { get; set; }


        /// <summary>
        /// Глобальний унікальний ідентифікатор власника
        /// </summary>

        [DocumentationMember]
        public Guid? OwnerGID { get; set; }



        public Guid? PostAddressGID { get; set; }



        public Face Owner { get; set; }




        public PostAddress PostAddressObject { get; set; }




        public string OwnerName { get; set; }
    }
}