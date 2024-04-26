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
        loadingForm loadingForm = new loadingForm();
        bool autoRefresh = true;
        
        void updateLoadingFormLoc()
        {
            loadingForm.setLocation(this.Location.X + (this.Width - loadingForm.Width) / 2, this.Location.Y + (this.Height - loadingForm.Height) / 2);
        }
        void generateMatrix(buttonMatrix m)
        {
            loadingForm.setProgressBarRange(widthResolution * heightResolution);
            updateLoadingFormLoc();
            loadingForm.Show();
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
            loadingForm.Hide();
        }
        public FormGraphicDisplay()
        {
            InitializeComponent();
            updateLoadingFormLoc();
            matrix = new buttonMatrix(widthResolution, heightResolution);
            matrix.setLocation(xLocation, yLocation);
            matrix.showButton();
            matrix.ButtonClickTask += this.generateTabContent;
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
            generateTabContent(autoRefresh);
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
            generateTabContent(autoRefresh);

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
                generateTabContent(autoRefresh);
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
                heightResolution = 10;
                widthResolution = 10;
                xLocation = 100;
                yLocation = 100;
                generateMatrix(xLocation, yLocation, widthResolution, heightResolution, 20, 20);
                generateTabContent(autoRefresh);
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

        void generateTabContent(bool refresh)
        {
            if (refresh)
            {
                loadingForm.setProgressBarRange(widthResolution * heightResolution);
                updateLoadingFormLoc();
                loadingForm.Show();
                loadingForm.Refresh();
                tabContentTextBox.Text = "const uint8_t PROGMEM " + tabNameTextBox.Text + "Width = "+widthResolution+";\r\n";
                tabContentTextBox.Text += "const uint8_t PROGMEM " + tabNameTextBox.Text + "Width = " + heightResolution + ";\r\n";
                tabContentTextBox.Text += "const unsigned char PROGMEM "+tabNameTextBox.Text+"[] = {\r\n";
                for(int i = heightResolution-1; i >= 0 ; i--)
                {
                    tabContentTextBox.Text += "\t";
                    byte bitNumber = 0;
                    for(int j = widthResolution-1; j >=0 ; j--)
                    {
                        loadingForm.incrementProgressBar();
                        if (bitNumber == 0)
                        {
                            tabContentTextBox.Text += "0b";
                        }
                        if (matrix.Status[i, j] == true)
                        {
                            tabContentTextBox.Text += "1";
                        }
                        else
                        {
                            tabContentTextBox.Text+= "0";
                        }
                        if (bitNumber < 7 && j == 0)
                        {
                            for (int k = 0; k < 8 - bitNumber; k++)
                            {
                                tabContentTextBox.Text += "0";
                            }
                            bitNumber = 7;
                        }
                        if (bitNumber == 7)
                        {
                            tabContentTextBox.Text += ", ";
                            bitNumber = 0;
                        }
                        else
                        {
                            bitNumber++;
                        }
                        loadingForm.Refresh();
                    }
                    tabContentTextBox.Text += "\r\n";
                }
                tabContentTextBox.Text += "}";
                loadingForm.Hide();
            }
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            generateTabContent(true);
        }

        private void autoRefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autoRefreshToolStripMenuItem.Checked)
            {
                autoRefreshToolStripMenuItem.Checked = false;
                autoRefresh = false;
                matrix.update = false;
            }
            else
            {
                autoRefresh = true;
                autoRefreshToolStripMenuItem.Checked= true;
                matrix.update = true;
            }
        }
    }
}
