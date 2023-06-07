using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    abstract class USSRFilm : IFilm
    {
        protected string name;
        protected int Year { get; set; }
        public string Director { get; set; }
        public string Name { get => name; set => name = value; }

        public USSRFilm(int year, string filmName, string director)
        {
            name = filmName;
            Year = year;
            Director = director;
        }
        public USSRFilm()
        {
            name = "default name";
            Year = DateTime.Now.Year;
            Director = "Somebody";
        }

        public abstract string pause();
        public abstract string play();

        public double getAge()
        {
            return DateTime.Now.Year - this.Year;
        }

    }
}
