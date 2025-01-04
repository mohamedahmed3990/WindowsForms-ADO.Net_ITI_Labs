namespace CrudOperationLab1
{
    partial class frmDelete
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
            lblResult = new Label();
            txtAge = new TextBox();
            txtAddress = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            txtId = new TextBox();
            btnDelete = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label1 = new Label();
            comboStudents = new ComboBox();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = Color.OrangeRed;
            lblResult.Location = new Point(526, 486);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 40;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(291, 416);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(250, 27);
            txtAge.TabIndex = 39;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(291, 357);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 38;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(291, 291);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(250, 27);
            txtLname.TabIndex = 37;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(291, 229);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(250, 27);
            txtFname.TabIndex = 36;
            // 
            // txtId
            // 
            txtId.Location = new Point(291, 161);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 35;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(364, 481);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(181, 419);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 33;
            label6.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 360);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 32;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 294);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 31;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 229);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 30;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 164);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 29;
            label2.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.OrangeRed;
            label7.Location = new Point(345, 35);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 28;
            label7.Text = "Delete Student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 104);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 27;
            label1.Text = "Students";
            // 
            // comboStudents
            // 
            comboStudents.FormattingEnabled = true;
            comboStudents.Location = new Point(307, 101);
            comboStudents.Name = "comboStudents";
            comboStudents.Size = new Size(175, 28);
            comboStudents.TabIndex = 26;
            comboStudents.SelectedIndexChanged += comboStudents_SelectedIndexChanged;
            // 
            // frmDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(lblResult);
            Controls.Add(txtAge);
            Controls.Add(txtAddress);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(txtId);
            Controls.Add(btnDelete);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(comboStudents);
            Name = "frmDelete";
            Text = "frmDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private TextBox txtAge;
        private TextBox txtAddress;
        private TextBox txtLname;
        private TextBox txtFname;
        private TextBox txtId;
        private Button btnDelete;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label1;
        private ComboBox comboStudents;
    }
}