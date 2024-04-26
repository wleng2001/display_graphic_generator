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
    public partial class loadingForm : Form
    {
        public void setProgressBarRange(int range, int step = 1)
        {
            progressBar2.Visible = true;
            progressBar2.Maximum = range;
            progressBar2.Minimum = 1;
            progressBar2.Step = step;
            progressBar2.Value = 1;
        }

        public void setProgressBar(int value) {  progressBar2.Value = value; }
        public loadingForm(int range, int step = 1)
        {
            InitializeComponent();
            setProgressBarRange(range, step);
        }
        public loadingForm()
        {
            InitializeComponent();
        }

        public void incrementProgressBar()
        {
            progressBar2.PerformStep();
        }

        public void setLocation(int x, int y)
        {
            this.Location = new Point(x, y);
        }

        public void setLocation(Point p)
        {
            this.Location = p;
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void loadingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
