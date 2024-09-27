namespace WinFormsApp1
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
            reg = new Button();
            LOGBox1 = new TextBox();
            REGBox2 = new TextBox();
            vxod = new Button();
            Otobr = new Button();
            smena = new Button();
            delete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // reg
            // 
            reg.Location = new Point(320, 481);
            reg.Name = "reg";
            reg.Size = new Size(144, 36);
            reg.TabIndex = 1;
            reg.Text = "Р Е Г И С Т Р А Ц И Я";
            reg.UseVisualStyleBackColor = true;
            // 
            // LOGBox1
            // 
            LOGBox1.Location = new Point(179, 218);
            LOGBox1.Multiline = true;
            LOGBox1.Name = "LOGBox1";
            LOGBox1.Size = new Size(461, 23);
            LOGBox1.TabIndex = 2;
            // 
            // REGBox2
            // 
            REGBox2.Location = new Point(179, 342);
            REGBox2.Name = "REGBox2";
            REGBox2.Size = new Size(461, 23);
            REGBox2.TabIndex = 3;
            // 
            // vxod
            // 
            vxod.Location = new Point(320, 407);
            vxod.Name = "vxod";
            vxod.Size = new Size(144, 36);
            vxod.TabIndex = 0;
            vxod.Text = "В Х О Д";
            vxod.UseVisualStyleBackColor = true;
            vxod.Click += vxod_Click;
            // 
            // Otobr
            // 
            Otobr.Location = new Point(450, 443);
            Otobr.Name = "Otobr";
            Otobr.Size = new Size(144, 36);
            Otobr.TabIndex = 5;
            Otobr.Text = "О Т О Б Р А Ж Е Н И Е";
            Otobr.UseVisualStyleBackColor = true;
            Otobr.Click += Otobr_Click_1;
            // 
            // smena
            // 
            smena.Location = new Point(12, 552);
            smena.Name = "smena";
            smena.Size = new Size(144, 36);
            smena.TabIndex = 6;
            smena.Text = "С М Е Н А   П А Р О Л Я";
            smena.UseVisualStyleBackColor = true;
            smena.Click += smena_Click;
            // 
            // delete
            // 
            delete.Location = new Point(191, 443);
            delete.Name = "delete";
            delete.Size = new Size(144, 36);
            delete.TabIndex = 7;
            delete.Text = "У Д А Л Е Н И Е";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(320, 103);
            label1.Name = "label1";
            label1.Size = new Size(192, 65);
            label1.TabIndex = 8;
            label1.Text = "В Х О Д";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(179, 194);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 9;
            label2.Text = "Л О Г И Н";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(179, 318);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 10;
            label3.Text = "П А Р О Л Ь";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(762, 4);
            button1.Name = "button1";
            button1.Size = new Size(30, 33);
            button1.TabIndex = 27;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(722, 5);
            button2.Name = "button2";
            button2.Size = new Size(30, 32);
            button2.TabIndex = 28;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._62c5a4634f021;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(delete);
            Controls.Add(smena);
            Controls.Add(Otobr);
            Controls.Add(REGBox2);
            Controls.Add(LOGBox1);
            Controls.Add(reg);
            Controls.Add(vxod);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button reg;
        private TextBox LOGBox1;
        private TextBox REGBox2;
        private Button vxod;
        private Button Otobr;
        private Button smena;
        private Button delete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}
