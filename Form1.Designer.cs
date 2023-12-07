namespace SeviyeliYilanOyunu
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(1, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 600);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(94, 59);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 1;
            label1.Text = "Seviye  = 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(383, 59);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 2;
            label2.Text = "Skor = 0";
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(94, 723);
            button1.Name = "button1";
            button1.Size = new Size(409, 70);
            button1.TabIndex = 3;
            button1.Text = "Oyunu Başlat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(94, 803);
            button3.Name = "button3";
            button3.Size = new Size(409, 70);
            button3.TabIndex = 5;
            button3.Text = "Sornaki Seviyeye Geç";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(169, 9);
            label3.Name = "label3";
            label3.Size = new Size(244, 23);
            label3.TabIndex = 6;
            label3.Text = "Hedef = 1000 Puan Ulaş";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 894);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Yılan Oyunu";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
    }
}