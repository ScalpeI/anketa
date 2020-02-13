namespace anketa
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.cbEnableEditInterview = new System.Windows.Forms.CheckBox();
            this.pInterviewer = new System.Windows.Forms.Panel();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.tAREABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFORMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFORMDataSet = new anketa.DBFORMDataSet();
            this.cbInterviewer = new System.Windows.Forms.ComboBox();
            this.tAUTHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMo = new System.Windows.Forms.ComboBox();
            this.tMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDateSoc = new System.Windows.Forms.DateTimePicker();
            this.lDate = new System.Windows.Forms.Label();
            this.lMo = new System.Windows.Forms.Label();
            this.lCity = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.lRespondent = new System.Windows.Forms.Label();
            this.lInterviewer = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbRespondent = new System.Windows.Forms.TextBox();
            this.t_AUTHTableAdapter = new anketa.DBFORMDataSetTableAdapters.T_AUTHTableAdapter();
            this.t_AREATableAdapter = new anketa.DBFORMDataSetTableAdapters.T_AREATableAdapter();
            this.t_MOTableAdapter = new anketa.DBFORMDataSetTableAdapters.T_MOTableAdapter();
            this.pInterviewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAREABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFORMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFORMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAUTHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbEnableEditInterview
            // 
            this.cbEnableEditInterview.AutoSize = true;
            this.cbEnableEditInterview.Location = new System.Drawing.Point(30, 12);
            this.cbEnableEditInterview.Name = "cbEnableEditInterview";
            this.cbEnableEditInterview.Size = new System.Drawing.Size(99, 17);
            this.cbEnableEditInterview.TabIndex = 1;
            this.cbEnableEditInterview.Text = "Edit Interviewer";
            this.cbEnableEditInterview.UseVisualStyleBackColor = true;
            this.cbEnableEditInterview.Click += new System.EventHandler(this.cbEnableEditInterview_Click);
            // 
            // pInterviewer
            // 
            this.pInterviewer.Controls.Add(this.cbCity);
            this.pInterviewer.Controls.Add(this.cbInterviewer);
            this.pInterviewer.Controls.Add(this.cbMo);
            this.pInterviewer.Controls.Add(this.dtpDateSoc);
            this.pInterviewer.Controls.Add(this.lDate);
            this.pInterviewer.Controls.Add(this.lMo);
            this.pInterviewer.Controls.Add(this.lCity);
            this.pInterviewer.Controls.Add(this.lPhone);
            this.pInterviewer.Controls.Add(this.lRespondent);
            this.pInterviewer.Controls.Add(this.lInterviewer);
            this.pInterviewer.Controls.Add(this.tbPhone);
            this.pInterviewer.Controls.Add(this.tbRespondent);
            this.pInterviewer.Controls.Add(this.cbEnableEditInterview);
            this.pInterviewer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInterviewer.Location = new System.Drawing.Point(0, 0);
            this.pInterviewer.Name = "pInterviewer";
            this.pInterviewer.Size = new System.Drawing.Size(439, 211);
            this.pInterviewer.TabIndex = 2;
            // 
            // cbCity
            // 
            this.cbCity.DataSource = this.tAREABindingSource;
            this.cbCity.DisplayMember = "namearea";
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(243, 119);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(160, 21);
            this.cbCity.TabIndex = 17;
            this.cbCity.ValueMember = "idarea";
            // 
            // tAREABindingSource
            // 
            this.tAREABindingSource.DataMember = "T_AREA";
            this.tAREABindingSource.DataSource = this.dBFORMDataSetBindingSource;
            this.tAREABindingSource.Sort = "prz";
            // 
            // dBFORMDataSetBindingSource
            // 
            this.dBFORMDataSetBindingSource.DataSource = this.dBFORMDataSet;
            this.dBFORMDataSetBindingSource.Position = 0;
            // 
            // dBFORMDataSet
            // 
            this.dBFORMDataSet.DataSetName = "DBFORMDataSet";
            this.dBFORMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbInterviewer
            // 
            this.cbInterviewer.DataSource = this.tAUTHBindingSource;
            this.cbInterviewer.DisplayMember = "description";
            this.cbInterviewer.FormattingEnabled = true;
            this.cbInterviewer.Location = new System.Drawing.Point(243, 41);
            this.cbInterviewer.Name = "cbInterviewer";
            this.cbInterviewer.Size = new System.Drawing.Size(160, 21);
            this.cbInterviewer.TabIndex = 16;
            this.cbInterviewer.ValueMember = "iduser";
            // 
            // tAUTHBindingSource
            // 
            this.tAUTHBindingSource.DataMember = "T_AUTH";
            this.tAUTHBindingSource.DataSource = this.dBFORMDataSetBindingSource;
            this.tAUTHBindingSource.Sort = "description";
            // 
            // cbMo
            // 
            this.cbMo.DataSource = this.tMOBindingSource;
            this.cbMo.DisplayMember = "namemo";
            this.cbMo.FormattingEnabled = true;
            this.cbMo.Location = new System.Drawing.Point(243, 145);
            this.cbMo.Name = "cbMo";
            this.cbMo.Size = new System.Drawing.Size(160, 21);
            this.cbMo.TabIndex = 15;
            this.cbMo.ValueMember = "idmo";
            // 
            // tMOBindingSource
            // 
            this.tMOBindingSource.DataMember = "T_MO";
            this.tMOBindingSource.DataSource = this.dBFORMDataSetBindingSource;
            this.tMOBindingSource.Sort = "kodmo";
            // 
            // dtpDateSoc
            // 
            this.dtpDateSoc.Location = new System.Drawing.Point(243, 172);
            this.dtpDateSoc.Name = "dtpDateSoc";
            this.dtpDateSoc.Size = new System.Drawing.Size(160, 20);
            this.dtpDateSoc.TabIndex = 14;
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(27, 174);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(153, 13);
            this.lDate.TabIndex = 13;
            this.lDate.Text = "Дата проведения соцопроса";
            // 
            // lMo
            // 
            this.lMo.AutoSize = true;
            this.lMo.Location = new System.Drawing.Point(27, 148);
            this.lMo.Name = "lMo";
            this.lMo.Size = new System.Drawing.Size(24, 13);
            this.lMo.TabIndex = 12;
            this.lMo.Text = "МО";
            // 
            // lCity
            // 
            this.lCity.AutoSize = true;
            this.lCity.Location = new System.Drawing.Point(27, 122);
            this.lCity.Name = "lCity";
            this.lCity.Size = new System.Drawing.Size(211, 13);
            this.lCity.TabIndex = 11;
            this.lCity.Text = "Муниципальный район/городской округ";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(27, 96);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(182, 13);
            this.lPhone.TabIndex = 10;
            this.lPhone.Text = "Контактный телефон респондента";
            // 
            // lRespondent
            // 
            this.lRespondent.AutoSize = true;
            this.lRespondent.Location = new System.Drawing.Point(27, 70);
            this.lRespondent.Name = "lRespondent";
            this.lRespondent.Size = new System.Drawing.Size(67, 13);
            this.lRespondent.TabIndex = 9;
            this.lRespondent.Text = "Респондент";
            // 
            // lInterviewer
            // 
            this.lInterviewer.AutoSize = true;
            this.lInterviewer.Location = new System.Drawing.Point(27, 44);
            this.lInterviewer.Name = "lInterviewer";
            this.lInterviewer.Size = new System.Drawing.Size(70, 13);
            this.lInterviewer.TabIndex = 8;
            this.lInterviewer.Text = "Интервьюер";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(243, 93);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(160, 20);
            this.tbPhone.TabIndex = 4;
            // 
            // tbRespondent
            // 
            this.tbRespondent.Location = new System.Drawing.Point(243, 67);
            this.tbRespondent.Name = "tbRespondent";
            this.tbRespondent.Size = new System.Drawing.Size(160, 20);
            this.tbRespondent.TabIndex = 3;
            // 
            // t_AUTHTableAdapter
            // 
            this.t_AUTHTableAdapter.ClearBeforeFill = true;
            // 
            // t_AREATableAdapter
            // 
            this.t_AREATableAdapter.ClearBeforeFill = true;
            // 
            // t_MOTableAdapter
            // 
            this.t_MOTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 591);
            this.Controls.Add(this.pInterviewer);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pInterviewer.ResumeLayout(false);
            this.pInterviewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAREABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFORMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFORMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAUTHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbEnableEditInterview;
        private System.Windows.Forms.Panel pInterviewer;
        private System.Windows.Forms.ComboBox cbInterviewer;
        private System.Windows.Forms.ComboBox cbMo;
        private System.Windows.Forms.DateTimePicker dtpDateSoc;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lMo;
        private System.Windows.Forms.Label lCity;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lRespondent;
        private System.Windows.Forms.Label lInterviewer;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbRespondent;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.BindingSource dBFORMDataSetBindingSource;
        private DBFORMDataSet dBFORMDataSet;
        private System.Windows.Forms.BindingSource tAUTHBindingSource;
        private DBFORMDataSetTableAdapters.T_AUTHTableAdapter t_AUTHTableAdapter;
        private System.Windows.Forms.BindingSource tAREABindingSource;
        private DBFORMDataSetTableAdapters.T_AREATableAdapter t_AREATableAdapter;
        private System.Windows.Forms.BindingSource tMOBindingSource;
        private DBFORMDataSetTableAdapters.T_MOTableAdapter t_MOTableAdapter;
    }
}

