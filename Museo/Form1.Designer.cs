
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
            this.lbl_nPersone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_apriMuseo = new System.Windows.Forms.Button();
            this.list_coda = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_saluto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_tornelli = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nPersone
            // 
            this.lbl_nPersone.AutoSize = true;
            this.lbl_nPersone.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_nPersone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nPersone.Location = new System.Drawing.Point(0, 0);
            this.lbl_nPersone.Name = "lbl_nPersone";
            this.lbl_nPersone.Size = new System.Drawing.Size(115, 15);
            this.lbl_nPersone.TabIndex = 0;
            this.lbl_nPersone.Text = "Persone prenotate: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vladimir Script", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 116);
            this.label2.TabIndex = 1;
            this.label2.Text = "Òl Museo";
            // 
            // btn_apriMuseo
            // 
            this.btn_apriMuseo.Location = new System.Drawing.Point(137, 144);
            this.btn_apriMuseo.Name = "btn_apriMuseo";
            this.btn_apriMuseo.Size = new System.Drawing.Size(138, 65);
            this.btn_apriMuseo.TabIndex = 2;
            this.btn_apriMuseo.Text = "Apri il museo!";
            this.btn_apriMuseo.UseVisualStyleBackColor = true;
            this.btn_apriMuseo.Click += new System.EventHandler(this.btn_apriMuseo_Click);
            // 
            // list_coda
            // 
            this.list_coda.FormattingEnabled = true;
            this.list_coda.ItemHeight = 17;
            this.list_coda.Location = new System.Drawing.Point(407, 212);
            this.list_coda.Name = "list_coda";
            this.list_coda.Size = new System.Drawing.Size(165, 344);
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
            this.lbl_saluto.Location = new System.Drawing.Point(110, 124);
            this.lbl_saluto.Name = "lbl_saluto";
            this.lbl_saluto.Size = new System.Drawing.Size(202, 17);
            this.lbl_saluto.TabIndex = 4;
            this.lbl_saluto.Text = "Ol museo piö bél de Berghem";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Museo.Properties.Resources.museo;
            this.pictureBox1.Location = new System.Drawing.Point(376, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 286);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_tornelli
            // 
            this.pnl_tornelli.Location = new System.Drawing.Point(654, 56);
            this.pnl_tornelli.Name = "pnl_tornelli";
            this.pnl_tornelli.Size = new System.Drawing.Size(708, 454);
            this.pnl_tornelli.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 591);
            this.Controls.Add(this.pnl_tornelli);
            this.Controls.Add(this.list_coda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_saluto);
            this.Controls.Add(this.btn_apriMuseo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nPersone);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nPersone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_apriMuseo;
        private System.Windows.Forms.ListBox list_coda;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_saluto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_tornelli;
    }
}

