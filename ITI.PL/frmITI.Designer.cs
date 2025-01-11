namespace ITI.PL
{
    partial class frmITI
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtAdd = new TextBox();
            txtAge = new TextBox();
            comboStud = new ComboBox();
            btnIns = new Button();
            btnUpdate = new Button();
            btnDel = new Button();
            lblRes = new Label();
            ((System.ComponentModel.ISupportInitialize)gridResult).BeginInit();
            SuspendLayout();
            // 
            // gridResult
            // 
            gridResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridResult.Location = new Point(21, 98);
            gridResult.Name = "gridResult";
            gridResult.RowHeadersWidth = 51;
            gridResult.Size = new Size(702, 459);
            gridResult.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 39);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Students";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(774, 112);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(760, 169);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 3;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(760, 227);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 4;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(760, 291);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 5;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(762, 350);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 6;
            label6.Text = "Age";
            // 
            // txtId
            // 
            txtId.Location = new Point(855, 109);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Unique";
            txtId.Size = new Size(151, 27);
            txtId.TabIndex = 7;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(855, 166);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(151, 27);
            txtFname.TabIndex = 8;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(855, 224);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(151, 27);
            txtLname.TabIndex = 9;
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(855, 288);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(151, 27);
            txtAdd.TabIndex = 10;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(855, 347);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "22 - 40";
            txtAge.Size = new Size(151, 27);
            txtAge.TabIndex = 11;
            // 
            // comboStud
            // 
            comboStud.FormattingEnabled = true;
            comboStud.Location = new Point(296, 36);
            comboStud.Name = "comboStud";
            comboStud.Size = new Size(151, 28);
            comboStud.TabIndex = 12;
            comboStud.SelectedIndexChanged += comboStud_SelectedIndexChanged;
            // 
            // btnIns
            // 
            btnIns.Location = new Point(793, 409);
            btnIns.Name = "btnIns";
            btnIns.Size = new Size(197, 47);
            btnIns.TabIndex = 13;
            btnIns.Text = "Insert";
            btnIns.UseVisualStyleBackColor = true;
            btnIns.Click += btnIns_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(793, 462);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(197, 45);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(793, 513);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(197, 44);
            btnDel.TabIndex = 15;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(855, 39);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 20);
            lblRes.TabIndex = 16;
            // 
            // frmITI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 594);
            Controls.Add(lblRes);
            Controls.Add(btnDel);
            Controls.Add(btnUpdate);
            Controls.Add(btnIns);
            Controls.Add(comboStud);
            Controls.Add(txtAge);
            Controls.Add(txtAdd);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridResult);
            Name = "frmITI";
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
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtAdd;
        private TextBox txtAge;
        private ComboBox comboStud;
        private Button btnIns;
        private Button btnUpdate;
        private Button btnDel;
        private Label lblRes;
    }
}
