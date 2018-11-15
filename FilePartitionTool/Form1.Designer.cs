namespace FilePartitionTool
{
    partial class Form_Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.label_DirPathList = new System.Windows.Forms.Label();
            this.listBox_DirList = new System.Windows.Forms.ListBox();
            this.label_RuleList = new System.Windows.Forms.Label();
            this.button_AddRule = new System.Windows.Forms.Button();
            this.button_DelRule = new System.Windows.Forms.Button();
            this.listBox_RuleList = new System.Windows.Forms.ListBox();
            this.label_RuleFile = new System.Windows.Forms.Label();
            this.listBox_RuleFile = new System.Windows.Forms.ListBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_DelRuleFile = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_DirPathList
            // 
            this.label_DirPathList.AutoSize = true;
            this.label_DirPathList.Font = new System.Drawing.Font("新細明體", 24F);
            this.label_DirPathList.Location = new System.Drawing.Point(-2, 8);
            this.label_DirPathList.Name = "label_DirPathList";
            this.label_DirPathList.Size = new System.Drawing.Size(175, 32);
            this.label_DirPathList.TabIndex = 1;
            this.label_DirPathList.Text = "DirectoryList";
            // 
            // listBox_DirList
            // 
            this.listBox_DirList.AllowDrop = true;
            this.listBox_DirList.FormattingEnabled = true;
            this.listBox_DirList.HorizontalScrollbar = true;
            this.listBox_DirList.ItemHeight = 12;
            this.listBox_DirList.Location = new System.Drawing.Point(4, 43);
            this.listBox_DirList.Name = "listBox_DirList";
            this.listBox_DirList.Size = new System.Drawing.Size(193, 244);
            this.listBox_DirList.TabIndex = 3;
            this.listBox_DirList.SelectedIndexChanged += new System.EventHandler(this.listBox_DirList_SelectedIndexChanged);
            this.listBox_DirList.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DirList_DragDrop);
            this.listBox_DirList.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DirList_DragEnter);
            // 
            // label_RuleList
            // 
            this.label_RuleList.AutoSize = true;
            this.label_RuleList.Font = new System.Drawing.Font("新細明體", 16F);
            this.label_RuleList.Location = new System.Drawing.Point(230, 17);
            this.label_RuleList.Name = "label_RuleList";
            this.label_RuleList.Size = new System.Drawing.Size(88, 22);
            this.label_RuleList.TabIndex = 4;
            this.label_RuleList.Text = "Rule List";
            // 
            // button_AddRule
            // 
            this.button_AddRule.Font = new System.Drawing.Font("新細明體", 16F);
            this.button_AddRule.Location = new System.Drawing.Point(203, 256);
            this.button_AddRule.Name = "button_AddRule";
            this.button_AddRule.Size = new System.Drawing.Size(75, 31);
            this.button_AddRule.TabIndex = 5;
            this.button_AddRule.Text = "Add";
            this.button_AddRule.UseVisualStyleBackColor = true;
            this.button_AddRule.Click += new System.EventHandler(this.button_AddRule_Click);
            // 
            // button_DelRule
            // 
            this.button_DelRule.Font = new System.Drawing.Font("新細明體", 16F);
            this.button_DelRule.Location = new System.Drawing.Point(284, 256);
            this.button_DelRule.Name = "button_DelRule";
            this.button_DelRule.Size = new System.Drawing.Size(75, 31);
            this.button_DelRule.TabIndex = 5;
            this.button_DelRule.Text = "Del";
            this.button_DelRule.UseVisualStyleBackColor = true;
            this.button_DelRule.Click += new System.EventHandler(this.button_DelRule_Click);
            // 
            // listBox_RuleList
            // 
            this.listBox_RuleList.FormattingEnabled = true;
            this.listBox_RuleList.HorizontalScrollbar = true;
            this.listBox_RuleList.ItemHeight = 12;
            this.listBox_RuleList.Location = new System.Drawing.Point(204, 43);
            this.listBox_RuleList.Name = "listBox_RuleList";
            this.listBox_RuleList.Size = new System.Drawing.Size(155, 196);
            this.listBox_RuleList.TabIndex = 6;
            // 
            // label_RuleFile
            // 
            this.label_RuleFile.AutoSize = true;
            this.label_RuleFile.Font = new System.Drawing.Font("新細明體", 16F);
            this.label_RuleFile.Location = new System.Drawing.Point(405, 17);
            this.label_RuleFile.Name = "label_RuleFile";
            this.label_RuleFile.Size = new System.Drawing.Size(87, 22);
            this.label_RuleFile.TabIndex = 4;
            this.label_RuleFile.Text = "Rule File";
            // 
            // listBox_RuleFile
            // 
            this.listBox_RuleFile.FormattingEnabled = true;
            this.listBox_RuleFile.HorizontalScrollbar = true;
            this.listBox_RuleFile.ItemHeight = 12;
            this.listBox_RuleFile.Location = new System.Drawing.Point(379, 43);
            this.listBox_RuleFile.Name = "listBox_RuleFile";
            this.listBox_RuleFile.Size = new System.Drawing.Size(155, 196);
            this.listBox_RuleFile.TabIndex = 6;
            this.listBox_RuleFile.SelectedIndexChanged += new System.EventHandler(this.listBox_RuleFile_SelectedIndexChanged);
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("新細明體", 24F);
            this.button_Start.Location = new System.Drawing.Point(549, 43);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(112, 81);
            this.button_Start.TabIndex = 7;
            this.button_Start.Text = "Go";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("新細明體", 16F);
            this.button_Save.Location = new System.Drawing.Point(379, 256);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(121, 31);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "SaveRule";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_DelRuleFile
            // 
            this.button_DelRuleFile.Font = new System.Drawing.Font("新細明體", 16F);
            this.button_DelRuleFile.Location = new System.Drawing.Point(506, 256);
            this.button_DelRuleFile.Name = "button_DelRuleFile";
            this.button_DelRuleFile.Size = new System.Drawing.Size(121, 31);
            this.button_DelRuleFile.TabIndex = 5;
            this.button_DelRuleFile.Text = "DeleteRule";
            this.button_DelRuleFile.UseVisualStyleBackColor = true;
            this.button_DelRuleFile.Click += new System.EventHandler(this.button_DelRuleFile_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("新細明體", 16F);
            this.button_Clear.Location = new System.Drawing.Point(549, 176);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(112, 44);
            this.button_Clear.TabIndex = 7;
            this.button_Clear.Text = "Clean Dir";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 301);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.listBox_RuleFile);
            this.Controls.Add(this.listBox_RuleList);
            this.Controls.Add(this.button_DelRuleFile);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_DelRule);
            this.Controls.Add(this.label_RuleFile);
            this.Controls.Add(this.button_AddRule);
            this.Controls.Add(this.label_RuleList);
            this.Controls.Add(this.listBox_DirList);
            this.Controls.Add(this.label_DirPathList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.Text = "FilePartitionTool";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_DirPathList;
        private System.Windows.Forms.ListBox listBox_DirList;
        private System.Windows.Forms.Label label_RuleList;
        private System.Windows.Forms.Button button_AddRule;
        private System.Windows.Forms.Button button_DelRule;
        private System.Windows.Forms.ListBox listBox_RuleList;
        private System.Windows.Forms.Label label_RuleFile;
        private System.Windows.Forms.ListBox listBox_RuleFile;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_DelRuleFile;
        private System.Windows.Forms.Button button_Clear;
    }
}

