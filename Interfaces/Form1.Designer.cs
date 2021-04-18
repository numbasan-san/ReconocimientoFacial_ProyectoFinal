
namespace ProyectoFinal_ReconocimientoFacial.CS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.IBX_Camara = new Emgu.CV.UI.ImageBox();
            this.BTN_Registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Cantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IBX_Camara)).BeginInit();
            this.SuspendLayout();
            // 
            // IBX_Camara
            // 
            this.IBX_Camara.Location = new System.Drawing.Point(36, 62);
            this.IBX_Camara.Name = "IBX_Camara";
            this.IBX_Camara.Size = new System.Drawing.Size(319, 302);
            this.IBX_Camara.TabIndex = 2;
            this.IBX_Camara.TabStop = false;
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.Location = new System.Drawing.Point(483, 231);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(116, 34);
            this.BTN_Registrar.TabIndex = 3;
            this.BTN_Registrar.Text = "Registrar";
            this.BTN_Registrar.UseVisualStyleBackColor = true;
            this.BTN_Registrar.Click += new System.EventHandler(this.BTN_Registrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detecciones:";
            // 
            // LBL_Cantidad
            // 
            this.LBL_Cantidad.AutoSize = true;
            this.LBL_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Cantidad.Location = new System.Drawing.Point(581, 143);
            this.LBL_Cantidad.Name = "LBL_Cantidad";
            this.LBL_Cantidad.Size = new System.Drawing.Size(18, 20);
            this.LBL_Cantidad.TabIndex = 5;
            this.LBL_Cantidad.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBL_Cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Registrar);
            this.Controls.Add(this.IBX_Camara);
            this.Name = "Form1";
            this.Text = "Reconocimiento Facial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IBX_Camara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_Registrar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LBL_Cantidad;
        public Emgu.CV.UI.ImageBox IBX_Camara;
    }
}

