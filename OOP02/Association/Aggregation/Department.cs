using OOP02.Association.Composition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Association.Aggregation
{

    //Association Relationship [Aggregation] : has a
    //                                       : Department Has A Employees? 
    internal class Department
    {
        public int Code { get; set; }
        public /*required*/ string? Name { get; set; }
        public List<Employee>? Employee { get; set; }

    }
}
