using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Collection : Comedy
    {
        public int numberOfViews { get; set; }
        public List<Comedy> films = new List<Comedy>();

        public Collection(int year, string filmName, string director,int views) : base(year, filmName, director)
        {
            this.numberOfViews = views;
        }

        public Collection() : base()
        {
            this.numberOfViews = 0;
        }


        public void addFilm(Comedy film)
        { 
           films.Add(film);
        }

        public string printFilms()
        {
            string res = "Фильмы коллекции: ";
            foreach(Comedy comedy in films) 
            {
                res += comedy.ToString();
            }
            return res;
        }

        public override string ToString() => $"[name: {name}, filmDirector: {Director}, age: {getAge()}] , views: {numberOfViews}]\n";

        public override string pause()
        {
            return "Сборник фильмов поставлен на паузу";
        }

        public override string play()
        {
            return "Начат просмотр сборника фильмов";
        }
    }
}
