namespace Polinomios
{
    partial class FrmPolinomios
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
            label1 = new Label();
            txtCoeficiente = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtExponente = new TextBox();
            cmbPolinomio = new ComboBox();
            btnAgregar = new Button();
            lblPolinomio1 = new Label();
            lblPolinomio2 = new Label();
            lblPolinomioR = new Label();
            btnCalcular = new Button();
            cmbOperacion = new ComboBox();
            btnLimpiar = new Button();
            lblPolinomioRR = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 71);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Coeficiente";
            // 
            // txtCoeficiente
            // 
            txtCoeficiente.Location = new Point(123, 67);
            txtCoeficiente.Name = "txtCoeficiente";
            txtCoeficiente.Size = new Size(100, 23);
            txtCoeficiente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(229, 40);
            label2.Name = "label2";
            label2.Size = new Size(45, 55);
            label2.TabIndex = 2;
            label2.Text = "x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 40);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 3;
            label3.Text = "Exponente";
            // 
            // txtExponente
            // 
            txtExponente.Location = new Point(265, 32);
            txtExponente.Name = "txtExponente";
            txtExponente.Size = new Size(100, 23);
            txtExponente.TabIndex = 4;
            // 
            // cmbPolinomio
            // 
            cmbPolinomio.FormattingEnabled = true;
            cmbPolinomio.Items.AddRange(new object[] { "Polinomio 1", "Polinomio 2" });
            cmbPolinomio.Location = new Point(381, 63);
            cmbPolinomio.Name = "cmbPolinomio";
            cmbPolinomio.Size = new Size(121, 23);
            cmbPolinomio.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(530, 68);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblPolinomio1
            // 
            lblPolinomio1.BackColor = Color.SteelBlue;
            lblPolinomio1.Location = new Point(-1, 107);
            lblPolinomio1.Name = "lblPolinomio1";
            lblPolinomio1.Size = new Size(797, 86);
            lblPolinomio1.TabIndex = 7;
            // 
            // lblPolinomio2
            // 
            lblPolinomio2.BackColor = Color.SteelBlue;
            lblPolinomio2.Location = new Point(-1, 205);
            lblPolinomio2.Name = "lblPolinomio2";
            lblPolinomio2.Size = new Size(797, 86);
            lblPolinomio2.TabIndex = 8;
            // 
            // lblPolinomioR
            // 
            lblPolinomioR.BackColor = Color.Bisque;
            lblPolinomioR.Location = new Point(-1, 355);
            lblPolinomioR.Name = "lblPolinomioR";
            lblPolinomioR.Size = new Size(797, 86);
            lblPolinomioR.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(37, 310);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "Suma", "Resta", "Multiplicación", "División", "Derivada" });
            cmbOperacion.Location = new Point(153, 310);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(144, 23);
            cmbOperacion.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(626, 66);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblPolinomioRR
            // 
            lblPolinomioRR.BackColor = Color.Khaki;
            lblPolinomioRR.Location = new Point(-1, 454);
            lblPolinomioRR.Name = "lblPolinomioRR";
            lblPolinomioRR.Size = new Size(797, 86);
            lblPolinomioRR.TabIndex = 13;
            // 
            // FrmPolinomios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 571);
            Controls.Add(lblPolinomioRR);
            Controls.Add(btnLimpiar);
            Controls.Add(cmbOperacion);
            Controls.Add(btnCalcular);
            Controls.Add(lblPolinomioR);
            Controls.Add(lblPolinomio2);
            Controls.Add(lblPolinomio1);
            Controls.Add(btnAgregar);
            Controls.Add(cmbPolinomio);
            Controls.Add(txtExponente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCoeficiente);
            Controls.Add(label1);
            Name = "FrmPolinomios";
            Text = "Operaciones con Polinomios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCoeficiente;
        private Label label2;
        private Label label3;
        private TextBox txtExponente;
        private ComboBox cmbPolinomio;
        private Button btnAgregar;
        private Label lblPolinomio1;
        private Label lblPolinomio2;
        private Label lblPolinomioR;
        private Button btnCalcular;
        private ComboBox cmbOperacion;
        private Button btnLimpiar;
        private Label lblPolinomioRR;
    }
}
