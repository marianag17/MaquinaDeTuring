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
using System.Reflection;

namespace ProyectoMT
{
    public partial class Form2 : Form
    {
        //variables globales a utilizar
        int estados = 0; //numero de estados
        int estadoInicial = 0; //estado inicial
        List<string> alfabeto = new List<string>(); //lista de alfabeto
        List<Transicion> transiciones = new List<Transicion>(); //lista de transiciones
        List<Estado> listaestados = new List<Estado>(); //lista de estados
        List<string> entrada = new List<string>(); //lista de caracteres en la entrada
        string entradatbx = ""; //string recibido de entrada
        int ini = 0; //posicion inicial de la lista 
        int pos = 0;
        int op = 0;
        int estactual = 1;
        bool terminado = false;
        bool correcto = false;
        public Form2(int opcion)
        {
            InitializeComponent();
            op = opcion;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            btnauto.Enabled = false;
            label5.Hide();
            btnstep.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) //leer archivo .txt
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;
            try
            {
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
                        textBox2.Text = filePath.ToString();
                        System.IO.StreamReader file = new System.IO.StreamReader(filePath);
                        while ((line = file.ReadLine()) != null)
                        {
                            counter++;
                            if (counter == 1)
                            {
                                estados = Convert.ToInt32(line);
                                for (int i = 1; i <= estados; i++)
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
                        button2.Enabled = true;
                        button1.Enabled = false;
                    }

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
                entrada.AddRange(entradatbx.Select(c => c.ToString()));
                entrada.Add("_");
                entrada.Add("_");
                entrada.Add("_");
                entrada.Add("_");
                lbllectura.Text = entrada[4];
                string texto = string.Join(" ", entrada);
                lblcinta.Text = texto;
            }
            btnstep.Enabled = true;
            btnauto.Enabled = true;
            label5.Show();
        }
        private void btnstep_Click(object sender, EventArgs e)
        {
            btnauto.Enabled = false;
            lecturastep(entrada, estactual, pos);
        }
        private void lecturastep(List<string> entradaa, int estadoa, int posicion)
        {
            
            bool terminado = false;
            bool correcto = false;
            string lectura = entrada[pos];
            int estadoActual = estadoa;
            foreach (var item in transiciones)
            {
                if (alfabeto.Contains(lectura)||lectura=="_")
                {
                    if (lectura == item.Leido && estadoActual == item.EstadoInicial)
                    {
                        correcto = true;
                        entrada[pos] = item.AEscribir;
                        lblescritura.Text = item.AEscribir;
                        lbllectura.Text = item.Leido;
                        string texto = string.Join(" ", entrada);
                        lblcinta.Text = texto;
                        estactual = item.EstadoFinal;
                        lblestadoactual.Text = Convert.ToString(item.EstadoFinal);
                        lblestadoanterior.Text = Convert.ToString(item.EstadoInicial);
                        if (item.Movimiento == "d" || item.Movimiento == "D")
                        {
                            
                            pos++;
                            label5.Location = new Point(label5.Location.X + 17, label5.Location.Y);
                            break;
                        }
                        if (item.Movimiento == "i" || item.Movimiento == "I")
                        {
                            pos--;
                            label5.Location = new Point(label5.Location.X - 17, label5.Location.Y);
                            break;
                        }
                        if (item.Movimiento == "0")
                        {
                            label5.Location = new Point(label5.Location.X, label5.Location.Y);
                            break;
                        }
                        if (item.Movimiento == "p" || item.Movimiento == "P")
                        {
                            MessageBox.Show("TERMINADO");
                            terminado = true;
                            btnstep.Enabled = false;
                        }
                    }
                    else
                    {
                        correcto = false;
                    }
                }
                else
                {
                    correcto = false;
                    break;
                }
            }
            if (!correcto && !terminado)
            {
                if (op == 1)
                {
                    MessageBox.Show("PALABRA NO ACEPTADA POR EL LENGUAJE", "AVISO");
                    btnstep.Enabled = false;
                }
                else
                {
                    MessageBox.Show("ENTRADA NO VÁLIDA","AVISO");
                    btnstep.Enabled = false;
                }
            }
            if (op == 3)
            {
                if (entrada.Contains("S") && entrada.Contains("I"))
                {
                    MessageBox.Show("SI ( ♥ ͜ʖ ♥)", "AVISO");
                    btnstep.Enabled = false;
                }
                if (entrada.Contains("N") && entrada.Contains("O"))
                {
                    MessageBox.Show("NO ಠ╭╮ಠ", "AVISO");
                    btnstep.Enabled = false;
                }
            }
        }
        private bool sigue(Transicion trans)
        {
            if (trans.Movimiento == "p" || trans.Movimiento == "P")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void leer(int posicion, int estadoactual)
        {
            label5.Hide();
            int estadoActual = estadoactual;
            string lectura = entrada[posicion];
            foreach (var item in transiciones)
            {
                if (alfabeto.Contains(lectura)||lectura=="_") 
                { 
                    if (!terminado)
                    {
                        if (lectura == item.Leido && estadoActual == item.EstadoInicial)
                        {
                            correcto = true;
                            entrada[posicion] = item.AEscribir;
                            lblescritura.Text = item.AEscribir;
                            estadoActual = item.EstadoFinal;
                            string texto = string.Join(" ", entrada);
                            lblcinta.Text = texto;
                            if (sigue(item))
                            {
                                terminado = false;
                                if (item.Movimiento == "d" || item.Movimiento == "D")
                                {
                                    lbllectura.Text = entrada[posicion + 1];
                                    lblestadoanterior.Text = Convert.ToString(estadoActual);
                                    leer(posicion + 1, item.EstadoFinal);
                                }
                                if (item.Movimiento == "i" || item.Movimiento == "I")
                                {
                                    lbllectura.Text = entrada[posicion - 1];
                                    lblestadoanterior.Text = Convert.ToString(estadoActual);
                                    leer(posicion - 1, item.EstadoFinal);
                                }
                                if (item.Movimiento == "0")
                                {
                                    lbllectura.Text = entrada[posicion];
                                    lblestadoanterior.Text = Convert.ToString(estadoActual);
                                    leer(posicion, item.EstadoFinal);
                                }
                            }
                            else
                            {
                                terminado = true;
                                MessageBox.Show("TERMINADO");
                                break;
                            }
                        }
                        else
                        {
                            correcto = false;
                        }
                    }
                    else { break; }
                }
                else
                {
                    correcto = false;
                    terminado = true;
                    break;
                }
                
            }
        }
        private void mensaje(bool cor, bool ter)
        {
            
            if (!cor && ter)
            {
                if (op == 1)
                {
                    MessageBox.Show("PALABRA NO ACEPTADA POR EL LENGUAJE", "AVISO");
                    btnstep.Enabled = false;
                }
                else
                {
                    MessageBox.Show("ENTRADA NO VÁLIDA", "AVISO");
                    btnstep.Enabled = false;
                }
            }
            if (op == 3 && ter)
            {
                if (entrada.Contains("S") && entrada.Contains("I"))
                {
                    MessageBox.Show("SI ( ♥ ͜ʖ ♥)", "AVISO");
                    btnstep.Enabled = false;
                }
                if (entrada.Contains("N") && entrada.Contains("O"))
                {
                    MessageBox.Show("NO ಠ╭╮ಠ", "AVISO");
                    btnstep.Enabled = false;
                }
            }
        }
        private void btnauto_Click(object sender, EventArgs e)
        {
            leer(ini, estadoInicial);
            mensaje(correcto, terminado);
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2(op);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
