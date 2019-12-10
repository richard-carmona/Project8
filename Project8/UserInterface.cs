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
    /// 
    /// </summary>
    public partial class ConnectFour : Form
    {
        /// <summary>
        /// 
        /// </summary>
        PictureBox [,] box = new PictureBox[6, 7];

        /// <summary>
        /// 
        /// </summary>
        public ConnectFour()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
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

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickColumn(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            box[i,j].Image = 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxNewGame_Click(object sender, EventArgs e)
        {


        }

        private void UxPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        
    }
}
