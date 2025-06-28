namespace StudentActivity
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtName = new System.Windows.Forms.TextBox();
            cmbGender = new System.Windows.Forms.ComboBox();
            dtpBirth = new System.Windows.Forms.DateTimePicker();
            nudEvents = new System.Windows.Forms.NumericUpDown();
            nudProposals = new System.Windows.Forms.NumericUpDown();
            txtFaculty = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            bntLoadAll = new System.Windows.Forms.Button();
            btnTopProposal = new System.Windows.Forms.Button();
            Записи = new System.Windows.Forms.ListBox();
            ФИО = new System.Windows.Forms.Label();
            Пол = new System.Windows.Forms.Label();
            ДР = new System.Windows.Forms.Label();
            Посещения = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            Факультет = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)nudEvents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProposals).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(122, 12);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "ФИО";
            txtName.Size = new System.Drawing.Size(199, 27);
            txtName.TabIndex = 0;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbGender.Items.AddRange(new object[] { "Мужской", "Женский" });
            cmbGender.Location = new System.Drawing.Point(122, 106);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new System.Drawing.Size(121, 28);
            cmbGender.TabIndex = 1;
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new System.Drawing.Point(123, 142);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new System.Drawing.Size(200, 27);
            dtpBirth.TabIndex = 2;
            // 
            // nudEvents
            // 
            nudEvents.Location = new System.Drawing.Point(124, 189);
            nudEvents.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudEvents.Name = "nudEvents";
            nudEvents.Size = new System.Drawing.Size(120, 27);
            nudEvents.TabIndex = 3;
            // 
            // nudProposals
            // 
            nudProposals.Location = new System.Drawing.Point(124, 241);
            nudProposals.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudProposals.Name = "nudProposals";
            nudProposals.Size = new System.Drawing.Size(120, 27);
            nudProposals.TabIndex = 4;
            // 
            // txtFaculty
            // 
            txtFaculty.Location = new System.Drawing.Point(123, 285);
            txtFaculty.Name = "txtFaculty";
            txtFaculty.PlaceholderText = "Факультет";
            txtFaculty.Size = new System.Drawing.Size(200, 27);
            txtFaculty.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(327, 264);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(143, 51);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(122, 48);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(199, 51);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить";
            btnDelete.Click += btnDelete_Click;
            // 
            // bntLoadAll
            // 
            bntLoadAll.Location = new System.Drawing.Point(493, 264);
            bntLoadAll.Name = "bntLoadAll";
            bntLoadAll.Size = new System.Drawing.Size(147, 51);
            bntLoadAll.TabIndex = 8;
            bntLoadAll.Text = "Загрузить\r\nиз файла";
            bntLoadAll.Click += btnLoadAll_Click;
            // 
            // btnTopProposal
            // 
            btnTopProposal.Location = new System.Drawing.Point(663, 264);
            btnTopProposal.Name = "btnTopProposal";
            btnTopProposal.Size = new System.Drawing.Size(152, 51);
            btnTopProposal.TabIndex = 9;
            btnTopProposal.Text = "Лидеры по предложениям";
            btnTopProposal.Click += btnTopProposal_Click;
            // 
            // Записи
            // 
            Записи.ItemHeight = 20;
            Записи.Location = new System.Drawing.Point(327, 12);
            Записи.Name = "Записи";
            Записи.Size = new System.Drawing.Size(488, 244);
            Записи.TabIndex = 10;
            // 
            // ФИО
            // 
            ФИО.AutoSize = true;
            ФИО.Location = new System.Drawing.Point(12, 15);
            ФИО.Name = "ФИО";
            ФИО.Size = new System.Drawing.Size(42, 20);
            ФИО.TabIndex = 11;
            ФИО.Text = "ФИО";
            // 
            // Пол
            // 
            Пол.AutoSize = true;
            Пол.Location = new System.Drawing.Point(13, 108);
            Пол.Name = "Пол";
            Пол.Size = new System.Drawing.Size(37, 20);
            Пол.TabIndex = 12;
            Пол.Text = "Пол";
            // 
            // ДР
            // 
            ДР.AutoSize = true;
            ДР.Location = new System.Drawing.Point(13, 137);
            ДР.Name = "ДР";
            ДР.Size = new System.Drawing.Size(79, 40);
            ДР.TabIndex = 13;
            ДР.Text = "Дата \r\nРождения";
            // 
            // Посещения
            // 
            Посещения.AutoSize = true;
            Посещения.Location = new System.Drawing.Point(13, 182);
            Посещения.Name = "Посещения";
            Посещения.Size = new System.Drawing.Size(91, 40);
            Посещения.TabIndex = 14;
            Посещения.Text = "Кол-во\r\nПосещений";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 232);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 40);
            label1.TabIndex = 15;
            label1.Text = "Кол-во\r\nПредложений";
            // 
            // Факультет
            // 
            Факультет.AutoSize = true;
            Факультет.Location = new System.Drawing.Point(13, 286);
            Факультет.Name = "Факультет";
            Факультет.Size = new System.Drawing.Size(78, 20);
            Факультет.TabIndex = 16;
            Факультет.Text = "Факультет";
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(823, 329);
            Controls.Add(Факультет);
            Controls.Add(label1);
            Controls.Add(Посещения);
            Controls.Add(ДР);
            Controls.Add(Пол);
            Controls.Add(ФИО);
            Controls.Add(txtName);
            Controls.Add(cmbGender);
            Controls.Add(dtpBirth);
            Controls.Add(nudEvents);
            Controls.Add(nudProposals);
            Controls.Add(txtFaculty);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(bntLoadAll);
            Controls.Add(btnTopProposal);
            Controls.Add(Записи);
            Name = "MainForm";
            Text = "Студенческий актив";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudEvents).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProposals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.NumericUpDown nudEvents;
        private System.Windows.Forms.NumericUpDown nudProposals;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button bntLoadAll;
        private System.Windows.Forms.Button btnTopProposal;
        private System.Windows.Forms.ListBox Записи;
        private System.Windows.Forms.Label ФИО;
        private System.Windows.Forms.Label Пол;
        private System.Windows.Forms.Label ДР;
        private System.Windows.Forms.Label Посещения;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Факультет;
    }
}