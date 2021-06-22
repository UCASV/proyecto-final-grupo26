using System.ComponentModel;

namespace Proyecto_POO_BDD
{
    partial class frmRegisterCitizen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterCitizen));
            this.panelBannerTab1 = new System.Windows.Forms.Panel();
            this.pictureBoxBannerTab1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_dui = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_numerPhone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_dui = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_celphone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.gBox_Institution = new System.Windows.Forms.GroupBox();
            this.rb_institutionYes = new System.Windows.Forms.RadioButton();
            this.rb_institutionNo = new System.Windows.Forms.RadioButton();
            this.gBox_diseases = new System.Windows.Forms.GroupBox();
            this.rb_deseasesYes = new System.Windows.Forms.RadioButton();
            this.rb_deseasesNo = new System.Windows.Forms.RadioButton();
            this.btn_register = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_cancelDeseases = new System.Windows.Forms.Button();
            this.btn_aceptDeseases = new System.Windows.Forms.Button();
            this.cmb_Deseases = new System.Windows.Forms.ComboBox();
            this.lbl_deseases = new System.Windows.Forms.Label();
            this.panelBannerTab2 = new System.Windows.Forms.Panel();
            this.pictureBoxBannerTab2 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_cancelTab3 = new System.Windows.Forms.Button();
            this.btn_aceptTab3 = new System.Windows.Forms.Button();
            this.lbl_nameInstitution = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_numInstitution = new System.Windows.Forms.TextBox();
            this.lbl_numInstitution = new System.Windows.Forms.Label();
            this.panelBannerTab3 = new System.Windows.Forms.Panel();
            this.pictureBoxBannerTab3 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelBannerTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gBox_Institution.SuspendLayout();
            this.gBox_diseases.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelBannerTab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panelBannerTab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBannerTab1
            // 
            this.panelBannerTab1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.panelBannerTab1.Controls.Add(this.pictureBoxBannerTab1);
            this.panelBannerTab1.Location = new System.Drawing.Point(0, 0);
            this.panelBannerTab1.Name = "panelBannerTab1";
            this.panelBannerTab1.Size = new System.Drawing.Size(513, 81);
            this.panelBannerTab1.TabIndex = 2;
            // 
            // pictureBoxBannerTab1
            // 
            this.pictureBoxBannerTab1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxBannerTab1.Image")));
            this.pictureBoxBannerTab1.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxBannerTab1.Name = "pictureBoxBannerTab1";
            this.pictureBoxBannerTab1.Size = new System.Drawing.Size(233, 72);
            this.pictureBoxBannerTab1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBannerTab1.TabIndex = 3;
            this.pictureBoxBannerTab1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, -5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 573);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelBannerTab1);
            this.tabPage1.Controls.Add(this.btn_cancel);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.btn_register);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(273, 487);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(190, 38);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_dui, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_age, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_address, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_numerPhone, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_email, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_name, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_dui, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_age, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_celphone, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_email, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.gBox_Institution, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.gBox_diseases, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.206882F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.15931F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.15931F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.15931F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.15931F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.15931F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.074082F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.94858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.9739F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 378);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lbl_dui
            // 
            this.lbl_dui.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_dui.ForeColor = System.Drawing.Color.Black;
            this.lbl_dui.Location = new System.Drawing.Point(27, 0);
            this.lbl_dui.Name = "lbl_dui";
            this.lbl_dui.Size = new System.Drawing.Size(114, 28);
            this.lbl_dui.TabIndex = 4;
            this.lbl_dui.Text = "DUI:";
            this.lbl_dui.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(27, 34);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(143, 31);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Nombre completo:";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_age
            // 
            this.lbl_age.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_age.ForeColor = System.Drawing.Color.Black;
            this.lbl_age.Location = new System.Drawing.Point(27, 72);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(143, 31);
            this.lbl_age.TabIndex = 6;
            this.lbl_age.Text = "Edad:";
            this.lbl_age.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_address
            // 
            this.lbl_address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_address.ForeColor = System.Drawing.Color.Black;
            this.lbl_address.Location = new System.Drawing.Point(27, 110);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(143, 31);
            this.lbl_address.TabIndex = 7;
            this.lbl_address.Text = "Dirección:";
            this.lbl_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_numerPhone
            // 
            this.lbl_numerPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_numerPhone.ForeColor = System.Drawing.Color.Black;
            this.lbl_numerPhone.Location = new System.Drawing.Point(27, 148);
            this.lbl_numerPhone.Name = "lbl_numerPhone";
            this.lbl_numerPhone.Size = new System.Drawing.Size(143, 31);
            this.lbl_numerPhone.TabIndex = 8;
            this.lbl_numerPhone.Text = "Telefono:";
            this.lbl_numerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_email
            // 
            this.lbl_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_email.Location = new System.Drawing.Point(27, 186);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(143, 31);
            this.lbl_email.TabIndex = 9;
            this.lbl_email.Text = "Correo electronico:";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_name.Location = new System.Drawing.Point(176, 37);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(291, 25);
            this.txt_name.TabIndex = 12;
            // 
            // txt_dui
            // 
            this.txt_dui.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_dui.Location = new System.Drawing.Point(176, 3);
            this.txt_dui.Name = "txt_dui";
            this.txt_dui.Size = new System.Drawing.Size(291, 25);
            this.txt_dui.TabIndex = 13;
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_age.Location = new System.Drawing.Point(176, 75);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(291, 25);
            this.txt_age.TabIndex = 14;
            // 
            // txt_celphone
            // 
            this.txt_celphone.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_celphone.Location = new System.Drawing.Point(176, 151);
            this.txt_celphone.Name = "txt_celphone";
            this.txt_celphone.Size = new System.Drawing.Size(292, 25);
            this.txt_celphone.TabIndex = 16;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_email.Location = new System.Drawing.Point(176, 189);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(292, 25);
            this.txt_email.TabIndex = 17;
            // 
            // gBox_Institution
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gBox_Institution, 2);
            this.gBox_Institution.Controls.Add(this.rb_institutionYes);
            this.gBox_Institution.Controls.Add(this.rb_institutionNo);
            this.gBox_Institution.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gBox_Institution.Location = new System.Drawing.Point(27, 310);
            this.gBox_Institution.Name = "gBox_Institution";
            this.gBox_Institution.Size = new System.Drawing.Size(440, 59);
            this.gBox_Institution.TabIndex = 19;
            this.gBox_Institution.TabStop = false;
            this.gBox_Institution.Text = "¿Pertenece a alguna institución?";
            // 
            // rb_institutionYes
            // 
            this.rb_institutionYes.Location = new System.Drawing.Point(198, 30);
            this.rb_institutionYes.Name = "rb_institutionYes";
            this.rb_institutionYes.Size = new System.Drawing.Size(52, 23);
            this.rb_institutionYes.TabIndex = 2;
            this.rb_institutionYes.Text = "Si";
            this.rb_institutionYes.UseVisualStyleBackColor = true;
            this.rb_institutionYes.CheckedChanged += new System.EventHandler(this.rb_institutionYes_CheckedChanged);
            // 
            // rb_institutionNo
            // 
            this.rb_institutionNo.Checked = true;
            this.rb_institutionNo.Location = new System.Drawing.Point(18, 25);
            this.rb_institutionNo.Name = "rb_institutionNo";
            this.rb_institutionNo.Size = new System.Drawing.Size(52, 23);
            this.rb_institutionNo.TabIndex = 2;
            this.rb_institutionNo.TabStop = true;
            this.rb_institutionNo.Text = "No";
            this.rb_institutionNo.UseVisualStyleBackColor = true;
            // 
            // gBox_diseases
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gBox_diseases, 2);
            this.gBox_diseases.Controls.Add(this.rb_deseasesYes);
            this.gBox_diseases.Controls.Add(this.rb_deseasesNo);
            this.gBox_diseases.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gBox_diseases.Location = new System.Drawing.Point(27, 246);
            this.gBox_diseases.Name = "gBox_diseases";
            this.gBox_diseases.Size = new System.Drawing.Size(440, 58);
            this.gBox_diseases.TabIndex = 18;
            this.gBox_diseases.TabStop = false;
            this.gBox_diseases.Text = "¿Padece de alguna enfermedad cronica?";
            // 
            // rb_deseasesYes
            // 
            this.rb_deseasesYes.Location = new System.Drawing.Point(198, 25);
            this.rb_deseasesYes.Name = "rb_deseasesYes";
            this.rb_deseasesYes.Size = new System.Drawing.Size(52, 23);
            this.rb_deseasesYes.TabIndex = 1;
            this.rb_deseasesYes.Text = "Si";
            this.rb_deseasesYes.UseVisualStyleBackColor = true;
            this.rb_deseasesYes.Click += new System.EventHandler(this.rb_deseasesYes_Click);
            // 
            // rb_deseasesNo
            // 
            this.rb_deseasesNo.Checked = true;
            this.rb_deseasesNo.Location = new System.Drawing.Point(18, 25);
            this.rb_deseasesNo.Name = "rb_deseasesNo";
            this.rb_deseasesNo.Size = new System.Drawing.Size(52, 23);
            this.rb_deseasesNo.TabIndex = 0;
            this.rb_deseasesNo.TabStop = true;
            this.rb_deseasesNo.Text = "No";
            this.rb_deseasesNo.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(37, 487);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(190, 38);
            this.btn_register.TabIndex = 9;
            this.btn_register.Text = "Registrar";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_cancelDeseases);
            this.tabPage2.Controls.Add(this.btn_aceptDeseases);
            this.tabPage2.Controls.Add(this.cmb_Deseases);
            this.tabPage2.Controls.Add(this.lbl_deseases);
            this.tabPage2.Controls.Add(this.panelBannerTab2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(513, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_cancelDeseases
            // 
            this.btn_cancelDeseases.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelDeseases.FlatAppearance.BorderSize = 0;
            this.btn_cancelDeseases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelDeseases.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_cancelDeseases.ForeColor = System.Drawing.Color.White;
            this.btn_cancelDeseases.Location = new System.Drawing.Point(274, 193);
            this.btn_cancelDeseases.Name = "btn_cancelDeseases";
            this.btn_cancelDeseases.Size = new System.Drawing.Size(191, 43);
            this.btn_cancelDeseases.TabIndex = 7;
            this.btn_cancelDeseases.Text = "Cancelar";
            this.btn_cancelDeseases.UseVisualStyleBackColor = false;
            this.btn_cancelDeseases.Click += new System.EventHandler(this.btn_cancelDeseases_Click);
            // 
            // btn_aceptDeseases
            // 
            this.btn_aceptDeseases.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.btn_aceptDeseases.FlatAppearance.BorderSize = 0;
            this.btn_aceptDeseases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptDeseases.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_aceptDeseases.ForeColor = System.Drawing.Color.White;
            this.btn_aceptDeseases.Location = new System.Drawing.Point(40, 193);
            this.btn_aceptDeseases.Name = "btn_aceptDeseases";
            this.btn_aceptDeseases.Size = new System.Drawing.Size(191, 43);
            this.btn_aceptDeseases.TabIndex = 6;
            this.btn_aceptDeseases.Text = "Aceptar";
            this.btn_aceptDeseases.UseVisualStyleBackColor = false;
            // 
            // cmb_Deseases
            // 
            this.cmb_Deseases.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmb_Deseases.FormattingEnabled = true;
            this.cmb_Deseases.Location = new System.Drawing.Point(148, 124);
            this.cmb_Deseases.Name = "cmb_Deseases";
            this.cmb_Deseases.Size = new System.Drawing.Size(317, 25);
            this.cmb_Deseases.TabIndex = 5;
            // 
            // lbl_deseases
            // 
            this.lbl_deseases.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_deseases.Location = new System.Drawing.Point(40, 126);
            this.lbl_deseases.Name = "lbl_deseases";
            this.lbl_deseases.Size = new System.Drawing.Size(118, 32);
            this.lbl_deseases.TabIndex = 4;
            this.lbl_deseases.Text = "Enfermedad:";
            // 
            // panelBannerTab2
            // 
            this.panelBannerTab2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.panelBannerTab2.Controls.Add(this.pictureBoxBannerTab2);
            this.panelBannerTab2.Location = new System.Drawing.Point(0, 0);
            this.panelBannerTab2.Name = "panelBannerTab2";
            this.panelBannerTab2.Size = new System.Drawing.Size(513, 75);
            this.panelBannerTab2.TabIndex = 3;
            // 
            // pictureBoxBannerTab2
            // 
            this.pictureBoxBannerTab2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxBannerTab2.Image")));
            this.pictureBoxBannerTab2.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxBannerTab2.Name = "pictureBoxBannerTab2";
            this.pictureBoxBannerTab2.Size = new System.Drawing.Size(233, 72);
            this.pictureBoxBannerTab2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBannerTab2.TabIndex = 3;
            this.pictureBoxBannerTab2.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_cancelTab3);
            this.tabPage3.Controls.Add(this.btn_aceptTab3);
            this.tabPage3.Controls.Add(this.lbl_nameInstitution);
            this.tabPage3.Controls.Add(this.lbl_description);
            this.tabPage3.Controls.Add(this.txt_numInstitution);
            this.tabPage3.Controls.Add(this.lbl_numInstitution);
            this.tabPage3.Controls.Add(this.panelBannerTab3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(513, 547);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_cancelTab3
            // 
            this.btn_cancelTab3.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelTab3.FlatAppearance.BorderSize = 0;
            this.btn_cancelTab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelTab3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_cancelTab3.ForeColor = System.Drawing.Color.White;
            this.btn_cancelTab3.Location = new System.Drawing.Point(276, 255);
            this.btn_cancelTab3.Name = "btn_cancelTab3";
            this.btn_cancelTab3.Size = new System.Drawing.Size(191, 43);
            this.btn_cancelTab3.TabIndex = 10;
            this.btn_cancelTab3.Text = "Cancelar";
            this.btn_cancelTab3.UseVisualStyleBackColor = false;
            this.btn_cancelTab3.Click += new System.EventHandler(this.btn_cancelTab3_Click);
            // 
            // btn_aceptTab3
            // 
            this.btn_aceptTab3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.btn_aceptTab3.FlatAppearance.BorderSize = 0;
            this.btn_aceptTab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptTab3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_aceptTab3.ForeColor = System.Drawing.Color.White;
            this.btn_aceptTab3.Location = new System.Drawing.Point(42, 255);
            this.btn_aceptTab3.Name = "btn_aceptTab3";
            this.btn_aceptTab3.Size = new System.Drawing.Size(191, 43);
            this.btn_aceptTab3.TabIndex = 9;
            this.btn_aceptTab3.Text = "Aceptar";
            this.btn_aceptTab3.UseVisualStyleBackColor = false;
            // 
            // lbl_nameInstitution
            // 
            this.lbl_nameInstitution.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_nameInstitution.Location = new System.Drawing.Point(57, 202);
            this.lbl_nameInstitution.Name = "lbl_nameInstitution";
            this.lbl_nameInstitution.Size = new System.Drawing.Size(395, 30);
            this.lbl_nameInstitution.TabIndex = 8;
            this.lbl_nameInstitution.Text = "Institución";
            // 
            // lbl_description
            // 
            this.lbl_description.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_description.Location = new System.Drawing.Point(48, 176);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(102, 26);
            this.lbl_description.TabIndex = 7;
            this.lbl_description.Text = "Institución";
            // 
            // txt_numInstitution
            // 
            this.txt_numInstitution.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_numInstitution.Location = new System.Drawing.Point(156, 114);
            this.txt_numInstitution.Name = "txt_numInstitution";
            this.txt_numInstitution.Size = new System.Drawing.Size(287, 24);
            this.txt_numInstitution.TabIndex = 6;
            // 
            // lbl_numInstitution
            // 
            this.lbl_numInstitution.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_numInstitution.Location = new System.Drawing.Point(48, 114);
            this.lbl_numInstitution.Name = "lbl_numInstitution";
            this.lbl_numInstitution.Size = new System.Drawing.Size(102, 26);
            this.lbl_numInstitution.TabIndex = 5;
            this.lbl_numInstitution.Text = "Identificador: ";
            // 
            // panelBannerTab3
            // 
            this.panelBannerTab3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.panelBannerTab3.Controls.Add(this.pictureBoxBannerTab3);
            this.panelBannerTab3.Location = new System.Drawing.Point(0, 0);
            this.panelBannerTab3.Name = "panelBannerTab3";
            this.panelBannerTab3.Size = new System.Drawing.Size(513, 75);
            this.panelBannerTab3.TabIndex = 4;
            // 
            // pictureBoxBannerTab3
            // 
            this.pictureBoxBannerTab3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxBannerTab3.Image")));
            this.pictureBoxBannerTab3.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxBannerTab3.Name = "pictureBoxBannerTab3";
            this.pictureBoxBannerTab3.Size = new System.Drawing.Size(233, 72);
            this.pictureBoxBannerTab3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBannerTab3.TabIndex = 3;
            this.pictureBoxBannerTab3.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 25);
            this.comboBox1.TabIndex = 20;
            // 
            // frmRegisterCitizen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 569);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmRegisterCitizen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de primera dosis";
            this.Load += new System.EventHandler(this.frmRegisterCitizen_Load);
            this.panelBannerTab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gBox_Institution.ResumeLayout(false);
            this.gBox_diseases.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelBannerTab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panelBannerTab3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab3)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.TextBox txt_age;

        private System.Windows.Forms.Button btn_register;

        private System.Windows.Forms.Button btn_aceptTab3;
        private System.Windows.Forms.Button btn_cancelTab3;

        private System.Windows.Forms.Label lbl_nameInstitution;

        private System.Windows.Forms.Label lbl_description;

        private System.Windows.Forms.Label lbl_numInstitution;
        private System.Windows.Forms.TextBox txt_numInstitution;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelBannerTab3;
        private System.Windows.Forms.PictureBox pictureBoxBannerTab3;


        //tab2
        private System.Windows.Forms.PictureBox pictureBoxBannerTab2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelBannerTab2;
        private System.Windows.Forms.Button btn_cancelDeseases;
        private System.Windows.Forms.Button btn_aceptDeseases;
        private System.Windows.Forms.ComboBox cmb_Deseases;
        //
        
        
        private System.Windows.Forms.Label lbl_deseases;
        private System.Windows.Forms.PictureBox pictureBoxBannerTab1;
        private System.Windows.Forms.Panel panelBannerTab1;
        

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.Button btn_cancel;

        private System.Windows.Forms.RadioButton rb_deseasesNo;
        private System.Windows.Forms.RadioButton rb_deseasesYes;
        private System.Windows.Forms.RadioButton rb_institutionNo;
        private System.Windows.Forms.RadioButton rb_institutionYes;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.GroupBox gBox_Institution;

        private System.Windows.Forms.GroupBox gBox_diseases;

        private System.Windows.Forms.TextBox txt_dui;
        private System.Windows.Forms.TextBox txt_celphone;
        private System.Windows.Forms.TextBox txt_email;

        private System.Windows.Forms.TextBox txt_name;

        private System.Windows.Forms.Label lbl_numerPhone;

        private System.Windows.Forms.Label lbl_email;

        private System.Windows.Forms.Label lbl_address;

        private System.Windows.Forms.Label lbl_age;

        private System.Windows.Forms.Label lbl_name;
        
        private System.Windows.Forms.Label lbl_dui;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        

        #endregion
    }
}