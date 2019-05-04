using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixMaster_Mix_Calc
{
    public partial class Form1 : Form
    {
        float CORE_DROP_RATE = 4.5f; // 4.5x 

        public void DropCore()
        {
            float MyHeroRate = 1.0f;
            double baserate = MyHeroRate * CORE_DROP_RATE;

        } 



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();


            long MyBase = (long)0x66666667;

            int Core1_lv = int.Parse(textBox1.Text); // lv do core 1
            int Core2_lv = int.Parse(textBox2.Text); // lv do core 2

            int Core1_lvmax = int.Parse(textBox4.Text); // lv do core 1
            int Core2_lvmax = int.Parse(textBox5.Text); // lv do core 2

            int CoreA = (100 * Core1_lv / (Core1_lvmax)); // 100 * CoreLv / CoreLvBase
            int CoreB = (100 * Core2_lv / (Core2_lvmax)); // 100 * CoreLv / CoreLvBase

            int MediaCoresLv = (Core1_lv + Core2_lv) / 2; // media do lv dos cores



            // abaixo esta o calculo em modo binário
            int teste = (int)((double)(CoreA + CoreB) * 0.05);
            int MixResult = ((int)((long)(MyBase * (CoreA + CoreB)) >> 32) >> 3) + MediaCoresLv;
        

            textBox3.AppendText(Environment.NewLine + "Result: " + MixResult.ToString());


        }
    }
}
