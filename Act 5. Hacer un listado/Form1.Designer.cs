namespace Act_5._Hacer_un_listado
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
            textBox1 = new TextBox();
            button1 = new Button();
            DatosDelListado = new ListBox();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(278, 31);
            label1.Name = "label1";
            label1.Size = new Size(259, 31);
            label1.TabIndex = 0;
            label1.Text = "Act 5. Hacer un listado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(131, 105);
            label2.Name = "label2";
            label2.Size = new Size(559, 28);
            label2.TabIndex = 1;
            label2.Text = "Agrega palabras o numeros y luego presiona el boton agregar:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(92, 183);
            label3.Name = "label3";
            label3.Size = new Size(251, 28);
            label3.TabIndex = 2;
            label3.Text = "Dato a agregar a la lista:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(382, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(555, 186);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DatosDelListado
            // 
            DatosDelListado.FormattingEnabled = true;
            DatosDelListado.Location = new Point(245, 275);
            DatosDelListado.Name = "DatosDelListado";
            DatosDelListado.Size = new Size(320, 104);
            DatosDelListado.TabIndex = 5;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(300, 409);
            button2.Name = "button2";
            button2.Size = new Size(207, 29);
            button2.TabIndex = 6;
            button2.Text = "Mostrar listado";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(690, 191);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(594, 325);
            label5.Name = "label5";
            label5.Size = new Size(0, 17);
            label5.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(841, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(DatosDelListado);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private ListBox DatosDelListado;
        private Button button2;
        private Label label4;
        private Label label5;
    }
}
