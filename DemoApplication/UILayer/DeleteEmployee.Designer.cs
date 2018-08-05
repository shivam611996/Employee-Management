namespace UILayer
{
    partial class DeleteEmployee
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Selection = new System.Windows.Forms.Label();
            this.btnDelEmp = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.Navbtn = new System.Windows.Forms.Button();
            this.lblSearchData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(423, 158);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(420, 117);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(200, 20);
            this.txtEmpId.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(235, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Employee Id :";
            // 
            // Selection
            // 
            this.Selection.AutoSize = true;
            this.Selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selection.Location = new System.Drawing.Point(352, 52);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(122, 20);
            this.Selection.TabIndex = 25;
            this.Selection.Text = "Deletion Form";
            // 
            // btnDelEmp
            // 
            this.btnDelEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelEmp.Location = new System.Drawing.Point(301, 225);
            this.btnDelEmp.Name = "btnDelEmp";
            this.btnDelEmp.Size = new System.Drawing.Size(179, 35);
            this.btnDelEmp.TabIndex = 30;
            this.btnDelEmp.Text = "Delete Employee Record";
            this.btnDelEmp.UseVisualStyleBackColor = true;
            this.btnDelEmp.Click += new System.EventHandler(this.btnDelEmp_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearch.Location = new System.Drawing.Point(235, 196);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(0, 17);
            this.lblSearch.TabIndex = 31;
            // 
            // Navbtn
            // 
            this.Navbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Navbtn.Location = new System.Drawing.Point(301, 288);
            this.Navbtn.Name = "Navbtn";
            this.Navbtn.Size = new System.Drawing.Size(179, 35);
            this.Navbtn.TabIndex = 32;
            this.Navbtn.Text = "Go to navigation page";
            this.Navbtn.UseVisualStyleBackColor = true;
            this.Navbtn.Click += new System.EventHandler(this.Navbtn_Click);
            // 
            // lblSearchData
            // 
            this.lblSearchData.AutoSize = true;
            this.lblSearchData.Location = new System.Drawing.Point(301, 196);
            this.lblSearchData.Name = "lblSearchData";
            this.lblSearchData.Size = new System.Drawing.Size(0, 13);
            this.lblSearchData.TabIndex = 33;
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 569);
            this.Controls.Add(this.lblSearchData);
            this.Controls.Add(this.Navbtn);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnDelEmp);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Selection);
            this.Name = "DeleteEmployee";
            this.Text = "DeleteEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Selection;
        private System.Windows.Forms.Button btnDelEmp;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button Navbtn;
        private System.Windows.Forms.Label lblSearchData;
    }
}