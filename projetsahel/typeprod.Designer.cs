namespace projetsahel
{
    partial class typeprod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(65, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 206);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "examen";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(187, 128);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 29);
            textBox2.TabIndex = 57;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(187, 96);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 26);
            textBox1.TabIndex = 56;
            // 
            // label9
            // 
            label9.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(26, 122);
            label9.Name = "label9";
            label9.Size = new Size(166, 35);
            label9.TabIndex = 53;
            label9.Text = "CodeName";
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 86);
            label3.Name = "label3";
            label3.Size = new Size(155, 36);
            label3.TabIndex = 47;
            label3.Text = "CodeType";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Stencil", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(122, 19);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(303, 53);
            label1.TabIndex = 45;
            label1.Text = "TYPEPROD";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(407, 163);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 69;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            // 
            // typeprod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 323);
            Controls.Add(groupBox1);
            Name = "typeprod";
            Text = "typeprod";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label9;
        private Label label3;
        private Label label1;
        private Button button1;
    }
}