namespace practica18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 21);
            label1.Name = "label1";
            label1.Size = new Size(631, 20);
            label1.TabIndex = 0;
            label1.Text = "Diagrama que pida los 3 lados de un triangulo y diga si es equilatero, isosceles o escaleno\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(241, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(514, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(225, 198);
            label2.Name = "label2";
            label2.Size = new Size(108, 17);
            label2.TabIndex = 2;
            label2.Text = "Longitud lado A";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(339, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(225, 238);
            label3.Name = "label3";
            label3.Size = new Size(107, 17);
            label3.TabIndex = 4;
            label3.Text = "Longitud lado B";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(339, 237);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(226, 275);
            label4.Name = "label4";
            label4.Size = new Size(107, 17);
            label4.TabIndex = 6;
            label4.Text = "Longitud lado C";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(339, 274);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(319, 344);
            button1.Name = "button1";
            button1.Size = new Size(96, 35);
            button1.TabIndex = 8;
            button1.Text = "Decision";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(463, 343);
            button2.Name = "button2";
            button2.Size = new Size(96, 36);
            button2.TabIndex = 9;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(620, 343);
            button3.Name = "button3";
            button3.Size = new Size(97, 36);
            button3.TabIndex = 10;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(226, 410);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 11;
            label5.Text = "Tipo triangulo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(339, 407);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1123, 462);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
        private TextBox textBox4;
    }
}