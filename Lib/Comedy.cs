using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Comedy : USSRFilm
    {

        public Comedy(int year, string filmName, string director) : base(year, filmName, director) {}

        public Comedy() : base()
        {

        }


        public override string ToString()
        {
            return $"[name: {name}, filmDirector: {Director}, age: {getAge()}]\n";
        }

        public override string pause()
        {
            return "Комедия поставлена на паузу"; 
        }

        public override string play()
        {
            return "Начат просмотр комедии" ;
        }
    }
}
