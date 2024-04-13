using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConvert
{
    public partial class unit_conversion : Form
    {
        public unit_conversion()
        {
            InitializeComponent();
            //InitializeComponent();
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.SizableToolWindow;//.None;
           this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_fa_Click(object sender, EventArgs e)
        {
            float f = 0;
            try { f = float.Parse(txt_fa.Text);
            }
            catch { MessageBox.Show("TRY NUMBERS ONLY ");
            }
            
            float c = 5f / 9f*(f-32f)  ;
            txt_cel.Text = c.ToString();
            double k =(f-32)*5/9+273.15;
             txt_kel.Text = k.ToString();

        }

        private void btn_cel_Click(object sender, EventArgs e)
        {
            float c = 0;
            try
            {
                c = float.Parse(txt_cel.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            float f = c*(9f/5f)+32;
            txt_fa.Text = f.ToString();
            double k = c+ 273.15;
            txt_kel.Text = k.ToString();
        }

        private void btn_kel_Click(object sender, EventArgs e)
        {
            float k = 0;
            try
            {
                k= float.Parse(txt_kel.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            double c = k-273.15;
            txt_cel.Text = c.ToString();
            double f = (k-273.15)*(9f/5f)+32;
            txt_fa.Text = f.ToString();
        }

        private void btn_m_Click(object sender, EventArgs e)
        {

            float m = 0;
            try
            {
                m = float.Parse(txt_m.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            float cm =m*100 ;
            txt_cm.Text = cm.ToString();
            float km = m*(1/1000f);
            txt_km.Text = km.ToString();
            double foot = m *3.28084;
            txt_foot.Text = foot.ToString();
            double i = m *39.37008;
            txt_in.Text = i.ToString();

        }

        private void btn_cm_Click(object sender, EventArgs e)
        {

            float cm = 0;
            try
            {
                cm = float.Parse(txt_cm.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            float m= cm *(1/ 100f);
            txt_m.Text = m.ToString();
            double km = cm * (1 / 100000d);
            txt_km.Text = km.ToString();
            double foot = cm * 3.0328084;
            txt_foot.Text = foot.ToString();
            double i =cm * 0.3937008;
            txt_in.Text = i.ToString();
        }

        private void btn_km_Click(object sender, EventArgs e)
        {

            float km = 0;
            try
            {
                km= float.Parse(txt_km.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            float m = km * 1000;
            txt_m.Text = m.ToString();
            float cm = km * 100000;
            txt_cm.Text = cm.ToString();
            double foot = km * 3280.84;
            txt_foot.Text = foot.ToString();
            double i = km * 39370.08;
            txt_in.Text = i.ToString();
        }

        private void btn_foot_Click(object sender, EventArgs e)
        {

            float foot = 0;
            try
            {
                foot = float.Parse(txt_foot.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            double m = foot * 0.3048;
            txt_m.Text = m.ToString();
            double cm = foot * 30.48;
            txt_cm.Text = cm.ToString();
            double km = foot * 0.00030479;
            txt_km.Text = km.ToString();
            double i = foot * 11.99;
            txt_in.Text = i.ToString();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {

            float i = 0;
            try
            {
                i = float.Parse(txt_in.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            double cm = i * 2.54;
            txt_cm.Text = cm.ToString();
            double km = i*0.0000254;
            txt_km.Text = km.ToString();
            double foot = i * 0.08333;
            txt_foot.Text = foot.ToString();
            double m = i* 0.0254;
            txt_m.Text = m.ToString();
        }

        private void btn_g_Click(object sender, EventArgs e)
        {
            float g = 0;
            try
            {
                g = float.Parse(txt_g.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            double mg = g * 0.001;
            txt_mg.Text = mg.ToString();
            double kg = g * 1000;
            txt_kg.Text = kg.ToString();
            double ca = g * 5;
            txt_carat.Text = ca.ToString();
            
        }

        private void btn_mg_Click(object sender, EventArgs e)
        {

            float mg = 0;
            try
            {
                mg = float.Parse(txt_mg.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            double g = mg * 0.001;
            txt_g.Text = mg.ToString();
            double kg = mg * 0.000001;
            txt_kg.Text = kg.ToString();
            double ca = mg *0.005;
            txt_carat.Text = ca.ToString();

        }

        private void btn_kg_Click(object sender, EventArgs e)
        {

            float kg = 0;
            try
            {
                kg = float.Parse(txt_kg.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            double mg = kg *1000000;
            txt_mg.Text = mg.ToString();
            float g = kg * 1000;
            txt_g.Text = g.ToString();
            float ca = kg * 5000;
            txt_carat.Text = ca.ToString();

        }

        private void btn_carat_Click(object sender, EventArgs e)
        {

            float ca= 0;
            try
            {
              ca = float.Parse(txt_carat.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            float mg = ca *200;
            txt_mg.Text = mg.ToString();
            double kg = ca * 0.002;
            txt_kg.Text = kg.ToString();
            double g = ca * 0.2;
            txt_g.Text = g.ToString();

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_cub_m_Click(object sender, EventArgs e)
        {
            float cum = 0;
            try
            {
                cum = float.Parse(txt_cub_m.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            double cucm = cum *1000000;
            txt_cub_cm.Text = cucm.ToString();
            double li = cum *1000 ;
            txt_l.Text = li.ToString();
            double ml = cum * 1000000;
            txt_ml.Text = ml.ToString();
            double cin= cum *61023.74;
            txt_cub_in.Text = cin.ToString();
        }

        private void btn_cub_cm_Click(object sender, EventArgs e)
        {
            float cucm = 0;
            try
            {
                cucm = float.Parse(txt_cub_cm.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            double cum = cucm * 0.0000001;
            txt_cub_m.Text = cum.ToString();
            double li = cucm * 0.001;
            txt_l.Text = li.ToString();
            double ml = cucm *1;
            txt_ml.Text = ml.ToString();
            double cin = cucm * 0.06102;
            txt_cub_in.Text = cin.ToString();
        }

        private void btn_cub_mm_Click(object sender, EventArgs e)
        {
            float li = 0;
            try
            {
                li = float.Parse(txt_l.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            double cucm = li * 1000;
            txt_cub_cm.Text = cucm.ToString();
            double cum = li * 0.001;
            txt_cub_m.Text = cum.ToString();
            double ml = li * 1000;
            txt_ml.Text = ml.ToString();
            double cin =li* 61.0237;
            txt_cub_in.Text = cin.ToString();
        }

        private void btn_l_Click(object sender, EventArgs e)
        {
            float ml = 0;
            try
            {
                ml = float.Parse(txt_ml.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            double cum = ml * 0.000001;
            txt_cub_m.Text = cum.ToString();
            double li = ml * 0.001;
            txt_l.Text = li.ToString();
            double cucm = ml * 1;
            txt_cub_cm.Text = cucm.ToString();
            double cin = ml *0.06102;
            txt_cub_in.Text = cin.ToString();
        }

        private void btn_cub_in_Click(object sender, EventArgs e)
        {
            float cin = 0;
            try
            {
                cin = float.Parse(txt_cub_in.Text);
            }
            catch
            {
                MessageBox.Show("TRY NUMBERS ONLY ");
            }

            double cucm = cin * 16.38706;
            txt_cub_cm.Text = cucm.ToString();
            double li = cin * 0.01638;
            txt_l.Text = li.ToString();
            double ml = cin * 16.38706;
            txt_ml.Text = ml.ToString();
            double cum = cin * 0.00001638;
            txt_cub_m.Text = cum.ToString();
        }

        private void lable_Click(object sender, EventArgs e)
        {

        }
    }
}
