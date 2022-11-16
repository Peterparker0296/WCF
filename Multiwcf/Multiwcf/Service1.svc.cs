using Multiwcf.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Multiwcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Employeesss> GetEmployees()
        {

            var db1 = new TestDBEntities();
            var db2 = new SampleProductEntities();

            var Emp = db1.Employeessses.ToList();
            var Dept = db2.Departments.ToList();
            //  var de = db2.Departments.ToList();

            var DE = db2.Departments.ToList();



            var task = (from Employeesss in Emp
                       
                        join Department in Dept
                        on new { X1 = Employeesss.EmployeeID , X2 = Employeesss.DeptID } equals new {X1 = Department.EmployeeID , X2 = Department.DeptID}


                        where Employeesss.Marks > 67

                        orderby Employeesss.EmpName descending

                     
                         select Employeesss).AsEnumerable().Select(x => new Employeesss()
                         {

                             EmployeeId = x.EmployeeID,

                             EmpName = x.EmpName,

                             DeptID = x.DeptID ,

                             Course = x.Course ,

                             City = x.City,

                             
                             Marks = (int)x.Marks


                             

                         }
                        ).Take(2).ToList();

            return task;






          



        }
    }
}
