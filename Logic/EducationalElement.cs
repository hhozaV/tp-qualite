using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class EducationalElement
    {
        private string name;
        private float coef;

        public EducationalElement(string name, float coef)
        {
            Name = name;
            Coef = coef;
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The name must not be empty");
                }
                name = value;
            }
        }

        public float Coef
        {
            get => coef;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("The coef must be > 0");
                }
                coef = value;
            }
        }
    }
}
