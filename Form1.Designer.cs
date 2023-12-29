namespace HelloWorld
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
            this.btnRefresh1 = new System.Windows.Forms.Button();
            this.btnDownload1 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.btnUpload1 = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CreatedAt = new System.Windows.Forms.DateTimePicker();
            this.UpdatedAt = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh1
            // 
            this.btnRefresh1.Location = new System.Drawing.Point(41, 292);
            this.btnRefresh1.Name = "btnRefresh1";
            this.btnRefresh1.Size = new System.Drawing.Size(120, 23);
            this.btnRefresh1.TabIndex = 0;
            this.btnRefresh1.Text = "Refresh";
            this.btnRefresh1.UseVisualStyleBackColor = true;
            this.btnRefresh1.Click += new System.EventHandler(this.btnRefresh1_Click);
            // 
            // btnDownload1
            // 
            this.btnDownload1.Location = new System.Drawing.Point(347, 292);
            this.btnDownload1.Name = "btnDownload1";
            this.btnDownload1.Size = new System.Drawing.Size(103, 23);
            this.btnDownload1.TabIndex = 1;
            this.btnDownload1.Text = "Download";
            this.btnDownload1.UseVisualStyleBackColor = true;
            this.btnDownload1.Click += new System.EventHandler(this.btnDownload1_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.Location = new System.Drawing.Point(644, 292);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(115, 23);
            this.btnDelete1.TabIndex = 2;
            this.btnDelete1.Text = "Delete";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(41, 368);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(120, 23);
            this.btnBrowse1.TabIndex = 3;
            this.btnBrowse1.Text = "Browse";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // btnUpload1
            // 
            this.btnUpload1.Location = new System.Drawing.Point(644, 368);
            this.btnUpload1.Name = "btnUpload1";
            this.btnUpload1.Size = new System.Drawing.Size(115, 23);
            this.btnUpload1.TabIndex = 4;
            this.btnUpload1.Text = "Upload";
            this.btnUpload1.UseVisualStyleBackColor = true;
            this.btnUpload1.Click += new System.EventHandler(this.btnUpload1_Click);
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Location = new System.Drawing.Point(167, 371);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(74, 16);
            this.file.TabIndex = 5;
            this.file.Text = "chooseFile";
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UpdatedAt);
            this.panel1.Controls.Add(this.CreatedAt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Data);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fileName);
            this.panel1.Location = new System.Drawing.Point(41, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 207);
            this.panel1.TabIndex = 6;
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(100, 36);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(100, 22);
            this.fileName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "FileName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data";
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(335, 36);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(100, 22);
            this.Data.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "UserName";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(581, 36);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 22);
            this.UserName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "CreatedAt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "UpdatedAt";
            // 
            // CreatedAt
            // 
            this.CreatedAt.Location = new System.Drawing.Point(116, 121);
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.Size = new System.Drawing.Size(200, 22);
            this.CreatedAt.TabIndex = 8;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.Location = new System.Drawing.Point(495, 121);
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.Size = new System.Drawing.Size(200, 22);
            this.UpdatedAt.TabIndex = 9;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(808, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.file);
            this.Controls.Add(this.btnUpload1);
            this.Controls.Add(this.btnBrowse1);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnDownload1);
            this.Controls.Add(this.btnRefresh1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label txtFilename;
        private System.Windows.Forms.Button btnRefresh1;
        private System.Windows.Forms.Button btnDownload1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Button btnUpload1;
        private System.Windows.Forms.Label file;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker UpdatedAt;
        private System.Windows.Forms.DateTimePicker CreatedAt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.Label label2;
    }
}

