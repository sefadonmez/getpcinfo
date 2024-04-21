namespace getpcinfo
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
            this.listBoxInfoList = new System.Windows.Forms.ListBox();
            this.buttonTXTexport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxInfoList
            // 
            this.listBoxInfoList.FormattingEnabled = true;
            this.listBoxInfoList.Location = new System.Drawing.Point(12, 12);
            this.listBoxInfoList.Name = "listBoxInfoList";
            this.listBoxInfoList.Size = new System.Drawing.Size(359, 420);
            this.listBoxInfoList.TabIndex = 0;
            // 
            // buttonTXTexport
            // 
            this.buttonTXTexport.Location = new System.Drawing.Point(283, 438);
            this.buttonTXTexport.Name = "buttonTXTexport";
            this.buttonTXTexport.Size = new System.Drawing.Size(88, 23);
            this.buttonTXTexport.TabIndex = 1;
            this.buttonTXTexport.Text = "Save To .txt";
            this.buttonTXTexport.UseVisualStyleBackColor = true;
            this.buttonTXTexport.Click += new System.EventHandler(this.buttonTXTexport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 464);
            this.Controls.Add(this.buttonTXTexport);
            this.Controls.Add(this.listBoxInfoList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Pc Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxInfoList;
        private System.Windows.Forms.Button buttonTXTexport;
    }
}

