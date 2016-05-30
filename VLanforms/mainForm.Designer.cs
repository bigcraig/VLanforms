namespace VLanforms
{
    partial class mainForm
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
            this.NF5 = new System.Windows.Forms.Button();
            this.TWBroadcom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NF5
            // 
            this.NF5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NF5.Location = new System.Drawing.Point(67, 153);
            this.NF5.Name = "NF5";
            this.NF5.Size = new System.Drawing.Size(148, 85);
            this.NF5.TabIndex = 1;
            this.NF5.Text = "NF5";
            this.NF5.UseVisualStyleBackColor = true;
            this.NF5.Click += new System.EventHandler(this.NF5_Click_1);
            // 
            // TWBroadcom
            // 
            this.TWBroadcom.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TWBroadcom.Location = new System.Drawing.Point(67, 47);
            this.TWBroadcom.Name = "TWBroadcom";
            this.TWBroadcom.Size = new System.Drawing.Size(148, 85);
            this.TWBroadcom.TabIndex = 2;
            this.TWBroadcom.Text = "T&W NF4,10";
            this.TWBroadcom.UseVisualStyleBackColor = true;
            this.TWBroadcom.Click += new System.EventHandler(this.TWBroadcom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vlan 100 PPPoE and ACS utility";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TWBroadcom);
            this.Controls.Add(this.NF5);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NF5;
        private System.Windows.Forms.Button TWBroadcom;
        private System.Windows.Forms.Label label1;
    }
}