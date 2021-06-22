using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.SqlServerContext
{
    public partial class Cabin
    {
        public Cabin()
        {
            Citizens = new HashSet<Citizen>();
            Employeexcabins = new HashSet<Employeexcabin>();
        }

        public int Id { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int IdDirection { get; set; }

        public virtual Direction IdDirectionNavigation { get; set; }
        public virtual ICollection<Citizen> Citizens { get; set; }
        public virtual ICollection<Employeexcabin> Employeexcabins { get; set; }
    }
}
