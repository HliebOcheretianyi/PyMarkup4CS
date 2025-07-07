
using Common.Documentation;
using System.Runtime.Serialization;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// Клас для зберігання інформації про підписантів
    /// </summary>


    [DocumentationContract]
    public partial class Signer : Workflow.DTO.Models.IdentityDeletedPersistentEntity
    {


        public Guid FaceGID { get; set; }



        public Guid? RepresentativeGID { get; set; }



        public Guid? AccountGID { get; set; }



        public Guid? DocumentGID { get; set; }

        /// <summary>
        /// Gid Ідентифікуючого документу
        /// </summary>
        /// 
        [DocumentationMember]

        public Guid? FaceDocumentGID { get; set; }

        /// <summary>
        /// Особа, що є підписантом
        /// </summary>


        [DocumentationMember]
        public Face Face { get; set; }

        /// <summary>
        /// Представник підписанта
        /// </summary>


        [DocumentationMember]
        public Face Representative { get; set; }


        public DateTime? LastModifiedFaceDate { get; set; }


        public DateTime? LastModifiedRepresentativeDate { get; set; }



        public string FaceName { get; set; }



        public string RepresentativeName { get; set; }



        public long FacePersonTypeID { get; set; }



        public long? RepresentativePersonTypeID { get; set; }

        /// <summary>
        /// Атрибути об'єкта підписанта, що описують його характеристики та властивості
        /// </summary>


        [DocumentationMember]
        public List<EntityAttribute> EntityAttributes { get; set; }



        public Guid? HeadRepresentativeGID { get; set; }



        public string HeadRepresentativeName { get; set; }



        public Face HeadRepresentative { get; set; }


        [DataMember]

        public Guid? FaceVersionGID { get; set; }


        [DataMember]

        public Guid? RepresentativeVersionGID { get; set; }


        [DataMember]

        public Guid? HeadRepresentativeVersionGID { get; set; }


        [DataMember]

        public Guid? SignTypeGID { get; set; }

        public Guid ActualFaceGID
        {
            get
            {
                return FaceVersionGID ?? FaceGID;
            }
        }

        public Guid? ActualRepresentativeGID
        {
            get
            {
                return RepresentativeVersionGID ?? RepresentativeGID;
            }
        }

        public Guid? ActualHeadRepresentativeGID
        {
            get
            {
                return HeadRepresentativeVersionGID ?? HeadRepresentativeGID;
            }
        }

        #region ISigner

        /// <summary>
        /// Ідентифікуючий документ
        /// </summary>
        /// 
        [DocumentationMember]
        public Document FaceDocument
        {
            get
            {
                return Face?.Documents?.FirstOrDefault(d => d.gid == FaceDocumentGID);
            }
        }
        #endregion
    }
}