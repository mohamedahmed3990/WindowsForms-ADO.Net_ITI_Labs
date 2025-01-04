namespace CrudOperationLab1
{
    partial class frmSelect
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
            gridView = new DataGridView();
            comboStudents = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // gridView
            // 
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Location = new Point(12, 92);
            gridView.Name = "gridView";
            gridView.RowHeadersWidth = 51;
            gridView.Size = new Size(776, 346);
            gridView.TabIndex = 0;
            // 
            // comboStudents
            // 
            comboStudents.FormattingEnabled = true;
            comboStudents.Location = new Point(305, 25);
            comboStudents.Name = "comboStudents";
            comboStudents.Size = new Size(220, 28);
            comboStudents.TabIndex = 1;
            comboStudents.SelectedIndexChanged += comboStudents_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 28);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 2;
            label1.Text = "Students";
            // 
            // frmSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(comboStudents);
            Controls.Add(gridView);
            Name = "frmSelect";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridView;
        private ComboBox comboStudents;
        private Label label1;
    }
}
