namespace practica2
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
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            txtEdad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rbdMasculino = new RadioButton();
            rbdFemenino = new RadioButton();
            rbdOtro = new RadioButton();
            groupBox1 = new GroupBox();
            chkDeportes = new CheckBox();
            chkTecnologia = new CheckBox();
            chkMusica = new CheckBox();
            chkArte = new CheckBox();
            cmbEstudios = new ComboBox();
            label5 = new Label();
            pnlResumen = new Panel();
            lblResume = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            pnlResumen.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(229, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(344, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(229, 117);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(344, 27);
            txtCorreo.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(121, 185);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 62);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 3;
            label1.Text = "Escribe tu nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 124);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 4;
            label2.Text = "Escribe tu correo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 192);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Edad :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 266);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Intereses:";
            // 
            // rbdMasculino
            // 
            rbdMasculino.AutoSize = true;
            rbdMasculino.Location = new Point(6, 26);
            rbdMasculino.Name = "rbdMasculino";
            rbdMasculino.Size = new Size(111, 27);
            rbdMasculino.TabIndex = 7;
            rbdMasculino.TabStop = true;
            rbdMasculino.Text = "Masculino";
            rbdMasculino.UseVisualStyleBackColor = true;
            // 
            // rbdFemenino
            // 
            rbdFemenino.AutoSize = true;
            rbdFemenino.Location = new Point(6, 59);
            rbdFemenino.Name = "rbdFemenino";
            rbdFemenino.Size = new Size(108, 27);
            rbdFemenino.TabIndex = 8;
            rbdFemenino.TabStop = true;
            rbdFemenino.Text = "Femenino";
            rbdFemenino.UseVisualStyleBackColor = true;
            // 
            // rbdOtro
            // 
            rbdOtro.AutoSize = true;
            rbdOtro.Location = new Point(6, 95);
            rbdOtro.Name = "rbdOtro";
            rbdOtro.Size = new Size(67, 27);
            rbdOtro.TabIndex = 9;
            rbdOtro.TabStop = true;
            rbdOtro.Text = "Otro";
            rbdOtro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbdOtro);
            groupBox1.Controls.Add(rbdMasculino);
            groupBox1.Controls.Add(rbdFemenino);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(589, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(209, 135);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "¿Cual es tu genero?";
            // 
            // chkDeportes
            // 
            chkDeportes.AutoSize = true;
            chkDeportes.Location = new Point(59, 299);
            chkDeportes.Name = "chkDeportes";
            chkDeportes.Size = new Size(92, 24);
            chkDeportes.TabIndex = 11;
            chkDeportes.Text = "Deportes";
            chkDeportes.UseVisualStyleBackColor = true;
            // 
            // chkTecnologia
            // 
            chkTecnologia.AutoSize = true;
            chkTecnologia.Location = new Point(59, 329);
            chkTecnologia.Name = "chkTecnologia";
            chkTecnologia.Size = new Size(104, 24);
            chkTecnologia.TabIndex = 12;
            chkTecnologia.Text = "Tecnologia";
            chkTecnologia.UseVisualStyleBackColor = true;
            // 
            // chkMusica
            // 
            chkMusica.AutoSize = true;
            chkMusica.Location = new Point(59, 359);
            chkMusica.Name = "chkMusica";
            chkMusica.Size = new Size(77, 24);
            chkMusica.TabIndex = 13;
            chkMusica.Text = "Musica";
            chkMusica.UseVisualStyleBackColor = true;
            // 
            // chkArte
            // 
            chkArte.AutoSize = true;
            chkArte.Location = new Point(59, 389);
            chkArte.Name = "chkArte";
            chkArte.Size = new Size(59, 24);
            chkArte.TabIndex = 14;
            chkArte.Text = "Arte";
            chkArte.UseVisualStyleBackColor = true;
            // 
            // cmbEstudios
            // 
            cmbEstudios.FormattingEnabled = true;
            cmbEstudios.Location = new Point(422, 185);
            cmbEstudios.Name = "cmbEstudios";
            cmbEstudios.Size = new Size(151, 28);
            cmbEstudios.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 192);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 16;
            label5.Text = "Nivel de estudios :";
            // 
            // pnlResumen
            // 
            pnlResumen.Controls.Add(lblResume);
            pnlResumen.Location = new Point(206, 244);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Size = new Size(592, 125);
            pnlResumen.TabIndex = 17;
            // 
            // lblResume
            // 
            lblResume.AutoSize = true;
            lblResume.Location = new Point(23, 22);
            lblResume.Name = "lblResume";
            lblResume.Size = new Size(0, 20);
            lblResume.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(595, 190);
            button1.Name = "button1";
            button1.Size = new Size(203, 41);
            button1.TabIndex = 18;
            button1.Text = "Presiona para registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(821, 450);
            Controls.Add(button1);
            Controls.Add(pnlResumen);
            Controls.Add(label5);
            Controls.Add(cmbEstudios);
            Controls.Add(chkArte);
            Controls.Add(chkMusica);
            Controls.Add(chkTecnologia);
            Controls.Add(chkDeportes);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEdad);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlResumen.ResumeLayout(false);
            pnlResumen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtEdad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton rbdMasculino;
        private RadioButton rbdFemenino;
        private RadioButton rbdOtro;
        private GroupBox groupBox1;
        private CheckBox chkDeportes;
        private CheckBox chkTecnologia;
        private CheckBox chkMusica;
        private CheckBox chkArte;
        private ComboBox cmbEstudios;
        private Label label5;
        private Panel pnlResumen;
        private Button button1;
        private Label lblResume;
    }
}
