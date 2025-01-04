namespace CrudOperationLab1
{
    partial class frmInsert
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnInsert = new Button();
            txtId = new TextBox();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtAddress = new TextBox();
            txtAge = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 39);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "ADD New Studet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 110);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 175);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 240);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 306);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(141, 365);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 5;
            label6.Text = "Age";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(324, 427);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(251, 107);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 7;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(251, 172);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(250, 27);
            txtFname.TabIndex = 8;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(251, 237);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(250, 27);
            txtLname.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(251, 303);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 10;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(251, 362);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(250, 27);
            txtAge.TabIndex = 11;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = Color.ForestGreen;
            lblResult.Location = new Point(486, 432);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 12;
            // 
            // frmInsert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(lblResult);
            Controls.Add(txtAge);
            Controls.Add(txtAddress);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(txtId);
            Controls.Add(btnInsert);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmInsert";
            Text = "frmInsert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnInsert;
        private TextBox txtId;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtAddress;
        private TextBox txtAge;
        private Label lblResult;
    }
}