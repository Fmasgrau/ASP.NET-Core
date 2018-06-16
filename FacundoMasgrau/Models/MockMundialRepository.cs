using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FacundoMasgrau.Models
{
    public class MockMundialRepository : IMundialRepository
    {
        private List<Mundial> _mundiales;

        public MockMundialRepository()
        {
            if (_mundiales == null)
            {
                InitializeMundials();
            }
        }

        private void InitializeMundials()
        {
            _mundiales = new List<Mundial> {

                new Mundial { Id = 1, Año = "1930", Sede = "Uruguay", Campeon = "Uruguay", Subcampeon = "Argentina" },
                new Mundial { Id = 2, Año = "1934", Sede = "Italia", Campeon = "Italia", Subcampeon = "Checoslovaquia" },
                new Mundial { Id = 3, Año = "1938", Sede = "Francia", Campeon = "Italia", Subcampeon = "Hungria" },
                new Mundial { Id = 4, Año = "1950", Sede = "Brasil", Campeon = "Uruguay", Subcampeon = "Brasil" },
                new Mundial { Id = 5, Año = "1954", Sede = "Suiza", Campeon = "Alemania", Subcampeon = "Hungria" },
                new Mundial { Id = 6, Año = "1958", Sede = "Suecia", Campeon = "Brasil", Subcampeon = "Suecia" },
                new Mundial { Id = 7, Año = "1962", Sede = "Chile", Campeon = "Brasil", Subcampeon = "Checoslovaquia" },
                new Mundial { Id = 8, Año = "1968", Sede = "Inglaterra", Campeon = "Inglaterra", Subcampeon = "Alemania" },
                new Mundial { Id = 9, Año = "1972", Sede = "Mexico", Campeon = "Brasil", Subcampeon = "Italia" },
                new Mundial { Id = 10, Año = "1974", Sede = "Alemania", Campeon = "Alemania", Subcampeon = "Holanda" },
                new Mundial { Id = 11, Año = "1978", Sede = "Argentina", Campeon = "Argentina", Subcampeon = "Holanda" },
                new Mundial { Id = 12, Año = "1982", Sede = "España", Campeon = "Italia", Subcampeon = "Alemania" },
                new Mundial { Id = 13, Año = "1986", Sede = "Mexico", Campeon = "Argentina", Subcampeon = "Alemania" },
                new Mundial { Id = 14, Año = "1990", Sede = "Italia", Campeon = "Alemania", Subcampeon = "Argentina" },
                new Mundial { Id = 15, Año = "1994", Sede = "Estados Unidos", Campeon = "Brasil", Subcampeon = "Italia" },
                new Mundial { Id = 16, Año = "1998", Sede = "Francia", Campeon = "Francia", Subcampeon = "Brasil" },
                new Mundial { Id = 17, Año = "2002", Sede = "Corea Japon", Campeon = "Brasil", Subcampeon = "Alemania" },
                new Mundial { Id = 18, Año = "2006", Sede = "Alemania", Campeon = "Italia", Subcampeon = "Francia" },
                new Mundial { Id = 19, Año = "2010", Sede = "Sudafrica", Campeon = "España", Subcampeon = "Holanda" },
                new Mundial { Id = 20, Año = "2014", Sede = "Brasil", Campeon = "Alemania", Subcampeon = "Argentina" },
            };
        }

        public Mundial GetMundialById(int mundialId)
        {
            return _mundiales.FirstOrDefault(m => m.Id == mundialId);
        }

        public IEnumerable<Mundial> GetAllMundials()
        {
            return _mundiales;
        }
    }
}
