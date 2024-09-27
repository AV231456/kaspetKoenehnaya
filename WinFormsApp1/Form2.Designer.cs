namespace WinFormsApp1
{
    partial class Form2
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
            z1 = new Button();
            btnExit = new Button();
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            bratata = new Button();
            d1 = new DateTimePicker();
            d2 = new DateTimePicker();
            label1 = new Label();
            gst = new TextBox();
            Psk = new TextBox();
            btnpsk = new Button();
            bron = new ListBox();
            btnbron = new Button();
            btnotz = new Button();
            txtOtz = new TextBox();
            btnprice2 = new Button();
            btnprice1 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // z1
            // 
            z1.Location = new Point(2, 530);
            z1.Name = "z1";
            z1.Size = new Size(207, 58);
            z1.TabIndex = 1;
            z1.Text = "P R O S M O T R";
            z1.UseVisualStyleBackColor = true;
            z1.Click += z1_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Brown;
            btnExit.Location = new Point(715, 546);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(76, 42);
            btnExit.TabIndex = 8;
            btnExit.Text = "E X I T";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(371, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(410, 379);
            dataGridView1.TabIndex = 10;
            // 
            // bratata
            // 
            bratata.Location = new Point(3, 55);
            bratata.Name = "bratata";
            bratata.Size = new Size(184, 77);
            bratata.TabIndex = 13;
            bratata.Text = "B R O N I R O V A N I E";
            bratata.Click += bratata_Click;
            // 
            // d1
            // 
            d1.Location = new Point(193, 55);
            d1.Name = "d1";
            d1.Size = new Size(159, 23);
            d1.TabIndex = 15;
            // 
            // d2
            // 
            d2.Location = new Point(193, 84);
            d2.Name = "d2";
            d2.Size = new Size(159, 23);
            d2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(193, 112);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 17;
            label1.Text = "Скок гостей?";
            // 
            // gst
            // 
            gst.Location = new Point(193, 130);
            gst.Name = "gst";
            gst.Size = new Size(134, 23);
            gst.TabIndex = 14;
            // 
            // Psk
            // 
            Psk.Location = new Point(3, 147);
            Psk.Name = "Psk";
            Psk.Size = new Size(184, 23);
            Psk.TabIndex = 18;
            Psk.TextChanged += Psk_TextChanged;
            // 
            // btnpsk
            // 
            btnpsk.Location = new Point(3, 176);
            btnpsk.Name = "btnpsk";
            btnpsk.Size = new Size(75, 23);
            btnpsk.TabIndex = 19;
            btnpsk.Text = "П О И С К";
            btnpsk.UseVisualStyleBackColor = true;
            // 
            // bron
            // 
            bron.FormattingEnabled = true;
            bron.ItemHeight = 15;
            bron.Location = new Point(3, 205);
            bron.Name = "bron";
            bron.Size = new Size(184, 109);
            bron.TabIndex = 20;
            // 
            // btnbron
            // 
            btnbron.Location = new Point(195, 284);
            btnbron.Name = "btnbron";
            btnbron.Size = new Size(76, 30);
            btnbron.TabIndex = 21;
            btnbron.Text = "Т Ы К";
            btnbron.Click += btnbron_Click_1;
            // 
            // btnotz
            // 
            btnotz.Location = new Point(2, 327);
            btnotz.Name = "btnotz";
            btnotz.Size = new Size(76, 30);
            btnotz.TabIndex = 22;
            btnotz.Text = "O T Z";
            btnotz.Click += btnotz_Click;
            // 
            // txtOtz
            // 
            txtOtz.Location = new Point(3, 363);
            txtOtz.Name = "txtOtz";
            txtOtz.Size = new Size(207, 23);
            txtOtz.TabIndex = 23;
            // 
            // btnprice2
            // 
            btnprice2.Location = new Point(85, 415);
            btnprice2.Name = "btnprice2";
            btnprice2.Size = new Size(102, 30);
            btnprice2.TabIndex = 24;
            btnprice2.Text = "У Д А Л Е Н И Е";
            btnprice2.Click += btnprice2_Click;
            // 
            // btnprice1
            // 
            btnprice1.Location = new Point(3, 415);
            btnprice1.Name = "btnprice1";
            btnprice1.Size = new Size(76, 30);
            btnprice1.TabIndex = 25;
            btnprice1.Text = "Норм раскладка";
            btnprice1.Click += btnprice1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(587, 77);
            button1.Name = "button1";
            button1.Size = new Size(194, 50);
            button1.TabIndex = 26;
            button1.Text = "П Р О Д О Л Ж И М ? ----->>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(764, 3);
            button2.Name = "button2";
            button2.Size = new Size(30, 33);
            button2.TabIndex = 27;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(728, 4);
            button3.Name = "button3";
            button3.Size = new Size(30, 32);
            button3.TabIndex = 28;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.thumb_1562765_hotel_big;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 600);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnprice1);
            Controls.Add(btnprice2);
            Controls.Add(txtOtz);
            Controls.Add(btnotz);
            Controls.Add(btnbron);
            Controls.Add(bron);
            Controls.Add(btnpsk);
            Controls.Add(Psk);
            Controls.Add(label1);
            Controls.Add(d2);
            Controls.Add(d1);
            Controls.Add(gst);
            Controls.Add(bratata);
            Controls.Add(dataGridView1);
            Controls.Add(btnExit);
            Controls.Add(z1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button z1;
        private Button btnExit;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button bratata;
        private DateTimePicker d1;
        private DateTimePicker d2;
        private Label label1;
        private TextBox gst;
        private TextBox Psk;
        private Button btnpsk;
        private ListBox bron;
        private Button btnbron;
        private Button btnotz;
        private TextBox txtOtz;
        private Button btnprice2;
        private Button btnprice1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}