using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Unit : EducationalElement
    {
        public List<Module> Modules { get; set; } = new List<Module>();

        public Unit(string name, float coef) : base(name, coef)
        {
        }
    }
}
