using System.ComponentModel;

namespace Proyecto_POO_BDD
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_DuiSearch = new System.Windows.Forms.Label();
            this.txt_DuiSearch = new System.Windows.Forms.TextBox();
            this.panelBanner = new System.Windows.Forms.Panel();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.dgv_citizenInformation = new System.Windows.Forms.DataGridView();
            this.bt_download = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panelBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_citizenInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(288, 85);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 40);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_DuiSearch
            // 
            this.lbl_DuiSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_DuiSearch.Location = new System.Drawing.Point(22, 96);
            this.lbl_DuiSearch.Name = "lbl_DuiSearch";
            this.lbl_DuiSearch.Size = new System.Drawing.Size(47, 24);
            this.lbl_DuiSearch.TabIndex = 1;
            this.lbl_DuiSearch.Text = "DUI:";
            // 
            // txt_DuiSearch
            // 
            this.txt_DuiSearch.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_DuiSearch.Location = new System.Drawing.Point(65, 94);
            this.txt_DuiSearch.Name = "txt_DuiSearch";
            this.txt_DuiSearch.Size = new System.Drawing.Size(204, 24);
            this.txt_DuiSearch.TabIndex = 2;
            // 
            // panelBanner
            // 
            this.panelBanner.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.panelBanner.Controls.Add(this.pictureBoxBanner);
            this.panelBanner.Location = new System.Drawing.Point(0, 0);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(606, 73);
            this.panelBanner.TabIndex = 3;
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxBanner.Image")));
            this.pictureBoxBanner.Location = new System.Drawing.Point(0, -1);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(217, 72);
            this.pictureBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBanner.TabIndex = 0;
            this.pictureBoxBanner.TabStop = false;
            this.pictureBoxBanner.WaitOnLoad = true;
            // 
            // dgv_citizenInformation
            // 
            this.dgv_citizenInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_citizenInformation.Location = new System.Drawing.Point(22, 143);
            this.dgv_citizenInformation.Name = "dgv_citizenInformation";
            this.dgv_citizenInformation.Size = new System.Drawing.Size(561, 83);
            this.dgv_citizenInformation.TabIndex = 4;
            // 
            // bt_download
            // 
            this.bt_download.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.bt_download.FlatAppearance.BorderSize = 0;
            this.bt_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_download.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bt_download.ForeColor = System.Drawing.Color.White;
            this.bt_download.Location = new System.Drawing.Point(261, 246);
            this.bt_download.Name = "bt_download";
            this.bt_download.Size = new System.Drawing.Size(155, 40);
            this.bt_download.TabIndex = 5;
            this.bt_download.Text = "Descargar";
            this.bt_download.UseVisualStyleBackColor = false;
            this.bt_download.Click += new System.EventHandler(this.bt_download_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(470, 246);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(113, 40);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Salir";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 306);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.bt_download);
            this.Controls.Add(this.dgv_citizenInformation);
            this.Controls.Add(this.panelBanner);
            this.Controls.Add(this.txt_DuiSearch);
            this.Controls.Add(this.lbl_DuiSearch);
            this.Controls.Add(this.btn_search);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.panelBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_citizenInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_cancel;

        private System.Windows.Forms.Button bt_download;

        private System.Windows.Forms.DataGridView dgv_citizenInformation;

        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.PictureBox pictureBoxBanner;

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_DuiSearch;
        private System.Windows.Forms.TextBox txt_DuiSearch;

        #endregion
    }
}