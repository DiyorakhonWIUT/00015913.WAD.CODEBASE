using _00015913_back_end.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _00015913_back_end.Data;
using _00015913_back_end.Repositories;
/*    00015913    */
namespace _00015913_back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _repository;

        public CompanyController(ICompanyRepository repository)
        {
            _repository = repository;
        }
        /*    00015913    */
        // GET: api/Company
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanies()
        {
            var companies = await _repository.GetAllCompaniesAsync();
            return Ok(companies);
        }
        /*    00015913    */
        // POST: api/Company
        [HttpPost]
        public async Task<ActionResult> CreateCompany(Company company)
        {
            await _repository.AddCompanyAsync(company);
            await _repository.SaveAsync();
            return CreatedAtAction(nameof(GetCompanies), new { id = company.CompanyId }, company);
        }
        /*    00015913    */
        // PUT: api/Company/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompany(int id, Company company)
        {
            if (id != company.CompanyId)
            {
                return BadRequest();
            }

            await _repository.UpdateCompanyAsync(company);
            await _repository.SaveAsync();
            return NoContent();
        }

        // DELETE: api/Company/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            await _repository.DeleteCompanyAsync(id);
            await _repository.SaveAsync();
            return NoContent();
        }
    }
}
/*    00015913    */