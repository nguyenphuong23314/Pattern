﻿using SOLID.DependencyInversion;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            DependencyInjection();


            void DependencyInjection()
            {
                EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
                List<Employee> ListEmployee = employeeBL.GetAllEmployees();
                foreach (Employee emp in ListEmployee)
                {
                    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", 
                            emp.ID, 
                            emp.Name, 
                            emp.Department);
                }
                Console.ReadKey();
            }
        }
    }
}