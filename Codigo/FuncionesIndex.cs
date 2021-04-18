using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using ProyectoFinal_ReconocimientoFacial.CS.BaseDatos;

namespace ProyectoFinal_ReconocimientoFacial.CS.Codigo
{
    class FuncionesIndex
    {

        //Vectores y Marcadores
        int Con = 0;
        Image<Bgr, Byte> currentFrame;
        Capture Grabar;
        HaarCascade Face;//Rostro
        MCvFont Font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.4d, 0.4d);
        Image<Gray, byte> Result = null;
        Image<Gray, byte> Gray = null;
        List<Image<Gray, byte>> TrainingImage = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NombrePersonas = new List<string>();
        int ContTrain, NumLabels, T;
        string Nombre;
        DataGridView D = new DataGridView();
        DataBase DataBase = new DataBase();
        Form1 Index = new Form1();

        public void Deteccion()
        {

            Face = new HaarCascade("haarcascade_frontalface_default.xml");
            try
            {

                DataBase.Consulta(D);
                string[] Labels = DataBase.Nombre;
                NumLabels = DataBase.TotalCaras;
                ContTrain = NumLabels;

                for (int i = 0; i < NumLabels; i++)
                {

                    Con = i;
                    Bitmap BMP = new Bitmap(DataBase.ConvertBinaryToImg(Con));
                    TrainingImage.Add(new Image<Gray, byte>(BMP));
                    labels.Add(Labels[i]);

                }

            }
            catch (Exception)
            {

                MessageBox.Show("No hay rostros a cargar.");

            }
        }

        public void FrameGrabar(object Sendet, EventArgs e)
        {

            Index.LBL_Cantidad.Text = "0";
            NombrePersonas.Add("");

            try
            {

                currentFrame = Grabar.QueryFrame().Resize(320, 240, INTER.CV_INTER_CUBIC);
                Gray = currentFrame.Convert<Gray, Byte>();
                MCvAvgComp[][] Detecciones = Gray.DetectHaarCascade(Face, 1.5, 10, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

                foreach (MCvAvgComp R in Detecciones[0])
                {

                    T = T++;
                    Result = currentFrame.Copy(R.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                    currentFrame.Draw(R.rect, new Bgr(Color.Green), 1);

                    if (TrainingImage.ToArray().Length != 0)
                    {

                        MCvTermCriteria Criterio = new MCvTermCriteria(ContTrain, 0.88);
                        EigenObjectRecognizer Recogida = new EigenObjectRecognizer(TrainingImage.ToArray(), labels.ToArray(), ref Criterio);
                        var FA = new Image<Gray, byte>[TrainingImage.Count];
                        Nombre = Recogida.Recognize(Result);
                        currentFrame.Draw(Nombre, ref Font, new Point(R.rect.X - 2, R.rect.Y - 2), new Bgr(Color.Green));

                    }

                    NombrePersonas[T - 1] = Nombre;
                    NombrePersonas.Add("");
                    Index.LBL_Cantidad.Text = Detecciones[0].Length.ToString();

                }

                T = 0;
                Index.IBX_Camara.Image = currentFrame;
                Nombre = "";
                NombrePersonas.Clear();

            }
            catch (Exception Error)
            {

                MessageBox.Show(Error.Message);

            }

        }

        public void Reconocer()
        {

            try
            {

                Grabar = new Capture();
                Grabar.QueryFrame();
                Application.Idle += new EventHandler(FrameGrabar);

            }
            catch (Exception Error)
            {

                MessageBox.Show(Error.Message);

            }

        }
        public void DetenerReconocer()
        {

            try
            {

                Application.Idle -= new EventHandler(FrameGrabar);
                Grabar.Dispose();

            }
            catch (Exception Error)
            {

                MessageBox.Show(Error.Message);

            }

        }


    }
}