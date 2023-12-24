using JWT.Models;

namespace JWT.Constants
{
    public class CountryConstants
    {
        public static List<CountryModel> Countries = new List<CountryModel>()
        {
            new CountryModel() { Name = "Colombia" },
            new CountryModel() { Name = "Mexico" },
            new CountryModel() { Name = "Argentina" },
            new CountryModel() { Name = "Peru" }
        };
    }
}
