using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    public class EmployeeBL
    {
        public IEmployeeDAL employeeDAL;
        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL = employeeDAL;
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeDAL.SelectAllEmployees();
        }
    }


    //public class EmployeeBL
    //{
    //    public EmployeeDAL employeeDAL;
    //    public List<Employee> GetAllEmployees()
    //    {
    //        employeeDAL = new EmployeeDAL();
    //        return employeeDAL.SelectAllEmployees();
    //    }
    //}
}
