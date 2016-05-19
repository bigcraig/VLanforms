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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // configureModem
            // 
            this.configureModem.BackColor = System.Drawing.SystemColors.Highlight;
            this.configureModem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configureModem.Location = new System.Drawing.Point(43, 302);
            this.configureModem.Name = "configureModem";
            this.configureModem.Size = new System.Drawing.Size(199, 129);
            this.configureModem.TabIndex = 0;
            this.configureModem.Text = "Please Wait till modem online before configuring";
            this.configureModem.UseVisualStyleBackColor = false;
            this.configureModem.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernameControl
            // 
            this.usernameControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameControl.Location = new System.Drawing.Point(43, 147);
            this.usernameControl.Name = "usernameControl";
            this.usernameControl.Size = new System.Drawing.Size(199, 29);
            this.usernameControl.TabIndex = 1;
            this.usernameControl.Text = "username@domain";
            this.usernameControl.TextChanged += new System.EventHandler(this.usernameControl_TextChanged);
            // 
            // passwordControl
            // 
            this.passwordControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordControl.Location = new System.Drawing.Point(43, 242);
            this.passwordControl.Name = "passwordControl";
            this.passwordControl.Size = new System.Drawing.Size(199, 29);
            this.passwordControl.TabIndex = 2;
            this.passwordControl.Text = "Password";
            this.passwordControl.TextChanged += new System.EventHandler(this.passwordControl_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 80);
            this.label1.TabIndex = 3;
            this.label1.Text = "This utility will configure VDSL\r\n with VLAN 100 and configure\r\nACS settings for " +
    "NF4v,NF10W(V)\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "PPP Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "PPP password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

