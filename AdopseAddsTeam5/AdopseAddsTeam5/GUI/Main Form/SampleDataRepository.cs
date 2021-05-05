using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopseAddsTeam5.GUI.Main_Form
{
    class SampleDataRepository
    {
        public static Adds Get(int id)
        {
            return GetAll().SingleOrDefault(x => x.sid.Equals(id));
        }

        public static List<Adds> GetAll()
        {
            return new List<Adds>
            {
                new Adds { sid = 1, perioxi = "toumpa", title = "diamerisma", eidos ="polisi", emvadon = 85 , mpanio = "1", timi = 70000, ypnodomatia = "2" },
                new Adds { sid = 2, perioxi = "xarilaou", title = "monokatikia", eidos ="polisi", emvadon = 75 , mpanio = "", timi = 60000, ypnodomatia = "2" },
                new Adds { sid = 3, perioxi = "kalamaria", title = "diamerisma", eidos ="polisi", emvadon = 65 , mpanio = "1", timi = 50000, ypnodomatia = "1" },
                new Adds { sid = 4, perioxi = "sikies", title = "monokatikia", eidos ="polisi", emvadon = 105 , mpanio = "2", timi = 90000, ypnodomatia = "3" },
                new Adds { sid = 5, perioxi = "kentro", title = "diamerisma", eidos ="polisi", emvadon = 95 , mpanio = "2", timi = 80000, ypnodomatia = "2" },
            };


        }
    }
}
