namespace WinFormsApp1
{
    partial class Form3
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
            boxYcl = new ComboBox();
            Check = new ListBox();
            txtYcl = new TextBox();
            btnYcl = new Button();
            txtYcl2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            txtSmart = new TextBox();
            btnOtkr = new Button();
            txtOtkr = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnOrderExcursion = new Button();
            listBoxzakaz = new ListBox();
            listBoxPromotions = new ListBox();
            listBoxServices = new ListBox();
            btnDeleteOrder = new Button();
            btnhis = new Button();
            lstPop = new ListBox();
            btnShow = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // boxYcl
            // 
            boxYcl.FormattingEnabled = true;
            boxYcl.Location = new Point(12, 80);
            boxYcl.Name = "boxYcl";
            boxYcl.Size = new Size(121, 23);
            boxYcl.TabIndex = 0;
            // 
            // Check
            // 
            Check.FormattingEnabled = true;
            Check.ItemHeight = 15;
            Check.Location = new Point(9, 109);
            Check.Name = "Check";
            Check.Size = new Size(169, 124);
            Check.TabIndex = 3;
            // 
            // txtYcl
            // 
            txtYcl.Location = new Point(184, 109);
            txtYcl.Name = "txtYcl";
            txtYcl.Size = new Size(100, 23);
            txtYcl.TabIndex = 4;
            // 
            // btnYcl
            // 
            btnYcl.Location = new Point(12, 239);
            btnYcl.Name = "btnYcl";
            btnYcl.Size = new Size(121, 29);
            btnYcl.TabIndex = 5;
            btnYcl.Text = "З А К А З А Т Ь";
            btnYcl.UseVisualStyleBackColor = true;
            btnYcl.Click += btnYcl_Click;
            // 
            // txtYcl2
            // 
            txtYcl2.Location = new Point(184, 155);
            txtYcl2.Name = "txtYcl2";
            txtYcl2.Size = new Size(100, 23);
            txtYcl2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(182, 91);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 7;
            label1.Text = "Выбирай ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(181, 137);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 8;
            label2.Text = "Комнату укажи, да";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(550, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(238, 259);
            dataGridView1.TabIndex = 9;
            // 
            // txtSmart
            // 
            txtSmart.Location = new Point(117, 298);
            txtSmart.Name = "txtSmart";
            txtSmart.Size = new Size(100, 23);
            txtSmart.TabIndex = 10;
            // 
            // btnOtkr
            // 
            btnOtkr.Location = new Point(8, 327);
            btnOtkr.Name = "btnOtkr";
            btnOtkr.Size = new Size(125, 36);
            btnOtkr.TabIndex = 11;
            btnOtkr.Text = "О Т К Р Ы В А Й";
            btnOtkr.UseVisualStyleBackColor = true;
            btnOtkr.Click += button1_Click;
            // 
            // txtOtkr
            // 
            txtOtkr.Location = new Point(12, 298);
            txtOtkr.Name = "txtOtkr";
            txtOtkr.Size = new Size(100, 23);
            txtOtkr.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(8, 280);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 13;
            label3.Text = "Комната";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(117, 280);
            label4.Name = "label4";
            label4.Size = new Size(173, 15);
            label4.TabIndex = 14;
            label4.Text = "Открой с помощью телефона";
            // 
            // btnOrderExcursion
            // 
            btnOrderExcursion.Location = new Point(8, 459);
            btnOrderExcursion.Name = "btnOrderExcursion";
            btnOrderExcursion.Size = new Size(125, 29);
            btnOrderExcursion.TabIndex = 16;
            btnOrderExcursion.Text = "Э К С К У Р С С И Я ";
            btnOrderExcursion.UseVisualStyleBackColor = true;
            // 
            // listBoxzakaz
            // 
            listBoxzakaz.FormattingEnabled = true;
            listBoxzakaz.ItemHeight = 15;
            listBoxzakaz.Location = new Point(9, 373);
            listBoxzakaz.Name = "listBoxzakaz";
            listBoxzakaz.Size = new Size(190, 79);
            listBoxzakaz.TabIndex = 19;
            listBoxzakaz.SelectedIndexChanged += listBoxzakaz_SelectedIndexChanged;
            // 
            // listBoxPromotions
            // 
            listBoxPromotions.FormattingEnabled = true;
            listBoxPromotions.ItemHeight = 15;
            listBoxPromotions.Location = new Point(8, 494);
            listBoxPromotions.Name = "listBoxPromotions";
            listBoxPromotions.Size = new Size(391, 94);
            listBoxPromotions.TabIndex = 20;
            // 
            // listBoxServices
            // 
            listBoxServices.FormattingEnabled = true;
            listBoxServices.ItemHeight = 15;
            listBoxServices.Location = new Point(448, 494);
            listBoxServices.Name = "listBoxServices";
            listBoxServices.Size = new Size(340, 94);
            listBoxServices.TabIndex = 21;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(181, 184);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.RightToLeft = RightToLeft.Yes;
            btnDeleteOrder.Size = new Size(103, 29);
            btnDeleteOrder.TabIndex = 22;
            btnDeleteOrder.Text = "У Д А Л И Т Ь";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click_1;
            // 
            // btnhis
            // 
            btnhis.Location = new Point(322, 433);
            btnhis.Name = "btnhis";
            btnhis.Size = new Size(148, 49);
            btnhis.TabIndex = 23;
            btnhis.Text = "И С Т О Р И Я";
            btnhis.UseVisualStyleBackColor = true;
            btnhis.Click += btnhis_Click;
            // 
            // lstPop
            // 
            lstPop.FormattingEnabled = true;
            lstPop.ItemHeight = 15;
            lstPop.Location = new Point(322, 109);
            lstPop.Name = "lstPop";
            lstPop.Size = new Size(169, 124);
            lstPop.TabIndex = 24;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(331, 239);
            btnShow.Name = "btnShow";
            btnShow.RightToLeft = RightToLeft.No;
            btnShow.Size = new Size(148, 49);
            btnShow.TabIndex = 25;
            btnShow.Text = "М Е Р О П Р И Я Т И Я";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(732, 5);
            button2.Name = "button2";
            button2.Size = new Size(30, 32);
            button2.TabIndex = 27;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(768, 5);
            button1.Name = "button1";
            button1.Size = new Size(30, 33);
            button1.TabIndex = 26;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.scale_1200;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnShow);
            Controls.Add(lstPop);
            Controls.Add(btnhis);
            Controls.Add(btnDeleteOrder);
            Controls.Add(listBoxServices);
            Controls.Add(listBoxPromotions);
            Controls.Add(listBoxzakaz);
            Controls.Add(btnOrderExcursion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtOtkr);
            Controls.Add(btnOtkr);
            Controls.Add(txtSmart);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtYcl2);
            Controls.Add(btnYcl);
            Controls.Add(txtYcl);
            Controls.Add(Check);
            Controls.Add(boxYcl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox boxYcl;
        private ListBox Check;
        private TextBox txtYcl;
        private Button btnYcl;
        private TextBox txtYcl2;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox txtSmart;
        private Button btnOtkr;
        private TextBox txtOtkr;
        private Label label3;
        private Label label4;
        private Button btnOrderExcursion;
        private ListBox listBoxzakaz;
        private ListBox listBoxPromotions;
        private ListBox listBoxServices;
        private Button btnDeleteOrder;
        private Button btnhis;
        private ListBox lstPop;
        private Button btnShow;
        private Button button2;
        private Button button1;
    }
}