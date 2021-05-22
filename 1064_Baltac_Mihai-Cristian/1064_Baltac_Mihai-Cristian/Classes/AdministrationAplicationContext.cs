using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1064_Baltac_Mihai_Cristian.Classes
{
  public  class AdministrationAplicationContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }


        // config part 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=adm.db");
        }


        public AdministrationAplicationContext()
        {
            try
            {
                Database.Migrate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
