namespace MD5_Encryptor_GUI
{
    partial class UI
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
            this.OutputField = new System.Windows.Forms.TextBox();
            this.Encrypt_Button = new System.Windows.Forms.Button();
            this.Decrypt_Button = new System.Windows.Forms.Button();
            this.InputField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CopyToClipboard_Button = new System.Windows.Forms.Button();
            this.CopiedToClipboard_Label = new System.Windows.Forms.Label();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputField
            // 
            this.OutputField.Enabled = false;
            this.OutputField.Location = new System.Drawing.Point(181, 63);
            this.OutputField.MaxLength = 34;
            this.OutputField.Name = "OutputField";
            this.OutputField.Size = new System.Drawing.Size(375, 20);
            this.OutputField.TabIndex = 0;
            this.OutputField.TextChanged += new System.EventHandler(this.InputField_TextChanged);
            // 
            // Encrypt_Button
            // 
            this.Encrypt_Button.Location = new System.Drawing.Point(181, 124);
            this.Encrypt_Button.Name = "Encrypt_Button";
            this.Encrypt_Button.Size = new System.Drawing.Size(375, 82);
            this.Encrypt_Button.TabIndex = 1;
            this.Encrypt_Button.Text = "Encrypt\r\n";
            this.Encrypt_Button.UseVisualStyleBackColor = true;
            this.Encrypt_Button.Click += new System.EventHandler(this.Encrypt_Button_Click);
            // 
            // Decrypt_Button
            // 
            this.Decrypt_Button.Location = new System.Drawing.Point(181, 259);
            this.Decrypt_Button.Name = "Decrypt_Button";
            this.Decrypt_Button.Size = new System.Drawing.Size(375, 80);
            this.Decrypt_Button.TabIndex = 2;
            this.Decrypt_Button.Text = "Decrypt";
            this.Decrypt_Button.UseVisualStyleBackColor = true;
            this.Decrypt_Button.Click += new System.EventHandler(this.Decrypt_Button_Click);
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(181, 389);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(375, 20);
            this.InputField.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input:";
            // 
            // CopyToClipboard_Button
            // 
            this.CopyToClipboard_Button.Location = new System.Drawing.Point(12, 60);
            this.CopyToClipboard_Button.Name = "CopyToClipboard_Button";
            this.CopyToClipboard_Button.Size = new System.Drawing.Size(140, 23);
            this.CopyToClipboard_Button.TabIndex = 6;
            this.CopyToClipboard_Button.Text = "Copy To Clipboard";
            this.CopyToClipboard_Button.UseVisualStyleBackColor = true;
            this.CopyToClipboard_Button.Click += new System.EventHandler(this.CopyToClipboard_Button_Click);
            // 
            // CopiedToClipboard_Label
            // 
            this.CopiedToClipboard_Label.AutoSize = true;
            this.CopiedToClipboard_Label.Location = new System.Drawing.Point(31, 106);
            this.CopiedToClipboard_Label.Name = "CopiedToClipboard_Label";
            this.CopiedToClipboard_Label.Size = new System.Drawing.Size(106, 13);
            this.CopiedToClipboard_Label.TabIndex = 7;
            this.CopiedToClipboard_Label.Text = "Copied To Clipboard!";
            this.CopiedToClipboard_Label.Visible = false;
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(562, 60);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(75, 23);
            this.Clear_Button.TabIndex = 8;
            this.Clear_Button.Text = "Clear Text";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.CopiedToClipboard_Label);
            this.Controls.Add(this.CopyToClipboard_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputField);
            this.Controls.Add(this.Decrypt_Button);
            this.Controls.Add(this.Encrypt_Button);
            this.Controls.Add(this.OutputField);
            this.Name = "UI";
            this.Text = "MD5 Encryptor/Decryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputField;
        private System.Windows.Forms.Button Encrypt_Button;
        private System.Windows.Forms.Button Decrypt_Button;
        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CopyToClipboard_Button;
        private System.Windows.Forms.Label CopiedToClipboard_Label;
        private System.Windows.Forms.Button Clear_Button;
    }
}

