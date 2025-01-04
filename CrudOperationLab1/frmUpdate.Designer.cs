namespace CrudOperationLab1
{
    partial class frmUpdate
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
            label1 = new Label();
            comboStudents = new ComboBox();
            lblResult = new Label();
            txtAge = new TextBox();
            txtAddress = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            txtId = new TextBox();
            btnUpdate = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 93);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 4;
            label1.Text = "Students";
            // 
            // comboStudents
            // 
            comboStudents.FormattingEnabled = true;
            comboStudents.Location = new Point(288, 90);
            comboStudents.Name = "comboStudents";
            comboStudents.Size = new Size(175, 28);
            comboStudents.TabIndex = 3;
            comboStudents.SelectedIndexChanged += comboStudents_SelectedIndexChanged;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = Color.ForestGreen;
            lblResult.Location = new Point(507, 475);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 25;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(272, 405);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(250, 27);
            txtAge.TabIndex = 24;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(272, 346);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 23;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(272, 280);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(250, 27);
            txtLname.TabIndex = 22;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(272, 218);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(250, 27);
            txtFname.TabIndex = 21;
            // 
            // txtId
            // 
            txtId.Location = new Point(272, 150);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 20;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = Color.Green;
            btnUpdate.Location = new Point(345, 470);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 408);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 18;
            label6.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 349);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 17;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 283);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 16;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 218);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 15;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 153);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 14;
            label2.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(326, 24);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 13;
            label7.Text = "Update Studet";
            // 
            // frmUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 551);
            Controls.Add(lblResult);
            Controls.Add(txtAge);
            Controls.Add(txtAddress);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(txtId);
            Controls.Add(btnUpdate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(comboStudents);
            Name = "frmUpdate";
            Text = "frmUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboStudents;
        private Label lblResult;
        private TextBox txtAge;
        private TextBox txtAddress;
        private TextBox txtLname;
        private TextBox txtFname;
        private TextBox txtId;
        private Button btnUpdate;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
    }
}