namespace wFigurasGeometricas
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.cmbTipoFigura = new System.Windows.Forms.ComboBox();
            this.lblFigura = new System.Windows.Forms.Label();
            this.lblPosicionX = new System.Windows.Forms.Label();
            this.lblPosicionY = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPosicionX = new System.Windows.Forms.TextBox();
            this.txtPosicionY = new System.Windows.Forms.TextBox();
            this.txtContador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(140, 256);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(114, 35);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // cmbTipoFigura
            // 
            this.cmbTipoFigura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoFigura.FormattingEnabled = true;
            this.cmbTipoFigura.Location = new System.Drawing.Point(154, 64);
            this.cmbTipoFigura.Name = "cmbTipoFigura";
            this.cmbTipoFigura.Size = new System.Drawing.Size(121, 28);
            this.cmbTipoFigura.TabIndex = 1;
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFigura.Location = new System.Drawing.Point(66, 64);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(60, 20);
            this.lblFigura.TabIndex = 2;
            this.lblFigura.Text = "Figura";
            // 
            // lblPosicionX
            // 
            this.lblPosicionX.AutoSize = true;
            this.lblPosicionX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicionX.Location = new System.Drawing.Point(78, 128);
            this.lblPosicionX.Name = "lblPosicionX";
            this.lblPosicionX.Size = new System.Drawing.Size(21, 20);
            this.lblPosicionX.TabIndex = 3;
            this.lblPosicionX.Text = "X";
            // 
            // lblPosicionY
            // 
            this.lblPosicionY.AutoSize = true;
            this.lblPosicionY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicionY.Location = new System.Drawing.Point(78, 188);
            this.lblPosicionY.Name = "lblPosicionY";
            this.lblPosicionY.Size = new System.Drawing.Size(21, 20);
            this.lblPosicionY.TabIndex = 4;
            this.lblPosicionY.Text = "Y";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(297, 185);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(83, 20);
            this.lblContador.TabIndex = 5;
            this.lblContador.Text = "Contador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(343, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 56);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtPosicionX
            // 
            this.txtPosicionX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicionX.Location = new System.Drawing.Point(154, 122);
            this.txtPosicionX.Name = "txtPosicionX";
            this.txtPosicionX.Size = new System.Drawing.Size(100, 26);
            this.txtPosicionX.TabIndex = 7;
            // 
            // txtPosicionY
            // 
            this.txtPosicionY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicionY.Location = new System.Drawing.Point(154, 182);
            this.txtPosicionY.Name = "txtPosicionY";
            this.txtPosicionY.Size = new System.Drawing.Size(100, 26);
            this.txtPosicionY.TabIndex = 8;
            // 
            // txtContador
            // 
            this.txtContador.Location = new System.Drawing.Point(408, 188);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(100, 20);
            this.txtContador.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.txtPosicionY);
            this.Controls.Add(this.txtPosicionX);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblPosicionY);
            this.Controls.Add(this.lblPosicionX);
            this.Controls.Add(this.lblFigura);
            this.Controls.Add(this.cmbTipoFigura);
            this.Controls.Add(this.btnCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cmbTipoFigura;
        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.Label lblPosicionX;
        private System.Windows.Forms.Label lblPosicionY;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPosicionX;
        private System.Windows.Forms.TextBox txtPosicionY;
        private System.Windows.Forms.TextBox txtContador;
    }
}

