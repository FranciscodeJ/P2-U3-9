namespace Práctica_8
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
            button1 = new Button();
            label5 = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.NavajoWhite;
            button1.Location = new Point(443, 236);
            button1.Name = "button1";
            button1.Size = new Size(226, 60);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.BlanchedAlmond;
            label5.Location = new Point(171, 60);
            label5.Name = "label5";
            label5.Size = new Size(278, 35);
            label5.TabIndex = 14;
            label5.Text = "Factorial de un Número";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.PaleGoldenrod;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 34;
            listBox1.Location = new Point(201, 146);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(169, 306);
            listBox1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.BlanchedAlmond;
            label1.Location = new Point(61, 505);
            label1.Name = "label1";
            label1.Size = new Size(278, 35);
            label1.TabIndex = 16;
            label1.Text = "Factorial de un Número";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.BlanchedAlmond;
            label2.Location = new Point(488, 509);
            label2.Name = "label2";
            label2.Size = new Size(37, 35);
            label2.TabIndex = 17;
            label2.Text = "es";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Beige;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sitka Small", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(467, 60);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 47);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Beige;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Sitka Small", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(345, 502);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 51);
            textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Beige;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Sitka Small", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(544, 502);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 51);
            textBox3.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(920, 623);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}