using System.ComponentModel;

namespace Proyecto_POO_BDD
{
    partial class frmVaccinationProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVaccinationProcess));
            this.tabVaccinationProcess = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelBannerTab1 = new System.Windows.Forms.Panel();
            this.pictureBoxBannerTab1 = new System.Windows.Forms.PictureBox();
            this.btn_cancelDui = new System.Windows.Forms.Button();
            this.btn_aceptDui = new System.Windows.Forms.Button();
            this.txt_dui = new System.Windows.Forms.TextBox();
            this.lbl_dui = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.picCheck = new System.Windows.Forms.PictureBox();
            this.btnConsentCancel = new System.Windows.Forms.Button();
            this.btnConsentAcepted = new System.Windows.Forms.Button();
            this.tlpConsent = new System.Windows.Forms.TableLayoutPanel();
            this.chkConsent = new System.Windows.Forms.CheckBox();
            this.lbl_consent = new System.Windows.Forms.Label();
            this.lbl_formComplete = new System.Windows.Forms.Label();
            this.panelBannerTab2 = new System.Windows.Forms.Panel();
            this.pictureBoxBannerTab2 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_queueAcept = new System.Windows.Forms.Button();
            this.lbl_queue = new System.Windows.Forms.Label();
            this.lbl_queueDate = new System.Windows.Forms.Label();
            this.dtp_queueDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxBannerTab3 = new System.Windows.Forms.PictureBox();
            this.panelBannerTab3 = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grp_sideEffects = new System.Windows.Forms.GroupBox();
            this.radYesSideEffects = new System.Windows.Forms.RadioButton();
            this.radNoSideEffects = new System.Windows.Forms.RadioButton();
            this.dtp_dateVaccineRecieved = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateVaccineRecieved = new System.Windows.Forms.Label();
            this.btn_aceptVaccineRecieved = new System.Windows.Forms.Button();
            this.lbl_vaccineReceived = new System.Windows.Forms.Label();
            this.pictureBoxBannerTab4 = new System.Windows.Forms.PictureBox();
            this.panelbannerTab4 = new System.Windows.Forms.Panel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_CancelSideEffect = new System.Windows.Forms.Button();
            this.btn_aceptTimeEffects = new System.Windows.Forms.Button();
            this.lbl_timeSideEffect = new System.Windows.Forms.Label();
            this.dtpTimeSideEffect = new System.Windows.Forms.DateTimePicker();
            this.cmbSideEffect = new System.Windows.Forms.ComboBox();
            this.lbl_sideEffects = new System.Windows.Forms.Label();
            this.pictureBoxBannerTab5 = new System.Windows.Forms.PictureBox();
            this.panelBannerTab5 = new System.Windows.Forms.Panel();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btn_Acept2vaccine = new System.Windows.Forms.Button();
            this.dtp_date2vaccine = new System.Windows.Forms.DateTimePicker();
            this.lbl_date2Vaccine = new System.Windows.Forms.Label();
            this.pictureBoxBanner6 = new System.Windows.Forms.PictureBox();
            this.panelBannerTab6 = new System.Windows.Forms.Panel();
            this.tabVaccinationProcess.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelBannerTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picCheck)).BeginInit();
            this.tlpConsent.SuspendLayout();
            this.panelBannerTab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab3)).BeginInit();
            this.panelBannerTab3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.grp_sideEffects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab5)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBanner6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabVaccinationProcess
            // 
            this.tabVaccinationProcess.Controls.Add(this.tabPage1);
            this.tabVaccinationProcess.Controls.Add(this.tabPage2);
            this.tabVaccinationProcess.Controls.Add(this.tabPage3);
            this.tabVaccinationProcess.Controls.Add(this.tabPage4);
            this.tabVaccinationProcess.Controls.Add(this.tabPage5);
            this.tabVaccinationProcess.Controls.Add(this.tabPage6);
            this.tabVaccinationProcess.Location = new System.Drawing.Point(1, -4);
            this.tabVaccinationProcess.Name = "tabVaccinationProcess";
            this.tabVaccinationProcess.SelectedIndex = 0;
            this.tabVaccinationProcess.Size = new System.Drawing.Size(394, 362);
            this.tabVaccinationProcess.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelBannerTab1);
            this.tabPage1.Controls.Add(this.btn_cancelDui);
            this.tabPage1.Controls.Add(this.btn_aceptDui);
            this.tabPage1.Controls.Add(this.txt_dui);
            this.tabPage1.Controls.Add(this.lbl_dui);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(386, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dui";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelBannerTab1
            // 
            this.panelBannerTab1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.panelBannerTab1.Controls.Add(this.pictureBoxBannerTab1);
            this.panelBannerTab1.Location = new System.Drawing.Point(0, 0);
            this.panelBannerTab1.Name = "panelBannerTab1";
            this.panelBannerTab1.Size = new System.Drawing.Size(386, 69);
            this.panelBannerTab1.TabIndex = 4;
            // 
            // pictureBoxBannerTab1
            // 
            this.pictureBoxBannerTab1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxBannerTab1.Image")));
            this.pictureBoxBannerTab1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBoxBannerTab1.Name = "pictureBoxBannerTab1";
            this.pictureBoxBannerTab1.Size = new System.Drawing.Size(213, 68);
            this.pictureBoxBannerTab1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBannerTab1.TabIndex = 0;
            this.pictureBoxBannerTab1.TabStop = false;
            // 
            // btn_cancelDui
            // 
            this.btn_cancelDui.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelDui.FlatAppearance.BorderSize = 0;
            this.btn_cancelDui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelDui.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_cancelDui.ForeColor = System.Drawing.Color.White;
            this.btn_cancelDui.Location = new System.Drawing.Point(219, 149);
            this.btn_cancelDui.Name = "btn_cancelDui";
            this.btn_cancelDui.Size = new System.Drawing.Size(136, 42);
            this.btn_cancelDui.TabIndex = 3;
            this.btn_cancelDui.Text = "Cancel";
            this.btn_cancelDui.UseVisualStyleBackColor = false;
            // 
            // btn_aceptDui
            // 
            this.btn_aceptDui.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.btn_aceptDui.FlatAppearance.BorderSize = 0;
            this.btn_aceptDui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptDui.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_aceptDui.ForeColor = System.Drawing.Color.White;
            this.btn_aceptDui.Location = new System.Drawing.Point(21, 149);
            this.btn_aceptDui.Name = "btn_aceptDui";
            this.btn_aceptDui.Size = new System.Drawing.Size(136, 42);
            this.btn_aceptDui.TabIndex = 2;
            this.btn_aceptDui.Text = "Aceptar";
            this.btn_aceptDui.UseVisualStyleBackColor = false;
            this.btn_aceptDui.Click += new System.EventHandler(this.btn_aceptDui_Click);
            // 
            // txt_dui
            // 
            this.txt_dui.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_dui.Location = new System.Drawing.Point(95, 99);
            this.txt_dui.Name = "txt_dui";
            this.txt_dui.Size = new System.Drawing.Size(260, 25);
            this.txt_dui.TabIndex = 1;
            // 
            // lbl_dui
            // 
            this.lbl_dui.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_dui.Location = new System.Drawing.Point(36, 101);
            this.lbl_dui.Name = "lbl_dui";
            this.lbl_dui.Size = new System.Drawing.Size(44, 23);
            this.lbl_dui.TabIndex = 0;
            this.lbl_dui.Text = "DUI:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.picCheck);
            this.tabPage2.Controls.Add(this.btnConsentCancel);
            this.tabPage2.Controls.Add(this.btnConsentAcepted);
            this.tabPage2.Controls.Add(this.tlpConsent);
            this.tabPage2.Controls.Add(this.lbl_formComplete);
            this.tabPage2.Controls.Add(this.panelBannerTab2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(386, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consentimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // picCheck
            // 
            this.picCheck.Image = ((System.Drawing.Image) (resources.GetObject("picCheck.Image")));
            this.picCheck.Location = new System.Drawing.Point(183, 85);
            this.picCheck.Name = "picCheck";
            this.picCheck.Size = new System.Drawing.Size(40, 32);
            this.picCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCheck.TabIndex = 10;
            this.picCheck.TabStop = false;
            // 
            // btnConsentCancel
            // 
            this.btnConsentCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnConsentCancel.FlatAppearance.BorderSize = 0;
            this.btnConsentCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsentCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnConsentCancel.ForeColor = System.Drawing.Color.White;
            this.btnConsentCancel.Location = new System.Drawing.Point(217, 220);
            this.btnConsentCancel.Name = "btnConsentCancel";
            this.btnConsentCancel.Size = new System.Drawing.Size(136, 42);
            this.btnConsentCancel.TabIndex = 9;
            this.btnConsentCancel.Text = "Cancel";
            this.btnConsentCancel.UseVisualStyleBackColor = false;
            // 
            // btnConsentAcepted
            // 
            this.btnConsentAcepted.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.btnConsentAcepted.Enabled = false;
            this.btnConsentAcepted.FlatAppearance.BorderSize = 0;
            this.btnConsentAcepted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsentAcepted.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnConsentAcepted.ForeColor = System.Drawing.Color.White;
            this.btnConsentAcepted.Location = new System.Drawing.Point(19, 220);
            this.btnConsentAcepted.Name = "btnConsentAcepted";
            this.btnConsentAcepted.Size = new System.Drawing.Size(136, 42);
            this.btnConsentAcepted.TabIndex = 8;
            this.btnConsentAcepted.Text = "Aceptar";
            this.btnConsentAcepted.UseVisualStyleBackColor = false;
            this.btnConsentAcepted.Click += new System.EventHandler(this.btnConsentAcepted_Click);
            // 
            // tlpConsent
            // 
            this.tlpConsent.ColumnCount = 2;
            this.tlpConsent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpConsent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpConsent.Controls.Add(this.chkConsent, 0, 0);
            this.tlpConsent.Controls.Add(this.lbl_consent, 1, 0);
            this.tlpConsent.Location = new System.Drawing.Point(7, 140);
            this.tlpConsent.Name = "tlpConsent";
            this.tlpConsent.RowCount = 1;
            this.tlpConsent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConsent.Size = new System.Drawing.Size(369, 63);
            this.tlpConsent.TabIndex = 7;
            // 
            // chkConsent
            // 
            this.chkConsent.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkConsent.Location = new System.Drawing.Point(3, 3);
            this.chkConsent.Name = "chkConsent";
            this.chkConsent.Size = new System.Drawing.Size(30, 31);
            this.chkConsent.TabIndex = 0;
            this.chkConsent.UseVisualStyleBackColor = true;
            this.chkConsent.CheckedChanged += new System.EventHandler(this.chkConsent_CheckedChanged);
            // 
            // lbl_consent
            // 
            this.lbl_consent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_consent.Location = new System.Drawing.Point(39, 0);
            this.lbl_consent.Name = "lbl_consent";
            this.lbl_consent.Size = new System.Drawing.Size(297, 50);
            this.lbl_consent.TabIndex = 1;
            this.lbl_consent.Text = "Doy mi consentimiento para recibir las dosis de la vacuna contra el covid-19";
            // 
            // lbl_formComplete
            // 
            this.lbl_formComplete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_formComplete.Location = new System.Drawing.Point(10, 93);
            this.lbl_formComplete.Name = "lbl_formComplete";
            this.lbl_formComplete.Size = new System.Drawing.Size(167, 32);
            this.lbl_formComplete.TabIndex = 6;
            this.lbl_formComplete.Text = "¡Formulario Completo!";
            // 
            // panelBannerTab2
            // 
            this.panelBannerTab2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.panelBannerTab2.Controls.Add(this.pictureBoxBannerTab2);
            this.panelBannerTab2.Location = new System.Drawing.Point(0, 0);
            this.panelBannerTab2.Name = "panelBannerTab2";
            this.panelBannerTab2.Size = new System.Drawing.Size(386, 69);
            this.panelBannerTab2.TabIndex = 5;
            // 
            // pictureBoxBannerTab2
            // 
            this.pictureBoxBannerTab2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxBannerTab2.Image")));
            this.pictureBoxBannerTab2.Location = new System.Drawing.Point(-4, 0);
            this.pictureBoxBannerTab2.Name = "pictureBoxBannerTab2";
            this.pictureBoxBannerTab2.Size = new System.Drawing.Size(213, 68);
            this.pictureBoxBannerTab2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBannerTab2.TabIndex = 0;
            this.pictureBoxBannerTab2.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_queueAcept);
            this.tabPage3.Controls.Add(this.lbl_queue);
            this.tabPage3.Controls.Add(this.lbl_queueDate);
            this.tabPage3.Controls.Add(this.dtp_queueDate);
            this.tabPage3.Controls.Add(this.panelBannerTab3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(386, 336);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fila espera";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_queueAcept
            // 
            this.btn_queueAcept.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.btn_queueAcept.FlatAppearance.BorderSize = 0;
            this.btn_queueAcept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_queueAcept.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_queueAcept.ForeColor = System.Drawing.Color.White;
            this.btn_queueAcept.Location = new System.Drawing.Point(49, 173);
            this.btn_queueAcept.Name = "btn_queueAcept";
            this.btn_queueAcept.Size = new System.Drawing.Size(282, 42);
            this.btn_queueAcept.TabIndex = 11;
            this.btn_queueAcept.Text = "Aceptar";
            this.btn_queueAcept.UseVisualStyleBackColor = false;
            this.btn_queueAcept.Click += new System.EventHandler(this.btn_queueAcept_Click);
            // 
            // lbl_queue
            // 
            this.lbl_queue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_queue.Location = new System.Drawing.Point(49, 85);
            this.lbl_queue.Name = "lbl_queue";
            this.lbl_queue.Size = new System.Drawing.Size(148, 32);
            this.lbl_queue.TabIndex = 10;
            this.lbl_queue.Text = "FILA DE ESPERA";
            // 
            // lbl_queueDate
            // 
            this.lbl_queueDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_queueDate.Location = new System.Drawing.Point(49, 127);
            this.lbl_queueDate.Name = "lbl_queueDate";
            this.lbl_queueDate.Size = new System.Drawing.Size(110, 32);
            this.lbl_queueDate.TabIndex = 9;
            this.lbl_queueDate.Text = "Fecha y Hora: ";
            // 
            // dtp_queueDate
            // 
            this.dtp_queueDate.CalendarFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dtp_queueDate.CustomFormat = "yyyy/MM/dd    hh:mm";
            this.dtp_queueDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dtp_queueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_queueDate.Location = new System.Drawing.Point(165, 124);
            this.dtp_queueDate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtp_queueDate.MinDate = new System.DateTime(2021, 6, 24, 0, 0, 0, 0);
            this.dtp_queueDate.Name = "dtp_queueDate";
            this.dtp_queueDate.Size = new System.Drawing.Size(166, 23);
            this.dtp_queueDate.TabIndex = 8;
            this.dtp_queueDate.Value = new System.DateTime(2021, 6, 24, 0, 0, 0, 0);
            // 
            // pictureBoxBannerTab3
            // 
            this.pictureBoxBannerTab3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxBannerTab3.Image")));
            this.pictureBoxBannerTab3.Location = new System.Drawing.Point(-4, 0);
            this.pictureBoxBannerTab3.Name = "pictureBoxBannerTab3";
            this.pictureBoxBannerTab3.Size = new System.Drawing.Size(213, 68);
            this.pictureBoxBannerTab3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBannerTab3.TabIndex = 0;
            this.pictureBoxBannerTab3.TabStop = false;
            // 
            // panelBannerTab3
            // 
            this.panelBannerTab3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.panelBannerTab3.Controls.Add(this.pictureBoxBannerTab3);
            this.panelBannerTab3.Location = new System.Drawing.Point(0, 0);
            this.panelBannerTab3.Name = "panelBannerTab3";
            this.panelBannerTab3.Size = new System.Drawing.Size(386, 69);
            this.panelBannerTab3.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.grp_sideEffects);
            this.tabPage4.Controls.Add(this.dtp_dateVaccineRecieved);
            this.tabPage4.Controls.Add(this.lbl_dateVaccineRecieved);
            this.tabPage4.Controls.Add(this.btn_aceptVaccineRecieved);
            this.tabPage4.Controls.Add(this.lbl_vaccineReceived);
            this.tabPage4.Controls.Add(this.pictureBoxBannerTab4);
            this.tabPage4.Controls.Add(this.panelbannerTab4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(386, 336);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "vacuna";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grp_sideEffects
            // 
            this.grp_sideEffects.Controls.Add(this.radYesSideEffects);
            this.grp_sideEffects.Controls.Add(this.radNoSideEffects);
            this.grp_sideEffects.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.grp_sideEffects.Location = new System.Drawing.Point(31, 194);
            this.grp_sideEffects.Name = "grp_sideEffects";
            this.grp_sideEffects.Size = new System.Drawing.Size(312, 61);
            this.grp_sideEffects.TabIndex = 16;
            this.grp_sideEffects.TabStop = false;
            this.grp_sideEffects.Text = "¿Se presentaron efectos secundarios?";
            // 
            // radYesSideEffects
            // 
            this.radYesSideEffects.Location = new System.Drawing.Point(163, 25);
            this.radYesSideEffects.Name = "radYesSideEffects";
            this.radYesSideEffects.Size = new System.Drawing.Size(73, 22);
            this.radYesSideEffects.TabIndex = 1;
            this.radYesSideEffects.TabStop = true;
            this.radYesSideEffects.Text = "Yes";
            this.radYesSideEffects.UseVisualStyleBackColor = true;
            // 
            // radNoSideEffects
            // 
            this.radNoSideEffects.Location = new System.Drawing.Point(20, 25);
            this.radNoSideEffects.Name = "radNoSideEffects";
            this.radNoSideEffects.Size = new System.Drawing.Size(73, 22);
            this.radNoSideEffects.TabIndex = 0;
            this.radNoSideEffects.TabStop = true;
            this.radNoSideEffects.Text = "No";
            this.radNoSideEffects.UseVisualStyleBackColor = true;
            // 
            // dtp_dateVaccineRecieved
            // 
            this.dtp_dateVaccineRecieved.CalendarFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dtp_dateVaccineRecieved.CustomFormat = "yyyy/MM/dd    HH:mm";
            this.dtp_dateVaccineRecieved.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dtp_dateVaccineRecieved.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dateVaccineRecieved.Location = new System.Drawing.Point(170, 135);
            this.dtp_dateVaccineRecieved.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtp_dateVaccineRecieved.MinDate = new System.DateTime(2021, 6, 24, 0, 0, 0, 0);
            this.dtp_dateVaccineRecieved.Name = "dtp_dateVaccineRecieved";
            this.dtp_dateVaccineRecieved.Size = new System.Drawing.Size(176, 23);
            this.dtp_dateVaccineRecieved.TabIndex = 15;
            this.dtp_dateVaccineRecieved.Value = new System.DateTime(2021, 6, 24, 0, 0, 0, 0);
            // 
            // lbl_dateVaccineRecieved
            // 
            this.lbl_dateVaccineRecieved.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_dateVaccineRecieved.Location = new System.Drawing.Point(31, 135);
            this.lbl_dateVaccineRecieved.Name = "lbl_dateVaccineRecieved";
            this.lbl_dateVaccineRecieved.Size = new System.Drawing.Size(133, 39);
            this.lbl_dateVaccineRecieved.TabIndex = 14;
            this.lbl_dateVaccineRecieved.Text = "Fecha y hora \r\nde vacunación:";
            // 
            // btn_aceptVaccineRecieved
            // 
            this.btn_aceptVaccineRecieved.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.btn_aceptVaccineRecieved.FlatAppearance.BorderSize = 0;
            this.btn_aceptVaccineRecieved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptVaccineRecieved.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_aceptVaccineRecieved.ForeColor = System.Drawing.Color.White;
            this.btn_aceptVaccineRecieved.Location = new System.Drawing.Point(31, 276);
            this.btn_aceptVaccineRecieved.Name = "btn_aceptVaccineRecieved";
            this.btn_aceptVaccineRecieved.Size = new System.Drawing.Size(315, 42);
            this.btn_aceptVaccineRecieved.TabIndex = 13;
            this.btn_aceptVaccineRecieved.Text = "Aceptar";
            this.btn_aceptVaccineRecieved.UseVisualStyleBackColor = false;
            // 
            // lbl_vaccineReceived
            // 
            this.lbl_vaccineReceived.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_vaccineReceived.Location = new System.Drawing.Point(31, 87);
            this.lbl_vaccineReceived.Name = "lbl_vaccineReceived";
            this.lbl_vaccineReceived.Size = new System.Drawing.Size(170, 32);
            this.lbl_vaccineReceived.TabIndex = 12;
            this.lbl_vaccineReceived.Text = "VACUNA RECIBIDA";
            // 
            // pictureBoxBannerTab4
            // 
            this.pictureBoxBannerTab4.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxBannerTab4.Image")));
            this.pictureBoxBannerTab4.Location = new System.Drawing.Point(-4, 0);
            this.pictureBoxBannerTab4.Name = "pictureBoxBannerTab4";
            this.pictureBoxBannerTab4.Size = new System.Drawing.Size(213, 68);
            this.pictureBoxBannerTab4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBannerTab4.TabIndex = 0;
            this.pictureBoxBannerTab4.TabStop = false;
            // 
            // panelbannerTab4
            // 
            this.panelbannerTab4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.panelbannerTab4.Location = new System.Drawing.Point(0, 0);
            this.panelbannerTab4.Name = "panelbannerTab4";
            this.panelbannerTab4.Size = new System.Drawing.Size(386, 69);
            this.panelbannerTab4.TabIndex = 6;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_CancelSideEffect);
            this.tabPage5.Controls.Add(this.btn_aceptTimeEffects);
            this.tabPage5.Controls.Add(this.lbl_timeSideEffect);
            this.tabPage5.Controls.Add(this.dtpTimeSideEffect);
            this.tabPage5.Controls.Add(this.cmbSideEffect);
            this.tabPage5.Controls.Add(this.lbl_sideEffects);
            this.tabPage5.Controls.Add(this.pictureBoxBannerTab5);
            this.tabPage5.Controls.Add(this.panelBannerTab5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(386, 336);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "efectos sec.";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_CancelSideEffect
            // 
            this.btn_CancelSideEffect.BackColor = System.Drawing.Color.DarkGray;
            this.btn_CancelSideEffect.FlatAppearance.BorderSize = 0;
            this.btn_CancelSideEffect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelSideEffect.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_CancelSideEffect.ForeColor = System.Drawing.Color.White;
            this.btn_CancelSideEffect.Location = new System.Drawing.Point(220, 211);
            this.btn_CancelSideEffect.Name = "btn_CancelSideEffect";
            this.btn_CancelSideEffect.Size = new System.Drawing.Size(136, 42);
            this.btn_CancelSideEffect.TabIndex = 18;
            this.btn_CancelSideEffect.Text = "Cancel";
            this.btn_CancelSideEffect.UseVisualStyleBackColor = false;
            // 
            // btn_aceptTimeEffects
            // 
            this.btn_aceptTimeEffects.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.btn_aceptTimeEffects.FlatAppearance.BorderSize = 0;
            this.btn_aceptTimeEffects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptTimeEffects.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_aceptTimeEffects.ForeColor = System.Drawing.Color.White;
            this.btn_aceptTimeEffects.Location = new System.Drawing.Point(22, 211);
            this.btn_aceptTimeEffects.Name = "btn_aceptTimeEffects";
            this.btn_aceptTimeEffects.Size = new System.Drawing.Size(136, 42);
            this.btn_aceptTimeEffects.TabIndex = 17;
            this.btn_aceptTimeEffects.Text = "Aceptar";
            this.btn_aceptTimeEffects.UseVisualStyleBackColor = false;
            // 
            // lbl_timeSideEffect
            // 
            this.lbl_timeSideEffect.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_timeSideEffect.Location = new System.Drawing.Point(16, 150);
            this.lbl_timeSideEffect.Name = "lbl_timeSideEffect";
            this.lbl_timeSideEffect.Size = new System.Drawing.Size(120, 51);
            this.lbl_timeSideEffect.TabIndex = 16;
            this.lbl_timeSideEffect.Text = "Hora en que se presentaron:";
            // 
            // dtpTimeSideEffect
            // 
            this.dtpTimeSideEffect.CustomFormat = "HH:mm:00";
            this.dtpTimeSideEffect.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dtpTimeSideEffect.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeSideEffect.Location = new System.Drawing.Point(157, 154);
            this.dtpTimeSideEffect.Name = "dtpTimeSideEffect";
            this.dtpTimeSideEffect.Size = new System.Drawing.Size(203, 25);
            this.dtpTimeSideEffect.TabIndex = 15;
            // 
            // cmbSideEffect
            // 
            this.cmbSideEffect.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbSideEffect.FormattingEnabled = true;
            this.cmbSideEffect.Location = new System.Drawing.Point(157, 89);
            this.cmbSideEffect.Name = "cmbSideEffect";
            this.cmbSideEffect.Size = new System.Drawing.Size(204, 25);
            this.cmbSideEffect.TabIndex = 14;
            // 
            // lbl_sideEffects
            // 
            this.lbl_sideEffects.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_sideEffects.Location = new System.Drawing.Point(16, 91);
            this.lbl_sideEffects.Name = "lbl_sideEffects";
            this.lbl_sideEffects.Size = new System.Drawing.Size(142, 32);
            this.lbl_sideEffects.TabIndex = 13;
            this.lbl_sideEffects.Text = "Efecto secundario: ";
            // 
            // pictureBoxBannerTab5
            // 
            this.pictureBoxBannerTab5.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxBannerTab5.Image")));
            this.pictureBoxBannerTab5.Location = new System.Drawing.Point(-4, 0);
            this.pictureBoxBannerTab5.Name = "pictureBoxBannerTab5";
            this.pictureBoxBannerTab5.Size = new System.Drawing.Size(213, 68);
            this.pictureBoxBannerTab5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBannerTab5.TabIndex = 7;
            this.pictureBoxBannerTab5.TabStop = false;
            // 
            // panelBannerTab5
            // 
            this.panelBannerTab5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.panelBannerTab5.Location = new System.Drawing.Point(0, 0);
            this.panelBannerTab5.Name = "panelBannerTab5";
            this.panelBannerTab5.Size = new System.Drawing.Size(386, 69);
            this.panelBannerTab5.TabIndex = 8;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btn_Acept2vaccine);
            this.tabPage6.Controls.Add(this.dtp_date2vaccine);
            this.tabPage6.Controls.Add(this.lbl_date2Vaccine);
            this.tabPage6.Controls.Add(this.pictureBoxBanner6);
            this.tabPage6.Controls.Add(this.panelBannerTab6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(386, 336);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "2° vacuna";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btn_Acept2vaccine
            // 
            this.btn_Acept2vaccine.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.btn_Acept2vaccine.FlatAppearance.BorderSize = 0;
            this.btn_Acept2vaccine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Acept2vaccine.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_Acept2vaccine.ForeColor = System.Drawing.Color.White;
            this.btn_Acept2vaccine.Location = new System.Drawing.Point(52, 164);
            this.btn_Acept2vaccine.Name = "btn_Acept2vaccine";
            this.btn_Acept2vaccine.Size = new System.Drawing.Size(282, 42);
            this.btn_Acept2vaccine.TabIndex = 13;
            this.btn_Acept2vaccine.Text = "Aceptar";
            this.btn_Acept2vaccine.UseVisualStyleBackColor = false;
            // 
            // dtp_date2vaccine
            // 
            this.dtp_date2vaccine.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dtp_date2vaccine.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_date2vaccine.Location = new System.Drawing.Point(153, 107);
            this.dtp_date2vaccine.Name = "dtp_date2vaccine";
            this.dtp_date2vaccine.Size = new System.Drawing.Size(203, 25);
            this.dtp_date2vaccine.TabIndex = 12;
            // 
            // lbl_date2Vaccine
            // 
            this.lbl_date2Vaccine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_date2Vaccine.Location = new System.Drawing.Point(24, 101);
            this.lbl_date2Vaccine.Name = "lbl_date2Vaccine";
            this.lbl_date2Vaccine.Size = new System.Drawing.Size(123, 45);
            this.lbl_date2Vaccine.TabIndex = 11;
            this.lbl_date2Vaccine.Text = "Fecha y hora segunda dosis:";
            // 
            // pictureBoxBanner6
            // 
            this.pictureBoxBanner6.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxBanner6.Image")));
            this.pictureBoxBanner6.Location = new System.Drawing.Point(-4, 0);
            this.pictureBoxBanner6.Name = "pictureBoxBanner6";
            this.pictureBoxBanner6.Size = new System.Drawing.Size(213, 68);
            this.pictureBoxBanner6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBanner6.TabIndex = 9;
            this.pictureBoxBanner6.TabStop = false;
            // 
            // panelBannerTab6
            // 
            this.panelBannerTab6.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (27)))), ((int) (((byte) (36)))));
            this.panelBannerTab6.Location = new System.Drawing.Point(0, 0);
            this.panelBannerTab6.Name = "panelBannerTab6";
            this.panelBannerTab6.Size = new System.Drawing.Size(386, 69);
            this.panelBannerTab6.TabIndex = 10;
            // 
            // frmVaccinationProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(393, 358);
            this.Controls.Add(this.tabVaccinationProcess);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "frmVaccinationProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmVaccinationProcess_Load);
            this.tabVaccinationProcess.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelBannerTab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picCheck)).EndInit();
            this.tlpConsent.ResumeLayout(false);
            this.panelBannerTab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab3)).EndInit();
            this.panelBannerTab3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.grp_sideEffects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBannerTab5)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBanner6)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabVaccinationProcess;
        
        // tab1 //
        private System.Windows.Forms.Button btn_cancelDui;
        private System.Windows.Forms.Label lbl_dui;
        private System.Windows.Forms.TextBox txt_dui;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_aceptDui;
        private System.Windows.Forms.Panel panelBannerTab1;
        private System.Windows.Forms.PictureBox pictureBoxBannerTab1;
        //

        // tab2 //
        private System.Windows.Forms.Panel panelBannerTab2;
        private System.Windows.Forms.PictureBox pictureBoxBannerTab2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_formComplete;
        private System.Windows.Forms.Button btnConsentCancel;
        private System.Windows.Forms.Button btnConsentAcepted;
        private System.Windows.Forms.Label lbl_consent;
        private System.Windows.Forms.TableLayoutPanel tlpConsent;
        private System.Windows.Forms.CheckBox chkConsent;
        private System.Windows.Forms.PictureBox picCheck;
        
        // tab3 //
        private System.Windows.Forms.Panel panelBannerTab3;
        private System.Windows.Forms.PictureBox pictureBoxBannerTab3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dtp_queueDate;
        private System.Windows.Forms.Label lbl_queueDate;
        private System.Windows.Forms.Label lbl_queue;
        private System.Windows.Forms.Button btn_queueAcept;
        //
        
        // tab4 //
        private System.Windows.Forms.Panel panelbannerTab4;
        private System.Windows.Forms.PictureBox pictureBoxBannerTab4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lbl_vaccineReceived;
        private System.Windows.Forms.Button btn_aceptVaccineRecieved;
        private System.Windows.Forms.GroupBox grp_sideEffects;
        private System.Windows.Forms.DateTimePicker dtp_dateVaccineRecieved;
        private System.Windows.Forms.Label lbl_dateVaccineRecieved;
        private System.Windows.Forms.RadioButton radNoSideEffects;
        private System.Windows.Forms.RadioButton radYesSideEffects;
        //
        
        // tab5 //
        private System.Windows.Forms.PictureBox pictureBoxBannerTab5;
        private System.Windows.Forms.Panel panelBannerTab5;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DateTimePicker dtpTimeSideEffect;
        private System.Windows.Forms.ComboBox cmbSideEffect;
        private System.Windows.Forms.Label lbl_sideEffects;
        private System.Windows.Forms.Label lbl_timeSideEffect;
        private System.Windows.Forms.Button btn_CancelSideEffect;
        private System.Windows.Forms.Button btn_aceptTimeEffects;
        //
        
        // tab6 //
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.PictureBox pictureBoxBanner6;
        private System.Windows.Forms.Panel panelBannerTab6;
        private System.Windows.Forms.Label lbl_date2Vaccine;
        private System.Windows.Forms.DateTimePicker dtp_date2vaccine;
        private System.Windows.Forms.Button btn_Acept2vaccine;
        //

        #endregion
    }
}