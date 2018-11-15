namespace FilePartitionTool
{
    partial class Form_RuleAdd
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
            this.label_FilenameExtension = new System.Windows.Forms.Label();
            this.label_CustomName = new System.Windows.Forms.Label();
            this.textBox_FileNameExtension = new System.Windows.Forms.TextBox();
            this.textBox_NewName = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_FilenameExtension
            // 
            this.label_FilenameExtension.AutoSize = true;
            this.label_FilenameExtension.Font = new System.Drawing.Font("新細明體", 16F);
            this.label_FilenameExtension.Location = new System.Drawing.Point(12, 9);
            this.label_FilenameExtension.Name = "label_FilenameExtension";
            this.label_FilenameExtension.Size = new System.Drawing.Size(168, 22);
            this.label_FilenameExtension.TabIndex = 0;
            this.label_FilenameExtension.Text = "FilenameExtension";
            // 
            // label_CustomName
            // 
            this.label_CustomName.AutoSize = true;
            this.label_CustomName.Font = new System.Drawing.Font("新細明體", 16F);
            this.label_CustomName.Location = new System.Drawing.Point(186, 9);
            this.label_CustomName.Name = "label_CustomName";
            this.label_CustomName.Size = new System.Drawing.Size(98, 22);
            this.label_CustomName.TabIndex = 1;
            this.label_CustomName.Text = "NewName";
            // 
            // textBox_FileNameExtension
            // 
            this.textBox_FileNameExtension.Font = new System.Drawing.Font("新細明體", 9F);
            this.textBox_FileNameExtension.Location = new System.Drawing.Point(16, 49);
            this.textBox_FileNameExtension.Name = "textBox_FileNameExtension";
            this.textBox_FileNameExtension.Size = new System.Drawing.Size(100, 22);
            this.textBox_FileNameExtension.TabIndex = 2;
            this.textBox_FileNameExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox_NewName
            // 
            this.textBox_NewName.Location = new System.Drawing.Point(190, 49);
            this.textBox_NewName.Name = "textBox_NewName";
            this.textBox_NewName.Size = new System.Drawing.Size(100, 22);
            this.textBox_NewName.TabIndex = 3;
            this.textBox_NewName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("新細明體", 16F);
            this.button_OK.Location = new System.Drawing.Point(312, 37);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(82, 36);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("新細明體", 16F);
            this.button_Cancel.Location = new System.Drawing.Point(400, 35);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 36);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Form_RuleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 89);
            this.ControlBox = false;
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_NewName);
            this.Controls.Add(this.textBox_FileNameExtension);
            this.Controls.Add(this.label_CustomName);
            this.Controls.Add(this.label_FilenameExtension);
            this.Name = "Form_RuleAdd";
            this.Text = "Form_RuleAdd";
            this.Load += new System.EventHandler(this.Form_RuleAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FilenameExtension;
        private System.Windows.Forms.Label label_CustomName;
        private System.Windows.Forms.TextBox textBox_FileNameExtension;
        private System.Windows.Forms.TextBox textBox_NewName;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
    }
}