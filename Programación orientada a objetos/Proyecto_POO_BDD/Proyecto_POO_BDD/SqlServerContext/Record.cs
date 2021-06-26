using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.SqlServerContext
{
    public partial class Record
    {
        public int Id { get; set; }
        public DateTime? DateR { get; set; }
        public TimeSpan? TimeR { get; set; }
        public int? IdEmployee { get; set; }
        public int? IdCabin { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}
