// ACÁ SE USA Backend.buscar(), LA FUNCIÓN BUSCAR QUE ESTÁ EN BACKEND.CS
using tp1;
using tpfinal;
using System.Runtime.InteropServices;

namespace tpfinal
{
    public partial class Form1 : Form
    {
        private int ocurrencias = 1;
        public Form1()
        {
            InitializeComponent();
		}
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Cuando se toca el botón 1, con el click iquierdo, se ejecuta la función Backend.buscar(), que hace ???
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            List<ListItem> lista = new List<ListItem>();
            List<Dato> collected = new List<Dato>();

            Backend.buscar(heapOp.Checked, ocurrencias, collected); // Llama a buscar(), le pasa como parámetros si está marcado el Método "Heap", ocurrencias (La barrita deslizable de la interfaz que dice "Resultados: x") y collected, lista vacía de Dato(s), que luego vuelve con los resultados de los elementos más repetidos

            flowLayoutPanel1.Controls.Clear();
            
            foreach (var datoDistancia in collected)
            {
                ListItem item = new ListItem();
                item.Dato = datoDistancia;
                item.Width = flowLayoutPanel1.Width - 25;
                lista.Add(item);
                flowLayoutPanel1.Controls.Add(item);
            }
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_consulta1_Click(object sender, EventArgs e)
        {
            string resultado = Backend.todasLasPredicciones();
            this.mostrarConsulta(resultado);

        }

        private void btn_consulta2_Click(object sender, EventArgs e)
        {
            string resultado = Backend.caminoAPrediccion();
            this.mostrarConsulta(resultado);
        }

        private void btn_consulta3_Click(object sender, EventArgs e)
        {
            string resultado = Backend.aProfundidad();
            this.mostrarConsulta(resultado);
        }

        private void mostrarConsulta(string resultado)
        {
            Consultas consulta = new Consultas(this, resultado);
            consulta.Show();
            this.Hide();
        }

        /*private void teclaPressed(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13 && textBox1.Text.Trim().Length > 0)
            {
                button1_Click_1(sender, e);
            }
        }*/

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtDist.Text = "Resultados: " + trackBar1.Value;
            ocurrencias = trackBar1.Value; // ACÁ SE DEFINE OCURRENCIAS
        }

        private void txtDist_TextChanged(object sender, EventArgs e)
        {

        }
    }


}