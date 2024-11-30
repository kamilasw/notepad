namespace todolist
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
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LavenderBlush;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.ForeColor = Color.SteelBlue;
            textBox1.Location = new Point(12, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(451, 37);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.SteelBlue;
            button1.Location = new Point(469, 51);
            button1.Name = "button1";
            button1.Size = new Size(112, 37);
            button1.TabIndex = 1;
            button1.Text = "add";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LavenderBlush;
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.ForeColor = Color.SteelBlue;
            textBox2.Location = new Point(12, 134);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(451, 533);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(12, 93);
            label1.Name = "label1";
            label1.Size = new Size(119, 38);
            label1.TabIndex = 3;
            label1.Text = "notepad";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(117, 38);
            label2.TabIndex = 4;
            label2.Text = "add text";
            // 
            // button2
            // 
            button2.BackColor = Color.LavenderBlush;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 11F);
            button2.ForeColor = Color.SteelBlue;
            button2.Location = new Point(469, 134);
            button2.Name = "button2";
            button2.Size = new Size(112, 39);
            button2.TabIndex = 5;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.SteelBlue;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(434, 13);
            label3.Name = "label3";
            label3.Size = new Size(29, 36);
            label3.TabIndex = 6;
            label3.Text = "0";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(593, 679);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            ForeColor = Color.PaleVioletRed;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "notepad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
    }
}
