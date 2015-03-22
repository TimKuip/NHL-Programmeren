using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku9000
{
    public partial class Form1 : Form
    {public TextBox[,] sudokuArray = new TextBox[9, 9];  
        int rows = 9;
        int colums = 9;

        public Form1()
        {
            InitializeComponent();
            sudokuArray = new TextBox[rows, colums];
        
        }

        public void setNumber()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int colum = 0; colum < 9; colum++)
                {
                    
                }
            }
        }

        //void drawSudoBoard()
        //{
        //    for (int x = 0; x < 9; x++)
        //    {
        //        for (int y = 0; y < 9; y++)
        //        {
        //            sudokuArray[x, y] = new TextBox();
        //            sudokuArray[x, y].Name = "txt" + x + y;
        //            sudokuArray[x, y].Top = 27 + (27 * y);
        //            sudokuArray[x, y].Left = 27 + (27 * x);
        //            sudokuArray[x, y].Size = new System.Drawing.Size(26, 26);
        //            sudokuArray[x, y].Text = "";
        //            sudokuArray[x, y].MaxLength = 1;
        //            sudokuArray[x, y].TextAlign = HorizontalAlignment.Center;
        //            sudokuArray[x, y].Multiline = true;
        //            sudokuArray[x, y].Font = new Font("Arial", 13, FontStyle.Bold);
        //            sudokuArray[x, y].BorderStyle = BorderStyle.None;
        //        }
        //    }
        //}
        int row = 0;
        int colum = 0;
        int square = 0;
        public bool checkRow(int getal, int row)
        {
            for (int i = 0; i < 9; i++)
            {
                if (Convert.ToString(sudokuArray[row, i]) == Convert.ToString(getal))
                {
                    return false;   
                }
            } 
            return true;
        }

        public bool checkColum(int getal, int colum)
        {
            for (int i = 0; i < 9; i++)
            {
                if (Convert.ToString(sudokuArray[i, colum]) == Convert.ToString(getal))
                {
                    return false;   
                }
            } 
            return true;
        }

        public System.Windows.Forms.TextBox drawBackGround()
        {
            //drawing the background, which is a black textbox set that has the read-only property = true
            System.Windows.Forms.TextBox background = new System.Windows.Forms.TextBox();
            this.Controls.Add(background);
            background.Top = 22;
            background.Left = 22;
            background.Size = new System.Drawing.Size(252, 252);
            background.Multiline = true;
            background.ReadOnly = true;
            background.BackColor = Color.Black;
            background.BorderStyle = BorderStyle.None;
            return background;
        }

        private void drawSudokuButt_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    System.Windows.Forms.TextBox sudokuArray = new System.Windows.Forms.TextBox();
                    this.Controls.Add(sudokuArray);
                    sudokuArray.Top = 27 + (27 * y);
                    sudokuArray.Left = 27 + (27 * x);
                    sudokuArray.Size = new System.Drawing.Size(26, 26);
                    sudokuArray.Name = Convert.ToString(x + y);
                    sudokuArray.Text = "";
                    sudokuArray.MaxLength = 1;
                    sudokuArray.TextAlign = HorizontalAlignment.Center;
                    sudokuArray.Multiline = true;
                    sudokuArray.Font = new Font("Arial", 13, FontStyle.Bold);
                    sudokuArray.BorderStyle = BorderStyle.None;
                }
            }
            drawBackGround();
            
        }
   
        private void quitButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }


        //public bool checkSquare(int row, int colum, int getal)
        //{
            
        //}


    }
}
