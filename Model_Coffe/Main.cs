using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;

namespace Model_Coffe
{
    public partial class Main : Form
    {
        Water water;
        Air air;
        double k = 0;
        int plt_count = 0;
        public Main()
        {
            InitializeComponent();

        }

        private void WaterTemp_txtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar==',' || e.KeyChar == (char)Keys.Back || e.KeyChar==(char) Keys.Delete) return;
            else
                e.Handled = true;
        }

        private void AirTeamp_txtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete) return;
            else
                e.Handled = true;
        }

        private void DeltaTemp_txtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete) return;
            else
                e.Handled = true;
        }

        private void k_txtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete) return;
            else
                e.Handled = true;
        }

        private void MakeModel_btn_Click(object sender, EventArgs e)
        {
            formsPlot2.plt.Clear();
            plt_count = 0;
            double water_primary_temp = 0;
            double air_primary_temp = 0;
            if(Check(water_primary_temp, air_primary_temp))
            {
                Model m = new Model(water, air, k);
                m.calc();
                double[] water_temps = m.water.temperatures.ToArray();
                double[] air_temps = m.air.temperatures.ToArray();
                double[] universal_x = new double[water_temps.Length];
                
                for (int i = 0; i < universal_x.Length; i++)
                    universal_x[i] = i;

                formsPlot2.plt.PlotScatter(universal_x, water_temps, label: "Жидкость");
                formsPlot2.plt.PlotScatter(universal_x, air_temps, label: "Воздух");
                formsPlot2.plt.Title("Остывание кружки и нагревание воздуха");
                formsPlot2.plt.Legend();
                formsPlot2.Render();
                plt_count++;
            }
        }

        bool Check(double water_primary_temp, double air_primary_temp)
        {
            if (double.TryParse(WaterTemp_txtBx.Text, out water_primary_temp))
            {
                water = new Water(water_primary_temp);
            }
            else if (WaterTemp_txtBx.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \u0022Температура жидкости\u0022", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Заполните корректно поле \u0022Температура жидкости\u0022", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (double.TryParse(AirTeamp_txtBx.Text, out air_primary_temp))
            {
                air = new Air(air_primary_temp);
            }
            else if (AirTeamp_txtBx.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \u0022Температура среды\u0022", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Заполните корректно поле \u0022Температура среды\u0022", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (double.TryParse(k_txtBx.Text, out k)) { return true; }
            else if (k_txtBx.Text.Length > 0)
            {
                MessageBox.Show("Заполните корректно поле \u0022k\u0022", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Заполните поле \u0022k\u0022", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Add_model_Click(object sender, EventArgs e)
        {
            
            double water_primary_temp = 0;
            double air_primary_temp = 0;
            if (Check(water_primary_temp, air_primary_temp))
            {
                Model m = new Model(water, air, k);
                m.calc();
                double[] water_temps = m.water.temperatures.ToArray();
                double[] air_temps = m.air.temperatures.ToArray();
                double[] universal_x = new double[water_temps.Length];

                for (int i = 0; i < universal_x.Length; i++)
                    universal_x[i] = i;
                if (plt_count > 0)
                {
                    formsPlot2.plt.PlotScatter(universal_x, water_temps, label: "Жидкость "+plt_count.ToString());
                    formsPlot2.plt.PlotScatter(universal_x, air_temps, label: "Воздух " + plt_count.ToString());
                    formsPlot2.plt.Title("Остывание кружки и нагревание воздуха");
                    formsPlot2.plt.Legend();
                    formsPlot2.Render();
                }
                plt_count++;
            }
        }
    }
}
