using SOLID.DependencyInversion;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dependency Injection

            //DependencyInjectionByConstructor();
            //void DependencyInjectionByConstructor()
            //{
            //    EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
            //    List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            //    foreach (Employee emp in ListEmployee)
            //    {
            //        Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", 
            //                emp.ID, 
            //                emp.Name, 
            //                emp.Department);
            //    }
            //    Console.ReadKey();
            //}

            DependencyInjectionByMethod();
            void DependencyInjectionByMethod()
            {
                //Create object of EmployeeBL class
                EmployeeBL employeeBL = new EmployeeBL();
                //Call to GetAllEmployees method with proper object.            
                List<Employee> ListEmployee = employeeBL.GetAllEmployees(new EmployeeDAL());
                foreach (Employee emp in ListEmployee)
                {
                    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
                }
                Console.ReadKey();
            }


            //DependencyInjectByProperty();
            //void DependencyInjectByProperty()
            //{
            //    EmployeeBL employeeBL = new EmployeeBL();
            //    employeeBL.employeeDataObject = new EmployeeDAL();

            //    List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            //    foreach (Employee emp in ListEmployee)
            //    {
            //        Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            //    }
            //    Console.ReadKey();
            //}



            #endregion
        }
    }
}