using _00015913_back_end.Data;
using _00015913_back_end.Models;
using Microsoft.EntityFrameworkCore;
/*    00015913    */
namespace _00015913_back_end.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _context;

        public CompanyRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        /*    00015913    */
        public async Task<IEnumerable<Company>> GetAllCompaniesAsync()
        {
            return await _context.Companies.ToListAsync();
        }

        public async Task AddCompanyAsync(Company company)
        {
            await _context.Companies.AddAsync(company);
        }

        public async Task UpdateCompanyAsync(Company company)
        {
            _context.Companies.Update(company);
        }
        /*    00015913    */
        public async Task DeleteCompanyAsync(int id)
        {
            var company = await _context.Companies.FindAsync(id);
            if (company != null)
            {
                _context.Companies.Remove(company);
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
/*    00015913    */