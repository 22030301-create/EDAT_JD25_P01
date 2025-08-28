namespace UI.NumerosAleatorios
{
    partial class Form1
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
            btnGenerar = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            rbtnMasculino = new RadioButton();
            rbtnFemenino = new RadioButton();
            cboGrupo = new ComboBox();
            txtSueldo = new TextBox();
            chkSeguroMedico = new CheckBox();
            txtNumero = new TextBox();
            txtNombre = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(186, 464);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(189, 33);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar Datos Aleatorios";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 36);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 1;
            label1.Text = "Datos del Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 133);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 174);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 5;
            label4.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 277);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 6;
            label5.Text = "Grupo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 321);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 7;
            label6.Text = "Sueldo";
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Location = new Point(72, 202);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(97, 24);
            rbtnMasculino.TabIndex = 8;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "Masculino";
            rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Location = new Point(72, 232);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(95, 24);
            rbtnFemenino.TabIndex = 9;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "Femenino";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // cboGrupo
            // 
            cboGrupo.FormattingEnabled = true;
            cboGrupo.Location = new Point(115, 274);
            cboGrupo.Name = "cboGrupo";
            cboGrupo.Size = new Size(151, 28);
            cboGrupo.TabIndex = 10;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(118, 318);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(125, 27);
            txtSueldo.TabIndex = 11;
            // 
            // chkSeguroMedico
            // 
            chkSeguroMedico.AutoSize = true;
            chkSeguroMedico.Location = new Point(118, 390);
            chkSeguroMedico.Name = "chkSeguroMedico";
            chkSeguroMedico.Size = new Size(132, 24);
            chkSeguroMedico.TabIndex = 12;
            chkSeguroMedico.Text = "Seguro Médico";
            chkSeguroMedico.UseVisualStyleBackColor = true;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(118, 85);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(118, 130);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(209, 27);
            txtNombre.TabIndex = 14;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(209, 169);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(250, 27);
            dtpFechaNacimiento.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 92);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 3;
            label2.Text = "Número";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 573);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtNombre);
            Controls.Add(txtNumero);
            Controls.Add(chkSeguroMedico);
            Controls.Add(txtSueldo);
            Controls.Add(cboGrupo);
            Controls.Add(rbtnFemenino);
            Controls.Add(rbtnMasculino);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGenerar);
            Name = "Form1";
            Text = "Empleado con Datos Aleatorios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerar;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton rbtnMasculino;
        private RadioButton rbtnFemenino;
        private ComboBox cboGrupo;
        private TextBox txtSueldo;
        private CheckBox chkSeguroMedico;
        private TextBox txtNumero;
        private TextBox txtNombre;
        private DateTimePicker dtpFechaNacimiento;
        private Label label2;
    }
}
