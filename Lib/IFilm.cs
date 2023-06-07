using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    interface IFilm
    {
        string Name { get; set; }

        string pause();
        string play();
    }
}
