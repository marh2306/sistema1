using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        Negocio neg = new Negocio();
        Entidad ent = new Entidad();

        public Form1()
        {
            InitializeComponent();
        }


        public void suma()
        {
            try
            {
                ent.a = Convert.ToDouble(textBox1.Text);
                ent.b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = neg.N_suma(ent).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            suma();
        }
    }
}
