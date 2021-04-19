using System;
using System.Collections.Generic;
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

        private static OleDbConnection Link = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DocumentacionFacial.accdb;");
        public static string[] Nombre;
        private static byte[] Caras;
        public static List<byte[]> ListCaras = new List<byte[]>();
        public static int TotalCaras;

        public static bool GuardarImagen(string Nombre, byte[] Imagen)
        {

            Link.Open();
            OleDbCommand Comando = new OleDbCommand("INSERT INTO DatosFaciales ( Nombre, Foto ) VALUES ( '" + Nombre + "', ? );", Link);
            OleDbParameter ParImagen = new OleDbParameter("@Imagen", OleDbType.VarBinary, Imagen.Length);
            ParImagen.Value = Imagen;
            Comando.Parameters.Add(ParImagen);
            int Resultado = Comando.ExecuteNonQuery();
            Link.Close();

            return Convert.ToBoolean(Resultado);

        }

        public static void Eliminar()
        {

            Link.Open();
            OleDbCommand Comando = new OleDbCommand("DELETE FROM DatosFaciales WHERE  Nombre = ?;", Link);
            Comando.Parameters.Add(Nombre);
            Comando.ExecuteNonQuery();
            Link.Close();

        }

        public static DataTable Consulta(DataGridView DATA)
        {

            Link.Open();
            OleDbCommand Comando = new OleDbCommand("SELECT * FROM DatosFaciales", Link);
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

                    DATA.Rows[i].Height = 110;

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
