using SoftUni.Data;

namespace SoftUni
{
    public class StartUp
    {
        static void Main()
        {
            var context = new SoftUniContext();
        }

        //Problem 01
        public static string FindEmployeesWithJobTitle(SoftUniContext context)
        {
            return string.Join(Environment.NewLine, employees);
        }

        //Problem 02
        public static string FindProjectWithId(SoftUniContext context)
        {
            return project.Name;
        }

        //Problem 03
        public static void CreateNewProject(SoftUniContext context)
        {
            
        }

        //Problem 04
        public static string UpdateFirstEmployee(SoftUniContext context)
        {
            if (employee != null)
            { 
                return employee.FirstName;
            }
            return "";
        }

        //Problem 05
        public static string DeleteFirstProject(SoftUniContext context)
        {
            return project.Name;
        }

        //Problem 06
        public static string UpdateAddresses(SoftUniContext context)
        {
            return addresses.Count.ToString();
        }
    }
}
