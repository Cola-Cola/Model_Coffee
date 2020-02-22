using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Coffe
{
    class Water : Object
    {
        public List<double> temperatures = new List<double>();

        public Water(double primary_temp) {
            base.primary_temp = primary_temp;
            base.current_temp = primary_temp;
        }

        public double Next_temp(double primary_temp, double air_temp, double k)
        {
            return primary_temp - (primary_temp - air_temp) * k;
        }
    }
}
