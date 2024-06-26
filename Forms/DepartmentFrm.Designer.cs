﻿namespace Offline_System {
    partial class DepartmentFrm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            groupBox1 = new GroupBox();
            editDepBtn = new Button();
            deleteDepBtn = new Button();
            SaveDepBtn = new Button();
            label3 = new Label();
            grd_dep = new DataGridView();
            inputField = new GroupBox();
            label7 = new Label();
            depStatus = new CheckBox();
            textDepName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textDepId = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd_dep).BeginInit();
            inputField.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(editDepBtn);
            groupBox1.Controls.Add(deleteDepBtn);
            groupBox1.Controls.Add(SaveDepBtn);
            groupBox1.Location = new Point(622, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(150, 113);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "&Actions";
            // 
            // editDepBtn
            // 
            editDepBtn.Location = new Point(6, 51);
            editDepBtn.Name = "editDepBtn";
            editDepBtn.Size = new Size(138, 23);
            editDepBtn.TabIndex = 3;
            editDepBtn.Text = "Update";
            editDepBtn.UseVisualStyleBackColor = true;
            editDepBtn.Click += editDepBtn_Click;
            // 
            // deleteDepBtn
            // 
            deleteDepBtn.Location = new Point(6, 79);
            deleteDepBtn.Name = "deleteDepBtn";
            deleteDepBtn.Size = new Size(138, 23);
            deleteDepBtn.TabIndex = 2;
            deleteDepBtn.Text = "Delete";
            deleteDepBtn.UseVisualStyleBackColor = true;
            deleteDepBtn.Click += deleteDepBtn_Click;
            // 
            // SaveDepBtn
            // 
            SaveDepBtn.Location = new Point(6, 22);
            SaveDepBtn.Name = "SaveDepBtn";
            SaveDepBtn.Size = new Size(138, 23);
            SaveDepBtn.TabIndex = 1;
            SaveDepBtn.Text = "Save";
            SaveDepBtn.UseVisualStyleBackColor = true;
            SaveDepBtn.Click += SaveDepBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(422, 45);
            label3.TabIndex = 9;
            label3.Text = "&Departments Management";
            // 
            // grd_dep
            // 
            grd_dep.AllowUserToAddRows = false;
            grd_dep.AllowUserToDeleteRows = false;
            grd_dep.AllowUserToResizeColumns = false;
            grd_dep.AllowUserToResizeRows = false;
            grd_dep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grd_dep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd_dep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_dep.Location = new Point(12, 176);
            grd_dep.Name = "grd_dep";
            grd_dep.ReadOnly = true;
            grd_dep.RightToLeft = RightToLeft.No;
            grd_dep.RowHeadersVisible = false;
            grd_dep.RowTemplate.Height = 25;
            grd_dep.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd_dep.Size = new Size(760, 375);
            grd_dep.TabIndex = 8;
            grd_dep.CellDoubleClick += grd_dep_CellDoubleClick;
            // 
            // inputField
            // 
            inputField.Controls.Add(label7);
            inputField.Controls.Add(depStatus);
            inputField.Controls.Add(textDepName);
            inputField.Controls.Add(label2);
            inputField.Controls.Add(label1);
            inputField.Controls.Add(textDepId);
            inputField.Location = new Point(12, 57);
            inputField.Name = "inputField";
            inputField.Size = new Size(358, 113);
            inputField.TabIndex = 7;
            inputField.TabStop = false;
            inputField.Text = "&Department Info";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 83);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 15;
            label7.Text = "Status";
            // 
            // depStatus
            // 
            depStatus.AutoSize = true;
            depStatus.Checked = true;
            depStatus.CheckState = CheckState.Checked;
            depStatus.Location = new Point(113, 82);
            depStatus.Name = "depStatus";
            depStatus.RightToLeft = RightToLeft.No;
            depStatus.Size = new Size(59, 19);
            depStatus.TabIndex = 14;
            depStatus.Text = "Active";
            depStatus.UseVisualStyleBackColor = true;
            // 
            // textDepName
            // 
            textDepName.Location = new Point(113, 51);
            textDepName.Name = "textDepName";
            textDepName.Size = new Size(238, 23);
            textDepName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 5;
            label2.Text = "Deparment Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 4;
            label1.Text = "Deparment ID";
            // 
            // textDepId
            // 
            textDepId.Enabled = false;
            textDepId.Location = new Point(113, 22);
            textDepId.Name = "textDepId";
            textDepId.Size = new Size(238, 23);
            textDepId.TabIndex = 3;
            // 
            // DepartmentFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(grd_dep);
            Controls.Add(inputField);
            Name = "DepartmentFrm";
            Text = "Departments Management";
            Load += DepartmentFrm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd_dep).EndInit();
            inputField.ResumeLayout(false);
            inputField.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button editDepBtn;
        private Button deleteDepBtn;
        private Button SaveDepBtn;
        private Label label3;
        private DataGridView grd_dep;
        private GroupBox inputField;
        private TextBox textDepName;
        private Label label2;
        private Label label1;
        private TextBox textDepId;
        private Label label7;
        private CheckBox depStatus;
    }
}