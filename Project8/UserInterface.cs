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
        /// <summary>
        /// PictureBox array for the UI
        /// </summary>
        PictureBox [,] box = new PictureBox[6, 7];

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
        }

        /// <summary>
        /// Loads the Picture onto the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectFour_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 6 ; i++)
            {
                for (int j = 0; j < 7 ; j++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(i * 90+15, j*60 + 75);
                    pb.Size = new Size(68, 68);
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(pb);
                    //pb.Image = Properties.Resources.redCircle;
                    box[i, j] = pb; 
                }
            }
            //uxLabel.Text = Display current turn on label

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

            for (int i = 0; i <= box.Length; i++)
            {
                for (int j = 0; j <= box.Length; j++)
                {
                    if (//column is not full)
                    {
                        //place a piece of the current color in the clicked column
                        //then switch the displayed turn.
                        if (//Check to see if the recent move made the player win or tie)
                        {
                            MessageBox.Show("wins!");
                            //If so, display an appropriate message and disable the column buttons.
                        }
                        else
                        {
                            MessageBox.Show("Tie game.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Column" + "is full");
                        //Dont switch turns
                    }
                }
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
            for(int i = 0; i <= box.Length; i++)
            {
                for(int j = 0; j <= box.Length; j++)
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
