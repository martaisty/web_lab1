
namespace web_lab1
{
    partial class FormSagesList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Sages = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewSages = new System.Windows.Forms.DataGridView();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.textSageId = new System.Windows.Forms.TextBox();
            this.dataGridViewSageBooks = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.imgProfile = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewBookSages = new System.Windows.Forms.DataGridView();
            this.textBookId = new System.Windows.Forms.TextBox();
            this.labelBooksDescription = new System.Windows.Forms.Label();
            this.textBookDescription = new System.Windows.Forms.TextBox();
            this.btnAddSage = new System.Windows.Forms.Button();
            this.labelBookSages = new System.Windows.Forms.Label();
            this.btnBookCancel = new System.Windows.Forms.Button();
            this.btnBookSave = new System.Windows.Forms.Button();
            this.labelBookName = new System.Windows.Forms.Label();
            this.textBookName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Sages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSages)).BeginInit();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSageBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookSages)).BeginInit();
            this.SuspendLayout();
            // 
            // Sages
            // 
            this.Sages.Controls.Add(this.tabPage1);
            this.Sages.Controls.Add(this.tabPage2);
            this.Sages.Location = new System.Drawing.Point(12, 12);
            this.Sages.Name = "Sages";
            this.Sages.SelectedIndex = 0;
            this.Sages.Size = new System.Drawing.Size(1040, 628);
            this.Sages.TabIndex = 0;
            this.Sages.Selected += new System.Windows.Forms.TabControlEventHandler(this.Sages_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSages);
            this.tabPage1.Controls.Add(this.infoPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1032, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sages";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSages
            // 
            this.dataGridViewSages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSages.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewSages.MultiSelect = false;
            this.dataGridViewSages.Name = "dataGridViewSages";
            this.dataGridViewSages.ReadOnly = true;
            this.dataGridViewSages.RowTemplate.Height = 25;
            this.dataGridViewSages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSages.Size = new System.Drawing.Size(563, 585);
            this.dataGridViewSages.TabIndex = 1;
            this.dataGridViewSages.SelectionChanged += new System.EventHandler(this.dataGridViewSages_SelectionChanged);
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.textSageId);
            this.infoPanel.Controls.Add(this.dataGridViewSageBooks);
            this.infoPanel.Controls.Add(this.btnAddBook);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Controls.Add(this.btnCancel);
            this.infoPanel.Controls.Add(this.bntSave);
            this.infoPanel.Controls.Add(this.btnBrowse);
            this.infoPanel.Controls.Add(this.labelCity);
            this.infoPanel.Controls.Add(this.labelAge);
            this.infoPanel.Controls.Add(this.labelName);
            this.infoPanel.Controls.Add(this.textCity);
            this.infoPanel.Controls.Add(this.textAge);
            this.infoPanel.Controls.Add(this.textName);
            this.infoPanel.Controls.Add(this.imgProfile);
            this.infoPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoPanel.Location = new System.Drawing.Point(575, 6);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(451, 588);
            this.infoPanel.TabIndex = 0;
            // 
            // textSageId
            // 
            this.textSageId.Location = new System.Drawing.Point(240, 106);
            this.textSageId.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.textSageId.Name = "textSageId";
            this.textSageId.ReadOnly = true;
            this.textSageId.Size = new System.Drawing.Size(201, 23);
            this.textSageId.TabIndex = 9;
            this.textSageId.Visible = false;
            // 
            // dataGridViewSageBooks
            // 
            this.dataGridViewSageBooks.AllowUserToAddRows = false;
            this.dataGridViewSageBooks.AllowUserToDeleteRows = false;
            this.dataGridViewSageBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSageBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSageBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSageBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSageBooks.Location = new System.Drawing.Point(10, 283);
            this.dataGridViewSageBooks.MultiSelect = false;
            this.dataGridViewSageBooks.Name = "dataGridViewSageBooks";
            this.dataGridViewSageBooks.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSageBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSageBooks.RowTemplate.Height = 25;
            this.dataGridViewSageBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSageBooks.Size = new System.Drawing.Size(431, 273);
            this.dataGridViewSageBooks.TabIndex = 8;
            this.dataGridViewSageBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSageBooks_CellContentClick);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(366, 254);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Books";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(91, 562);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(10, 562);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(75, 23);
            this.bntSave.TabIndex = 4;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(48, 223);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(173, 71);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(28, 15);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "City";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(173, 42);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(28, 15);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(173, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(240, 68);
            this.textCity.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(201, 23);
            this.textCity.TabIndex = 3;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(240, 39);
            this.textAge.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(201, 23);
            this.textAge.TabIndex = 2;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(240, 10);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(201, 23);
            this.textName.TabIndex = 1;
            // 
            // imgProfile
            // 
            this.imgProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgProfile.Location = new System.Drawing.Point(10, 10);
            this.imgProfile.Margin = new System.Windows.Forms.Padding(10);
            this.imgProfile.Name = "imgProfile";
            this.imgProfile.Size = new System.Drawing.Size(150, 200);
            this.imgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProfile.TabIndex = 0;
            this.imgProfile.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewBooks);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1032, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Books";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewBooks.MultiSelect = false;
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowTemplate.Height = 25;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(563, 585);
            this.dataGridViewBooks.TabIndex = 2;
            this.dataGridViewBooks.SelectionChanged += new System.EventHandler(this.dataGridViewBooks_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewBookSages);
            this.panel1.Controls.Add(this.textBookId);
            this.panel1.Controls.Add(this.labelBooksDescription);
            this.panel1.Controls.Add(this.textBookDescription);
            this.panel1.Controls.Add(this.btnAddSage);
            this.panel1.Controls.Add(this.labelBookSages);
            this.panel1.Controls.Add(this.btnBookCancel);
            this.panel1.Controls.Add(this.btnBookSave);
            this.panel1.Controls.Add(this.labelBookName);
            this.panel1.Controls.Add(this.textBookName);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(575, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 588);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // dataGridViewBookSages
            // 
            this.dataGridViewBookSages.AllowUserToAddRows = false;
            this.dataGridViewBookSages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookSages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBookSages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookSages.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBookSages.Location = new System.Drawing.Point(10, 283);
            this.dataGridViewBookSages.MultiSelect = false;
            this.dataGridViewBookSages.Name = "dataGridViewBookSages";
            this.dataGridViewBookSages.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookSages.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewBookSages.RowTemplate.Height = 25;
            this.dataGridViewBookSages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookSages.Size = new System.Drawing.Size(431, 273);
            this.dataGridViewBookSages.TabIndex = 11;
            this.dataGridViewBookSages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookSages_CellContentClick);
            // 
            // textBookId
            // 
            this.textBookId.Location = new System.Drawing.Point(224, 36);
            this.textBookId.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.textBookId.Name = "textBookId";
            this.textBookId.ReadOnly = true;
            this.textBookId.Size = new System.Drawing.Size(217, 23);
            this.textBookId.TabIndex = 10;
            this.textBookId.Visible = false;
            // 
            // labelBooksDescription
            // 
            this.labelBooksDescription.AutoSize = true;
            this.labelBooksDescription.Location = new System.Drawing.Point(10, 44);
            this.labelBooksDescription.Name = "labelBooksDescription";
            this.labelBooksDescription.Size = new System.Drawing.Size(67, 15);
            this.labelBooksDescription.TabIndex = 9;
            this.labelBooksDescription.Text = "Description";
            // 
            // textBookDescription
            // 
            this.textBookDescription.Location = new System.Drawing.Point(10, 62);
            this.textBookDescription.Multiline = true;
            this.textBookDescription.Name = "textBookDescription";
            this.textBookDescription.Size = new System.Drawing.Size(431, 186);
            this.textBookDescription.TabIndex = 2;
            // 
            // btnAddSage
            // 
            this.btnAddSage.Location = new System.Drawing.Point(366, 254);
            this.btnAddSage.Name = "btnAddSage";
            this.btnAddSage.Size = new System.Drawing.Size(75, 23);
            this.btnAddSage.TabIndex = 3;
            this.btnAddSage.Text = "Add Sage";
            this.btnAddSage.UseVisualStyleBackColor = true;
            this.btnAddSage.Click += new System.EventHandler(this.btnAddSage_Click);
            // 
            // labelBookSages
            // 
            this.labelBookSages.AutoSize = true;
            this.labelBookSages.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBookSages.Location = new System.Drawing.Point(10, 254);
            this.labelBookSages.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelBookSages.Name = "labelBookSages";
            this.labelBookSages.Size = new System.Drawing.Size(49, 20);
            this.labelBookSages.TabIndex = 6;
            this.labelBookSages.Text = "Sages";
            // 
            // btnBookCancel
            // 
            this.btnBookCancel.Location = new System.Drawing.Point(91, 562);
            this.btnBookCancel.Name = "btnBookCancel";
            this.btnBookCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBookCancel.TabIndex = 5;
            this.btnBookCancel.Text = "Cancel";
            this.btnBookCancel.UseVisualStyleBackColor = true;
            this.btnBookCancel.Click += new System.EventHandler(this.btnBookCancel_Click);
            // 
            // btnBookSave
            // 
            this.btnBookSave.Location = new System.Drawing.Point(10, 562);
            this.btnBookSave.Name = "btnBookSave";
            this.btnBookSave.Size = new System.Drawing.Size(75, 23);
            this.btnBookSave.TabIndex = 4;
            this.btnBookSave.Text = "Save";
            this.btnBookSave.UseVisualStyleBackColor = true;
            this.btnBookSave.Click += new System.EventHandler(this.btnBookSave_Click);
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(10, 13);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(39, 15);
            this.labelBookName.TabIndex = 2;
            this.labelBookName.Text = "Name";
            // 
            // textBookName
            // 
            this.textBookName.Location = new System.Drawing.Point(55, 10);
            this.textBookName.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.textBookName.Name = "textBookName";
            this.textBookName.Size = new System.Drawing.Size(386, 23);
            this.textBookName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 646);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(97, 646);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(178, 646);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormSagesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Sages);
            this.Name = "FormSagesList";
            this.Text = "Lab1";
            this.Load += new System.EventHandler(this.FormSagesList_Load);
            this.Sages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSages)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSageBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookSages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Sages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.PictureBox imgProfile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.DataGridView dataGridViewSages;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddSage;
        private System.Windows.Forms.Label labelBookSages;
        private System.Windows.Forms.Button btnBookCancel;
        private System.Windows.Forms.Button btnBookSave;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.TextBox textBookName;
        private System.Windows.Forms.Label labelBooksDescription;
        private System.Windows.Forms.TextBox textBookDescription;
        private System.Windows.Forms.DataGridView dataGridViewSageBooks;
        private System.Windows.Forms.TextBox textSageId;
        private System.Windows.Forms.TextBox textBookId;
        private System.Windows.Forms.DataGridView dataGridViewBookSages;
    }
}