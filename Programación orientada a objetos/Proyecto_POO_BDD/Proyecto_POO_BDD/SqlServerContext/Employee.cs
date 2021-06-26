using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.SqlServerContext
{
    public partial class Employee
    {
        public Employee()
        {
            Citizens = new HashSet<Citizen>();
            Employeexcabins = new HashSet<Employeexcabin>();
            Records = new HashSet<Record>();
        }

        public int Id { get; set; }
        public string NameEmployee { get; set; }
        public string Mail { get; set; }
        public string UserG { get; set; }
        public string Passwordd { get; set; }
        public int IdDirection { get; set; }
        public int? IdTypeEmployee { get; set; }

        public virtual Direction IdDirectionNavigation { get; set; }
        public virtual TypeEmployee IdTypeEmployeeNavigation { get; set; }
        public virtual ICollection<Citizen> Citizens { get; set; }
        public virtual ICollection<Employeexcabin> Employeexcabins { get; set; }
        public virtual ICollection<Record> Records { get; set; }
    }
}
