namespace stajornek4
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtadsoyad = new TextBox();
            txttelefon = new TextBox();
            txtadres = new TextBox();
            comboBoy = new ComboBox();
            comboIcecek = new ComboBox();
            lstAd = new ListBox();
            lstTelefon = new ListBox();
            lstAdres = new ListBox();
            lstBoy = new ListBox();
            lstIcecek = new ListBox();
            lstCesit = new ListBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1021, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(493, 41);
            label1.Name = "label1";
            label1.Size = new Size(266, 37);
            label1.TabIndex = 1;
            label1.Text = "Sandviç Siparis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(84, 159);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 2;
            label2.Text = "Ad-Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(84, 210);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 3;
            label3.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(84, 259);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 4;
            label4.Text = "Adres:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(32, 443);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 5;
            label5.Text = "İçecek:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Malgun Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(32, 394);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 6;
            label6.Text = "Sandviç Boyu:";
            // 
            // txtadsoyad
            // 
            txtadsoyad.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtadsoyad.Location = new Point(189, 164);
            txtadsoyad.Name = "txtadsoyad";
            txtadsoyad.Size = new Size(233, 29);
            txtadsoyad.TabIndex = 7;
            // 
            // txttelefon
            // 
            txttelefon.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttelefon.Location = new Point(189, 215);
            txttelefon.Name = "txttelefon";
            txttelefon.Size = new Size(233, 29);
            txttelefon.TabIndex = 8;
            // 
            // txtadres
            // 
            txtadres.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtadres.Location = new Point(189, 264);
            txtadres.Multiline = true;
            txtadres.Name = "txtadres";
            txtadres.Size = new Size(233, 98);
            txtadres.TabIndex = 9;
            // 
            // comboBoy
            // 
            comboBoy.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoy.FormattingEnabled = true;
            comboBoy.Items.AddRange(new object[] { "Küçük", "Orta", "Büyük" });
            comboBoy.Location = new Point(189, 399);
            comboBoy.Name = "comboBoy";
            comboBoy.Size = new Size(233, 29);
            comboBoy.TabIndex = 10;
            // 
            // comboIcecek
            // 
            comboIcecek.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboIcecek.FormattingEnabled = true;
            comboIcecek.Items.AddRange(new object[] { "Kola", "Fanta", "Ice Tea", "Ayran", "Su", "Gaoz" });
            comboIcecek.Location = new Point(189, 445);
            comboIcecek.Name = "comboIcecek";
            comboIcecek.Size = new Size(233, 29);
            comboIcecek.TabIndex = 11;
            // 
            // lstAd
            // 
            lstAd.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstAd.FormattingEnabled = true;
            lstAd.ItemHeight = 21;
            lstAd.Location = new Point(21, 551);
            lstAd.Name = "lstAd";
            lstAd.Size = new Size(162, 151);
            lstAd.TabIndex = 12;
            lstAd.Visible = false;
            // 
            // lstTelefon
            // 
            lstTelefon.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstTelefon.FormattingEnabled = true;
            lstTelefon.ItemHeight = 21;
            lstTelefon.Location = new Point(189, 551);
            lstTelefon.Name = "lstTelefon";
            lstTelefon.Size = new Size(158, 151);
            lstTelefon.TabIndex = 13;
            lstTelefon.Visible = false;
            // 
            // lstAdres
            // 
            lstAdres.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstAdres.FormattingEnabled = true;
            lstAdres.ItemHeight = 21;
            lstAdres.Location = new Point(353, 551);
            lstAdres.Name = "lstAdres";
            lstAdres.Size = new Size(191, 151);
            lstAdres.TabIndex = 14;
            lstAdres.Visible = false;
            // 
            // lstBoy
            // 
            lstBoy.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstBoy.FormattingEnabled = true;
            lstBoy.ItemHeight = 21;
            lstBoy.Location = new Point(550, 551);
            lstBoy.Name = "lstBoy";
            lstBoy.Size = new Size(118, 151);
            lstBoy.TabIndex = 15;
            lstBoy.Visible = false;
            // 
            // lstIcecek
            // 
            lstIcecek.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstIcecek.FormattingEnabled = true;
            lstIcecek.ItemHeight = 21;
            lstIcecek.Location = new Point(674, 551);
            lstIcecek.Name = "lstIcecek";
            lstIcecek.Size = new Size(117, 151);
            lstIcecek.TabIndex = 16;
            lstIcecek.Visible = false;
            // 
            // lstCesit
            // 
            lstCesit.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstCesit.FormattingEnabled = true;
            lstCesit.ItemHeight = 21;
            lstCesit.Location = new Point(797, 551);
            lstCesit.Name = "lstCesit";
            lstCesit.Size = new Size(462, 151);
            lstCesit.TabIndex = 17;
            lstCesit.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox1.Location = new Point(18, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 21);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Biftek";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox2.Location = new Point(139, 22);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(112, 21);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "Teriyaki Tavuk";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox3.Location = new Point(278, 22);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(62, 21);
            checkBox3.TabIndex = 20;
            checkBox3.Text = "Sebze";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox4.Location = new Point(18, 65);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(82, 21);
            checkBox4.TabIndex = 23;
            checkBox4.Text = "Rosebeef";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox5.Location = new Point(139, 65);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(58, 21);
            checkBox5.TabIndex = 22;
            checkBox5.Text = "Köfte";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox6.Location = new Point(278, 65);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(74, 21);
            checkBox6.TabIndex = 21;
            checkBox6.Text = "Jambon";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(503, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 114);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Çesitler";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 37);
            label7.Name = "label7";
            label7.Size = new Size(10, 15);
            label7.TabIndex = 25;
            label7.Text = " ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 69);
            label8.Name = "label8";
            label8.Size = new Size(10, 15);
            label8.TabIndex = 26;
            label8.Text = " ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 106);
            label9.Name = "label9";
            label9.Size = new Size(10, 15);
            label9.TabIndex = 27;
            label9.Text = " ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 143);
            label10.Name = "label10";
            label10.Size = new Size(10, 15);
            label10.TabIndex = 28;
            label10.Text = " ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 176);
            label11.Name = "label11";
            label11.Size = new Size(10, 15);
            label11.TabIndex = 29;
            label11.Text = " ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 206);
            label12.Name = "label12";
            label12.Size = new Size(10, 15);
            label12.TabIndex = 30;
            label12.Text = " ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(962, 141);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(109, 235);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            groupBox2.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Beige;
            button1.Location = new Point(503, 303);
            button1.Name = "button1";
            button1.Size = new Size(164, 43);
            button1.TabIndex = 32;
            button1.Text = "Sipariş Ver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Beige;
            button2.Location = new Point(721, 300);
            button2.Name = "button2";
            button2.Size = new Size(164, 43);
            button2.TabIndex = 33;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1271, 717);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lstCesit);
            Controls.Add(lstIcecek);
            Controls.Add(lstBoy);
            Controls.Add(lstAdres);
            Controls.Add(lstTelefon);
            Controls.Add(lstAd);
            Controls.Add(comboIcecek);
            Controls.Add(comboBoy);
            Controls.Add(txtadres);
            Controls.Add(txttelefon);
            Controls.Add(txtadsoyad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtadsoyad;
        private TextBox txttelefon;
        private TextBox txtadres;
        private ComboBox comboBoy;
        private ComboBox comboIcecek;
        private ListBox lstAd;
        private ListBox lstTelefon;
        private ListBox lstAdres;
        private ListBox lstBoy;
        private ListBox lstIcecek;
        private ListBox lstCesit;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private GroupBox groupBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
    }
}