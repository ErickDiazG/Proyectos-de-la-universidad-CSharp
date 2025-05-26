namespace Registro_de_usuarios_con_vaidaciones
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(176, 45);
            label1.Name = "label1";
            label1.Size = new Size(503, 31);
            label1.TabIndex = 0;
            label1.Text = "Act 10. Registro de usuarios con validaciones ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 142);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 1;
            label2.Text = "Ingresa tu nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(111, 193);
            label3.Name = "label3";
            label3.Size = new Size(163, 23);
            label3.TabIndex = 2;
            label3.Text = "Ingresa tu apellido:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(662, 174);
            button1.Name = "button1";
            button1.Size = new Size(94, 57);
            button1.TabIndex = 3;
            button1.Text = "Presiona para registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(344, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 4;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 24);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hombre";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(111, 251);
            label4.Name = "label4";
            label4.Size = new Size(138, 23);
            label4.TabIndex = 6;
            label4.Text = "Ingresa tu edad:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(344, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(344, 247);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(247, 27);
            textBox3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 345);
            label5.Name = "label5";
            label5.Size = new Size(176, 20);
            label5.TabIndex = 9;
            label5.Text = "Mensaje de confirmacion";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 24);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mujer";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(111, 298);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Genero";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 86);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(60, 24);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "Otro";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
    }
}
