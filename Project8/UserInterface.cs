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
    public partial class ConnectFour : Form
    {
        public ConnectFour()
        {
            InitializeComponent();
        }

        private void ConnectFour_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 6 ; i++)
            {
                for (int j = 0; j < 7 ; j++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(i * 90+25, j*60 + 75);
                    pb.Size = new Size(50, 50);
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(pb);
                }
            }


        }

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
