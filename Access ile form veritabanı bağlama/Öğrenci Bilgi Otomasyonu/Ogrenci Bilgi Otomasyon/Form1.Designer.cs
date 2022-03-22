namespace telefon_otom
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtÖğrenciNO = new System.Windows.Forms.TextBox();
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.txtSoyadı = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnİptal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(131, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // txtÖğrenciNO
            // 
            this.txtÖğrenciNO.Location = new System.Drawing.Point(262, 244);
            this.txtÖğrenciNO.Name = "txtÖğrenciNO";
            this.txtÖğrenciNO.Size = new System.Drawing.Size(100, 20);
            this.txtÖğrenciNO.TabIndex = 2;
            this.txtÖğrenciNO.TextChanged += new System.EventHandler(this.txtÖğrenciNO_TextChanged);
            // 
            // txtAdı
            // 
            this.txtAdı.Location = new System.Drawing.Point(262, 280);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(100, 20);
            this.txtAdı.TabIndex = 3;
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.Location = new System.Drawing.Point(262, 316);
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Size = new System.Drawing.Size(100, 20);
            this.txtSoyadı.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(262, 352);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(432, 255);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(432, 293);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelle.TabIndex = 7;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(432, 332);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(208, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Öğrenci Bilgileri Aşağıda görünmektedir.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(165, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ÖğrenciNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(159, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Öğrenci Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(139, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Öğrenci Soyadı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(138, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Öğrenci Telefonu";
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(546, 280);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 10;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(150, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Öğrencinin ismini aratınız";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::telefon_otom.Properties.Resources._1024452;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 381);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyadı);
            this.Controls.Add(this.txtAdı);
            this.Controls.Add(this.txtÖğrenciNO);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Bilgi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtÖğrenciNO;
        private System.Windows.Forms.TextBox txtAdı;
        private System.Windows.Forms.TextBox txtSoyadı;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}

