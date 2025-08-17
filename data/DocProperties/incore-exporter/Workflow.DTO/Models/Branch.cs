/// <summary>
/// Повертає інформацію про дирекцію за унікальним ідентифікатором відділення.
/// </summary>
/// <param name = "branchGID">Унікальний ідентифікатор відділення</param>
/// <returns>Інформація про дирекцію</returns>
[DocumentationMember]
public async Task<Workflow.DTO.Models.Branch> GetDirectionBranch(Guid branchGID)