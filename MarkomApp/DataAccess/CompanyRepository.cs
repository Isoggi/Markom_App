using MarkomApp.Data;
using MarkomApp.Models;
using MarkomApp.Shared.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.DataAccess
{
    public class CompanyRepository : ICompanyInterface
    {
        private DataContext _context;
        public CompanyRepository(DataContext context)
        {
            _context = context;
        }

        public List<Company> GetCompanyList()
        {
            List<Company> companies = new List<Company>();
            companies = _context.Companies.Where(x => x.Id > 0).ToList();
            return companies;
        }
        public Company GetCompany(int id) 
        {
            Company company = new Company();

            return company;        
        }

        public bool DeleteCompany(int id)
        {
            return true;
        }
        public bool EditCompany(CompanyDto company) 
        {
            return true;
        }
        public bool AddCompany(CompanyDto company) 
        {
            return true;
        }
    }
}
