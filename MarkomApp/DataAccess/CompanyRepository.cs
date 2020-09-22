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
            companies = _context.Companies.Where(x => x.Id > 0 && !x.IsDelete).ToList();
            return companies;
        }
        public Company GetCompany(int? id)
        {
            Company company = new Company();
            company = _context.Companies.Where(x => x.Id == id && !x.IsDelete).FirstOrDefault();
            return company;
        }

        public bool IsExistCompany(CompanyDto company)
        {
            bool status = false;
            try
            {
                status = _context.Companies.Any(x => !x.IsDelete && x.Name != company.Name);
            }
            catch (Exception)
            {
                return status;
                throw;
            }

            return status;
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
                    _context.SaveChanges();

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

            try
            {
                Company entity = GetCompany(company.Id);
                if (entity != null)
                {
                    entity.Code = company.Code;
                    entity.Name = company.Name;
                    entity.Phone = company.Phone;
                    entity.Email = company.Email;
                    entity.Address = company.Address;

                    entity.UpdatedBy = "ADM";
                    entity.UpdatedDate = DateTime.Now;

                    _context.Companies.Update(entity);
                    _context.SaveChanges();

                    success = true;
                }
            }
            catch (Exception)
            {
                return success;
                throw;
            }

            return success;
        }
        public bool AddCompany(CompanyDto company) 
        {
            bool success = false;
            bool isExist = true;
            try
            {
                isExist = IsExistCompany(company);
                if (isExist)
                {
                    Company entity = new Company
                    {
                        Code = company.Code,
                        Name = company.Name,
                        Phone = company.Phone,
                        Email = company.Email,
                        Address = company.Address,
                        CreatedBy = "ADM",
                        CreatedDate = DateTime.Now
                    };


                    _context.Companies.Add(entity);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {
                return success;
                throw;
            }
            return success;
        }
    }
}
