using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BeerCollection
    {
        public List<Beer> MyBeers { get; set; }
        public BeerCollection(List<Beer> myBeers)
        {
            MyBeers=new List<Beer>(myBeers);
           
        }


    }
}
