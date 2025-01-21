using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOA_BT1
{
    /// <summary>
    /// Summary description for ServerRef
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServerRef : System.Web.Services.WebService
    {

        public readonly DatabaseManager _db;
        public ServerRef()
        {
            _db = new DatabaseManager();
        }
        [WebMethod]
        public string GreetWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<country> GetCountries()
        {
            return _db.GetCountries();
        }

        [WebMethod]
        public List<country> GetCountryByCode(string code)
        {
            return _db.GetCountryByCode(code);
        }

        [WebMethod]
        public List<city> GetCitiesByName(string name)
        {
            return _db.GetCitiesByName(name);
        }

        [WebMethod]
        public List<city> GetCitiesByCountry(string countryName)
        {
            return _db.GetCitiesByCountry(countryName);
        }

        [WebMethod]
        public long PopulationOfCountry(string countryName)
        {
            return _db.GetPopulationOfCountry(countryName);
        }

        [WebMethod]
        public List<city> GetCityByPopulation(int minPopulation, int maxPopulation)
        {
            return _db.GetCityByPopulation(minPopulation, maxPopulation);
        }

        [WebMethod]
        public List<string> OfficialLanguagesOfCountries(string countryCode)
        {
            return _db.GetOfficialLanguagesOfCountries(countryCode);
        }
    }

    public class DatabaseManager
    {
        private MyWorldEntities _databaseContext;
        public DatabaseManager()
        {
            _databaseContext = new MyWorldEntities();
        }
        public List<country> GetCountries()
        {
            return _databaseContext.countries.Take(50).ToList();
        }
        public List<country> GetCountryByCode(string code)
        {
            return _databaseContext.countries.Where(c => c.Code == code).ToList();
        }
        public List<city> GetCitiesByName(string name)
        {
            return _databaseContext.cities.Where(c => c.Name == name).ToList();
        }
        public List<city> GetCitiesByCountry(string countryName)
        {
            return _databaseContext.countries
                .Where(c => c.Name == countryName)
                .Join(
                    _databaseContext.cities,
                    country => country.Code,
                    city => city.CountryCode,
                    (country, city) => city
                )
                .ToList();
        }

        public long GetPopulationOfCountry(string countryName)
        {
            return _databaseContext.countries
                .Where(c => c.Name == countryName)
                .Select(c => c.Population)
                .FirstOrDefault();
        }

        public List<city> GetCityByPopulation(int minPopulation, int maxPopulation)
        {
            return _databaseContext.cities
                .Where(c => c.Population >= minPopulation && c.Population <= maxPopulation)
                .ToList();
        }

        public List<string> GetOfficialLanguagesOfCountries(string countryCode)
        {
            return _databaseContext.countrylanguages
                .Where(cl => cl.CountryCode == countryCode && cl.IsOfficial == "T")
                .Select(cl => cl.Language)
                .ToList();
        }
    }
    

}
