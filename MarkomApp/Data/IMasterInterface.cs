using MarkomApp.Models;
using MarkomApp.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Data
{
    //public interface IMasterInterface 
    //    : ICompanyInterface, IEmployeeInterface, IRoleinterface, IMenuInterface, 
    //    IMenuAccessInterface, IUserInterface, IUnitInterface, ISouvenirInterface,
    //    IProductInterface
    //{
        
    //}

    public interface ICompanyInterface
    {
        #region Company
        List<Company> GetCompanyList();
        Company GetCompany(int? id);
        bool DeleteCompany(int id);
        bool EditCompany(CompanyDto company);
        bool AddCompany(CompanyDto company);
        #endregion

    }

    public interface IEmployeeInterface
    {
        #region Employee
        List<Employee> GetEmpoyeeList();
        Employee GetEmployee(int id);
        bool DeleteEmployee(int id);
        bool EditEmployee(Employee employee);
        bool AddEmployee(Employee employee);
        #endregion
    }

    public interface IRoleinterface
    {
        #region Role
        List<Role> GetRoleList();
        Role GetRole(int id);
        bool DeleteRole(int id);
        bool EditRole(Role role);
        bool AddRole(Role role);
        #endregion
    }

    public interface IMenuInterface
    {
        #region Menu
        List<Menu> GetMenuList();
        Menu GetMenu(int id);
        bool DeleteMenu(int id);
        bool EditMenu(Menu menu);
        bool AddMenu(Menu menu);
        #endregion
    }

    public interface IMenuAccessInterface
    {
        #region MenuAccess
        List<MenuAccess> GetMenuAccessList();
        MenuAccess GetMenuAccess(int id);
        bool DeleteMenuAccess(int id);
        bool EditMenuAccess(MenuAccess menuAccess);
        bool AddMenuAccess(MenuAccess menuAccess);
        #endregion
    }

    public interface IUserInterface
    {

        #region User
        List<User> GetUserList();
        User GetUser(int id);
        bool DeleteUser(int id);
        bool EditUser(UserDto menuAccess);
        bool AddUser(UserDto menuAccess);
        #endregion
    }

    public interface IUnitInterface
    {
        #region Unit
        List<Unit> GetUnitList();
        User GetUnit(int id);
        bool DeleteUnit(int id);
        bool EditUnit(Unit unit);
        bool AddUnit(Unit unit);
        #endregion
    }

    public interface ISouvenirInterface
    {
        #region Souvenir
        List<Souvenir> GetSouvenirList();
        User GetSouvenir(int id);
        bool DeleteSouvenir(int id);
        bool EditSouvenir(Souvenir souvenir);
        bool AddSouvenir(Souvenir souvenir);
        #endregion
    }

    public interface IProductInterface
    {
        #region Product
        List<Product> GetSouvenirList();
        User GetProduct(int id);
        bool DeleteProduct(int id);
        bool EditProduct(Product product);
        bool AddProduct(Product product);
        #endregion
    }

}
