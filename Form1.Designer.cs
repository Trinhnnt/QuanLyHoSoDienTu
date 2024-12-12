namespace HoSoDienTu
{
    partial class Form1
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.dtpTimestamp = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.btnSearchByTime = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalEmployees = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeleteID = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Location = new System.Drawing.Point(32, 42);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(60, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(55, 22);
            this.txtID.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(127, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Họ và Tên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(212, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(212, 77);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(137, 22);
            this.txtPosition.TabIndex = 4;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPosition.Location = new System.Drawing.Point(127, 84);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(61, 16);
            this.lblPosition.TabIndex = 5;
            this.lblPosition.Text = "Chức vụ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGender.Location = new System.Drawing.Point(379, 45);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 16);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Giới tính";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Nam ",
            "Nữ ",
            "Khác"});
            this.cbGender.Location = new System.Drawing.Point(495, 37);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(90, 24);
            this.cbGender.TabIndex = 7;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimestamp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimestamp.Location = new System.Drawing.Point(384, 80);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(103, 16);
            this.lblTimestamp.TabIndex = 8;
            this.lblTimestamp.Text = "Ngày vào làm";
            // 
            // dtpTimestamp
            // 
            this.dtpTimestamp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimestamp.CalendarForeColor = System.Drawing.Color.MidnightBlue;
            this.dtpTimestamp.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dtpTimestamp.CalendarTitleBackColor = System.Drawing.Color.MidnightBlue;
            this.dtpTimestamp.CalendarTitleForeColor = System.Drawing.Color.MidnightBlue;
            this.dtpTimestamp.CalendarTrailingForeColor = System.Drawing.Color.MidnightBlue;
            this.dtpTimestamp.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dtpTimestamp.CustomFormat = "dd/MM/yyyy";
            this.dtpTimestamp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimestamp.Location = new System.Drawing.Point(495, 79);
            this.dtpTimestamp.Name = "dtpTimestamp";
            this.dtpTimestamp.Size = new System.Drawing.Size(90, 22);
            this.dtpTimestamp.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(620, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 24);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(444, 148);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByName.ForeColor = System.Drawing.Color.Black;
            this.btnSearchByName.Location = new System.Drawing.Point(444, 212);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(91, 23);
            this.btnSearchByName.TabIndex = 14;
            this.btnSearchByName.Text = "Tìm kiếm";
            this.btnSearchByName.UseVisualStyleBackColor = false;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // btnSearchByTime
            // 
            this.btnSearchByTime.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSearchByTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByTime.ForeColor = System.Drawing.Color.Black;
            this.btnSearchByTime.Location = new System.Drawing.Point(444, 271);
            this.btnSearchByTime.Name = "btnSearchByTime";
            this.btnSearchByTime.Size = new System.Drawing.Size(91, 24);
            this.btnSearchByTime.TabIndex = 15;
            this.btnSearchByTime.Text = "Tìm kiếm";
            this.btnSearchByTime.UseVisualStyleBackColor = false;
            this.btnSearchByTime.Click += new System.EventHandler(this.btnSearchByTime_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Gender,
            this.Position,
            this.Timestamp});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvData.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvData.Location = new System.Drawing.Point(35, 395);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(677, 167);
            this.dgvData.TabIndex = 17;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Form1";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Giới Tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // Position
            // 
            this.Position.HeaderText = "Chức vụ";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.Width = 125;
            // 
            // Timestamp
            // 
            this.Timestamp.HeaderText = "Ngày vào làm";
            this.Timestamp.MinimumWidth = 6;
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.Width = 125;
            // 
            // lblTotalEmployees
            // 
            this.lblTotalEmployees.AutoSize = true;
            this.lblTotalEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployees.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTotalEmployees.Location = new System.Drawing.Point(302, 376);
            this.lblTotalEmployees.Name = "lblTotalEmployees";
            this.lblTotalEmployees.Size = new System.Drawing.Size(185, 16);
            this.lblTotalEmployees.TabIndex = 18;
            this.lblTotalEmployees.Text = "Hiển thị toàn bộ nhân viên";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CalendarForeColor = System.Drawing.Color.MidnightBlue;
            this.dtpStartTime.CalendarTitleBackColor = System.Drawing.Color.MidnightBlue;
            this.dtpStartTime.CalendarTitleForeColor = System.Drawing.Color.MidnightBlue;
            this.dtpStartTime.CalendarTrailingForeColor = System.Drawing.Color.MidnightBlue;
            this.dtpStartTime.CustomFormat = "dd/MM/yyyy";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(212, 272);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(96, 22);
            this.dtpStartTime.TabIndex = 19;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "dd/MM/yyyy";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(335, 273);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(91, 22);
            this.dtpEndTime.TabIndex = 20;
            this.dtpEndTime.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(212, 212);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(215, 22);
            this.txtSearchName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(312, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(249, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 23;
            // 
            // txtDeleteID
            // 
            this.txtDeleteID.Location = new System.Drawing.Point(212, 148);
            this.txtDeleteID.Name = "txtDeleteID";
            this.txtDeleteID.Size = new System.Drawing.Size(215, 22);
            this.txtDeleteID.TabIndex = 24;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.GhostWhite;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReload.Location = new System.Drawing.Point(35, 324);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(171, 23);
            this.btnReload.TabIndex = 16;
            this.btnReload.Text = "Tải lại toàn bộ danh sách";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(32, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Xóa nhân viên theo ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(32, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tìm kiếm theo tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(32, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tìm kiếm theo thời gian";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(722, 588);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeleteID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.lblTotalEmployees);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSearchByTime);
            this.Controls.Add(this.btnSearchByName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpTimestamp);
            this.Controls.Add(this.lblTimestamp);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Quản lý nhân viên";
            this.TransparencyKey = System.Drawing.Color.MidnightBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblTimestamp;
        private System.Windows.Forms.DateTimePicker dtpTimestamp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.Button btnSearchByTime;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblTotalEmployees;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.TextBox txtDeleteID;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        
    }
}
