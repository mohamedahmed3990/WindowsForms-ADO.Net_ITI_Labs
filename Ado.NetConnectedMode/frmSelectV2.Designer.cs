namespace Ado.NetConnectedMode
{
    partial class frmSelectV2
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
            comboAuthors = new ComboBox();
            gridAuthor = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridAuthor).BeginInit();
            SuspendLayout();
            // 
            // comboAuthors
            // 
            comboAuthors.FormattingEnabled = true;
            comboAuthors.Location = new Point(215, 29);
            comboAuthors.Name = "comboAuthors";
            comboAuthors.Size = new Size(212, 28);
            comboAuthors.TabIndex = 0;
            comboAuthors.SelectedIndexChanged += comboAuthors_SelectedIndexChanged;
            // 
            // gridAuthor
            // 
            gridAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAuthor.Location = new Point(12, 88);
            gridAuthor.Name = "gridAuthor";
            gridAuthor.RowHeadersWidth = 51;
            gridAuthor.Size = new Size(776, 350);
            gridAuthor.TabIndex = 1;
            // 
            // frmSelectV2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridAuthor);
            Controls.Add(comboAuthors);
            Name = "frmSelectV2";
            Text = "frmSelectV2";
            ((System.ComponentModel.ISupportInitialize)gridAuthor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboAuthors;
        private DataGridView gridAuthor;
    }
}