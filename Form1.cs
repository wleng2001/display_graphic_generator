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
    
    public partial class chooseDisplayForm : Form
    {
        public Color ForeGroundColor = Color.FromKnownColor(KnownColor.Control);
        public chooseDisplayForm()
        {
            InitializeComponent();
        }

        private void chooseDisplayForm_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioLcd16x2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form;
            if (radioLcd16x2.Checked)
            {
                Form = new FormLcd16x2();

            }
            else
            {
                if (radioGraphicDisplay.Checked)
                {
                    Form = new FormGraphicDisplay();
                }
                else
                {
                    Form = new Form7Segment();
                }

            }
            Form.Show();
            Form.Location = this.Location;
        }
    }
}
