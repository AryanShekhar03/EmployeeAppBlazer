using CommonLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IRegisterBL
    {
        public bool AddEmployee(EmployeeModel employeeModel);

        public IEnumerable<EmployeeModel> GetAllEmployees();

        public EmployeeModel GetEmployeeData(long Id);

        public void UpdateEmployee(EmployeeModel employee);

        public void DeleteEmployee(long Id);
    }
}
