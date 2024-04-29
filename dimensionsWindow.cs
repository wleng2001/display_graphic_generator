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
    public partial class dimensionsForm : Form
    {
        FormGraphicDisplay form;
        public dimensionsForm(FormGraphicDisplay form)
        {
            InitializeComponent();
            this.form = form;
            this.Location = new Point(form.Location.X, form.Location.Y);
        }

        private void widthLabel_Click(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int windowHeight = form.Height-60;
            int windowWidth = form.Width - (form.Width-form.Controls["tabContentTextBox"].Location.X);
            int height;
            int width;
            if (!(int.TryParse(heightTextBox.Text, out height) && int.TryParse(widthTextBox.Text, out width)))
            {
                MessageBox.Show("Wrong format");
                return;
            }
            int buttonHeightAndWidth = 300;
            int importantDim;
            int importantButtonQuantity;
            if(windowHeight-(buttonHeightAndWidth*height) < windowWidth - (buttonHeightAndWidth * width))
            {
                importantDim = windowHeight;
                importantButtonQuantity = height;
            }
            else
            {
                importantDim = windowWidth;
                importantButtonQuantity = width;
            }
            while ((buttonHeightAndWidth * importantButtonQuantity) > importantDim)
            {
                buttonHeightAndWidth--;
                if(buttonHeightAndWidth < 3 || height*width>10000-20)
                {
                    MessageBox.Show("Too big matrix");
                    return;
                }
            }
            int xLocation = (windowWidth - buttonHeightAndWidth * width) / 2;
            int yLocation = (windowHeight - buttonHeightAndWidth * height) / 2+25;
            form.generateMatrix(xLocation, yLocation, width, height, buttonHeightAndWidth, buttonHeightAndWidth);
            form.generateTabContent(form.autoRefresh);
            this.Close();
        }

        private void dimensionsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
