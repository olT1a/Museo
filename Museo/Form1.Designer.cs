
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
            this.label2.Location = new System.Drawing.Point(288, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 116);
            this.label2.TabIndex = 1;
            this.label2.Text = "Museo";
            // 
            // btn_apriMuseo
            // 
            this.btn_apriMuseo.Location = new System.Drawing.Point(356, 158);
            this.btn_apriMuseo.Name = "btn_apriMuseo";
            this.btn_apriMuseo.Size = new System.Drawing.Size(121, 57);
            this.btn_apriMuseo.TabIndex = 2;
            this.btn_apriMuseo.Text = "Apri il museo!";
            this.btn_apriMuseo.UseVisualStyleBackColor = true;
            this.btn_apriMuseo.Click += new System.EventHandler(this.btn_apriMuseo_Click);
            // 
            // list_coda
            // 
            this.list_coda.FormattingEnabled = true;
            this.list_coda.ItemHeight = 15;
            this.list_coda.Location = new System.Drawing.Point(618, 9);
            this.list_coda.Name = "list_coda";
            this.list_coda.Size = new System.Drawing.Size(145, 454);
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
            this.lbl_saluto.Location = new System.Drawing.Point(356, 250);
            this.lbl_saluto.Name = "lbl_saluto";
            this.lbl_saluto.Size = new System.Drawing.Size(36, 15);
            this.lbl_saluto.TabIndex = 4;
            this.lbl_saluto.Text = "Saluti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 491);
            this.Controls.Add(this.lbl_saluto);
            this.Controls.Add(this.list_coda);
            this.Controls.Add(this.btn_apriMuseo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nPersone);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

