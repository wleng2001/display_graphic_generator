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
        int xLocation = 23;
        int yLocation = 25;
        int heightResolution = 48;
        int widthResolution = 48;
        buttonMatrix matrix;

        void generateMatrix(buttonMatrix m)
        {
            loadingForm loadingForm = new loadingForm(widthResolution*heightResolution);
            loadingForm.Show();
            loadingForm.setLocation(this.Location.X+60, this.Location.Y+60);
            loadingForm.Refresh();
            for (int i = 0; i < widthResolution; i++)
            {
                for (int j = 0; j < heightResolution; j++)
                {
                    loadingForm.incrementProgressBar();
                    Button b = m[i, j];
                    Controls.Add(b);
                    loadingForm.Refresh();
                }
            }
            loadingForm.Dispose();
        }
        public FormGraphicDisplay()
        {
            InitializeComponent();
            matrix = new buttonMatrix(widthResolution, heightResolution);
            matrix.setLocation(xLocation, yLocation);
            matrix.showButton();
            generateMatrix(xLocation, yLocation, widthResolution, heightResolution, 7, 7);

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
                shineColor = Color.White;
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
                shineColor = Color.Blue;
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
                shineColor = Color.Yellow;
                matrix.ShineColor = Color.Yellow;
                FormGraphicDisplay.ActiveForm.BackColor = chooseDisplayForm.ActiveForm.BackColor;
            }
        }

        private void negativeButton_Click(object sender, EventArgs e)
        {
            matrix.restart(true);
        }

        private void generateMatrix(int xLocation, int yLocation, int xResolution, int yResolution, int buttonWidth, int buttonHeight)
        {
            heightResolution = yResolution;
            widthResolution = xResolution;
            matrix = new buttonMatrix(widthResolution, heightResolution);
            matrix.ButtonWidth = buttonWidth;
            matrix.ButtonHeight = buttonHeight;
            this.xLocation = xLocation;
            this.yLocation = yLocation;
            matrix.setLocation(xLocation, yLocation);
            generateMatrix(matrix);
            matrix.ShineColor = shineColor;
            matrix.muteColor = muteColor;
        }
        private void dimensions48x48ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!dimensions48x48ToolStripMenuItem.Checked)
            {
                dimensions10x10ToolStripMenuItem.Checked = false;
                dimensions48x48ToolStripMenuItem.Checked = true;
                dimensionsOwnToolStripMenuItem.Checked = false;
                matrix.remove();
                xLocation = 23;
                yLocation = 25;
                widthResolution = 48;
                heightResolution = 48;
                generateMatrix(xLocation, yLocation, widthResolution, heightResolution, 7, 7);
            }
        }

        private void dimensions10x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!dimensions10x10ToolStripMenuItem.Checked)
            {
                dimensions10x10ToolStripMenuItem.Checked = true;
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

        private void dimensionsOwnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!dimensionsOwnToolStripMenuItem.Checked)
            {
                dimensions10x10ToolStripMenuItem.Checked = false;
                dimensions48x48ToolStripMenuItem.Checked = false;
                dimensionsOwnToolStripMenuItem.Checked = true;
            }
        }
    }
}
