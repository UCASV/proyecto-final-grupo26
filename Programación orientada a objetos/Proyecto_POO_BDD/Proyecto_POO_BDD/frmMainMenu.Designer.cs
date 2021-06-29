using System.ComponentModel;

namespace Proyecto_POO_BDD
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.panelBanner = new System.Windows.Forms.Panel();
            this.lbl_LogOut = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_register = new System.Windows.Forms.Label();
            this.btn_vaccinationProcess = new System.Windows.Forms.Button();
            this.lbl_vaccinate = new System.Windows.Forms.Label();
            this.btn_citizenRegister = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lbl_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBanner)).BeginInit();
            this.panelBanner.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // panelBanner
            // 
            this.panelBanner.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.panelBanner.Controls.Add(this.lbl_LogOut);
            this.panelBanner.Controls.Add(this.btn_LogOut);
            this.panelBanner.Controls.Add(this.pictureBoxBanner);
            this.panelBanner.Location = new System.Drawing.Point(-1, 0);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(533, 73);
            this.panelBanner.TabIndex = 1;
            // 
            // lbl_LogOut
            // 
            this.lbl_LogOut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_LogOut.Location = new System.Drawing.Point(429, 46);
            this.lbl_LogOut.Name = "lbl_LogOut";
            this.lbl_LogOut.Size = new System.Drawing.Size(107, 27);
            this.lbl_LogOut.TabIndex = 9;
            this.lbl_LogOut.Text = "Cerrar sesión";
            this.lbl_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_LogOut.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btn_LogOut.BackgroundImage")));
            this.btn_LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOut.FlatAppearance.BorderSize = 0;
            this.btn_LogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_LogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Location = new System.Drawing.Point(456, -1);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(55, 61);
            this.btn_LogOut.TabIndex = 8;
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // lbl_register
            // 
            this.lbl_register.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_register.ForeColor = System.Drawing.Color.Black;
            this.lbl_register.Location = new System.Drawing.Point(22, 102);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(114, 34);
            this.lbl_register.TabIndex = 3;
            this.lbl_register.Text = "Agendar\r\ncita";
            this.lbl_register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_vaccinationProcess
            // 
            this.btn_vaccinationProcess.BackColor = System.Drawing.Color.Transparent;
            this.btn_vaccinationProcess.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btn_vaccinationProcess.BackgroundImage")));
            this.btn_vaccinationProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_vaccinationProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vaccinationProcess.FlatAppearance.BorderSize = 0;
            this.btn_vaccinationProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_vaccinationProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_vaccinationProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vaccinationProcess.Location = new System.Drawing.Point(367, 150);
            this.btn_vaccinationProcess.Name = "btn_vaccinationProcess";
            this.btn_vaccinationProcess.Size = new System.Drawing.Size(151, 146);
            this.btn_vaccinationProcess.TabIndex = 4;
            this.btn_vaccinationProcess.UseVisualStyleBackColor = false;
            this.btn_vaccinationProcess.Click += new System.EventHandler(this.btn_vaccinationProcess_Click);
            // 
            // lbl_vaccinate
            // 
            this.lbl_vaccinate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_vaccinate.Location = new System.Drawing.Point(367, 89);
            this.lbl_vaccinate.Name = "lbl_vaccinate";
            this.lbl_vaccinate.Size = new System.Drawing.Size(143, 58);
            this.lbl_vaccinate.TabIndex = 5;
            this.lbl_vaccinate.Text = "Iniciar proceso\r\nvacunación";
            this.lbl_vaccinate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_citizenRegister
            // 
            this.btn_citizenRegister.BackColor = System.Drawing.Color.Transparent;
            this.btn_citizenRegister.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btn_citizenRegister.BackgroundImage")));
            this.btn_citizenRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_citizenRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_citizenRegister.FlatAppearance.BorderSize = 0;
            this.btn_citizenRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_citizenRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_citizenRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_citizenRegister.Location = new System.Drawing.Point(12, 150);
            this.btn_citizenRegister.Name = "btn_citizenRegister";
            this.btn_citizenRegister.Size = new System.Drawing.Size(151, 146);
            this.btn_citizenRegister.TabIndex = 6;
            this.btn_citizenRegister.UseVisualStyleBackColor = false;
            this.btn_citizenRegister.Click += new System.EventHandler(this.btn_citizenRegister_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.lbl_user});
            this.statusStrip.Location = new System.Drawing.Point(0, 369);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(532, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lbl_user
            // 
            this.lbl_user.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(60, 17);
            this.lbl_user.Text = "Usuario: ";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Location = new System.Drawing.Point(187, 150);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(151, 146);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_search
            // 
            this.lbl_search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_search.Location = new System.Drawing.Point(195, 90);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(143, 58);
            this.lbl_search.TabIndex = 9;
            this.lbl_search.Text = "Buscar";
            this.lbl_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 391);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btn_citizenRegister);
            this.Controls.Add(this.lbl_vaccinate);
            this.Controls.Add(this.btn_vaccinationProcess);
            this.Controls.Add(this.lbl_register);
            this.Controls.Add(this.panelBanner);
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBanner)).EndInit();
            this.panelBanner.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_search;
        
        private System.Windows.Forms.Button btn_Search;

        private System.Windows.Forms.Button btn_LogOut;

        private System.Windows.Forms.Label lbl_LogOut;

        private System.Windows.Forms.ToolStripStatusLabel lbl_user;

        private System.Windows.Forms.StatusStrip statusStrip;

        private System.Windows.Forms.Button btn_citizenRegister;

        private System.Windows.Forms.Button btn_vaccinationProcess;

        private System.Windows.Forms.Label lbl_vaccinate;

        private System.Windows.Forms.Label lbl_register;

        private System.Windows.Forms.PictureBox pictureBoxBanner;
        
        private System.Windows.Forms.Panel panelBanner;

        #endregion
    }
}