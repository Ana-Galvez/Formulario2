namespace Formulario2
{
    partial class frmIngresoYMuestraDeDatos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar = new Button();
            btnCalculo = new Button();
            lblDato1 = new Label();
            lblDato2 = new Label();
            txtDato2 = new TextBox();
            txtDato1 = new TextBox();
            btnAceptarCuadroTexto = new Button();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 192, 0);
            btnAceptar.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.FromArgb(0, 0, 192);
            btnAceptar.Location = new Point(327, 230);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(149, 39);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCalculo
            // 
            btnCalculo.BackColor = Color.FromArgb(192, 192, 0);
            btnCalculo.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btnCalculo.ForeColor = Color.FromArgb(0, 0, 192);
            btnCalculo.Location = new Point(327, 292);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(149, 39);
            btnCalculo.TabIndex = 1;
            btnCalculo.Text = "CALCULO";
            btnCalculo.UseVisualStyleBackColor = false;
            // 
            // lblDato1
            // 
            lblDato1.AutoSize = true;
            lblDato1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblDato1.Location = new Point(166, 102);
            lblDato1.Name = "lblDato1";
            lblDato1.Size = new Size(85, 24);
            lblDato1.TabIndex = 2;
            lblDato1.Text = "DATO 1";
            // 
            // lblDato2
            // 
            lblDato2.AutoSize = true;
            lblDato2.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblDato2.Location = new Point(166, 132);
            lblDato2.Name = "lblDato2";
            lblDato2.Size = new Size(85, 24);
            lblDato2.TabIndex = 3;
            lblDato2.Text = "DATO 2";
            // 
            // txtDato2
            // 
            txtDato2.Font = new Font("Arial", 15.75F);
            txtDato2.Location = new Point(276, 132);
            txtDato2.Name = "txtDato2";
            txtDato2.Size = new Size(274, 32);
            txtDato2.TabIndex = 4;
            // 
            // txtDato1
            // 
            txtDato1.Font = new Font("Arial", 15.75F);
            txtDato1.Location = new Point(276, 97);
            txtDato1.Name = "txtDato1";
            txtDato1.Size = new Size(274, 32);
            txtDato1.TabIndex = 5;
            // 
            // btnAceptarCuadroTexto
            // 
            btnAceptarCuadroTexto.BackColor = Color.FromArgb(192, 192, 0);
            btnAceptarCuadroTexto.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btnAceptarCuadroTexto.ForeColor = Color.FromArgb(0, 0, 192);
            btnAceptarCuadroTexto.Location = new Point(551, 230);
            btnAceptarCuadroTexto.Name = "btnAceptarCuadroTexto";
            btnAceptarCuadroTexto.Size = new Size(149, 101);
            btnAceptarCuadroTexto.TabIndex = 6;
            btnAceptarCuadroTexto.Text = "ACEPTAR CUADRO DE TEXTO";
            btnAceptarCuadroTexto.UseVisualStyleBackColor = false;
            btnAceptarCuadroTexto.Click += btnAceptarCuadroTexto_Click;
            // 
            // frmIngresoYMuestraDeDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptarCuadroTexto);
            Controls.Add(txtDato1);
            Controls.Add(txtDato2);
            Controls.Add(lblDato2);
            Controls.Add(lblDato1);
            Controls.Add(btnCalculo);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmIngresoYMuestraDeDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INGRESO Y MUESTRA DE DATOS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCalculo;
        private Label lblDato1;
        private Label lblDato2;
        private TextBox txtDato2;
        private TextBox txtDato1;
        private Button btnAceptarCuadroTexto;
    }
}
