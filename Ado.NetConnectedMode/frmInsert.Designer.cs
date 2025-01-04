namespace Ado.NetConnectedMode
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
            txtId = new TextBox();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtAddress = new TextBox();
            btnInsert = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 76);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 144);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 215);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 290);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // txtId
            // 
            txtId.Location = new Point(184, 73);
            txtId.Name = "txtId";
            txtId.Size = new Size(233, 27);
            txtId.TabIndex = 4;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(184, 137);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(233, 27);
            txtFname.TabIndex = 5;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(184, 212);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(233, 27);
            txtLname.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(184, 283);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(233, 27);
            txtAddress.TabIndex = 7;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(301, 363);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(540, 367);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 9;
            // 
            // frmInsert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnInsert);
            Controls.Add(txtAddress);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmInsert";
            Text = "frmInsert";
            Load += frmInsert_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtAddress;
        private Button btnInsert;
        private Label lblResult;
    }
}