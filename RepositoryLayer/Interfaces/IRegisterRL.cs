using CommonLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface IRegisterRL
    {
        public bool AddEmployee(EmployeeModel employeeModel);

        public IEnumerable<EmployeeModel> GetAllEmployees();

        public void UpdateEmployee(EmployeeModel employee);

        public EmployeeModel GetEmployeeData(long Id);

        public void DeleteEmployee(long Id);
    }
}
