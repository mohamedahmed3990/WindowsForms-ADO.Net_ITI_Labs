namespace AdoDotNetDisConnectedLab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridResult = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAddress = new Label();
            txtId = new TextBox();
            txtFname = new TextBox();
            txtlname = new TextBox();
            textBox4 = new TextBox();
            btnUpdate = new Button();
            btnInsert = new Button();
            btnDelete = new Button();
            btnSync = new Button();
            ((System.ComponentModel.ISupportInitialize)gridResult).BeginInit();
            SuspendLayout();
            // 
            // gridResult
            // 
            gridResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridResult.Location = new Point(12, 25);
            gridResult.Name = "gridResult";
            gridResult.RowHeadersWidth = 51;
            gridResult.Size = new Size(684, 413);
            gridResult.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(756, 49);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(756, 112);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(756, 175);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // txtAddress
            // 
            txtAddress.AutoSize = true;
            txtAddress.Location = new Point(756, 241);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(62, 20);
            txtAddress.TabIndex = 4;
            txtAddress.Text = "Address";
            // 
            // txtId
            // 
            txtId.Location = new Point(853, 46);
            txtId.Name = "txtId";
            txtId.Size = new Size(168, 27);
            txtId.TabIndex = 5;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(853, 105);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(168, 27);
            txtFname.TabIndex = 6;
            // 
            // txtlname
            // 
            txtlname.Location = new Point(853, 168);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(168, 27);
            txtlname.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(853, 234);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(168, 27);
            textBox4.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(840, 319);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(724, 319);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(955, 319);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSync
            // 
            btnSync.Location = new Point(840, 378);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(94, 29);
            btnSync.TabIndex = 12;
            btnSync.Text = "Sync";
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += btnSync_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 450);
            Controls.Add(btnSync);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(btnUpdate);
            Controls.Add(textBox4);
            Controls.Add(txtlname);
            Controls.Add(txtFname);
            Controls.Add(txtId);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridResult);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label txtAddress;
        private TextBox txtId;
        private TextBox txtFname;
        private TextBox txtlname;
        private TextBox textBox4;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnSync;
    }
}
