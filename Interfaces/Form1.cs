using System;
using System.Windows.Forms;
using ProyectoFinal_ReconocimientoFacial.CS.Codigo;

namespace ProyectoFinal_ReconocimientoFacial.CS
{
    public partial class Form1 : Form
    {

        FuncionesIndex Funcion = new FuncionesIndex();

        public Form1()
        {
            InitializeComponent();
            Funcion.Deteccion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Funcion.Reconocer ();

        }

        private void BTN_Registrar_Click(object sender, EventArgs e)
        {

            Registro_Facial Show = new Registro_Facial ();
            Funcion.DetenerReconocer ();
            this.Hide ();
            Show.ShowDialog ();
            this.Visible = true;
            Funcion.Reconocer ();

        }
        
    }
}
