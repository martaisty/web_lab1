
namespace web_lab1
{
    partial class AddSagesModal
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewSages = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imgProfile = new System.Windows.Forms.PictureBox();
            this.labelImage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(658, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(577, 500);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewSages
            // 
            this.dataGridViewSages.AllowUserToAddRows = false;
            this.dataGridViewSages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add});
            this.dataGridViewSages.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSages.MultiSelect = false;
            this.dataGridViewSages.Name = "dataGridViewSages";
            this.dataGridViewSages.ReadOnly = true;
            this.dataGridViewSages.RowTemplate.Height = 25;
            this.dataGridViewSages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSages.Size = new System.Drawing.Size(499, 482);
            this.dataGridViewSages.TabIndex = 1;
            this.dataGridViewSages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSages_CellContentClick);
            this.dataGridViewSages.SelectionChanged += new System.EventHandler(this.dataGridViewSages_SelectionChanged);
            // 
            // Add
            // 
            this.Add.FalseValue = "false";
            this.Add.HeaderText = "Add";
            this.Add.IndeterminateValue = "false";
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.TrueValue = "true";
            // 
            // imgProfile
            // 
            this.imgProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgProfile.Location = new System.Drawing.Point(524, 12);
            this.imgProfile.Margin = new System.Windows.Forms.Padding(10);
            this.imgProfile.Name = "imgProfile";
            this.imgProfile.Size = new System.Drawing.Size(209, 242);
            this.imgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProfile.TabIndex = 2;
            this.imgProfile.TabStop = false;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelImage.Location = new System.Drawing.Point(524, 264);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(102, 21);
            this.labelImage.TabIndex = 3;
            this.labelImage.Text = "Profile image";
            // 
            // AddSagesModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 528);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.imgProfile);
            this.Controls.Add(this.dataGridViewSages);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddSagesModal";
            this.Text = "Add Sages";
            this.Load += new System.EventHandler(this.AddSagesModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewSages;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Add;
        private System.Windows.Forms.PictureBox imgProfile;
        private System.Windows.Forms.Label labelImage;
    }
}