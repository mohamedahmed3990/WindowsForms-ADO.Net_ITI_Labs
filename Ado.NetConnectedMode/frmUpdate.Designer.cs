﻿namespace Ado.NetConnectedMode
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
            lblResult = new Label();
            btnUpdate = new Button();
            txtAddress = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboAuthors = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(645, 403);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 19;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(406, 399);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(289, 319);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(233, 27);
            txtAddress.TabIndex = 17;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(289, 248);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(233, 27);
            txtLname.TabIndex = 16;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(289, 173);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(233, 27);
            txtFname.TabIndex = 15;
            // 
            // txtId
            // 
            txtId.Location = new Point(289, 109);
            txtId.Name = "txtId";
            txtId.Size = new Size(233, 27);
            txtId.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 326);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 13;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 251);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 12;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 180);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 11;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 112);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 10;
            label1.Text = "ID";
            // 
            // comboAuthors
            // 
            comboAuthors.FormattingEnabled = true;
            comboAuthors.Location = new Point(183, 38);
            comboAuthors.Name = "comboAuthors";
            comboAuthors.Size = new Size(212, 28);
            comboAuthors.TabIndex = 20;
            comboAuthors.SelectedIndexChanged += comboAuthors_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 41);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 21;
            label5.Text = "Authors";
            // 
            // frmUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(comboAuthors);
            Controls.Add(lblResult);
            Controls.Add(btnUpdate);
            Controls.Add(txtAddress);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUpdate";
            Text = "frmUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private Button btnUpdate;
        private TextBox txtAddress;
        private TextBox txtLname;
        private TextBox txtFname;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboAuthors;
        private Label label5;
    }
}