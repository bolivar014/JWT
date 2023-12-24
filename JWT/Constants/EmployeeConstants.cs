using JWT.Models;

namespace JWT.Constants
{
    public class EmployeeConstants
    {
        public static List<EmployeeModel> Employees = new List<EmployeeModel>()
        {
            new EmployeeModel() { FirstName = "Pepito", LastName = "Perez", Email = "Cliente@sincorreo.com" },
            new EmployeeModel() { FirstName = "Pepito Alberto", LastName = "Perez Gomez", Email = "Cliente@sincorreo.com" }
        };
    }
}
