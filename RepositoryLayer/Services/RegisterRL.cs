using CommonLayer.Models;
using Microsoft.Extensions.Configuration;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace RepositoryLayer.Services
{
    public class RegisterRL : IRegisterRL
    {
      
         public SqlConnection sqlConnection;
        public IConfiguration configuration;
        public RegisterRL(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public bool AddEmployee(EmployeeModel employeeModel)
        {
            sqlConnection = new SqlConnection(this.configuration.GetConnectionString("empappBlazer"));
            try
            {
                using (this.sqlConnection)
                {
                    SqlCommand cmd = new SqlCommand("Sp_AddEmployees", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", employeeModel.Name);
                    cmd.Parameters.AddWithValue("@Profile_Img", employeeModel.ProfileImg);
                    cmd.Parameters.AddWithValue("@Gender", employeeModel.Gender);
                    cmd.Parameters.AddWithValue("@Department", employeeModel.Department);
                    cmd.Parameters.AddWithValue("@Salary", employeeModel.Salary);
                    cmd.Parameters.AddWithValue("@StartDate", employeeModel.StartDate);
                    cmd.Parameters.AddWithValue("@Notes", employeeModel.Notes);

                    this.sqlConnection.Open();
                    var result = cmd.ExecuteNonQuery();

                    this.sqlConnection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;

                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.sqlConnection.Close();
            }
        }

        public void DeleteEmployee(long Id)
        {
            sqlConnection = new SqlConnection(this.configuration.GetConnectionString("empappBlazer"));
            try
            {
                using (this.sqlConnection)
                {
                    SqlCommand cmd = new SqlCommand("Sp_DeleteEmployee", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", Id);
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    this.sqlConnection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.sqlConnection.Close();
            }
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
           List<EmployeeModel> ALLEmployee = new List<EmployeeModel>();
           sqlConnection = new SqlConnection(this.configuration.GetConnectionString("empappBlazer"));
            try
            {
                using (this.sqlConnection)
                {
                    SqlCommand cmd = new SqlCommand("Sp_GetAllEmployees", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        EmployeeModel employeeModel = new EmployeeModel();
                        employeeModel.Id = Convert.ToInt32(rdr["Id"]);
                        employeeModel.Name = rdr["Name"].ToString();
                        employeeModel.Gender = rdr["Gender"].ToString();
                        employeeModel.Department = rdr["Department"].ToString();
                        employeeModel.Salary = rdr["Salary"].ToString();
                        employeeModel.Notes = rdr["Notes"].ToString();
                        employeeModel.ProfileImg = rdr["Profile_Img"].ToString();
                        ALLEmployee.Add(employeeModel);
                    }
                    sqlConnection.Close();
                }
                return ALLEmployee;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.sqlConnection.Close();
            }
        }

        public EmployeeModel GetEmployeeData(long Id)
        {
            sqlConnection = new SqlConnection(this.configuration.GetConnectionString("empappBlazer"));
            EmployeeModel employeeModel = new EmployeeModel();
            try
            {
                using (this.sqlConnection)
                {

                    SqlCommand cmd = new SqlCommand("Sp_GetEmployeeByID", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", Id);
                    sqlConnection.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        //EmployeeModel employeeModel = new EmployeeModel();
                        employeeModel.Id = Convert.ToInt32(rdr["Id"]);
                        employeeModel.Name = rdr["Name"].ToString();
                        employeeModel.Gender = rdr["Gender"].ToString();
                        employeeModel.Department = rdr["Department"].ToString();
                        employeeModel.Salary = rdr["Salary"].ToString();
                        employeeModel.Notes = rdr["Notes"].ToString();
                        employeeModel.ProfileImg = rdr["Profile_Img"].ToString();
                    }
                }
                return employeeModel;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.sqlConnection.Close();
            }

        }

        public void UpdateEmployee(EmployeeModel employee)
        {
            sqlConnection = new SqlConnection(this.configuration.GetConnectionString("empappBlazer"));
            try
            {
                using (this.sqlConnection)
                {
                    SqlCommand cmd = new SqlCommand("Sp_UpdateEmployee", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", employee.Id);
                    cmd.Parameters.AddWithValue("@Name", employee.Name);
                    cmd.Parameters.AddWithValue("@Profile_Img", employee.ProfileImg);
                    cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                    cmd.Parameters.AddWithValue("@Department", employee.Department);
                    cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                    cmd.Parameters.AddWithValue("@StartDate", employee.StartDate);
                    cmd.Parameters.AddWithValue("@Notes", employee.Notes);
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.sqlConnection.Close();
            }

        }
    }



        
    


}
