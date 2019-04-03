using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightLiftingCalculator
{
    class Exercise
    {
        public string Name { get; private set; }
        public DateTime Date { get; private set; }
        public float weightlb { get; private set; }

        public Exercise(string newName, DateTime newDate, float weightInLb)
        {
            Name = newName;
            Date = newDate;
            weightlb = weightInLb;
            
        }
    }
}
