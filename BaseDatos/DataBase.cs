using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ProyectoFinal_ReconocimientoFacial.CS.BaseDatos
{
    class DataBase
    {

        private static OleDbConnection Link = new OleDbConnection("Provider = _________;Data Source = _________.____;");
        public static string[] Nombre;
        private static byte[] Caras;
        public static List<byte[]> ListCaras = new List<byte[]>();
        public static int TotalCaras;

        public static bool GuardarImagen(string Nombre, byte[] Imagen)
        {

            /*--------- Hay que hacerle una base de datos, pero aún no se la hago.
             Será cuando prenda la PC que la crearé con SQLServer o algo, ya le preguntaré a Megumin
             o al profesor, uno u otro, ya "ahorita vemos que pedo".jpg
             Las columnas de la tabla son ID, Nombre e Imagen; esto lo hago para evitar errores o
             contratiempos. Y otra cosa y es que no te fijes en los errores que se muestran en el código,
             solo están ahí por no haber una base de datos creada a la cual se puedan ligar. Como ya 
             dije "ahorita vemos que pedo".jpg
             Hasta entonces, lo dejo aquí y veré si lo logro terminara para el domingo a mas tardar. Mejor 
             será o sería si fuere el sábado. Sarabada ---------*/

            Link.Open();
            OleDbCommand Comando = new OleDbCommand("INSERT INTO ______ ( Nombre, Imagen ) VALUES ('" + Nombre
                + "', ?);");
            OleDbParameter ParImagen = new OleDbParameter("@Imagen", OleDbType.VarBinary, Imagen.Length);
            ParImagen.Value = Imagen;
            Comando.Parameters.Add(Imagen);
            int Resultado = Comando.ExecuteNonQuery();
            Link.Close();

            return Convert.ToBoolean(Resultado);

        }

        public static DataTable Consulta(DataGridView DATA)
        {

            Link.Open();
            OleDbCommand Comando = new OleDbCommand("SELECT * FROM _____", Link);
            OleDbDataAdapter DA = new OleDbDataAdapter(Comando);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            DATA.DataSource = DT;
            int Cont = DT.Rows.Count;
            Nombre = new string[Cont];

            for (int i = 0; i < Cont; i++)
            {

                Nombre[i] = DT.Rows[i]["Nombre"].ToString();
                Caras = (byte[])DT.Rows[i]["Imagen"];
                ListCaras.Add(Caras);

            }

            try
            {

                DATA.Columns[0].Width = 60;
                DATA.Columns[1].Width = 160;
                DATA.Columns[2].Width = 160;

                for (int i = 0; i < Cont; i++)
                {

                    DATA.Columns[1].Height = 110;

                }

            }
            catch { }

            TotalCaras = Cont;
            Link.Close();
            return DT;

        }

        public static byte[] ConvertingToBinary(Image img)
        {

            Bitmap BMP = new Bitmap(img);
            MemoryStream Memoria = new MemoryStream();
            BMP.Save(Memoria, ImageFormat.Bmp);

            byte[] imagen = Memoria.ToArray();
            return imagen;

        }

        public static Image ConvertBinaryToImg(int C)
        {

            Image Imagen;
            byte[] img = ListCaras[C];
            MemoryStream Memoria = new MemoryStream(img);
            Imagen = Image.FromStream(Memoria);
            Memoria.Close();
            return Imagen;

        }

    }
}
