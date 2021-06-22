using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.SqlServerContext
{
    public partial class Record
    {
        public Record()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public DateTime? DateR { get; set; }
        public TimeSpan? TimeR { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
