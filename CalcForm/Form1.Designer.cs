namespace CalcForm
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
            btnOperPlus = new Button();
            btnOperMin = new Button();
            btnEquals = new Button();
            btnNumTwo = new Button();
            btnNumOne = new Button();
            txtScreenResult = new TextBox();
            SuspendLayout();
            // 
            // btnOperPlus
            // 
            btnOperPlus.BackColor = Color.White;
            btnOperPlus.Location = new Point(69, 274);
            btnOperPlus.Name = "btnOperPlus";
            btnOperPlus.Size = new Size(94, 29);
            btnOperPlus.TabIndex = 2;
            btnOperPlus.Text = "+";
            btnOperPlus.UseVisualStyleBackColor = false;
            // 
            // btnOperMin
            // 
            btnOperMin.BackColor = Color.White;
            btnOperMin.Location = new Point(250, 274);
            btnOperMin.Name = "btnOperMin";
            btnOperMin.Size = new Size(94, 29);
            btnOperMin.TabIndex = 3;
            btnOperMin.Text = "-";
            btnOperMin.UseVisualStyleBackColor = false;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.White;
            btnEquals.Location = new Point(160, 349);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(94, 29);
            btnEquals.TabIndex = 4;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            // 
            // btnNumTwo
            // 
            btnNumTwo.BackColor = Color.White;
            btnNumTwo.Location = new Point(250, 185);
            btnNumTwo.Name = "btnNumTwo";
            btnNumTwo.Size = new Size(94, 29);
            btnNumTwo.TabIndex = 6;
            btnNumTwo.Text = "2";
            btnNumTwo.UseVisualStyleBackColor = false;
            btnNumTwo.Click += btnNumTwo_Click;
            // 
            // btnNumOne
            // 
            btnNumOne.BackColor = Color.White;
            btnNumOne.Location = new Point(69, 185);
            btnNumOne.Name = "btnNumOne";
            btnNumOne.Size = new Size(94, 29);
            btnNumOne.TabIndex = 8;
            btnNumOne.Text = "1";
            btnNumOne.UseVisualStyleBackColor = false;
            // 
            // txtScreenResult
            // 
            txtScreenResult.Location = new Point(139, 79);
            txtScreenResult.Name = "txtScreenResult";
            txtScreenResult.Size = new Size(125, 27);
            txtScreenResult.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 450);
            Controls.Add(txtScreenResult);
            Controls.Add(btnNumOne);
            Controls.Add(btnNumTwo);
            Controls.Add(btnEquals);
            Controls.Add(btnOperMin);
            Controls.Add(btnOperPlus);
            Enabled = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOperPlus;
        private Button btnOperMin;
        private Button btnEquals;
        private Button btnNumTwo;
        private Button btnNumOne;
        private TextBox txtScreenResult;
    }
}
