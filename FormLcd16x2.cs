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
    public partial class FormLcd16x2 : Form
    {
        public FormLcd16x2()
        {
            InitializeComponent();
        }

        private void FormLcd16x2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(char0x0Button.BackColor == Color.Lime)
            {
                char0x0Button.BackColor = Color.Gray;
            }
            else
            {
                char0x0Button.BackColor = Color.Lime;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            tabContentTextBox.Text = "uint8_t "+tabNameTextBox.Text+"[]={\n";
            tabContentTextBox.Text = tabContentTextBox.Text + "B" + "000";
            tabContentTextBox.Text = tabContentTextBox.Text + "}";
        }

        private void tabContentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void char0x1Button_Click(object sender, EventArgs e)
        {
            if (char0x1Button.BackColor == Color.Lime)
            {
                char0x1Button.BackColor = Color.Gray;
            }
            else
            {
                char0x1Button.BackColor = Color.Lime;
            }
        }

        private void char0x2Button_Click(object sender, EventArgs e)
        {
            if (char0x2Button.BackColor == Color.Lime)
            {
                char0x2Button.BackColor = Color.Gray;
            }
            else
            {
                char0x2Button.BackColor = Color.Lime;
            }
        }

        private void char0x3Button_Click(object sender, EventArgs e)
        {
            if (char0x3Button.BackColor == Color.Lime)
            {
                char0x3Button.BackColor = Color.Gray;
            }
            else
            {
                char0x3Button.BackColor = Color.Lime;
            }
        }

        private void char0x4Button_Click(object sender, EventArgs e)
        {
            if (char0x4Button.BackColor == Color.Lime)
            {
                char0x4Button.BackColor = Color.Gray;
            }
            else
            {
                char0x4Button.BackColor = Color.Lime;
            }
        }

        private void tabNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    public class lcdContent
    {
        private byte[] content =
            {
                0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0
            };
        public byte[] Content
        {
            get { return content; }
            set { }
        }
        public void set(byte row, byte col, bool value)
        {

        }
    };
}
