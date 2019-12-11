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
                for (int j = 0; j < 6; j++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(i * 90 + 15, j * 60 + 75);
                    pb.Size = new Size(68, 68);
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(pb);
                    //pb.Image = Properties.Resources.redCircle;
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
                        box[buttonIndex, i].Image = Properties.Resources.redCircle;
                        box[buttonIndex, i].Refresh();
                        box[buttonIndex, i].Visible = true;

                    }
                    else if(board.GetColor(i, buttonIndex) == PieceColor.black)
                    {
                        box[buttonIndex, i].Image = Properties.Resources.blackCircle;
                        box[buttonIndex, i].Refresh();
                        box[buttonIndex, i].Visible = true;
                    }
                    else
                    {
                        box[buttonIndex, i].Image = null;
                    }
                }


                if (board.IsWinner(board.Turn))//Check to see if the recent move made the player win or tie
                {
                    MessageBox.Show(board.Turn + " wins!");
                    //If so, display an appropriate message and disable the column buttons.
                }
                if (board.CheckTie())//check for tie
                {
                    MessageBox.Show("Tie game.");
                }
                board.SwitchTurns();
                uxLabel.Text = board.Turn.ToString();
            }
            else
            {
                MessageBox.Show("Column" + "is full");
                //Dont switch turns
            }


            //then switch the displayed turn.


            /*
             In column click event in GUI:
            Button clicked = (Button) sender;
            loop through your array of column buttons
            check if clicked equals columns[i]
            if it does, i is the column that was clicked

            call Move at that column (how to find it?)
            nested loop through all PictureBoxes
            call GetColor with i and j.
            if get back PieceColor.red
                set that PictureBox's Image Properties.Resources.redCircle
            set their image to be the right circle, 
            depending on the color from Board
            */
        }

        /// <summary>
        /// Starts a new game. refreshes the board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxNewGame_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            for (int i = 0; i <= box.Length; i++)
            {
                for (int j = 0; j <= box.Length; j++)
                {
                    //clear the board and reset the current turn to red.
                }
            }
        }

        private void UxPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
