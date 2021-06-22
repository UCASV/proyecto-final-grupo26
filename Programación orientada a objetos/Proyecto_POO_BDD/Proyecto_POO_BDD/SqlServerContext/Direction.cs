using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.SqlServerContext
{
    public partial class Direction
    {
        public Direction()
        {
            Cabins = new HashSet<Cabin>();
            Citizens = new HashSet<Citizen>();
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Department { get; set; }
        public string Street { get; set; }
        public string Municipality { get; set; }

        public virtual ICollection<Cabin> Cabins { get; set; }
        public virtual ICollection<Citizen> Citizens { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
