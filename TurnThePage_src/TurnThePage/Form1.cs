////////////////////////////////////////////////////////////////////////////
// Copyright : Robert Hartman 
// Date:       2/25/2006
// 
// Email : hart_dev@yahoo.com 
// 
// This file may be redistributed unmodified by any means PROVIDING it is
// not sold for profit without the authors written consent, and
// providing that this notice and the authors name is included.
//
// This file is provided 'as is' with no expressed or implied warranty.
// The author accepts no liability for damages caused by the use of this software.
////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TurnThePage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string current = Environment.CurrentDirectory;

            pageControl.HeightAdjustment = (int)(.15 * this.ClientRectangle.Height); 
            pageControl.LoadSamples();


        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {

            // Animate Right Page!
            pageControl.animateRightPageTurn();


        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            // Animate Left Page!
            pageControl.animateLeftPageTurn();





        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int speed = 10;
            speed = 10 + (int)(985*((float)this.trackBar1.Value / (float)trackBar1.Maximum));
            pageControl.TickSpeed = speed;


        }
    }
}