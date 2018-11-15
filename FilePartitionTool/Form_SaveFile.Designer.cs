namespace FilePartitionTool
{
    partial class Form_SaveFile
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
            this.button_OK = new System.Windows.Forms.Button();
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("新細明體", 16F);
            this.button_OK.Location = new System.Drawing.Point(188, 37);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 32);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.Font = new System.Drawing.Font("新細明體", 16F);
            this.textBox_FileName.Location = new System.Drawing.Point(71, 37);
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.Size = new System.Drawing.Size(111, 33);
            this.textBox_FileName.TabIndex = 1;
            this.textBox_FileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_FileName_KeyPress);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("新細明體", 16F);
            this.label_Name.Location = new System.Drawing.Point(6, 43);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(59, 22);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Name";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("新細明體", 16F);
            this.button_Cancel.Location = new System.Drawing.Point(269, 37);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(101, 33);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Form_SaveFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 111);
            this.ControlBox = false;
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_FileName);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Name = "Form_SaveFile";
            this.Text = "Form_SaveFile";
            this.Load += new System.EventHandler(this.Form_SaveFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_FileName;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_Cancel;
    }
}