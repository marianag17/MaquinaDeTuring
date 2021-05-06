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
        int pos = 0; //posición inicial de lectura paso por paso
        int op = 0;  //opción (MTA, MTD, MTF)
        int estactual = 1; //estado actual
        bool terminado = false; //si la lectura ha terminado
        bool correcto = false; //si la lectura es correcta
        public Form2(int opcion) //inicialización del form2 con la opción seleccionada como parámetro
        {
            InitializeComponent();
            op = opcion;
        }

        private void Form2_Load(object sender, EventArgs e) //al cargar ciertos botones y labels están desactivados
        {
            button2.Enabled = false;
            btnauto.Enabled = false;
            label5.Hide();
            btnstep.Enabled = false;
            textBox2.Enabled = false;
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
                            counter++; //contador de la línea
                            if (counter == 1) //primera línea=cantidad de estados
                            {
                                estados = Convert.ToInt32(line);
                                for (int i = 1; i <= estados; i++)
                                {
                                    Estado estado = new Estado(i);
                                    listaestados.Add(estado);
                                }
                            }
                            if (counter == 2) //segunda línea estado inicial
                            {
                                estadoInicial = Convert.ToInt32(line);
                            }
                            if (counter == 3) //tercera línea = alfabeto de la máquina
                            {
                                alfabeto.AddRange(line.Select(c => c.ToString()));
                            }
                            else if (counter > 3) //resto de líneas son las transiciones
                            {
                                string[] trans = line.Split(delimitador);
                                Transicion transicion = new Transicion(Convert.ToInt32(trans[0]), trans[1],
                                Convert.ToInt32(trans[2]), trans[3], trans[4]);
                                transiciones.Add(transicion);
                            }
                        }
                        file.Close(); //cierra el archivo
                        button2.Enabled = true; //permite ingresar entrada
                        button1.Enabled = false;  //desactiva el botón de archivo
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error en la lectura del archivo", "ERROR"); //mensaje de error de archivo
            }
        }

        private void button2_Click(object sender, EventArgs e) //inicializar entrada
        {
            entradatbx = textBox1.Text; //entrada a variable
            if (entradatbx == "") //no acepta entradas vacías
            {
                MessageBox.Show("Entrada vacía no válida", "ERROR");
            }
            else 
            {
                lblestadoactual.Text = Convert.ToString(estadoInicial);
                entrada.AddRange(entradatbx.Select(c => c.ToString())); //se agregan espacios vacíos a la izquierda para simular máquina de turing "infinita"
                entrada.Add("_");
                entrada.Add("_");
                entrada.Add("_");
                entrada.Add("_");
                lbllectura.Text = entrada[0]; 
                string texto = string.Join(" ", entrada);
                lblcinta.Text = texto; //se muestra el texto en el label
            }
            btnstep.Enabled = true; // se activan los botones de lectura
            btnauto.Enabled = true;
            label5.Show(); //se muestra el cabezal de la MT
        }
        private void btnstep_Click(object sender, EventArgs e)
        {
            btnauto.Enabled = false; //si se realiza la lectura paso por paso se desactiva la lectura automática
            lecturastep(entrada, estactual, pos); //se hace la lectura mandando como parámetro la entrada, el estado actual y la posición actual
        }
        private void lecturastep(List<string> entradaa, int estadoa, int posicion) //parámetros para la lectura paso por paso
        {
            
            bool terminado = false; //bool para determinar si ya está terminada la lectura
            bool correcto = false; //y ver si está correcta la entrada
            string lectura = entrada[pos]; //lectura del caracter específico
            int estadoActual = estadoa; //estado actual, estado inicial cuando es la primera iteración
            foreach (var item in transiciones) //se revisa entre todas las transiciones
            {
                if (alfabeto.Contains(lectura)||lectura=="_") //si el caracter pertenece al alfabeto se continúa
                {
                    if (lectura == item.Leido && estadoActual == item.EstadoInicial) //si el aracter coincide con la lectura de la transición
                        //y si el estado inicial de la transición coincide con el estado actual se procede
                    {
                        correcto = true; //por el momento es correcta la lectura
                        entrada[pos] = item.AEscribir; //ahora se cambia el caracter en la entrada por el caracter de escritura en dicha transición
                        lblescritura.Text = item.AEscribir; //se escribe en los labels lo que se escribe y lo que se lee
                        lbllectura.Text = item.Leido;
                        string texto = string.Join(" ", entrada); 
                        lblcinta.Text = texto; //se actualiza la cinta
                        estactual = item.EstadoFinal; //ahora el estado actual será el estado final de la transición
                        lblestadoactual.Text = Convert.ToString(item.EstadoFinal); //se muestra el estado actual
                        lblestadoanterior.Text = Convert.ToString(item.EstadoInicial); //se muestra el estado anterior
                        if (item.Movimiento == "d" || item.Movimiento == "D") //si el movimiento indica que es hacia la derecha
                        {
                            pos++; //se aumenta en 1 la posición
                            label5.Location = new Point(label5.Location.X + 17, label5.Location.Y); //se mueve el cabezal a la derecha
                            break;
                        }
                        if (item.Movimiento == "i" || item.Movimiento == "I") //si el movimiento indica que es hacia la izquierda
                        {
                            pos--; //se resta en 1 la posición
                            label5.Location = new Point(label5.Location.X - 17, label5.Location.Y); //se mueve el cabezal hacia la izq
                            break; 
                        }
                        if (item.Movimiento == "0") //si no hay movimeinto
                        {
                            label5.Location = new Point(label5.Location.X, label5.Location.Y); //el cabezal se queda igual
                            break;
                        }
                        if (item.Movimiento == "p" || item.Movimiento == "P") //si se para es porque se terminó la lectura
                        {
                            if (op == 1)
                            {
                                MessageBox.Show("PALABRA ACEPTADA POR EL LENGUAJE ( ♥ ͜ʖ ♥)","AVISO");
                                correcto = true;
                                terminado = true;
                                btnstep.Enabled = false;//ya no se puede dar más pasos
                            }
                            else
                            {
                                MessageBox.Show("TERMINADO ( ♥ ͜ʖ ♥)", "AVISO");
                                correcto = true;
                                terminado = true;
                                btnstep.Enabled = false;//ya no se puede dar más pasos
                            }
                        }
                    }
                    else
                    {
                        correcto = false; //por ahora no es correcto
                    }
                }
                else
                {
                    correcto = false; //no es correcta la entrada
                    break;
                }
            }
            if (!correcto && !terminado) //si no ha terminado y no es correcto
            {
                if (op == 1)
                {
                    MessageBox.Show("PALABRA NO ACEPTADA POR EL LENGUAJE ಠ╭╮ಠ", "AVISO"); //no se acepta la palabra
                    btnstep.Enabled = false; 
                }
                else
                {
                    MessageBox.Show("ENTRADA NO VÁLIDA ಠ╭╮ಠ", "AVISO"); //no es válida la entrada
                    btnstep.Enabled = false;
                }
            }
            if (op == 3) //si es una MTD 
            {
                if (entrada.Contains("S") && entrada.Contains("I")) //si al final contiene "SI"
                {
                    MessageBox.Show("SI ( ♥ ͜ʖ ♥)", "AVISO");
                    btnstep.Enabled = false;
                }
                if (entrada.Contains("N") && entrada.Contains("O")) //si al final contiene "NO"
                {
                    MessageBox.Show("NO ಠ╭╮ಠ", "AVISO");
                    btnstep.Enabled = false;
                }
            }
        }
        private bool sigue(Transicion trans) //función para verificar si el proceso de lectura automático sigue o no
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

        private void leer(int posicion, int estadoactual) //lectura automática de la entrada, recursivo
        {
            label5.Hide(); //se esconde el cabezal ya que no se irá viendo por dónde va
            int estadoActual = estadoactual; //estado actual
            string lectura = entrada[posicion]; //lectura de caracter individual
            foreach (var item in transiciones) //para cada transición se hará lo siguiente
            { 
                if (alfabeto.Contains(lectura)||lectura=="_") //si el caracter pertenece al alfabeto continúa
                { 
                    if (!terminado) //si no está terminado el proceso
                    {
                        if (lectura == item.Leido && estadoActual == item.EstadoInicial) //si coincide el caracter con la lectura de la transición
                            //y si coincide el estado actual con el estado inicial de la transición
                        {
                            correcto = true; //por ahora es correcto
                            entrada[posicion] = item.AEscribir; //entrada en label de escritura
                            lblescritura.Text = item.AEscribir;
                            estadoActual = item.EstadoFinal; //se actualiza el estado actual
                            string texto = string.Join(" ", entrada); //se muestra la cinta actualizada
                            lblcinta.Text = texto; 
                            if (sigue(item)) //si no ha terminado entonces
                            {
                                terminado = false; //terminado es falso
                                if (item.Movimiento == "d" || item.Movimiento == "D") //si el movimiento es a la derecha
                                {
                                    lbllectura.Text = entrada[posicion + 1]; //se actualiza la entrada
                                    lblestadoanterior.Text = Convert.ToString(estadoActual);  //se actualiza el estado anterior
                                    leer(posicion + 1, item.EstadoFinal); //se hace una llamada recursiva al método 
                                }
                                if (item.Movimiento == "i" || item.Movimiento == "I")//si el movimiento es a la izq
                                {
                                    lbllectura.Text = entrada[posicion - 1];//se actualiza la entrada
                                    lblestadoanterior.Text = Convert.ToString(estadoActual); //se actualiza el estado anterior
                                    leer(posicion - 1, item.EstadoFinal);//se hace una llamada recursiva al método 
                                }
                                if (item.Movimiento == "0")//si no hay movimiento 
                                {
                                    lbllectura.Text = entrada[posicion];//se actualiza la entrada
                                    lblestadoanterior.Text = Convert.ToString(estadoActual);//se actualiza el estado anterior
                                    leer(posicion, item.EstadoFinal);//se hace una llamada recursiva al método 
                                }
                            }
                            else
                            {
                                terminado = true; //si no sigue, quiere decir que está terminado
                                if (op == 1)
                                {
                                    MessageBox.Show("PALABRA ACEPTADA POR EL LENGUAJE ( ♥ ͜ʖ ♥)", "AVISO");
                                }
                                if (op == 2)
                                {
                                    MessageBox.Show("TERMINADO ( ♥ ͜ʖ ♥)", "AVISO");
                                }
                                break;
                            }
                        }
                        else
                        {
                            correcto = false; //falso por ahora
                        }
                    }
                    else { break; }
                }
                else
                {
                    correcto = false; //si no pertenece al alfabeto
                    terminado = true;
                    break;
                }
                
            }
        }
        private void mensaje(bool cor, bool ter) //método para mensaje ya que si se incluye en "leer" se muestra en cada iteración
        {
            
            if (!cor && ter) //si no está correcto pero está terminado
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
            if (op == 3 && ter) //si está terminado y es MTD
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
        private void btnauto_Click(object sender, EventArgs e) //botón de lectura automática de la entrada
        {
            leer(ini, estadoInicial);
            btnauto.Enabled = false;
            mensaje(correcto, terminado);

        }

        private void btnstop_Click(object sender, EventArgs e) //si se quiere parar se abrirá una ventana nueva, vacía
        {
            this.Hide();
            var form2 = new Form2(op);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //si se quiere regresar al menú principal
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
