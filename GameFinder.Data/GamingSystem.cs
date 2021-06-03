using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Data
{
    public enum System { PC = 0, Switch = 1, Xbox = 2, Playstation = 3 }
    public class GamingSystem
    {
        public System System { get; set; }
        public bool Console
        {
            get
            {
                if (System == System.PC)
                    return true;
                else
                    return false;
            }
        }
    }
}
