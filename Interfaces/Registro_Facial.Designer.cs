
namespace ProyectoFinal_ReconocimientoFacial.CS
{
    partial class Registro_Facial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.IBX_Camara = new Emgu.CV.UI.ImageBox();
            this.DGV_Historial = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Registrar = new System.Windows.Forms.Button();
            this.BTN_Capturar = new System.Windows.Forms.Button();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.LBL_Cantidad = new System.Windows.Forms.Label();
            this.IBX_Foto = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.IBX_Camara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IBX_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // IBX_Camara
            // 
            this.IBX_Camara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IBX_Camara.Location = new System.Drawing.Point(49, 92);
            this.IBX_Camara.Name = "IBX_Camara";
            this.IBX_Camara.Size = new System.Drawing.Size(324, 345);
            this.IBX_Camara.TabIndex = 2;
            this.IBX_Camara.TabStop = false;
            // 
            // DGV_Historial
            // 
            this.DGV_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Historial.Location = new System.Drawing.Point(778, 92);
            this.DGV_Historial.Name = "DGV_Historial";
            this.DGV_Historial.RowHeadersWidth = 51;
            this.DGV_Historial.RowTemplate.Height = 24;
            this.DGV_Historial.Size = new System.Drawing.Size(329, 345);
            this.DGV_Historial.TabIndex = 5;
            this.DGV_Historial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nuevo Registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Captura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(775, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Registros Realizados:";
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.Location = new System.Drawing.Point(425, 465);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(110, 43);
            this.BTN_Registrar.TabIndex = 9;
            this.BTN_Registrar.Text = "Registrar";
            this.BTN_Registrar.UseVisualStyleBackColor = true;
            // 
            // BTN_Capturar
            // 
            this.BTN_Capturar.Location = new System.Drawing.Point(157, 465);
            this.BTN_Capturar.Name = "BTN_Capturar";
            this.BTN_Capturar.Size = new System.Drawing.Size(100, 43);
            this.BTN_Capturar.TabIndex = 10;
            this.BTN_Capturar.Text = "Capturar";
            this.BTN_Capturar.UseVisualStyleBackColor = true;
            this.BTN_Capturar.Click += new System.EventHandler(this.BTN_Capturar_Click);
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.Location = new System.Drawing.Point(624, 465);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(107, 43);
            this.BTN_Cancelar.TabIndex = 11;
            this.BTN_Cancelar.Text = "Cancelar";
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(425, 404);
            this.TXT_Nombre.Multiline = true;
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(305, 32);
            this.TXT_Nombre.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre:";
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.Location = new System.Drawing.Point(879, 465);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(130, 43);
            this.BTN_Eliminar.TabIndex = 14;
            this.BTN_Eliminar.Text = "Eliminar";
            this.BTN_Eliminar.UseVisualStyleBackColor = true;
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_Eliminar_Click);
            // 
            // LBL_Cantidad
            // 
            this.LBL_Cantidad.AutoSize = true;
            this.LBL_Cantidad.Location = new System.Drawing.Point(154, 72);
            this.LBL_Cantidad.Name = "LBL_Cantidad";
            this.LBL_Cantidad.Size = new System.Drawing.Size(16, 17);
            this.LBL_Cantidad.TabIndex = 15;
            this.LBL_Cantidad.Text = "0";
            // 
            // IBX_Foto
            // 
            this.IBX_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IBX_Foto.Location = new System.Drawing.Point(425, 92);
            this.IBX_Foto.Name = "IBX_Foto";
            this.IBX_Foto.Size = new System.Drawing.Size(306, 266);
            this.IBX_Foto.TabIndex = 2;
            this.IBX_Foto.TabStop = false;
            // 
            // Registro_Facial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 599);
            this.Controls.Add(this.IBX_Foto);
            this.Controls.Add(this.LBL_Cantidad);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_Nombre);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.BTN_Capturar);
            this.Controls.Add(this.BTN_Registrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Historial);
            this.Controls.Add(this.IBX_Camara);
            this.Name = "Registro_Facial";
            this.Text = "Registro Facial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registro_Facial_FormClosing);
            this.Load += new System.EventHandler(this.Registro_Facial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IBX_Camara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IBX_Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Capturar;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_Eliminar;
        public System.Windows.Forms.Label LBL_Cantidad;
        public Emgu.CV.UI.ImageBox IBX_Camara;
        public Emgu.CV.UI.ImageBox IBX_Foto;
        public System.Windows.Forms.TextBox TXT_Nombre;
        public System.Windows.Forms.Button BTN_Registrar;
        public System.Windows.Forms.DataGridView DGV_Historial;
    }
}