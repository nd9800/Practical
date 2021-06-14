using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Models
{
    public class EmployeeList
    {
       
        public string name { get; set; }
        public string role { get; set; }
        public string birthyear { get; set; }
    }

    public class Root
    {
        public List<EmployeeList> employee_list { get; set; }
    }


}
