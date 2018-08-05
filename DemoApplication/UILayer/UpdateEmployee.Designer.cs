namespace UILayer
{
    partial class UpdateEmployee
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
            this.Selection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbUpdbx = new System.Windows.Forms.ComboBox();
            this.btnUpdEmp = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Navbtn = new System.Windows.Forms.Button();
            this.lblupdatesearch = new System.Windows.Forms.Label();
            this.lblUpdStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Selection
            // 
            this.Selection.AutoSize = true;
            this.Selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selection.Location = new System.Drawing.Point(393, 36);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(128, 20);
            this.Selection.TabIndex = 13;
            this.Selection.Text = "Updation Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(276, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Employee Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(276, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Department :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(276, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Employee Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(276, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Employee Id :";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(461, 101);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(200, 20);
            this.txtEmpId.TabIndex = 19;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(461, 181);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(200, 20);
            this.txtDept.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(461, 141);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 21;
            // 
            // cmbUpdbx
            // 
            this.cmbUpdbx.FormattingEnabled = true;
            this.cmbUpdbx.Items.AddRange(new object[] {
            "Permenent",
            "Contract"});
            this.cmbUpdbx.Location = new System.Drawing.Point(461, 221);
            this.cmbUpdbx.Name = "cmbUpdbx";
            this.cmbUpdbx.Size = new System.Drawing.Size(200, 21);
            this.cmbUpdbx.TabIndex = 22;
            // 
            // btnUpdEmp
            // 
            this.btnUpdEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdEmp.Location = new System.Drawing.Point(384, 282);
            this.btnUpdEmp.Name = "btnUpdEmp";
            this.btnUpdEmp.Size = new System.Drawing.Size(179, 35);
            this.btnUpdEmp.TabIndex = 23;
            this.btnUpdEmp.Text = "Update Employee Record";
            this.btnUpdEmp.UseVisualStyleBackColor = true;
            this.btnUpdEmp.Click += new System.EventHandler(this.btnUpdEmp_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(719, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Navbtn
            // 
            this.Navbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Navbtn.Location = new System.Drawing.Point(384, 337);
            this.Navbtn.Name = "Navbtn";
            this.Navbtn.Size = new System.Drawing.Size(179, 35);
            this.Navbtn.TabIndex = 32;
            this.Navbtn.Text = "Go to navigation page";
            this.Navbtn.UseVisualStyleBackColor = true;
            this.Navbtn.Click += new System.EventHandler(this.Navbtn_Click);
            // 
            // lblupdatesearch
            // 
            this.lblupdatesearch.AutoSize = true;
            this.lblupdatesearch.Location = new System.Drawing.Point(279, 254);
            this.lblupdatesearch.Name = "lblupdatesearch";
            this.lblupdatesearch.Size = new System.Drawing.Size(0, 13);
            this.lblupdatesearch.TabIndex = 33;
            // 
            // lblUpdStatus
            // 
            this.lblUpdStatus.AutoSize = true;
            this.lblUpdStatus.Location = new System.Drawing.Point(279, 253);
            this.lblUpdStatus.Name = "lblUpdStatus";
            this.lblUpdStatus.Size = new System.Drawing.Size(0, 13);
            this.lblUpdStatus.TabIndex = 34;
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 594);
            this.Controls.Add(this.lblUpdStatus);
            this.Controls.Add(this.lblupdatesearch);
            this.Controls.Add(this.Navbtn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdEmp);
            this.Controls.Add(this.cmbUpdbx);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Selection);
            this.Name = "UpdateEmployee";
            this.Text = "UpdateEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Selection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbUpdbx;
        private System.Windows.Forms.Button btnUpdEmp;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button Navbtn;
        private System.Windows.Forms.Label lblupdatesearch;
        private System.Windows.Forms.Label lblUpdStatus;
    }
}