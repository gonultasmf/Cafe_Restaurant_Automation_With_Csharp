
namespace Cafe_Otomat
{
    partial class FrmIndirimControl
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
            this.chckIndirim = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chckIndirim
            // 
            this.chckIndirim.AutoSize = true;
            this.chckIndirim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckIndirim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chckIndirim.Location = new System.Drawing.Point(98, 19);
            this.chckIndirim.Name = "chckIndirim";
            this.chckIndirim.Size = new System.Drawing.Size(119, 18);
            this.chckIndirim.TabIndex = 69;
            this.chckIndirim.Text = "İndirim Kontrol";
            this.chckIndirim.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(44, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 68;
            this.label18.Text = "Bitiş :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(15, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 67;
            this.label17.Text = "Başlangıç :";
            // 
            // dateBitis
            // 
            this.dateBitis.CalendarFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBitis.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBitis.Location = new System.Drawing.Point(81, 80);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(136, 26);
            this.dateBitis.TabIndex = 65;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.CalendarFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBaslangic.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBaslangic.Location = new System.Drawing.Point(81, 45);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(136, 26);
            this.dateBaslangic.TabIndex = 64;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(39, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 14);
            this.label16.TabIndex = 66;
            this.label16.Text = "İndirim :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = global::Cafe_Otomat.Properties.Resources._checked;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.Location = new System.Drawing.Point(13, 125);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(210, 46);
            this.btnKaydet.TabIndex = 70;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmIndirimControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(235, 183);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chckIndirim);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dateBitis);
            this.Controls.Add(this.dateBaslangic);
            this.Controls.Add(this.label16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmIndirimControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İndirim Kontrol";
            this.Load += new System.EventHandler(this.FrmIndirimControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chckIndirim;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnKaydet;
    }
}