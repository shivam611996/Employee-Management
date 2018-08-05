namespace UILayer
{
    partial class SaveEmployee
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
            this.Registration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbbxEmpt = new System.Windows.Forms.ComboBox();
            this.Navbtn = new System.Windows.Forms.Button();
            this.lblSavedchanges = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration.Location = new System.Drawing.Point(347, 43);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(236, 20);
            this.Registration.TabIndex = 0;
            this.Registration.Text = "Employee Registration Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(274, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(274, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(274, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee Type :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(439, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(376, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Employee";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbbxEmpt
            // 
            this.cmbbxEmpt.FormattingEnabled = true;
            this.cmbbxEmpt.Items.AddRange(new object[] {
            "Permenent",
            "Contract"});
            this.cmbbxEmpt.Location = new System.Drawing.Point(439, 183);
            this.cmbbxEmpt.Name = "cmbbxEmpt";
            this.cmbbxEmpt.Size = new System.Drawing.Size(200, 21);
            this.cmbbxEmpt.TabIndex = 8;
            // 
            // Navbtn
            // 
            this.Navbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Navbtn.Location = new System.Drawing.Point(376, 326);
            this.Navbtn.Name = "Navbtn";
            this.Navbtn.Size = new System.Drawing.Size(179, 35);
            this.Navbtn.TabIndex = 32;
            this.Navbtn.Text = "Go to navigation page";
            this.Navbtn.UseVisualStyleBackColor = true;
            this.Navbtn.Click += new System.EventHandler(this.Navbtn_Click);
            // 
            // lblSavedchanges
            // 
            this.lblSavedchanges.AutoSize = true;
            this.lblSavedchanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSavedchanges.Location = new System.Drawing.Point(274, 239);
            this.lblSavedchanges.Name = "lblSavedchanges";
            this.lblSavedchanges.Size = new System.Drawing.Size(0, 17);
            this.lblSavedchanges.TabIndex = 33;
            // 
            // SaveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 874);
            this.Controls.Add(this.lblSavedchanges);
            this.Controls.Add(this.Navbtn);
            this.Controls.Add(this.cmbbxEmpt);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registration);
            this.Name = "SaveEmployee";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbbxEmpt;
        private System.Windows.Forms.Button Navbtn;
        private System.Windows.Forms.Label lblSavedchanges;
    }
}

