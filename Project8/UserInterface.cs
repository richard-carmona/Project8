/// Richard Carmona-Andrade
/// Project 8
/// Thursday / 4:30 p.m.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project8
{
    /// <summary>
    /// Class that hold the buttons of the UI
    /// </summary>
    public partial class ConnectFour : Form
    {

        public Board board;

        /// <summary>
        /// PictureBox array for the UI
        /// </summary>
        PictureBox[,] box = new PictureBox[6, 7];

        /// <summary>
        /// Buttons array
        /// </summary>
        Button[] buttons = new Button[7];

        /// <summary>
        /// Constructor
        /// </summary>
        public ConnectFour()
        {
            InitializeComponent();
            board = new Board();
        }



        /// <summary>
        /// Loads the Picture onto the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectFour_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point( j * 68 + 20, i * 68+ 75);
                    pb.Size = new Size(60, 60);
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(pb);
                    box[i, j] = pb;
                }
            }

            buttons[0] = uxButton1;
            buttons[1] = uxButton2;
            buttons[2] = uxButton3;
            buttons[3] = uxButton4;
            buttons[4] = uxButton5;
            buttons[5] = uxButton6;
            buttons[6] = uxButton7;
        }

        /// <summary>
        /// Used for the columns on the connect four board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickColumn(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            int buttonIndex = -1;

            for (int i = 0; i < buttons.Length; i++)
            {
                if (clicked == buttons[i])
                {
                    buttonIndex = i;
                }
            }

            if (board.Move(buttonIndex))//column is not full
            {
                //place a piece of the current color in the clicked column
                for (int i = 0; i < 6; i++)
                {
                    if (board.GetColor(i,buttonIndex) == PieceColor.red)
                    {
                        box[i, buttonIndex].Image = Properties.Resources.redCircle;
                        box[i, buttonIndex].Refresh();
                        box[i, buttonIndex].Visible = true;

                    }
                    else if(board.GetColor(i, buttonIndex) == PieceColor.black)
                    {
                        box[i, buttonIndex].Image = Properties.Resources.blackCircle;
                        box[i, buttonIndex].Refresh();
                        box[i, buttonIndex].Visible = true;
                    }
                    else
                    {
                        box[i, buttonIndex].Image = null;
                    }
                }


                if (board.IsWinner(board.Turn))//Check to see if the recent move made the player win or tie
                {
                    MessageBox.Show(board.Turn + " wins!");
                    //If so, display an appropriate message and disable the column buttons.
                    uxButton1.Enabled = false;
                    uxButton2.Enabled = false;
                    uxButton3.Enabled = false;
                    uxButton4.Enabled = false;
                    uxButton5.Enabled = false;
                    uxButton6.Enabled = false;
                    uxButton7.Enabled = false;
                }
                if (board.CheckTie())//check for tie
                {
                    MessageBox.Show("Tie game.");
                    uxButton1.Enabled = false;
                    uxButton2.Enabled = false;
                    uxButton3.Enabled = false;
                    uxButton4.Enabled = false;
                    uxButton5.Enabled = false;
                    uxButton6.Enabled = false;
                    uxButton7.Enabled = false;
                }
                board.SwitchTurns();
                uxLabel.Text = (board.Turn.ToString() + "'s Turn");
            }
            else
            {
                MessageBox.Show("Column " + clicked.Text + " is full");
                //Dont switch turns
            }
        }

        /// <summary>
        /// Starts a new game. refreshes the board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxNewGame_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            board = new Board();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7 ; j++)
                {
                    //board.SwitchTurns();
                    box[i, j].Image = null;
                    uxButton1.Enabled = true;
                    uxButton2.Enabled = true;
                    uxButton3.Enabled = true;
                    uxButton4.Enabled = true;
                    uxButton5.Enabled = true;
                    uxButton6.Enabled = true;
                    uxButton7.Enabled = true;
                }
            }
        }

        private void UxPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void UxLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
