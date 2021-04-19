using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal_ReconocimientoFacial.CS.BaseDatos;
using ProyectoFinal_ReconocimientoFacial.CS.Codigo;

namespace ProyectoFinal_ReconocimientoFacial.CS
{
    public partial class Registro_Facial : Form
    {

        FuncionesRegistro Registro = new FuncionesRegistro();
        DataBase DataBase = new DataBase();

        public Registro_Facial()
        {

            InitializeComponent();
            Registro.Deteccion();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { /* Generado por accidente */ }

        private void Registro_Facial_Load(object sender, EventArgs e)
        {

            Registro.Reconocer();
            DataBase.Consulta(DGV_Historial);

        }

        private void Registro_Facial_FormClosing(object sender, FormClosingEventArgs e)
        {

            Registro.DetenerReconocer();

        }

        private void BTN_Capturar_Click(object sender, EventArgs e)
        {

            Registro.Capturar();

        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {

            DataBase.Eliminar();
            DataBase.Consulta(DGV_Historial);

        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {

            Form1 Show = new Form1();
            Registro.DetenerReconocer();
            this.Hide();
            Show.ShowDialog();
            this.Visible = true;
            Registro.Reconocer();

        }
    }
}
