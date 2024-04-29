using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        public bool autoRefresh = true;
        private Color formBackColor = SystemColors.Control;
        private Color textBoxColor = SystemColors.Window;
        private Color textColor = SystemColors.WindowText;
        
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
            matrix.ButtonClickTask = generateTabContent;
            generateMatrix(xLocation, yLocation, widthResolution, heightResolution, 7, 7);
            generateTabContent(true);

        }
        public FormGraphicDisplay(Color formBackColor, Color textBoxColor, Color fontColor)
        {
            InitializeComponent();
            updateLoadingFormLoc();
            matrix = new buttonMatrix(widthResolution, heightResolution);
            matrix.setLocation(xLocation, yLocation);
            matrix.showButton();
            matrix.ButtonClickTask = generateTabContent;
            generateMatrix(xLocation, yLocation, widthResolution, heightResolution, 7, 7);
            generateTabContent(true);
            this.formBackColor = formBackColor;
            this.textBoxColor = textBoxColor;
            this.textColor = fontColor;

            this.BackColor = formBackColor;
            tabNameLabel.ForeColor = textColor;
            tabNameLabel.ForeColor = fontColor;
            tableContentLabel.ForeColor = textColor;
            tabContentTextBox.ForeColor = textColor;
            tabContentTextBox.BackColor = textBoxColor;
            clearButton.ForeColor = textColor;
            clearButton.BackColor = textBoxColor;
            negativeButton.ForeColor = textColor;
            negativeButton.BackColor = textBoxColor;
            generateButton.ForeColor = textColor;
            generateButton.BackColor = textBoxColor;

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
            matrix.negative();
            generateTabContent(autoRefresh);

        }

        public void generateMatrix(int xLocation, int yLocation, int xResolution, int yResolution, int buttonWidth, int buttonHeight)
        {
            heightResolution = yResolution;
            widthResolution = xResolution;
            matrix.remove();
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
            dimensions10x10ToolStripMenuItem.Checked = false;
            dimensions48x48ToolStripMenuItem.Checked = false;
            dimensionsOwnToolStripMenuItem.Checked = true;
            dimensionsForm f = new dimensionsForm(this);
            f.Show();
            f.Location = new Point(this.Location.X+(this.Width-f.Width)/2, this.Location.Y+(this.Height-f.Height)/2);
        }

        public void generateTabContent(bool refresh)
        {
            if (refresh)
            {
                String text = "";
                loadingForm.setProgressBarRange(widthResolution * heightResolution);
                updateLoadingFormLoc();
                loadingForm.Show();
                loadingForm.Refresh();
                text = "const uint8_t PROGMEM " + tabNameTextBox.Text + "Width = "+widthResolution+";\r\n";
                text += "const uint8_t PROGMEM " + tabNameTextBox.Text + "Height = " + heightResolution + ";\r\n";
                text += "const unsigned char PROGMEM "+tabNameTextBox.Text+"[] = {\r\n";
                for(int i = 0; i < heightResolution ; i++)
                {
                    text += "\t";
                    byte bitNumber = 0;
                    for(int j = 0; j < widthResolution ; j++)
                    {
                        loadingForm.incrementProgressBar();
                        if (bitNumber == 0)
                        {
                            text += "0b";
                        }
                        if (matrix.Status[j, i] == true)
                        {
                            text += "1";
                        }
                        else
                        {
                            text += "0";
                        }
                        if (bitNumber < 7 && j == widthResolution-1)
                        {
                            for (int k = 0; k < 7 - bitNumber; k++)
                            {
                                text += "0";
                            }
                            bitNumber = 7;
                        }
                        if (bitNumber == 7)
                        {
                            text += ", ";
                            bitNumber = 0;
                        }
                        else
                        {
                            bitNumber++;
                        }
                        loadingForm.Refresh();
                    }
                    text += "\r\n";
                }
                text += "};";
                tabContentTextBox.Text = text;
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
