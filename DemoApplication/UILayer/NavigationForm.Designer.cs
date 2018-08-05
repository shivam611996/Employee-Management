namespace UILayer
{
    partial class NavigationForm
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
            this.btnShowEmp = new System.Windows.Forms.Button();
            this.btnDelEmp = new System.Windows.Forms.Button();
            this.btnUpdEmp = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.Selection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowEmp
            // 
            this.btnShowEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShowEmp.Location = new System.Drawing.Point(363, 320);
            this.btnShowEmp.Name = "btnShowEmp";
            this.btnShowEmp.Size = new System.Drawing.Size(179, 35);
            this.btnShowEmp.TabIndex = 8;
            this.btnShowEmp.Text = "Show Employee Record";
            this.btnShowEmp.UseVisualStyleBackColor = true;
            this.btnShowEmp.Click += new System.EventHandler(this.btnShowEmp_Click);
            // 
            // btnDelEmp
            // 
            this.btnDelEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelEmp.Location = new System.Drawing.Point(363, 263);
            this.btnDelEmp.Name = "btnDelEmp";
            this.btnDelEmp.Size = new System.Drawing.Size(179, 35);
            this.btnDelEmp.TabIndex = 9;
            this.btnDelEmp.Text = "Delete Employee Record";
            this.btnDelEmp.UseVisualStyleBackColor = true;
            this.btnDelEmp.Click += new System.EventHandler(this.btnDelEmp_Click);
            // 
            // btnUpdEmp
            // 
            this.btnUpdEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdEmp.Location = new System.Drawing.Point(363, 204);
            this.btnUpdEmp.Name = "btnUpdEmp";
            this.btnUpdEmp.Size = new System.Drawing.Size(179, 35);
            this.btnUpdEmp.TabIndex = 10;
            this.btnUpdEmp.Text = "Update Employee Record";
            this.btnUpdEmp.UseVisualStyleBackColor = true;
            this.btnUpdEmp.Click += new System.EventHandler(this.btnUpdEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddEmp.Location = new System.Drawing.Point(363, 148);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(179, 35);
            this.btnAddEmp.TabIndex = 11;
            this.btnAddEmp.Text = "Add Employee Record";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // Selection
            // 
            this.Selection.AutoSize = true;
            this.Selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selection.Location = new System.Drawing.Point(159, 79);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(159, 20);
            this.Selection.TabIndex = 12;
            this.Selection.Text = "Select what to do :";
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 642);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.btnUpdEmp);
            this.Controls.Add(this.btnDelEmp);
            this.Controls.Add(this.btnShowEmp);
            this.Name = "NavigationForm";
            this.Text = "NavigationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowEmp;
        private System.Windows.Forms.Button btnDelEmp;
        private System.Windows.Forms.Button btnUpdEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Label Selection;
    }
}