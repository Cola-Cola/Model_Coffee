using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Model_Coffe
{
    class Model
    {
        public Water water;
        public Air air;
        double k { get; set; }
        public Model(Water water_, Air air_, double k_)
        {
            water = water_;
            air = air_;
            k = k_;
        }

        public void test()
        {
            MessageBox.Show(water.primary_temp.ToString() + "   " + air.primary_temp.ToString() + "   " + k.ToString());
        }

        public void calc()
        {
            //int count = 0;
            while (Math.Round(water.current_temp, 8) != Math.Round(air.current_temp, 8))
            {
                water.current_temp = water.Next_temp(water.current_temp, air.current_temp, k);
                water.temperatures.Add(water.current_temp);

                air.current_temp =air.Next_temp(air.current_temp, water.primary_temp, k);
                air.temperatures.Add(air.current_temp);

                water.primary_temp = water.current_temp;
                //count++;
            }

            #if DEBUG
            MessageBox.Show(water.current_temp.ToString() + "   " + air.current_temp.ToString()/*+"   " +count.ToString()*/);
            #endif
        }
    }
}
