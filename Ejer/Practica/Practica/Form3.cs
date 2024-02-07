using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Dep : Form
    {
        public Dep()
        {
            InitializeComponent();
        }

        private void Dep_Load(object sender, EventArgs e)
        {
            text1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double eq, tot, dep;

            eq = double.Parse(Num.Text);
            if (eq <= 0 || eq > 300000)
            {
                MessageBox.Show("No puede ser cero ni negativo, ni mayor a 300,000");
                Num.Text = "";
            }
            else
            {
                if (cmb1.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una opcion");
                }
                else
                {
                    if (cmb1.SelectedItem.Equals("Equipos Industriales") || cmb1.SelectedItem.Equals("Muebles") && cmb2.SelectedItem.Equals("1-2"))
                    {
                        tot = eq * 0.10;
                        dep = tot / 2;
                        text1.Text = dep.ToString();
                    }
                    else
                    {
                        if (cmb1.SelectedItem.Equals("Equipos Industriales") || cmb1.SelectedItem.Equals("Muebles") && cmb2.SelectedItem.Equals("1-5"))
                        {
                            MessageBox.Show("La opcion no es valida");
                        }
                        else
                        {
                            if(cmb1.SelectedItem.Equals("Vehiculo") && cmb2.SelectedItem.Equals("1-5"))
                            {
                                tot = eq * 0.10;
                                dep = tot / 5;
                                text1.Text = dep.ToString();
                            }
                            else
                            {
                                if (cmb1.SelectedItem.Equals("Vehiculo") && cmb2.SelectedItem.Equals("1-2"))
                                {
                                    MessageBox.Show("La opcion no es valida");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
