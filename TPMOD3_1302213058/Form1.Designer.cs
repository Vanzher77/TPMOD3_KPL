namespace TPMOD3_1302213058
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
            BtnSubmit = new Button();
            textbox = new TextBox();
            output1 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // BtnSubmit
            // 
            BtnSubmit.BackColor = Color.FromArgb(128, 128, 255);
            BtnSubmit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSubmit.Location = new Point(-3, 375);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(807, 75);
            BtnSubmit.TabIndex = 0;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = false;
            BtnSubmit.Click += button1_Click;
            // 
            // textbox
            // 
            textbox.BackColor = Color.FromArgb(128, 128, 255);
            textbox.Cursor = Cursors.IBeam;
            textbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textbox.Location = new Point(209, 335);
            textbox.Multiline = true;
            textbox.Name = "textbox";
            textbox.Size = new Size(374, 34);
            textbox.TabIndex = 1;
            textbox.TextChanged += textBox1_TextChanged;
            // 
            // output1
            // 
            output1.AutoSize = true;
            output1.BackColor = Color.FromArgb(128, 128, 255);
            output1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            output1.Location = new Point(218, 339);
            output1.Name = "output1";
            output1.Size = new Size(20, 20);
            output1.TabIndex = 2;
            output1.Text = ">";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(292, 249);
            label1.Name = "label1";
            label1.Size = new Size(219, 25);
            label1.TabIndex = 3;
            label1.Text = "Silahkan isi nama anda!";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(209, 277);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(374, 34);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(output1);
            Controls.Add(textbox);
            Controls.Add(BtnSubmit);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSubmit;
        private TextBox textbox;
        private Label output1;
        private Label label1;
        private TextBox textBox1;
    }
}