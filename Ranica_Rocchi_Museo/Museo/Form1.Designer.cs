
namespace Museo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_nPersone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list_coda = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_saluto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_tornelli = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.list_museo = new System.Windows.Forms.ListBox();
            this.list_ingresso3 = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.list_ingresso2 = new System.Windows.Forms.ListBox();
            this.list_ingresso1 = new System.Windows.Forms.ListBox();
            this.pic_tornello3 = new System.Windows.Forms.PictureBox();
            this.pic_tornello2 = new System.Windows.Forms.PictureBox();
            this.pic_tornello1 = new System.Windows.Forms.PictureBox();
            this.timerTornelli = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_collina = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_gioconda = new System.Windows.Forms.PictureBox();
            this.lbl_stanza1 = new System.Windows.Forms.Label();
            this.lbl_stanza2 = new System.Windows.Forms.Label();
            this.pic_napoleone = new System.Windows.Forms.PictureBox();
            this.lbl_infoGioconda = new System.Windows.Forms.Label();
            this.list_eventi = new System.Windows.Forms.ListBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timerMuseo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_tornelli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tornello3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tornello2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tornello1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_collina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gioconda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_napoleone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nPersone
            // 
            this.lbl_nPersone.AutoSize = true;
            this.lbl_nPersone.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_nPersone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nPersone.Location = new System.Drawing.Point(0, 0);
            this.lbl_nPersone.Name = "lbl_nPersone";
            this.lbl_nPersone.Size = new System.Drawing.Size(144, 20);
            this.lbl_nPersone.TabIndex = 0;
            this.lbl_nPersone.Text = "Persone prenotate: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Òl Museo";
            // 
            // list_coda
            // 
            this.list_coda.FormattingEnabled = true;
            this.list_coda.ItemHeight = 22;
            this.list_coda.Location = new System.Drawing.Point(71, 359);
            this.list_coda.Name = "list_coda";
            this.list_coda.Size = new System.Drawing.Size(165, 268);
            this.list_coda.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_saluto
            // 
            this.lbl_saluto.AutoSize = true;
            this.lbl_saluto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_saluto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_saluto.Location = new System.Drawing.Point(53, 94);
            this.lbl_saluto.Name = "lbl_saluto";
            this.lbl_saluto.Size = new System.Drawing.Size(264, 24);
            this.lbl_saluto.TabIndex = 4;
            this.lbl_saluto.Text = "Ol museo piö bél de Berghem";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Museo.Properties.Resources.museo;
            this.pictureBox1.Location = new System.Drawing.Point(38, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 284);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_tornelli
            // 
            this.pnl_tornelli.BackColor = System.Drawing.Color.Transparent;
            this.pnl_tornelli.Controls.Add(this.label1);
            this.pnl_tornelli.Controls.Add(this.list_museo);
            this.pnl_tornelli.Controls.Add(this.list_ingresso3);
            this.pnl_tornelli.Controls.Add(this.pictureBox3);
            this.pnl_tornelli.Controls.Add(this.list_ingresso2);
            this.pnl_tornelli.Controls.Add(this.list_ingresso1);
            this.pnl_tornelli.Controls.Add(this.pic_tornello3);
            this.pnl_tornelli.Controls.Add(this.pic_tornello2);
            this.pnl_tornelli.Controls.Add(this.pic_tornello1);
            this.pnl_tornelli.Location = new System.Drawing.Point(439, 0);
            this.pnl_tornelli.Name = "pnl_tornelli";
            this.pnl_tornelli.Size = new System.Drawing.Size(472, 635);
            this.pnl_tornelli.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(62, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingressi";
            // 
            // list_museo
            // 
            this.list_museo.FormattingEnabled = true;
            this.list_museo.ItemHeight = 22;
            this.list_museo.Location = new System.Drawing.Point(282, 178);
            this.list_museo.Name = "list_museo";
            this.list_museo.Size = new System.Drawing.Size(139, 290);
            this.list_museo.TabIndex = 9;
            // 
            // list_ingresso3
            // 
            this.list_ingresso3.FormattingEnabled = true;
            this.list_ingresso3.ItemHeight = 22;
            this.list_ingresso3.Location = new System.Drawing.Point(23, 458);
            this.list_ingresso3.Name = "list_ingresso3";
            this.list_ingresso3.Size = new System.Drawing.Size(153, 136);
            this.list_ingresso3.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Museo.Properties.Resources.kisspng_police_officer_coloring_book_police_car_clip_art_policeman_cartoon_5a89b72ed8dc83_7007234015189747668883;
            this.pictureBox3.Location = new System.Drawing.Point(5, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 80);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // list_ingresso2
            // 
            this.list_ingresso2.FormattingEnabled = true;
            this.list_ingresso2.ItemHeight = 22;
            this.list_ingresso2.Location = new System.Drawing.Point(21, 267);
            this.list_ingresso2.Name = "list_ingresso2";
            this.list_ingresso2.Size = new System.Drawing.Size(153, 136);
            this.list_ingresso2.TabIndex = 6;
            // 
            // list_ingresso1
            // 
            this.list_ingresso1.FormattingEnabled = true;
            this.list_ingresso1.ItemHeight = 22;
            this.list_ingresso1.Location = new System.Drawing.Point(23, 84);
            this.list_ingresso1.Name = "list_ingresso1";
            this.list_ingresso1.Size = new System.Drawing.Size(153, 136);
            this.list_ingresso1.TabIndex = 5;
            // 
            // pic_tornello3
            // 
            this.pic_tornello3.Image = global::Museo.Properties.Resources.tornello;
            this.pic_tornello3.Location = new System.Drawing.Point(181, 458);
            this.pic_tornello3.Name = "pic_tornello3";
            this.pic_tornello3.Size = new System.Drawing.Size(87, 112);
            this.pic_tornello3.TabIndex = 4;
            this.pic_tornello3.TabStop = false;
            // 
            // pic_tornello2
            // 
            this.pic_tornello2.Image = global::Museo.Properties.Resources.tornello;
            this.pic_tornello2.Location = new System.Drawing.Point(181, 267);
            this.pic_tornello2.Name = "pic_tornello2";
            this.pic_tornello2.Size = new System.Drawing.Size(87, 112);
            this.pic_tornello2.TabIndex = 3;
            this.pic_tornello2.TabStop = false;
            // 
            // pic_tornello1
            // 
            this.pic_tornello1.Image = global::Museo.Properties.Resources.tornello;
            this.pic_tornello1.Location = new System.Drawing.Point(179, 84);
            this.pic_tornello1.Name = "pic_tornello1";
            this.pic_tornello1.Size = new System.Drawing.Size(87, 112);
            this.pic_tornello1.TabIndex = 0;
            this.pic_tornello1.TabStop = false;
            // 
            // timerTornelli
            // 
            this.timerTornelli.Enabled = true;
            this.timerTornelli.Interval = 1000;
            this.timerTornelli.Tick += new System.EventHandler(this.timerTornelli_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1016, 553);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 40);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pic_collina
            // 
            this.pic_collina.Location = new System.Drawing.Point(12, 665);
            this.pic_collina.Name = "pic_collina";
            this.pic_collina.Size = new System.Drawing.Size(33, 30);
            this.pic_collina.TabIndex = 9;
            this.pic_collina.TabStop = false;
            this.pic_collina.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(51, 659);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 36);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // pic_gioconda
            // 
            this.pic_gioconda.Image = global::Museo.Properties.Resources.gioconda;
            this.pic_gioconda.Location = new System.Drawing.Point(1123, 110);
            this.pic_gioconda.Name = "pic_gioconda";
            this.pic_gioconda.Size = new System.Drawing.Size(82, 113);
            this.pic_gioconda.TabIndex = 13;
            this.pic_gioconda.TabStop = false;
            // 
            // lbl_stanza1
            // 
            this.lbl_stanza1.AutoSize = true;
            this.lbl_stanza1.Location = new System.Drawing.Point(1095, 226);
            this.lbl_stanza1.Name = "lbl_stanza1";
            this.lbl_stanza1.Size = new System.Drawing.Size(180, 22);
            this.lbl_stanza1.TabIndex = 14;
            this.lbl_stanza1.Text = "Spettatore: nessuno";
            this.lbl_stanza1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_stanza2
            // 
            this.lbl_stanza2.AutoSize = true;
            this.lbl_stanza2.Location = new System.Drawing.Point(1092, 437);
            this.lbl_stanza2.Name = "lbl_stanza2";
            this.lbl_stanza2.Size = new System.Drawing.Size(180, 22);
            this.lbl_stanza2.TabIndex = 16;
            this.lbl_stanza2.Text = "Spettatore: nessuno";
            this.lbl_stanza2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_napoleone
            // 
            this.pic_napoleone.Image = global::Museo.Properties.Resources.napoleone;
            this.pic_napoleone.Location = new System.Drawing.Point(1092, 267);
            this.pic_napoleone.Name = "pic_napoleone";
            this.pic_napoleone.Size = new System.Drawing.Size(141, 167);
            this.pic_napoleone.TabIndex = 15;
            this.pic_napoleone.TabStop = false;
            // 
            // lbl_infoGioconda
            // 
            this.lbl_infoGioconda.AutoSize = true;
            this.lbl_infoGioconda.Location = new System.Drawing.Point(1503, 152);
            this.lbl_infoGioconda.Name = "lbl_infoGioconda";
            this.lbl_infoGioconda.Size = new System.Drawing.Size(0, 22);
            this.lbl_infoGioconda.TabIndex = 17;
            // 
            // list_eventi
            // 
            this.list_eventi.FormattingEnabled = true;
            this.list_eventi.ItemHeight = 22;
            this.list_eventi.Location = new System.Drawing.Point(1325, 67);
            this.list_eventi.Name = "list_eventi";
            this.list_eventi.Size = new System.Drawing.Size(337, 422);
            this.list_eventi.TabIndex = 18;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Museo.Properties.Resources.porta;
            this.pictureBox4.Location = new System.Drawing.Point(1063, 514);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 117);
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // timerMuseo
            // 
            this.timerMuseo.Enabled = true;
            this.timerMuseo.Tick += new System.EventHandler(this.timerMuseo_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1688, 646);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.list_eventi);
            this.Controls.Add(this.lbl_infoGioconda);
            this.Controls.Add(this.lbl_stanza2);
            this.Controls.Add(this.pic_napoleone);
            this.Controls.Add(this.lbl_stanza1);
            this.Controls.Add(this.pic_gioconda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnl_tornelli);
            this.Controls.Add(this.list_coda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_saluto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nPersone);
            this.Controls.Add(this.pic_collina);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Museo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_tornelli.ResumeLayout(false);
            this.pnl_tornelli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tornello3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tornello2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tornello1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_collina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gioconda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_napoleone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nPersone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list_coda;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_saluto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_tornelli;
        private System.Windows.Forms.PictureBox pic_tornello1;
        private System.Windows.Forms.PictureBox pic_tornello3;
        private System.Windows.Forms.PictureBox pic_tornello2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox list_ingresso3;
        private System.Windows.Forms.ListBox list_ingresso2;
        private System.Windows.Forms.ListBox list_ingresso1;
        public System.Windows.Forms.Timer timerTornelli;
        private System.Windows.Forms.ListBox list_museo;
        private System.Windows.Forms.PictureBox pic_collina;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pic_gioconda;
        private System.Windows.Forms.Label lbl_stanza1;
        private System.Windows.Forms.Label lbl_stanza2;
        private System.Windows.Forms.PictureBox pic_napoleone;
        private System.Windows.Forms.Label lbl_infoGioconda;
        private System.Windows.Forms.ListBox list_eventi;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timerMuseo;
    }
}

