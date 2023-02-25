using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Roof
{
    public class RoofFactory : IAbstractRoof
    {
        public int GetColor()
        {
            return 1;
        }
    }
}
