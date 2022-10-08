using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10._5
{
    public class AccesLevelAttribute:Attribute
    {
        public AccesLevelType accesLevelType { get; }

        public AccesLevelAttribute(AccesLevelType accesLevelType)
        { this.accesLevelType = accesLevelType; }
    }
}
