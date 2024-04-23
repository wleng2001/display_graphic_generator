using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace display_graphic_generator
{
    public partial class FormGraphicDisplay : Form
    {
        Color shineColor = Color.White;
        Color muteColor = Color.Gray;
        Color borderColor = Color.Gray;
        int xLocation = 60;
        int yLocation = 60;
        int heightResolution = 48;
        int widthResolution = 48;
        buttonMatrix matrix;

        void generateMatrix(buttonMatrix m)
        {
            for (int i = 0; i < widthResolution; i++)
            {
                for (int j = 0; j < heightResolution; j++)
                {
                    Button b = m[i, j];
                    b.SendToBack();
                    Controls.Add(b);
                }
            }
        }
        public FormGraphicDisplay()
        {
            InitializeComponent();
            matrix = new buttonMatrix(widthResolution, heightResolution);
            matrix.setLocation(xLocation, yLocation);
            matrix.showButton();
            generateMatrix(matrix);

        }

        private void tabNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void FormGraphicDisplay_Load(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            matrix.restart();
        }

        private void tabContentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!whiteToolStripMenuItem.Checked)
            {
                whiteToolStripMenuItem.Checked = true;
                blueToolStripMenuItem.Checked = false;
                yellowToolStripMenuItem.Checked = false;
                BackColor = Color.White;
                matrix.ShineColor = Color.White;
                FormGraphicDisplay.ActiveForm.BackColor = chooseDisplayForm.ActiveForm.BackColor;
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!blueToolStripMenuItem.Checked)
            {
                whiteToolStripMenuItem.Checked = false;
                blueToolStripMenuItem.Checked = true;
                yellowToolStripMenuItem.Checked = false;
                BackColor = Color.Blue;
                matrix.ShineColor = Color.Blue;
                FormGraphicDisplay.ActiveForm.BackColor = chooseDisplayForm.ActiveForm.BackColor;
            }
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!yellowToolStripMenuItem.Checked)
            {
                whiteToolStripMenuItem.Checked = false;
                blueToolStripMenuItem.Checked = false;
                yellowToolStripMenuItem.Checked = true;
                BackColor = Color.Yellow;
                matrix.ShineColor = Color.Yellow;
                FormGraphicDisplay.ActiveForm.BackColor = chooseDisplayForm.ActiveForm.BackColor;
            }
        }

        private void negativeButton_Click(object sender, EventArgs e)
        {
            matrix.restart(true);
        }

        private void dimensions48x48ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!dimensions48x48ToolStripMenuItem.Checked)
            {
                dimensions10x10ToolStripMenuItem.Checked = false;
                dimensions128x64ToolStripMenuItem.Checked = false;
                dimensions48x48ToolStripMenuItem.Checked = true;
                dimensionsOwnToolStripMenuItem.Checked = false;
                matrix.remove();
                heightResolution = 48;
                widthResolution = 48;
                matrix.ButtonWidth = 6;
                matrix.ButtonHeight = 6;
                xLocation = 60;
                yLocation = 60;
                matrix = new buttonMatrix(widthResolution, heightResolution);
                matrix.setLocation(xLocation, yLocation);
                generateMatrix(matrix);
                matrix.ShineColor = shineColor;
                matrix.muteColor = muteColor;
            }
        }

        private void dimensions10x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!dimensions10x10ToolStripMenuItem.Checked)
            {
                dimensions10x10ToolStripMenuItem.Checked = true;
                dimensions128x64ToolStripMenuItem.Checked = false;
                dimensions48x48ToolStripMenuItem.Checked = false;
                dimensionsOwnToolStripMenuItem.Checked = false;
                matrix.remove();
                matrix = new buttonMatrix(10, 10);
                matrix.ButtonWidth = 20;
                matrix.ButtonHeight = 20;
                heightResolution = 10;
                widthResolution = 10;
                xLocation = 100;
                yLocation = 100;
                matrix.setLocation(xLocation, yLocation);
                
                generateMatrix(matrix);
                matrix.ShineColor = shineColor;
                matrix.muteColor = muteColor;
            }
        }

        private void dimensions128x64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!dimensions128x64ToolStripMenuItem.Checked)
            {
                dimensions10x10ToolStripMenuItem.Checked = false;
                dimensions128x64ToolStripMenuItem.Checked = true;
                dimensions48x48ToolStripMenuItem.Checked = false;
                dimensionsOwnToolStripMenuItem.Checked = false;
                matrix.remove();
                heightResolution = 128;
                widthResolution = 64;
                matrix.ButtonWidth = 2;
                matrix.ButtonHeight = 2;
                xLocation = 20;
                yLocation = 40;
                matrix = new buttonMatrix(widthResolution, heightResolution);
                matrix.setLocation(xLocation, yLocation);
                generateMatrix(matrix);
                matrix.ShineColor = shineColor;
                matrix.muteColor = muteColor;
            }
        }

        private void dimensionsOwnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!dimensionsOwnToolStripMenuItem.Checked)
            {
                dimensions10x10ToolStripMenuItem.Checked = false;
                dimensions128x64ToolStripMenuItem.Checked = false;
                dimensions48x48ToolStripMenuItem.Checked = false;
                dimensionsOwnToolStripMenuItem.Checked = true;
            }
        }
    }
}
