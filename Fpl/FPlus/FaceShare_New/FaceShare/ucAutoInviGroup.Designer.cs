﻿namespace FPlus
{
    partial class ucAutoInviGroup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStopPost = new System.Windows.Forms.Button();
            this.lbTotalProcessed = new System.Windows.Forms.Label();
            this.metroProgressSpinnerOnePost = new MetroFramework.Controls.MetroProgressSpinner();
            this.lbStatus = new System.Windows.Forms.Label();
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtTimeDelay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDsNhom = new System.Windows.Forms.Label();
            this.timerstep = new System.Windows.Forms.Timer(this.components);
            this.per = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.wbPostGroup = new System.Windows.Forms.WebBrowser();
            this.txtLimit = new System.Windows.Forms.NumericUpDown();
            this.txtOffset = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.listBoxGroup = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchGroup = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFriendLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeDelay)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStopPost);
            this.groupBox1.Controls.Add(this.lbTotalProcessed);
            this.groupBox1.Controls.Add(this.metroProgressSpinnerOnePost);
            this.groupBox1.Controls.Add(this.lbStatus);
            this.groupBox1.Controls.Add(this.progressBarStatus);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.txtTimeDelay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(421, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 111);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tự động tham gia nhóm";
            // 
            // btnStopPost
            // 
            this.btnStopPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.btnStopPost.FlatAppearance.BorderSize = 0;
            this.btnStopPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopPost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStopPost.ForeColor = System.Drawing.Color.White;
            this.btnStopPost.Location = new System.Drawing.Point(447, 17);
            this.btnStopPost.Name = "btnStopPost";
            this.btnStopPost.Size = new System.Drawing.Size(100, 43);
            this.btnStopPost.TabIndex = 41;
            this.btnStopPost.Text = "Kết thúc";
            this.btnStopPost.UseVisualStyleBackColor = false;
            this.btnStopPost.Click += new System.EventHandler(this.btnStopPost_Click);
            // 
            // lbTotalProcessed
            // 
            this.lbTotalProcessed.Location = new System.Drawing.Point(446, 70);
            this.lbTotalProcessed.Name = "lbTotalProcessed";
            this.lbTotalProcessed.Size = new System.Drawing.Size(100, 13);
            this.lbTotalProcessed.TabIndex = 40;
            this.lbTotalProcessed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroProgressSpinnerOnePost
            // 
            this.metroProgressSpinnerOnePost.BackColor = System.Drawing.Color.Transparent;
            this.metroProgressSpinnerOnePost.Location = new System.Drawing.Point(16, 65);
            this.metroProgressSpinnerOnePost.Maximum = 100;
            this.metroProgressSpinnerOnePost.Name = "metroProgressSpinnerOnePost";
            this.metroProgressSpinnerOnePost.Size = new System.Drawing.Size(16, 16);
            this.metroProgressSpinnerOnePost.TabIndex = 39;
            this.metroProgressSpinnerOnePost.Visible = false;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(37, 68);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(55, 13);
            this.lbStatus.TabIndex = 38;
            this.lbStatus.Text = "Trạng thái";
            this.lbStatus.Visible = false;
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Location = new System.Drawing.Point(13, 86);
            this.progressBarStatus.Maximum = 1000;
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(535, 10);
            this.progressBarStatus.TabIndex = 37;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(342, 17);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 43);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtTimeDelay
            // 
            this.txtTimeDelay.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtTimeDelay.Location = new System.Drawing.Point(245, 28);
            this.txtTimeDelay.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtTimeDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTimeDelay.Name = "txtTimeDelay";
            this.txtTimeDelay.Size = new System.Drawing.Size(72, 20);
            this.txtTimeDelay.TabIndex = 16;
            this.txtTimeDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtTimeDelay.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(14, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Thời gian join (nên để thời gian từ 10> 90 giây)";
            // 
            // lbDsNhom
            // 
            this.lbDsNhom.AutoSize = true;
            this.lbDsNhom.ForeColor = System.Drawing.Color.Navy;
            this.lbDsNhom.Location = new System.Drawing.Point(37, 35);
            this.lbDsNhom.Name = "lbDsNhom";
            this.lbDsNhom.Size = new System.Drawing.Size(88, 13);
            this.lbDsNhom.TabIndex = 43;
            this.lbDsNhom.Text = "Danh sách nhóm";
            // 
            // timerstep
            // 
            this.timerstep.Interval = 10000;
            this.timerstep.Tick += new System.EventHandler(this.timerstep_Tick);
            // 
            // per
            // 
            this.per.Interval = 1000;
            this.per.Tick += new System.EventHandler(this.per_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(131, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Bắt đầu từ nhóm thứ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFriendLink);
            this.groupBox2.Controls.Add(this.wbPostGroup);
            this.groupBox2.Controls.Add(this.txtLimit);
            this.groupBox2.Controls.Add(this.txtOffset);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(421, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 335);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập nội dung bài đăng";
            // 
            // wbPostGroup
            // 
            this.wbPostGroup.Location = new System.Drawing.Point(40, 204);
            this.wbPostGroup.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPostGroup.Name = "wbPostGroup";
            this.wbPostGroup.ScriptErrorsSuppressed = true;
            this.wbPostGroup.Size = new System.Drawing.Size(506, 114);
            this.wbPostGroup.TabIndex = 45;
            this.wbPostGroup.Url = new System.Uri("", System.UriKind.Relative);
            this.wbPostGroup.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbPostGroup_DocumentCompleted);
            // 
            // txtLimit
            // 
            this.txtLimit.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtLimit.Location = new System.Drawing.Point(245, 167);
            this.txtLimit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(139, 20);
            this.txtLimit.TabIndex = 43;
            this.txtLimit.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtOffset
            // 
            this.txtOffset.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtOffset.Location = new System.Drawing.Point(245, 117);
            this.txtOffset.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtOffset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(139, 20);
            this.txtOffset.TabIndex = 44;
            this.txtOffset.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(87, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tổng số nhóm muốn gia nhập:";
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.Checked = true;
            this.cbSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSelectAll.Location = new System.Drawing.Point(18, 35);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(15, 14);
            this.cbSelectAll.TabIndex = 48;
            this.cbSelectAll.UseVisualStyleBackColor = true;
            this.cbSelectAll.CheckedChanged += new System.EventHandler(this.cbSelectAll_CheckedChanged);
            // 
            // listBoxGroup
            // 
            this.listBoxGroup.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listBoxGroup.CheckBoxes = true;
            this.listBoxGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listBoxGroup.FullRowSelect = true;
            this.listBoxGroup.GridLines = true;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            this.listBoxGroup.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.listBoxGroup.Location = new System.Drawing.Point(12, 51);
            this.listBoxGroup.Name = "listBoxGroup";
            this.listBoxGroup.Size = new System.Drawing.Size(403, 447);
            this.listBoxGroup.TabIndex = 49;
            this.listBoxGroup.UseCompatibleStateImageBehavior = false;
            this.listBoxGroup.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nhóm";
            this.columnHeader1.Width = 299;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Trạng Thái";
            this.columnHeader2.Width = 98;
            // 
            // txtSearchGroup
            // 
            this.txtSearchGroup.Location = new System.Drawing.Point(13, 8);
            this.txtSearchGroup.Name = "txtSearchGroup";
            this.txtSearchGroup.Size = new System.Drawing.Size(214, 20);
            this.txtSearchGroup.TabIndex = 50;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(239, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 23);
            this.btnSearch.TabIndex = 51;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtFriendLink
            // 
            this.txtFriendLink.Location = new System.Drawing.Point(245, 63);
            this.txtFriendLink.Name = "txtFriendLink";
            this.txtFriendLink.Size = new System.Drawing.Size(257, 20);
            this.txtFriendLink.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(115, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Link bạn bè muốn mời:";
            // 
            // ucAutoInviGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchGroup);
            this.Controls.Add(this.listBoxGroup);
            this.Controls.Add(this.cbSelectAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbDsNhom);
            this.Controls.Add(this.groupBox2);
            this.Name = "ucAutoInviGroup";
            this.Size = new System.Drawing.Size(996, 508);
            this.Load += new System.EventHandler(this.ucAutoJoinGroup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeDelay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown txtTimeDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDsNhom;
        private System.Windows.Forms.Timer timerstep;
        private System.Windows.Forms.Timer per;
        private System.Windows.Forms.ProgressBar progressBarStatus;
        private System.Windows.Forms.Label lbStatus;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinnerOnePost;
        private System.Windows.Forms.Label lbTotalProcessed;
        private System.Windows.Forms.Button btnStopPost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.ListView listBoxGroup;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtSearchGroup;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown txtLimit;
        private System.Windows.Forms.NumericUpDown txtOffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser wbPostGroup;
        private System.Windows.Forms.TextBox txtFriendLink;
        private System.Windows.Forms.Label label3;
    }
}