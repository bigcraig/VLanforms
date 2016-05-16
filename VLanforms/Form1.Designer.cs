namespace VLanforms
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
            this.configureModem = new System.Windows.Forms.Button();
            this.usernameControl = new System.Windows.Forms.TextBox();
            this.passwordControl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // configureModem
            // 
            this.configureModem.Location = new System.Drawing.Point(85, 340);
            this.configureModem.Name = "configureModem";
            this.configureModem.Size = new System.Drawing.Size(124, 44);
            this.configureModem.TabIndex = 0;
            this.configureModem.UseVisualStyleBackColor = true;
            this.configureModem.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernameControl
            // 
            this.usernameControl.Location = new System.Drawing.Point(43, 131);
            this.usernameControl.Name = "usernameControl";
            this.usernameControl.Size = new System.Drawing.Size(109, 20);
            this.usernameControl.TabIndex = 1;
            this.usernameControl.TextChanged += new System.EventHandler(this.usernameControl_TextChanged);
            // 
            // passwordControl
            // 
            this.passwordControl.Location = new System.Drawing.Point(43, 214);
            this.passwordControl.Name = "passwordControl";
            this.passwordControl.Size = new System.Drawing.Size(109, 20);
            this.passwordControl.TabIndex = 2;
            this.passwordControl.TextChanged += new System.EventHandler(this.passwordControl_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "This utility will configure VDSL with VLAN 100";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordControl);
            this.Controls.Add(this.usernameControl);
            this.Controls.Add(this.configureModem);
            this.Name = "Form1";
            this.Text = "Netcomm Vlan 100";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button configureModem;
        private System.Windows.Forms.TextBox usernameControl;
        private System.Windows.Forms.TextBox passwordControl;
        private System.Windows.Forms.Label label1;
    }
}

