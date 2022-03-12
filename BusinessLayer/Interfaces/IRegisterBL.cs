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
    }
}
