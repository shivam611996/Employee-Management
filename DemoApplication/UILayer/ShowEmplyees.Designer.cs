namespace UILayer
{
    partial class ShowEmplyees
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
            this.grdDataShow = new System.Windows.Forms.DataGridView();
            this.Navbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataShow)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDataShow
            // 
            this.grdDataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataShow.Location = new System.Drawing.Point(24, 12);
            this.grdDataShow.Name = "grdDataShow";
            this.grdDataShow.Size = new System.Drawing.Size(644, 456);
            this.grdDataShow.TabIndex = 0;
            // 
            // Navbtn
            // 
            this.Navbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Navbtn.Location = new System.Drawing.Point(248, 490);
            this.Navbtn.Name = "Navbtn";
            this.Navbtn.Size = new System.Drawing.Size(179, 35);
            this.Navbtn.TabIndex = 31;
            this.Navbtn.Text = "Go to navigation page";
            this.Navbtn.UseVisualStyleBackColor = true;
            this.Navbtn.Click += new System.EventHandler(this.Navbtn_Click);
            // 
            // ShowEmplyees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 555);
            this.Controls.Add(this.Navbtn);
            this.Controls.Add(this.grdDataShow);
            this.Name = "ShowEmplyees";
            this.Text = "ShowEmplyees";
            this.Load += new System.EventHandler(this.ShowEmplyees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDataShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDataShow;
        private System.Windows.Forms.Button Navbtn;
    }
}