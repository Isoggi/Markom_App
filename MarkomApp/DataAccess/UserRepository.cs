using MarkomApp.Data;
using MarkomApp.Models;
using MarkomApp.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.DataAccess
{
    public class UserRepository : IUserInterface
    {
        private DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public List<User> GetUserList()
        {
            List<User> users = new List<User>();
            users = _context.Users.Where(x => x.Id > 0 && !x.IsDelete).ToList();
            return users;
        }
        public User GetUser(int id)
        {
            User user = new User();
            user = _context.Users.Where(x => x.Id == id && !x.IsDelete).FirstOrDefault();
            return user;
        }

        public bool IsExistUser(UserDto user)
        {
            bool status = false;
            try
            {
                status = _context.Users.Any(x => !x.IsDelete && x.Username != user.Username);
            }
            catch (Exception)
            {
                return status;
                throw;
            }

            return status;
        }

        public bool DeleteUser(int id)
        {
            bool deleteSuccess = false;
            try
            {
                User user = _context.Users.Where(x => x.Id == id && !(x.IsDelete)).FirstOrDefault();
                if (user != null && id > 0)
                {
                    //_context.Companies.Remove(company);

                    user.IsDelete = true;
                    _context.Users.Update(user);
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
        public bool EditUser(UserDto user)
        {
            bool success = false;

            try
            {
                User entity = GetUser(user.Id);
                if (entity != null)
                {
                    entity.Username = user.Username;
                    entity.Password = user.Password;

                    entity.UpdatedBy = "ADM";
                    entity.UpdatedDate = DateTime.Now;

                    _context.Users.Update(entity);
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
        public bool AddUser(UserDto user)
        {
            bool success = false;
            try
            {
                bool isExist = IsExistUser(user);
                if (isExist)
                {
                    User entity = new User
                    {
                        Username = user.Username,
                        Password = user.Password,
                        M_Role_Id = user.M_Role_Id,
                        M_Employee_Id = user.M_Employee_Id,
                        CreatedBy = "ADM",
                        CreatedDate = DateTime.Now
                    };


                    _context.Users.Add(entity);
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
