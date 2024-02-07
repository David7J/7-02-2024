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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Enabled = false;
            txt2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kg, lib, gr;
            
                kg = double.Parse(Entnum.Text);
                if (kg <= 0 || kg > 1000)
                {
                    MessageBox.Show("No puede ser negativo ni cero, ni mayor a 1,000");
                    Entnum.Text = "";

                }
                else
                {
                    if (Articulo.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar un articulo");
                    }
                    else
                    {
                        if (Articulo.SelectedItem.Equals("Ladrillo"))
                        {
                            lib = kg * 2.20462;
                            gr = kg * 1000;
                            txt1.Text = lib.ToString();
                            txt2.Text = gr.ToString();
                    }
                        else
                        {
                            if (Articulo.SelectedItem.Equals("Bolsa de cemento"))
                            {
                                lib = kg * 2.20462;
                                gr = kg * 1000;
                                txt1.Text = lib.ToString();
                                txt2.Text = gr.ToString();
                        }
                            else
                            {
                                if (Articulo.SelectedItem.Equals("Piedrin"))
                                {
                                    lib = kg * 2.20462;
                                    gr = kg * 1000;
                                    txt1.Text = lib.ToString();
                                    txt2.Text = gr.ToString();
                                }
                            }
                        }
                    }
                }


           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entnum.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            Entnum.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
