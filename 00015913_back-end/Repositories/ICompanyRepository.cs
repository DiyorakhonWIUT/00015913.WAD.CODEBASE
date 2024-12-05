using _00015913_back_end.Models;
/*    00015913    */
namespace _00015913_back_end.Repositories
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> GetAllCompaniesAsync();
        Task AddCompanyAsync(Company company);
        Task UpdateCompanyAsync(Company company);
        Task DeleteCompanyAsync(int id);
        Task SaveAsync();
    }
}
/*    00015913    */