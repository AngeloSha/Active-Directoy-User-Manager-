namespace ActiveDirectoryManager
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTimeTacInstructions = new System.Windows.Forms.Label();
            this.txtTimeTacInput = new System.Windows.Forms.TextBox();
            this.btnCreateTimeTac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTimeTacInstructions
            // 
            this.lblTimeTacInstructions.AutoSize = true;
            this.lblTimeTacInstructions.Location = new System.Drawing.Point(13, 13);
            this.lblTimeTacInstructions.Name = "lblTimeTacInstructions";
            this.lblTimeTacInstructions.Size = new System.Drawing.Size(133, 13);
            this.lblTimeTacInstructions.TabIndex = 0;
            this.lblTimeTacInstructions.Text = "Enter TimeTac Information:";
            // 
            // txtTimeTacInput
            // 
            this.txtTimeTacInput.Location = new System.Drawing.Point(16, 30);
            this.txtTimeTacInput.Name = "txtTimeTacInput";
            this.txtTimeTacInput.Size = new System.Drawing.Size(256, 20);
            this.txtTimeTacInput.TabIndex = 1;
            // 
            // btnCreateTimeTac
            // 
            this.btnCreateTimeTac.Location = new System.Drawing.Point(197, 56);
            this.btnCreateTimeTac.Name = "btnCreateTimeTac";
            this.btnCreateTimeTac.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTimeTac.TabIndex = 2;
            this.btnCreateTimeTac.Text = "Create";
            this.btnCreateTimeTac.UseVisualStyleBackColor = true;
            this.btnCreateTimeTac.Click += new System.EventHandler(this.btnCreateTimeTac_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(284, 91);
            this.Controls.Add(this.btnCreateTimeTac);
            this.Controls.Add(this.txtTimeTacInput);
            this.Controls.Add(this.lblTimeTacInstructions);
            this.Name = "Form2";
            this.Text = "TimeTac Creation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTimeTacInstructions;
        private System.Windows.Forms.TextBox txtTimeTacInput;
        private System.Windows.Forms.Button btnCreateTimeTac;
    }
}