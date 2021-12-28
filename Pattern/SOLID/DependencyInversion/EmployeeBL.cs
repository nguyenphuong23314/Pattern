using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{



    /// <summary>
    /// This is the implementation of Dependency injection through Constructor
    /// </summary>
    //public class EmployeeBL
    //{
    //    public IEmployeeDAL employeeDAL;
    //    public EmployeeBL(IEmployeeDAL employeeDAL)
    //    {
    //        this.employeeDAL = employeeDAL;
    //    }
    //    public List<Employee> GetAllEmployees()
    //    {
    //        return employeeDAL.SelectAllEmployees();
    //    }
    //}
    //-------------------------------------------------//

    /// <summary>
    /// This is the implementation of Dependency injection through Property
    /// </summary>
    public class EmployeeBL
    {
        public IEmployeeDAL employeeDAL;
        public List<Employee> GetAllEmployees(IEmployeeDAL _employeeDAL)
        {
            employeeDAL = _employeeDAL;
            return employeeDAL.SelectAllEmployees();
        }
    }
    //-------------------------------------------------//


    /// <summary>
    /// This is the implementation of Dependency injection through Property
    /// </summary>
    //public class EmployeeBL
    //{
    //    private IEmployeeDAL employeeDAL;
    //    public IEmployeeDAL employeeDataObject
    //    {
    //        set
    //        {
    //            this.employeeDAL = value;
    //        }
    //        get
    //        {
    //            if (employeeDataObject == null)
    //            {
    //                throw new Exception("Employee is not initialized");
    //            }
    //            else
    //            {
    //                return employeeDAL;
    //            }
    //        }
    //    }
    //    public List<Employee> GetAllEmployees()
    //    {
    //        return employeeDAL.SelectAllEmployees();
    //    }
    //}
    //-------------------------------------------------//


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
