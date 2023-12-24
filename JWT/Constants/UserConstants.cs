using JWT.Models;

namespace JWT.Constants
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "pepitoperez", Password = "admin123", Rol = "Administrador", EmailAddress = "cliente@sincorreo.com", FirstName = "Pepito", LastName = "Perez" },
            new UserModel() { Username = "pepito.perez", Password = "admin123", Rol = "Vendedor", EmailAddress = "cliente1@sincorreo.com", FirstName = "Pepito JR", LastName = "Perez L" },
            new UserModel() { Username = "pepitoperez", Password = "admin123", Rol = "Administrador", EmailAddress = "cliente3@sincorreo.com", FirstName = "Pepito Alt", LastName = "Perez A" },
        };
    }
}
