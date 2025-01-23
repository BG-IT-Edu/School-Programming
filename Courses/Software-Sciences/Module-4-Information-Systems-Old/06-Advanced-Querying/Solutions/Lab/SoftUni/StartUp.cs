using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using System.Linq;
using Z.EntityFramework.Plus;

namespace SoftUni
{
    public class StartUp
    {
        static void Main()
        {
            var context = new SoftUniContext();
            //1. Add Employee to Project
            var employeeId = 1;
            var projectId = 1;
            context.Database
                .ExecuteSqlInterpolated($"EXEC sp_AddEmployeeToProjest {employeeId}, {projectId}");

            //Task 2
            context.EmployeesProjects.Where(x => x.ProjectId < 3).Delete();
        }

    }
}
