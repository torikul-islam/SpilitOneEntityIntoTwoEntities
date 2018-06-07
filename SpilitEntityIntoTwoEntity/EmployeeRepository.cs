using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpilitEntityIntoTwoWntity
{
    public class EmployeeRepository
    {
        EmployeeDBContex employeeDBContex = new EmployeeDBContex();
        
        public List<Employee> GetEmployees()
        {
           return employeeDBContex.Employees.ToList();
        }

        public void InsertEmployee(Employee employee)
        {
            employeeDBContex.Employees.Add(employee);
            employeeDBContex.SaveChanges();
        }
        public void UpDateEmployee(Employee employee)
        {
            Employee UpdateToEmployee = employeeDBContex.Employees.SingleOrDefault(x => x.EmployeeId == employee.EmployeeId);
            UpdateToEmployee.FirstName = employee.FirstName;
            UpdateToEmployee.LastName = employee.LastName;
            UpdateToEmployee.Gender = employee.Gender;
            UpdateToEmployee.Email = employee.Email;
            UpdateToEmployee.Mobile = employee.Mobile;
            UpdateToEmployee.Landline = employee.Landline;
            employeeDBContex.SaveChanges();

        }
        public void DeleteEmployee(Employee employee)
        {
            Employee DeleteToEmployee = employeeDBContex.Employees.SingleOrDefault(x => x.EmployeeId == employee.EmployeeId);
            employeeDBContex.Employees.Remove(DeleteToEmployee);
            employeeDBContex.SaveChanges();
        }



    }
}