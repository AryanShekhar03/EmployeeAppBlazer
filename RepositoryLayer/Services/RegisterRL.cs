﻿using CommonLayer.Models;
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

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
           List<EmployeeModel> lstEmployee = new List<EmployeeModel>();
           sqlConnection = new SqlConnection(this.configuration.GetConnectionString("empappBlazer"));
            try
            {
                using (this.sqlConnection)
                {
                    SqlCommand cmd = new SqlCommand("sp_GetAllEmployees", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        EmployeeModel employeeModel = new EmployeeModel();
                        employeeModel.Id = Convert.ToInt32(rdr["EmployeeID"]);
                        employeeModel.Name = rdr["Name"].ToString();
                        employeeModel.Gender = rdr["Gender"].ToString();
                        employeeModel.Department = rdr["Department"].ToString();
                        employeeModel.Salary = rdr["Salary"].ToString();
                        //employeeModel.StartDate = rdr["StartDate"].ToString();\
                        employeeModel.Notes = rdr["Notes"].ToString();
                        employeeModel.ProfileImg = rdr["ProfileImg"].ToString();
                        lstEmployee.Add(employeeModel);
                    }
                    sqlConnection.Close();
                }
                return lstEmployee;
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
