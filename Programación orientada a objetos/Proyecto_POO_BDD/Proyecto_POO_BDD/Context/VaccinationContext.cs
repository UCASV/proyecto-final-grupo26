using Microsoft.EntityFrameworkCore;
using Proyecto_POO_BDD.Entities;

namespace Proyecto_POO_BDD.Context
{
    public class VaccinationContext : DbContext
    {
        public  DbSet<Agent> Agents { get; set; }
        
        /*protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Server=localhost;Database =db; Trusted_Connection = True;");
        */
    }
}