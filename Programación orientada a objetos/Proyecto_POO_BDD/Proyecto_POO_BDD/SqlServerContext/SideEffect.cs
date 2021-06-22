using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.SqlServerContext
{
    public partial class SideEffect
    {
        public SideEffect()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public string SideEffects { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
