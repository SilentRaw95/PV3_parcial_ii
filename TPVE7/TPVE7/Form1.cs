using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPVE7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validation = true;
            if (campo_nombre.Text.Equals(""))
            {
                validation = false;
            }
            if (campo_fecha.Text.Equals(""))
            {
                validation = false;
            }
            if (campo_entrada.Text.Equals(""))
            {
                validation = false;
            }
            if (campo_salida.Text.Equals(""))
            {
                validation = false;
            }
            if (validation == false)
            {
                MessageBox.Show("Faltan campos por completar");
            }
            else
            {
                string file = "prankbro.txt";
                if (!File.Exists(file))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(file))
                    {
                        sw.WriteLine();
                        sw.WriteLine(campo_nombre.Text);
                        sw.WriteLine(campo_fecha.Text);
                        sw.WriteLine(campo_entrada.Text);
                        sw.WriteLine(campo_salida.Text);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(file))
                    {
                        sw.WriteLine();
                        sw.WriteLine(campo_nombre.Text);
                        sw.WriteLine(campo_fecha.Text);
                        sw.WriteLine(campo_entrada.Text);
                        sw.WriteLine(campo_salida.Text);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool validation = true;
            if (campo_nombre.Text.Equals(""))
            {
                validation = false;
            }
            if (validation == false)
            {
                MessageBox.Show("Faltan campos por completar");
            }
            else
            {
                // Open the file to read from.
                using (StreamReader sr = File.OpenText("prankbro.txt"))
                {
                    string s = "";
                    bool xd = false;
                    //datos
                    string nombre = "";
                    string fecha = "";
                    string entrada = "";
                    string salida = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (s.Equals(campo_nombre.Text))
                        {
                            xd = true;
                            //datos
                            nombre = s;
                            fecha = sr.ReadLine();
                            entrada = sr.ReadLine();
                            salida = sr.ReadLine();
                        }
                    }
                    if(xd == true)
                    {
                        MessageBox.Show("Nombre: "+nombre+"\nFecha: "+fecha+"\nEntrada: "+entrada+"\nSalida: "+salida);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
