
namespace Cafe_Otomat
{
    partial class FrmStokSec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokSec));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboArama = new System.Windows.Forms.ComboBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listeDeneme = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listeUrun = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeDeneme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listeUrun);
            this.panel1.Controls.Add(this.listeDeneme);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboArama);
            this.panel2.Controls.Add(this.btnSec);
            this.panel2.Controls.Add(this.txtArama);
            this.panel2.Controls.Add(this.label1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // comboArama
            // 
            this.comboArama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboArama, "comboArama");
            this.comboArama.FormattingEnabled = true;
            this.comboArama.Items.AddRange(new object[] {
            resources.GetString("comboArama.Items"),
            resources.GetString("comboArama.Items1"),
            resources.GetString("comboArama.Items2"),
            resources.GetString("comboArama.Items3")});
            this.comboArama.Name = "comboArama";
            // 
            // btnSec
            // 
            resources.ApplyResources(this.btnSec, "btnSec");
            this.btnSec.Image = global::Cafe_Otomat.Properties.Resources.refinement;
            this.btnSec.Name = "btnSec";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // txtArama
            // 
            resources.ApplyResources(this.txtArama, "txtArama");
            this.txtArama.Name = "txtArama";
            this.txtArama.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            this.txtArama.Enter += new System.EventHandler(this.txtBarkod_Enter);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // listeDeneme
            // 
            this.listeDeneme.AllowUserToAddRows = false;
            this.listeDeneme.AllowUserToDeleteRows = false;
            this.listeDeneme.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            this.listeDeneme.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.listeDeneme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeDeneme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.listeDeneme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeDeneme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            resources.ApplyResources(this.listeDeneme, "listeDeneme");
            this.listeDeneme.Name = "listeDeneme";
            this.listeDeneme.ReadOnly = true;
            this.listeDeneme.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.listeDeneme.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.listeDeneme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // listeUrun
            // 
            this.listeUrun.AllowUserToAddRows = false;
            this.listeUrun.AllowUserToDeleteRows = false;
            this.listeUrun.AllowUserToOrderColumns = true;
            this.listeUrun.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.listeUrun.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listeUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeUrun.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.listeUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.listeUrun, "listeUrun");
            this.listeUrun.Name = "listeUrun";
            this.listeUrun.ReadOnly = true;
            this.listeUrun.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.listeUrun.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.listeUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // FrmStokSec
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStokSec";
            this.Load += new System.EventHandler(this.FrmStokSec_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeDeneme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeUrun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboArama;
        private System.Windows.Forms.DataGridView listeDeneme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView listeUrun;
    }
}