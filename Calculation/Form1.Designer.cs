namespace Calculation
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
            btnNumThree = new Button();
            btnNumOne = new Button();
            btnNumTwo = new Button();
            btnNumFour = new Button();
            btnNumFive = new Button();
            btnNumSix = new Button();
            btnNumSeven = new Button();
            btnDot = new Button();
            btnNumEight = new Button();
            btnNumNine = new Button();
            btnZero = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnEqual = new Button();
            txtResult = new TextBox();
            btnPlus = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // btnNumThree
            // 
            btnNumThree.Location = new Point(160, 94);
            btnNumThree.Name = "btnNumThree";
            btnNumThree.Size = new Size(45, 47);
            btnNumThree.TabIndex = 0;
            btnNumThree.Text = "3";
            btnNumThree.UseVisualStyleBackColor = true;
            btnNumThree.Click += btnNumber_Click;
            // 
            // btnNumOne
            // 
            btnNumOne.Location = new Point(30, 94);
            btnNumOne.Name = "btnNumOne";
            btnNumOne.Size = new Size(45, 47);
            btnNumOne.TabIndex = 1;
            btnNumOne.Text = "1";
            btnNumOne.UseVisualStyleBackColor = true;
            btnNumOne.Click += btnNumber_Click;
            // 
            // btnNumTwo
            // 
            btnNumTwo.Location = new Point(93, 94);
            btnNumTwo.Name = "btnNumTwo";
            btnNumTwo.Size = new Size(45, 47);
            btnNumTwo.TabIndex = 2;
            btnNumTwo.Text = "2";
            btnNumTwo.UseVisualStyleBackColor = true;
            btnNumTwo.Click += btnNumber_Click;
            // 
            // btnNumFour
            // 
            btnNumFour.Location = new Point(30, 161);
            btnNumFour.Name = "btnNumFour";
            btnNumFour.Size = new Size(45, 47);
            btnNumFour.TabIndex = 4;
            btnNumFour.Text = "4";
            btnNumFour.UseVisualStyleBackColor = true;
            btnNumFour.Click += btnNumber_Click;
            // 
            // btnNumFive
            // 
            btnNumFive.Location = new Point(93, 161);
            btnNumFive.Name = "btnNumFive";
            btnNumFive.Size = new Size(45, 47);
            btnNumFive.TabIndex = 5;
            btnNumFive.Text = "5";
            btnNumFive.UseVisualStyleBackColor = true;
            btnNumFive.Click += btnNumber_Click;
            // 
            // btnNumSix
            // 
            btnNumSix.Location = new Point(160, 161);
            btnNumSix.Name = "btnNumSix";
            btnNumSix.Size = new Size(45, 47);
            btnNumSix.TabIndex = 6;
            btnNumSix.Text = "6";
            btnNumSix.UseVisualStyleBackColor = true;
            btnNumSix.Click += btnNumber_Click;
            // 
            // btnNumSeven
            // 
            btnNumSeven.Location = new Point(30, 232);
            btnNumSeven.Name = "btnNumSeven";
            btnNumSeven.Size = new Size(45, 47);
            btnNumSeven.TabIndex = 8;
            btnNumSeven.Text = "7";
            btnNumSeven.UseVisualStyleBackColor = true;
            btnNumSeven.Click += btnNumber_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(30, 297);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(45, 47);
            btnDot.TabIndex = 9;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnNumber_Click;
            // 
            // btnNumEight
            // 
            btnNumEight.Location = new Point(93, 232);
            btnNumEight.Name = "btnNumEight";
            btnNumEight.Size = new Size(45, 47);
            btnNumEight.TabIndex = 10;
            btnNumEight.Text = "8";
            btnNumEight.UseVisualStyleBackColor = true;
            btnNumEight.Click += btnNumber_Click;
            // 
            // btnNumNine
            // 
            btnNumNine.Location = new Point(160, 232);
            btnNumNine.Name = "btnNumNine";
            btnNumNine.Size = new Size(45, 47);
            btnNumNine.TabIndex = 11;
            btnNumNine.Text = "9";
            btnNumNine.UseVisualStyleBackColor = true;
            btnNumNine.Click += btnNumber_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(93, 297);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(45, 47);
            btnZero.TabIndex = 13;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnNumber_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(160, 297);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(45, 47);
            btnClear.TabIndex = 14;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(225, 359);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(45, 47);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "D";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(30, 359);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(175, 47);
            btnEqual.TabIndex = 17;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // txtResult
            // 
            txtResult.Enabled = false;
            txtResult.Location = new Point(30, 25);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(240, 27);
            txtResult.TabIndex = 18;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(225, 94);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(45, 47);
            btnPlus.TabIndex = 3;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnNumber_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(225, 161);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(45, 47);
            btnSub.TabIndex = 19;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnNumber_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(225, 232);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(45, 47);
            btnMul.TabIndex = 20;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnNumber_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(225, 297);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(45, 47);
            btnDiv.TabIndex = 21;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnNumber_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 433);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(txtResult);
            Controls.Add(btnEqual);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnZero);
            Controls.Add(btnNumNine);
            Controls.Add(btnNumEight);
            Controls.Add(btnDot);
            Controls.Add(btnNumSeven);
            Controls.Add(btnNumSix);
            Controls.Add(btnNumFive);
            Controls.Add(btnNumFour);
            Controls.Add(btnPlus);
            Controls.Add(btnNumTwo);
            Controls.Add(btnNumOne);
            Controls.Add(btnNumThree);
            Name = "Form1";
            Text = "Calculation";
            Click += btnNumber_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNumThree;
        private Button btnNumOne;
        private Button btnNumTwo;
        private Button btnNumFour;
        private Button btnNumFive;
        private Button btnNumSix;
        private Button btnNumSeven;
        private Button btnDot;
        private Button btnNumEight;
        private Button btnNumNine;
        private Button btnZero;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEqual;
        private TextBox txtResult;
        private Button btnPlus;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
    }
}
