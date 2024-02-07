using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prac06.models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public long Number { get; set; }
    }
}