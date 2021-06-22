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
            this.brn_register = new System.Windows.Forms.Button();
            this.lbl_register = new System.Windows.Forms.Label();
            this.btn_vaccinationProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBanner)).BeginInit();
            this.panelBanner.SuspendLayout();
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
            this.panelBanner.Controls.Add(this.pictureBoxBanner);
            this.panelBanner.Location = new System.Drawing.Point(-1, 0);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(438, 71);
            this.panelBanner.TabIndex = 1;
<<<<<<< HEAD
            // 
            // brn_register
            // 
            this.brn_register.BackColor = System.Drawing.Color.Transparent;
            this.brn_register.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("brn_register.BackgroundImage")));
            this.brn_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.brn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brn_register.FlatAppearance.BorderSize = 0;
            this.brn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.brn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.brn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brn_register.Location = new System.Drawing.Point(40, 172);
            this.brn_register.Name = "brn_register";
            this.brn_register.Size = new System.Drawing.Size(151, 146);
            this.brn_register.TabIndex = 2;
            this.brn_register.UseVisualStyleBackColor = false;
            this.brn_register.Click += new System.EventHandler(this.brn_register_Click);
=======
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
>>>>>>> 0a8242fa66d9bc3a51f34e6b9e2b9a1cc257a1fb
            // 
            // lbl_register
            // 
            this.lbl_register.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_register.ForeColor = System.Drawing.Color.Black;
            this.lbl_register.Location = new System.Drawing.Point(62, 124);
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
            this.btn_vaccinationProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btn_vaccinationProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_vaccinationProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vaccinationProcess.Location = new System.Drawing.Point(234, 172);
            this.btn_vaccinationProcess.Name = "btn_vaccinationProcess";
            this.btn_vaccinationProcess.Size = new System.Drawing.Size(151, 146);
            this.btn_vaccinationProcess.TabIndex = 4;
            this.btn_vaccinationProcess.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(242, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Iniciar proceso\r\nvacunación";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_vaccinationProcess);
            this.Controls.Add(this.lbl_register);
            this.Controls.Add(this.brn_register);
            this.Controls.Add(this.panelBanner);
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBanner)).EndInit();
            this.panelBanner.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button brn_register;

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