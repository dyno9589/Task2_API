//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Net.Http;
//using System.Web.Http;
//using System.Net;
//using DAL;
//using WebAPIProject.Controllers;

//namespace WebAPIProject.BusinessLogic
//{
//    public class EmployeeBLL
//    {
//        EmployeesController empcon = new EmployeesController();

//        public List<Employee> GetAllEmployees()
//        {
//            List<Employee> employees = new List<Employee>();

//           employees= empcon.Get().ToList();

//            return employees;

//            //List<Employee> employees = new List<Employee>();
//            //employees = EmployeeDAL.GetAllEmployees();
//            //return employees;
//        }

//        public void AddEmployee(Employee employee)
//        {
//            employee.
//            empcon.Post(employee);
//        }
//    }
//    }

   

//    //public void UpdateEmployee(Employee employee)
//    //{
//    //    // Implement logic to update an existing employee using DAL
//    //}

//    //public void DeleteEmployee(int employeeId)
//    //{
//    //    // Implement logic to delete an employee using DAL
//    //}
//    //}
//}