namespace ServicesWMI
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
            this.btnGetServices = new System.Windows.Forms.Button();
            this.txtServices = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGetServices
            // 
            this.btnGetServices.Location = new System.Drawing.Point(23, 12);
            this.btnGetServices.Name = "btnGetServices";
            this.btnGetServices.Size = new System.Drawing.Size(344, 55);
            this.btnGetServices.TabIndex = 0;
            this.btnGetServices.Text = "Get Services Status";
            this.btnGetServices.UseVisualStyleBackColor = true;
            this.btnGetServices.Click += new System.EventHandler(this.btnGetServices_Click);
            // 
            // txtServices
            // 
            this.txtServices.Location = new System.Drawing.Point(23, 73);
            this.txtServices.Name = "txtServices";
            this.txtServices.Size = new System.Drawing.Size(344, 268);
            this.txtServices.TabIndex = 1;
            this.txtServices.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 351);
            this.Controls.Add(this.txtServices);
            this.Controls.Add(this.btnGetServices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetServices;
        private System.Windows.Forms.RichTextBox txtServices;
    }
}

