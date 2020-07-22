namespace CRUD_Application
{
    partial class CRUD_Form
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
            this.components = new System.ComponentModel.Container();
            this.rightPanel = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.browseBtn = new MetroFramework.Controls.MetroButton();
            this.empIDTBox = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.nameTBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.emailTBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dobTBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.addressTBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightPanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.metroLabel5);
            this.rightPanel.Controls.Add(this.metroLabel4);
            this.rightPanel.Controls.Add(this.metroLabel3);
            this.rightPanel.Controls.Add(this.metroLabel2);
            this.rightPanel.Controls.Add(this.metroLabel1);
            this.rightPanel.Controls.Add(this.metroPanel2);
            this.rightPanel.Controls.Add(this.addressTBox);
            this.rightPanel.Controls.Add(this.dobTBox);
            this.rightPanel.Controls.Add(this.emailTBox);
            this.rightPanel.Controls.Add(this.nameTBox);
            this.rightPanel.Controls.Add(this.empIDTBox);
            this.rightPanel.Controls.Add(this.browseBtn);
            this.rightPanel.Controls.Add(this.picBox);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.HorizontalScrollbarBarColor = true;
            this.rightPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.rightPanel.HorizontalScrollbarSize = 10;
            this.rightPanel.Location = new System.Drawing.Point(313, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(447, 370);
            this.rightPanel.TabIndex = 1;
            this.rightPanel.VerticalScrollbarBarColor = true;
            this.rightPanel.VerticalScrollbarHighlightOnWheel = false;
            this.rightPanel.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dataGridView);
            this.metroPanel1.Controls.Add(this.rightPanel);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(760, 370);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(4, 4);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(142, 151);
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(36, 161);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(70, 25);
            this.browseBtn.TabIndex = 4;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseSelectable = true;
            // 
            // empIDTBox
            // 
            // 
            // 
            // 
            this.empIDTBox.CustomButton.Image = null;
            this.empIDTBox.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.empIDTBox.CustomButton.Name = "";
            this.empIDTBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.empIDTBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.empIDTBox.CustomButton.TabIndex = 1;
            this.empIDTBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.empIDTBox.CustomButton.UseSelectable = true;
            this.empIDTBox.CustomButton.Visible = false;
            this.empIDTBox.Lines = new string[0];
            this.empIDTBox.Location = new System.Drawing.Point(234, 7);
            this.empIDTBox.MaxLength = 32767;
            this.empIDTBox.Name = "empIDTBox";
            this.empIDTBox.PasswordChar = '\0';
            this.empIDTBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.empIDTBox.SelectedText = "";
            this.empIDTBox.SelectionLength = 0;
            this.empIDTBox.SelectionStart = 0;
            this.empIDTBox.ShortcutsEnabled = true;
            this.empIDTBox.Size = new System.Drawing.Size(210, 23);
            this.empIDTBox.TabIndex = 5;
            this.empIDTBox.UseSelectable = true;
            this.empIDTBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.empIDTBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.tableLayoutPanel1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 333);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(447, 37);
            this.metroPanel2.TabIndex = 6;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.63492F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel1.Controls.Add(this.saveBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.editBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 37);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.FlatAppearance.BorderSize = 2;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(82, 31);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBtn.FlatAppearance.BorderSize = 2;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(91, 3);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(86, 31);
            this.editBtn.TabIndex = 7;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.FlatAppearance.BorderSize = 2;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(183, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(82, 31);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBtn.FlatAppearance.BorderSize = 2;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(271, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(82, 31);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(359, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 31);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(176, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Emp ID";
            // 
            // nameTBox
            // 
            // 
            // 
            // 
            this.nameTBox.CustomButton.Image = null;
            this.nameTBox.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.nameTBox.CustomButton.Name = "";
            this.nameTBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameTBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTBox.CustomButton.TabIndex = 1;
            this.nameTBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTBox.CustomButton.UseSelectable = true;
            this.nameTBox.CustomButton.Visible = false;
            this.nameTBox.Lines = new string[0];
            this.nameTBox.Location = new System.Drawing.Point(234, 36);
            this.nameTBox.MaxLength = 32767;
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.PasswordChar = '\0';
            this.nameTBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTBox.SelectedText = "";
            this.nameTBox.SelectionLength = 0;
            this.nameTBox.SelectionStart = 0;
            this.nameTBox.ShortcutsEnabled = true;
            this.nameTBox.Size = new System.Drawing.Size(210, 23);
            this.nameTBox.TabIndex = 5;
            this.nameTBox.UseSelectable = true;
            this.nameTBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(183, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Name";
            // 
            // emailTBox
            // 
            // 
            // 
            // 
            this.emailTBox.CustomButton.Image = null;
            this.emailTBox.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.emailTBox.CustomButton.Name = "";
            this.emailTBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailTBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTBox.CustomButton.TabIndex = 1;
            this.emailTBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTBox.CustomButton.UseSelectable = true;
            this.emailTBox.CustomButton.Visible = false;
            this.emailTBox.Lines = new string[0];
            this.emailTBox.Location = new System.Drawing.Point(234, 65);
            this.emailTBox.MaxLength = 32767;
            this.emailTBox.Name = "emailTBox";
            this.emailTBox.PasswordChar = '\0';
            this.emailTBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTBox.SelectedText = "";
            this.emailTBox.SelectionLength = 0;
            this.emailTBox.SelectionStart = 0;
            this.emailTBox.ShortcutsEnabled = true;
            this.emailTBox.Size = new System.Drawing.Size(210, 23);
            this.emailTBox.TabIndex = 5;
            this.emailTBox.UseSelectable = true;
            this.emailTBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(187, 69);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Email";
            // 
            // dobTBox
            // 
            // 
            // 
            // 
            this.dobTBox.CustomButton.Image = null;
            this.dobTBox.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.dobTBox.CustomButton.Name = "";
            this.dobTBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dobTBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dobTBox.CustomButton.TabIndex = 1;
            this.dobTBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dobTBox.CustomButton.UseSelectable = true;
            this.dobTBox.CustomButton.Visible = false;
            this.dobTBox.Lines = new string[0];
            this.dobTBox.Location = new System.Drawing.Point(234, 94);
            this.dobTBox.MaxLength = 32767;
            this.dobTBox.Name = "dobTBox";
            this.dobTBox.PasswordChar = '\0';
            this.dobTBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dobTBox.SelectedText = "";
            this.dobTBox.SelectionLength = 0;
            this.dobTBox.SelectionStart = 0;
            this.dobTBox.ShortcutsEnabled = true;
            this.dobTBox.Size = new System.Drawing.Size(210, 23);
            this.dobTBox.TabIndex = 5;
            this.dobTBox.UseSelectable = true;
            this.dobTBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dobTBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(191, 98);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "DOB";
            // 
            // addressTBox
            // 
            // 
            // 
            // 
            this.addressTBox.CustomButton.Image = null;
            this.addressTBox.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.addressTBox.CustomButton.Name = "";
            this.addressTBox.CustomButton.Size = new System.Drawing.Size(101, 101);
            this.addressTBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addressTBox.CustomButton.TabIndex = 1;
            this.addressTBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addressTBox.CustomButton.UseSelectable = true;
            this.addressTBox.CustomButton.Visible = false;
            this.addressTBox.Lines = new string[0];
            this.addressTBox.Location = new System.Drawing.Point(234, 123);
            this.addressTBox.MaxLength = 32767;
            this.addressTBox.Multiline = true;
            this.addressTBox.Name = "addressTBox";
            this.addressTBox.PasswordChar = '\0';
            this.addressTBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addressTBox.SelectedText = "";
            this.addressTBox.SelectionLength = 0;
            this.addressTBox.SelectionStart = 0;
            this.addressTBox.ShortcutsEnabled = true;
            this.addressTBox.Size = new System.Drawing.Size(210, 103);
            this.addressTBox.TabIndex = 5;
            this.addressTBox.UseSelectable = true;
            this.addressTBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addressTBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(172, 127);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Address";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.employeeBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(313, 370);
            this.dataGridView.TabIndex = 2;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(CRUD_Application.Model.Employee);
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "EmpId";
            this.empIdDataGridViewTextBoxColumn.HeaderText = "EmpId";
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            this.empIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // CRUD_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Name = "CRUD_Form";
            this.Text = "CRUD_Form";
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel rightPanel;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private MetroFramework.Controls.MetroTextBox addressTBox;
        private MetroFramework.Controls.MetroTextBox dobTBox;
        private MetroFramework.Controls.MetroTextBox emailTBox;
        private MetroFramework.Controls.MetroTextBox nameTBox;
        private MetroFramework.Controls.MetroTextBox empIDTBox;
        private MetroFramework.Controls.MetroButton browseBtn;
        private System.Windows.Forms.PictureBox picBox;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
    }
}