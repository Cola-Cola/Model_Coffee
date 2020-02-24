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
        int plt_count1 = 0;
        int plt_count2 = 0;
        int plt_count3 = 0;
        int plt_count4 = 0;
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
            formsPlot1.plt.Clear();
            formsPlot2.plt.Clear();
            formsPlot3.plt.Clear();
            formsPlot4.plt.Clear();
            plt_count1 = 0;
            double water_primary_temp = 0;
            double air_primary_temp = 0;

            if (Check(water_primary_temp, air_primary_temp))
            {
                Model InRoom = new Model(water, air, k);
                InRoom.calc_in_room();

                double room_temp = double.Parse(AirTeamp_txtBx.Text);
                double[] water_temps = InRoom.water.temperatures.ToArray();
                double[] room_temps = new double[water_temps.Length];
                double[] universal_x = new double[water_temps.Length];

                for (int i = 0; i < universal_x.Length; i++)
                    universal_x[i] = i;

                for (int i = 0; i < room_temps.Length; i++)
                    room_temps[i] = room_temp;

                formsPlot1.plt.PlotScatter(universal_x, water_temps, label: "Жидкость");
                formsPlot1.plt.PlotStep(universal_x, room_temps, label: "Воздух");
                formsPlot1.plt.Title("Остывание кружки температура в комнате");
                formsPlot1.plt.Legend();
                formsPlot1.Render();
                plt_count1++;
                GC.Collect();
            }

            water_primary_temp = 0;
            air_primary_temp = 0;
            if (Check(water_primary_temp, air_primary_temp))
            {
                Model Near_water = new Model(water, air, k);
                Near_water.calc_near_water();

                double[] water_temps = Near_water.water.temperatures.ToArray();
                double[] air_temps_near_water = Near_water.air.temperatures.ToArray();
                double[] universal_x = new double[water_temps.Length];

                for (int i = 0; i < universal_x.Length; i++)
                    universal_x[i] = i;

                formsPlot2.plt.PlotScatter(universal_x, water_temps, label: "Жидкость");
                formsPlot2.plt.PlotScatter(universal_x, air_temps_near_water, label: "Воздух");
                formsPlot2.plt.Title("Остывание кружки и нагревание под крышкой");
                formsPlot2.plt.Legend();
                formsPlot2.Render();
                plt_count2++;
                GC.Collect();
            }

            water_primary_temp = 0;
            air_primary_temp = 0;
            if (Check(water_primary_temp, air_primary_temp))
            {
                Model heating = new Model(water, air, k);
                heating.calc_with_heating();

                double room_temp = double.Parse(AirTeamp_txtBx.Text);
                double[] water_temps = heating.water.temperatures.ToArray();
                double[] room_temps = new double[water_temps.Length];
                double[] universal_x = new double[water_temps.Length];

                for (int i = 0; i < universal_x.Length; i++)
                    universal_x[i] = i;

                for (int i = 0; i < room_temps.Length; i++)
                    room_temps[i] = room_temp;

                formsPlot3.plt.PlotStep(universal_x, water_temps, label: "Жидкость");
                formsPlot3.plt.PlotStep(universal_x, room_temps, label: "Воздух");
                formsPlot3.plt.Title("Остывание кружки температура в комнате");
                formsPlot3.plt.Legend();
                formsPlot3.Render();
                plt_count3++;
                GC.Collect();
            }

            water_primary_temp = 0;
            air_primary_temp = 0;
            if (Check(water_primary_temp, air_primary_temp))
            {
                Model cooling = new Model(water, air, k);
                cooling.calac_with_cooling();

                double room_temp = double.Parse(AirTeamp_txtBx.Text);
                double[] water_temps = cooling.water.temperatures.ToArray();
                double[] room_temps = new double[water_temps.Length];
                double[] universal_x = new double[water_temps.Length];

                for (int i = 0; i < universal_x.Length; i++)
                    universal_x[i] = i;

                for (int i = 0; i < room_temps.Length; i++)
                    room_temps[i] = room_temp;

                formsPlot4.plt.PlotScatter(universal_x, water_temps, label: "Жидкость");
                formsPlot4.plt.PlotStep(universal_x, room_temps, label: "Воздух");
                formsPlot4.plt.Title("Остывание кружки температура в комнате");
                formsPlot4.plt.Legend();
                formsPlot4.Render();
                plt_count4++;
                GC.Collect();
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
                Model InRoom = new Model(water, air, k);
                InRoom.calc_in_room();

                double room_temp = double.Parse(AirTeamp_txtBx.Text);
                double[] water_temps = InRoom.water.temperatures.ToArray();
                double[] room_temps = new double[water_temps.Length];
                double[] universal_x = new double[water_temps.Length];

                for (int i = 0; i < universal_x.Length; i++)
                    universal_x[i] = i;

                for (int i = 0; i < room_temps.Length; i++)
                    room_temps[i] = room_temp;

                formsPlot1.plt.PlotScatter(universal_x, water_temps, label: "Жидкость "+ plt_count1.ToString());
                formsPlot1.plt.PlotStep(universal_x, room_temps, label: "Воздух " + plt_count1.ToString());

                formsPlot1.plt.Title("Остывание кружки температура в комнате");
                formsPlot1.plt.Legend();
                formsPlot1.Render();
                plt_count1++;
                GC.Collect();
            }

            water_primary_temp = 0;
            air_primary_temp = 0;
            if (Check(water_primary_temp, air_primary_temp))
            {
                Model m = new Model(water, air, k);
                m.calc_near_water();
                double[] water_temps = m.water.temperatures.ToArray();
                double[] air_temps = m.air.temperatures.ToArray();
                double[] universal_x = new double[water_temps.Length];

                for (int i = 0; i < universal_x.Length; i++)
                    universal_x[i] = i;
                
                formsPlot2.plt.PlotScatter(universal_x, water_temps, label: "Жидкость "+plt_count2.ToString());
                formsPlot2.plt.PlotScatter(universal_x, air_temps, label: "Воздух " + plt_count2.ToString());
                formsPlot2.plt.Title("Остывание кружки и нагревание воздуха");
                formsPlot2.plt.Legend();
                formsPlot2.Render();
                plt_count2++;
            }

            water_primary_temp = 0;
            air_primary_temp = 0;
            if (Check(water_primary_temp, air_primary_temp))
            {
                Model heating = new Model(water, air, k);
                heating.calc_with_heating();

                double room_temp = double.Parse(AirTeamp_txtBx.Text);
                double[] water_temps = heating.water.temperatures.ToArray();
                double[] room_temps = new double[water_temps.Length];
                double[] universal_x = new double[water_temps.Length];

                for (int i = 0; i < universal_x.Length; i++)
                    universal_x[i] = i;

                for (int i = 0; i < room_temps.Length; i++)
                    room_temps[i] = room_temp;

                formsPlot3.plt.PlotStep(universal_x, water_temps, label: "Жидкость " + plt_count3.ToString());
                formsPlot3.plt.PlotStep(universal_x, room_temps, label: "Воздух " + plt_count3.ToString());
                formsPlot3.plt.Title("Остывание кружки температура в комнате");
                formsPlot3.plt.Legend();
                formsPlot3.Render();
                plt_count3++;
                GC.Collect();
            }

            water_primary_temp = 0;
            air_primary_temp = 0;
            if (Check(water_primary_temp, air_primary_temp))
            {
                Model cooling = new Model(water, air, k);
                cooling.calac_with_cooling();

                double room_temp = double.Parse(AirTeamp_txtBx.Text);
                double[] water_temps = cooling.water.temperatures.ToArray();
                double[] room_temps = new double[water_temps.Length];
                double[] universal_x = new double[water_temps.Length];

                for (int i = 0; i < universal_x.Length; i++)
                    universal_x[i] = i;

                for (int i = 0; i < room_temps.Length; i++)
                    room_temps[i] = room_temp;

                formsPlot4.plt.PlotScatter(universal_x, water_temps, label: "Жидкость "+plt_count4.ToString());
                formsPlot4.plt.PlotStep(universal_x, room_temps, label: "Воздух " + plt_count4.ToString());
                formsPlot4.plt.Title("Остывание кружки температура в комнате");
                formsPlot4.plt.Legend();
                formsPlot4.Render();
                plt_count4++;
                GC.Collect();
            }
        }
    }
}
