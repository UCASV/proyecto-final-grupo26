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
            this.lbl_logOut = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.lbl_register = new System.Windows.Forms.Label();
            this.lbl_vaccinateProcess = new System.Windows.Forms.Label();
            this.statusStripMainMenu = new System.Windows.Forms.StatusStrip();
            this.lbl_userStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_vaccinateProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBanner)).BeginInit();
            this.panelBanner.SuspendLayout();
            this.statusStripMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxBanner.Image")));
            this.pictureBoxBanner.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(217, 72);
            this.pictureBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBanner.TabIndex = 0;
            this.pictureBoxBanner.TabStop = false;
            // 
            // panelBanner
            // 
            this.panelBanner.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.panelBanner.Controls.Add(this.lbl_logOut);
            this.panelBanner.Controls.Add(this.btn_LogOut);
            this.panelBanner.Controls.Add(this.pictureBoxBanner);
            this.panelBanner.Location = new System.Drawing.Point(-1, 0);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(497, 75);
            this.panelBanner.TabIndex = 1;
            // {
            // brn_register
            // 
            
            
            // lbl_logOut
            // 
            this.lbl_logOut.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logOut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_logOut.ForeColor = System.Drawing.Color.Black;
            this.lbl_logOut.Location = new System.Drawing.Point(382, 55);
            this.lbl_logOut.Name = "lbl_logOut";
            this.lbl_logOut.Size = new System.Drawing.Size(115, 16);
            this.lbl_logOut.TabIndex = 2;
            this.lbl_logOut.Text = "Cerrar Sesión";
            this.lbl_logOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_LogOut.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btn_LogOut.BackgroundImage")));
            this.btn_LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOut.FlatAppearance.BorderSize = 0;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Location = new System.Drawing.Point(414, 0);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(58, 57);
            this.btn_LogOut.TabIndex = 1;
            this.btn_LogOut.UseVisualStyleBackColor = false;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_register.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btn_register.BackgroundImage")));
            this.btn_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Location = new System.Drawing.Point(57, 172);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(151, 146);
            this.btn_register.TabIndex = 2;
            this.btn_register.UseVisualStyleBackColor = false;
            // 
            // lbl_register
            // 
            this.lbl_register.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_register.ForeColor = System.Drawing.Color.Black;
            this.lbl_register.Location = new System.Drawing.Point(78, 118);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(114, 46);
            this.lbl_register.TabIndex = 3;
            this.lbl_register.Text = "Agendar\r\ncita";
            this.lbl_register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_vaccinateProcess
            // 
            this.lbl_vaccinateProcess.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_vaccinateProcess.Location = new System.Drawing.Point(290, 112);
            this.lbl_vaccinateProcess.Name = "lbl_vaccinateProcess";
            this.lbl_vaccinateProcess.Size = new System.Drawing.Size(143, 58);
            this.lbl_vaccinateProcess.TabIndex = 5;
            this.lbl_vaccinateProcess.Text = "Iniciar proceso\r\nvacunación";
            this.lbl_vaccinateProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_vaccinateProcess.UseMnemonic = false;
            // 
            // statusStripMainMenu
            // 
            this.statusStripMainMenu.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.statusStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.lbl_userStatusStrip});
            this.statusStripMainMenu.Location = new System.Drawing.Point(0, 383);
            this.statusStripMainMenu.Name = "statusStripMainMenu";
            this.statusStripMainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStripMainMenu.Size = new System.Drawing.Size(496, 22);
            this.statusStripMainMenu.TabIndex = 6;
            this.statusStripMainMenu.Text = "statusStrip1";
            // 
            // lbl_userStatusStrip
            // 
            this.lbl_userStatusStrip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_userStatusStrip.ForeColor = System.Drawing.Color.White;
            this.lbl_userStatusStrip.Name = "lbl_userStatusStrip";
            this.lbl_userStatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_userStatusStrip.RightToLeftAutoMirrorImage = true;
            this.lbl_userStatusStrip.Size = new System.Drawing.Size(60, 17);
            this.lbl_userStatusStrip.Text = "Usuario: ";
            // 
            // btn_vaccinateProcess
            // 
            this.btn_vaccinateProcess.BackColor = System.Drawing.Color.Transparent;
            this.btn_vaccinateProcess.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btn_vaccinateProcess.BackgroundImage")));
            this.btn_vaccinateProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_vaccinateProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vaccinateProcess.FlatAppearance.BorderSize = 0;
            this.btn_vaccinateProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_vaccinateProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_vaccinateProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vaccinateProcess.Location = new System.Drawing.Point(282, 173);
            this.btn_vaccinateProcess.Name = "btn_vaccinateProcess";
            this.btn_vaccinateProcess.Size = new System.Drawing.Size(151, 146);
            this.btn_vaccinateProcess.TabIndex = 7;
            this.btn_vaccinateProcess.UseVisualStyleBackColor = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 405);
            this.Controls.Add(this.btn_vaccinateProcess);
            this.Controls.Add(this.statusStripMainMenu);
            this.Controls.Add(this.lbl_vaccinateProcess);
            this.Controls.Add(this.lbl_register);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.panelBanner);
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBanner)).EndInit();
            this.panelBanner.ResumeLayout(false);
            this.statusStripMainMenu.ResumeLayout(false);
            this.statusStripMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_vaccinateProcess;

        private System.Windows.Forms.Label lbl_logOut;

        private System.Windows.Forms.Button btn_LogOut;

        private System.Windows.Forms.Button btn_register;

        private System.Windows.Forms.Label lbl_vaccinateProcess;

        private System.Windows.Forms.StatusStrip statusStripMainMenu;

        private System.Windows.Forms.ToolStripStatusLabel lbl_userStatusStrip;

        private System.Windows.Forms.Label lbl_register;

        private System.Windows.Forms.PictureBox pictureBoxBanner;
        
        private System.Windows.Forms.Panel panelBanner;

        #endregion
    }
}