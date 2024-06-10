using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorting
{
    //Here I'm defining the interface in which I'm gonna use as a strategy for sorting 
    public interface SortingStratInterface
    {
        string Sort(string input);
    }
}
