namespace Sudoku9000
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
            this.drawSudokuButt = new System.Windows.Forms.Button();
            this.quitButt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // drawSudokuButt
            // 
            this.drawSudokuButt.Location = new System.Drawing.Point(33, 294);
            this.drawSudokuButt.Name = "drawSudokuButt";
            this.drawSudokuButt.Size = new System.Drawing.Size(75, 23);
            this.drawSudokuButt.TabIndex = 0;
            this.drawSudokuButt.Text = "Draw Sudoku";
            this.drawSudokuButt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drawSudokuButt.UseVisualStyleBackColor = true;
            this.drawSudokuButt.Click += new System.EventHandler(this.drawSudokuButt_Click);
            // 
            // quitButt
            // 
            this.quitButt.Location = new System.Drawing.Point(194, 294);
            this.quitButt.Name = "quitButt";
            this.quitButt.Size = new System.Drawing.Size(75, 23);
            this.quitButt.TabIndex = 1;
            this.quitButt.Text = "Quit";
            this.quitButt.UseVisualStyleBackColor = true;
            this.quitButt.Click += new System.EventHandler(this.quitButt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 334);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.quitButt);
            this.Controls.Add(this.drawSudokuButt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawSudokuButt;
        private System.Windows.Forms.Button quitButt;
        private System.Windows.Forms.TextBox textBox1;
    }
}

