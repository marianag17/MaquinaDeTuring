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
using ProyectoMT;

namespace ProyectoMT
{
    public partial class Form2 : Form
    {
        int estados = 0;
        int estadoInicial = 0;
        List<string> alfabeto = new List<string>();
        List<Transicion> transiciones = new List<Transicion>();
        List<Estado> listaestados = new List<Estado>();
        List<string> entrada = new List<string>();
        string entradatbx = "";

        int op = 0;
        public Form2(int opcion)
        {
            InitializeComponent();
            op = opcion;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) //leer archivo .txt
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;
            try {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    string line = "";
                    int counter = 0;
                    char delimitador = ',';
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                        System.IO.StreamReader file = new System.IO.StreamReader(filePath);
                        while ((line = file.ReadLine()) != null)
                        {
                            counter++;
                            if (counter == 1)
                            {
                                estados = Convert.ToInt32(line);
                                for (int i = 0; i < estados; i++)
                                {
                                    Estado estado = new Estado(i);
                                    listaestados.Add(estado);
                                }
                            }
                            if (counter == 2)
                            {
                                estadoInicial = Convert.ToInt32(line);
                            }
                            if (counter == 3)
                            {
                                alfabeto.AddRange(line.Select(c => c.ToString()));
                            }
                            else if (counter > 3)
                            {
                                string[] trans = line.Split(delimitador);
                                Transicion transicion = new Transicion(Convert.ToInt32(trans[0]), trans[1],
                                Convert.ToInt32(trans[2]), trans[3], trans[4]);
                                transiciones.Add(transicion);
                            }
                        }
                        file.Close();
                    }
                    button2.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Error en la lectura del archivo", "ERROR");
            }
        }

        private void button2_Click(object sender, EventArgs e) //inicializar entrada
        {
            entradatbx = textBox1.Text;
            if (entradatbx == "")
            {
                MessageBox.Show("Entrada vacía no válida", "ERROR");
            }
            else
            {
                lblestadoactual.Text = Convert.ToString(estadoInicial);
                entrada.Add("_");
                entrada.Add("_");
                entrada.Add("_");
                entrada.Add("_");
                entrada.AddRange(entradatbx.Select(c => c.ToString()));
                entrada.Add("_");
                entrada.Add("_");
                entrada.Add("_");
                entrada.Add("_");
                lbllectura.Text = entrada[4];
                string texto = string.Join(" ", entrada);
                lblcinta.Text = texto;
            }
        }

        private void btnstep_Click(object sender, EventArgs e)
        {
            //bool correcto = true, completado = false;

            //while (correcto && !completado)
            //{
            //    //foreach (var item in transiciones)
            //    //{
            //    //    if (lbllectura.Text==item.Leido && lblestadoactual.Text==Convert.ToString(item.EstadoInicial))
            //    //    {

            //    //    }
            //    //}
            //}
        }
    }
}
