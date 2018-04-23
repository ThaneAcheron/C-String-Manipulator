namespace CTIExerciseTwo
{
    partial class Form1
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
            this.btnChar = new System.Windows.Forms.Button();
            this.btnNumber = new System.Windows.Forms.Button();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.brnUpperCase = new System.Windows.Forms.Button();
            this.btnLowerCase = new System.Windows.Forms.Button();
            this.btnNormalCase = new System.Windows.Forms.Button();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(12, 104);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(81, 34);
            this.btnChar.TabIndex = 0;
            this.btnChar.Text = "Add Char";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnNumber
            // 
            this.btnNumber.Location = new System.Drawing.Point(99, 104);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(81, 34);
            this.btnNumber.TabIndex = 1;
            this.btnNumber.Text = "Add Number";
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.Location = new System.Drawing.Point(186, 104);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(81, 34);
            this.btnRemoveLast.TabIndex = 2;
            this.btnRemoveLast.Text = "Remove Last";
            this.btnRemoveLast.UseVisualStyleBackColor = true;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // brnUpperCase
            // 
            this.brnUpperCase.Location = new System.Drawing.Point(12, 144);
            this.brnUpperCase.Name = "brnUpperCase";
            this.brnUpperCase.Size = new System.Drawing.Size(81, 34);
            this.brnUpperCase.TabIndex = 3;
            this.brnUpperCase.Text = "Upper Case";
            this.brnUpperCase.UseVisualStyleBackColor = true;
            this.brnUpperCase.Click += new System.EventHandler(this.brnUpperCase_Click);
            // 
            // btnLowerCase
            // 
            this.btnLowerCase.Location = new System.Drawing.Point(99, 144);
            this.btnLowerCase.Name = "btnLowerCase";
            this.btnLowerCase.Size = new System.Drawing.Size(81, 34);
            this.btnLowerCase.TabIndex = 4;
            this.btnLowerCase.Text = "Lower Case";
            this.btnLowerCase.UseVisualStyleBackColor = true;
            this.btnLowerCase.Click += new System.EventHandler(this.btnLowerCase_Click);
            // 
            // btnNormalCase
            // 
            this.btnNormalCase.Location = new System.Drawing.Point(186, 144);
            this.btnNormalCase.Name = "btnNormalCase";
            this.btnNormalCase.Size = new System.Drawing.Size(81, 34);
            this.btnNormalCase.TabIndex = 5;
            this.btnNormalCase.Text = "Normal Case";
            this.btnNormalCase.UseVisualStyleBackColor = true;
            this.btnNormalCase.Click += new System.EventHandler(this.btnNormalCase_Click);
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Location = new System.Drawing.Point(107, 51);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(56, 13);
            this.lblPassWord.TabIndex = 6;
            this.lblPassWord.Text = "PassWord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 219);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.btnNormalCase);
            this.Controls.Add(this.btnLowerCase);
            this.Controls.Add(this.brnUpperCase);
            this.Controls.Add(this.btnRemoveLast);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.btnChar);
            this.Name = "Form1";
            this.Text = "Password Creator ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button brnUpperCase;
        private System.Windows.Forms.Button btnLowerCase;
        private System.Windows.Forms.Button btnNormalCase;
        private System.Windows.Forms.Label lblPassWord;
    }
}

