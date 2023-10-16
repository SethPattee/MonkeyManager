using Microsoft.EntityFrameworkCore;
using MonkeyManager.Data.Models;

namespace MonkeyManager.Data
{
    public class EmployeeManagerDbContext : DbContext
    {
        public EmployeeManagerDbContext(
            DbContextOptions<EmployeeManagerDbContext> options) : base(options) {  }
        public DbSet<Employee> Emplyees => Set<Employee>();
        public DbSet<Department> Departments => Set<Department>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Banana Counting" },
                new Department { Id = 2, Name = "Sales"},
                new Department { Id = 3, Name = "Marketing"},
                new Department { Id = 4, Name = "Monkey Resources"},
                new Department { Id = 5, Name = "IT"});

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, FirstName = "Funky", LastName = "Kong", DepartmentId = 5, IsDeveloper = true},
                new Employee { Id = 2, FirstName = "Donkey", LastName = "Kong", DepartmentId = 3 },
                new Employee { Id = 3, FirstName = "Diddy", LastName = "Kong", DepartmentId = 2 },
                new Employee { Id = 4, FirstName = "Cranky", LastName = "Kong", DepartmentId = 4 },
                new Employee { Id = 5, FirstName = "Dixie", LastName = "Kong", DepartmentId = 3 },
                new Employee { Id = 6, FirstName = "Candy", LastName = "Kong", DepartmentId = 2 },
                new Employee { Id = 7, FirstName = "Chunky", LastName = "Kong", DepartmentId = 4 }
                );
        }



    }
}

//Package Manager Console
//Update-Database : updates your database
//Script-Migration : Generates an SQL File to let you update your database. 
