using Microsoft.EntityFrameworkCore;
namespace MVCEF_App.Models
{
    public class HospitalDbContext:DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            String conString = @"Server=200411LTP2860\SQLEXPRESS;Database=HospitalDB;integrated security=true;Encrypt=False";
            options.UseSqlServer(conString);
        }
    }
}
