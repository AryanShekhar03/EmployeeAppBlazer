using BusinessLayer.Interfaces;
using CommonLayer.Models;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class RegisterBL : IRegisterBL
    {
        private readonly IRegisterRL registerRL;

        public RegisterBL(IRegisterRL registerRL)
        {
        this.registerRL = registerRL;
        }
    
        public bool AddEmployee(EmployeeModel employeeModel)
        {
            try
            {
                return this.registerRL.AddEmployee(employeeModel);
            }
            catch (Exception)
            {
                throw;

            }
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            try
            {
                return this.registerRL.GetAllEmployees();
            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
