namespace labwork
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
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            Calculate = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(453, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(453, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 152);
            label1.Name = "label1";
            label1.Size = new Size(255, 32);
            label1.TabIndex = 2;
            label1.Text = "Vehicle Speed in MPH:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 234);
            label2.Name = "label2";
            label2.Size = new Size(178, 32);
            label2.TabIndex = 3;
            label2.Text = "Hours Traveled:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(167, 346);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(486, 228);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Calculate
            // 
            Calculate.Location = new Point(167, 613);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(150, 46);
            Calculate.TabIndex = 5;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(503, 613);
            Exit.Name = "Exit";
            Exit.Size = new Size(150, 46);
            Exit.TabIndex = 6;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 717);
            Controls.Add(Exit);
            Controls.Add(Calculate);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Button Calculate;
        private Button Exit;
    }
}