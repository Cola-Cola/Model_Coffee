using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Coffe
{
    class Air:Object
    {
        public List<double> temperatures = new List<double>();

        public Air(double primary_temp) {
            base.primary_temp = primary_temp;
            base.current_temp = primary_temp;
        }

        public double Next_temp(double primary_temp, double water_temp, double k)
        {
            return primary_temp + (water_temp - primary_temp) * k;
        }
    }
}
