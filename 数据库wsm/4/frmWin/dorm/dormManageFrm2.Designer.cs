﻿namespace frmWin.dorm
{
    partial class dormManageFrm2
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
            this.btnFind = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvDorm = new System.Windows.Forms.DataGridView();
            this.buildName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuildName = new System.Windows.Forms.ComboBox();
            this.txtDormName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDorm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(443, 76);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 47;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(518, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 50);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvDorm
            // 
            this.dgvDorm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDorm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildName,
            this.dormNum,
            this.personCount,
            this.flag});
            this.dgvDorm.Location = new System.Drawing.Point(28, 127);
            this.dgvDorm.Name = "dgvDorm";
            this.dgvDorm.RowHeadersWidth = 51;
            this.dgvDorm.RowTemplate.Height = 27;
            this.dgvDorm.Size = new System.Drawing.Size(581, 224);
            this.dgvDorm.TabIndex = 41;
            // 
            // buildName
            // 
            this.buildName.DataPropertyName = "buildName";
            this.buildName.HeaderText = "楼号";
            this.buildName.MinimumWidth = 6;
            this.buildName.Name = "buildName";
            this.buildName.Width = 125;
            // 
            // dormNum
            // 
            this.dormNum.DataPropertyName = "dormNum";
            this.dormNum.HeaderText = "宿舍号";
            this.dormNum.MinimumWidth = 6;
            this.dormNum.Name = "dormNum";
            this.dormNum.Width = 125;
            // 
            // personCount
            // 
            this.personCount.DataPropertyName = "personCount";
            this.personCount.HeaderText = "宿舍人数";
            this.personCount.MinimumWidth = 6;
            this.personCount.Name = "personCount";
            this.personCount.Width = 125;
            // 
            // flag
            // 
            this.flag.DataPropertyName = "flag";
            this.flag.HeaderText = "状态";
            this.flag.MinimumWidth = 6;
            this.flag.Name = "flag";
            this.flag.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "宿舍号";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(397, 377);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 50);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "宿舍楼";
            // 
            // txtBuildName
            // 
            this.txtBuildName.FormattingEnabled = true;
            this.txtBuildName.Location = new System.Drawing.Point(102, 76);
            this.txtBuildName.Name = "txtBuildName";
            this.txtBuildName.Size = new System.Drawing.Size(107, 23);
            this.txtBuildName.TabIndex = 51;
            // 
            // txtDormName
            // 
            this.txtDormName.FormattingEnabled = true;
            this.txtDormName.Location = new System.Drawing.Point(293, 79);
            this.txtDormName.Name = "txtDormName";
            this.txtDormName.Size = new System.Drawing.Size(121, 23);
            this.txtDormName.TabIndex = 52;
            // 
            // dormManageFrm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 439);
            this.Controls.Add(this.txtDormName);
            this.Controls.Add(this.txtBuildName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvDorm);
            this.Controls.Add(this.label1);
            this.Name = "dormManageFrm2";
            this.Text = "dormManageFrm2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dormManageFrm2_FormClosing);
            this.MdiChildActivate += new System.EventHandler(this.dormManageFrm2_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDorm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvDorm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtBuildName;
        private System.Windows.Forms.ComboBox txtDormName;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn personCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn flag;
    }
}