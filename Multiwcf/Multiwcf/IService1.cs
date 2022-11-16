using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Multiwcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetEmp", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Employeesss> GetEmployees();





    }





    [DataContract]
    public class Employeesss
    {

        [DataMember]
        public int EmployeeId { get; set; }

        [DataMember]
        public string EmpName { get; set; }

        [DataMember]
        public int DeptID { get; set; }

        [DataMember]
        public string City { get; set; }


        [DataMember]
        public string Course { get; set; }


        [DataMember]

        public int Marks { get; set; }

    }


    


 
   
   
}
