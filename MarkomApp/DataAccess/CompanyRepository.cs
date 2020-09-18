using MarkomApp.Data;
using MarkomApp.Models;
using MarkomApp.Shared.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
            company = _context.Companies.Where(x => x.Id == id).FirstOrDefault();
            return company;        
        }

        public bool DeleteCompany(int id)
        {
            bool deleteSuccess = false;
            try
            {
                Company company = _context.Companies.Where(x => x.Id == id && !(x.IsDelete)).FirstOrDefault();
                if (company != null && id > 0)
                {
                    //_context.Companies.Remove(company);

                    company.IsDelete = true;
                    _context.Companies.Update(company);
                    deleteSuccess = true;
                }
            }
            catch (Exception)
            {
                return deleteSuccess;
                throw;
            }
            return deleteSuccess;
        }
        public bool EditCompany(CompanyDto company) 
        {
            bool success = false;

            Company entity = GetCompany(company.Id);
            entity.Code = company.Code;
            entity.Name = company.Name;
            entity.Phone = company.Phone;
            entity.Email = company.Email;
            entity.Address = company.Address;

            entity.UpdatedBy = "ADM";
            entity.UpdatedDate = DateTime.Now;

            _context.Companies.Update(entity);

            return success;
        }
        public bool AddCompany(CompanyDto company) 
        {
            return true;
        }
    }
}
