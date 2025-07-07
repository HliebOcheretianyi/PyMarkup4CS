using Common.Documentation;

namespace Workflow.DTO.Models
{
    /// <summary>
    /// ���� � ������� ��� ��������� ����� �����, �� ���������� ��������� ������������� � ������.
    /// </summary>











































































    [DocumentationContract]
    public abstract class IdentityPersistentEntity
    {
        /// <summary>
        /// �������� ������������� �������. ��������������� ��� ��������� ������������� ��'���� � ����� �������.
        /// </summary>

        [DocumentationMember]

        public Int64 id { get; set; }


        /// <summary>
        /// ���������� ���������� ������������� �������. ��������������� ��� ������������ ��������� ������������� ��'���� �� ����������� ����.
        /// </summary>

        [DocumentationMember]

        public Guid gid { get; set; }

        public Guid AuthorGID { get; set; }
    }
}
