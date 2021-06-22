using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.SqlServerContext
{
    public partial class Disease
    {
        public Disease()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public string Diseases { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
