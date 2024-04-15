using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            btnPutOnForm(sender, e);
            tabContentTextBox.Text = "uint8_t tabName[] = {\r\n\tB00000000,\r\n\tB00000000,\r\n\tB00000000,\r\n\tB00000000,\r\n\tB00000000,\r\n\tB00000000,\r\n\tB00000000,\r\n\tB00000000,\r\n};";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button41_Click(object sender, EventArgs e)
        {
            tabContentTextBox.Text = "uint8_t "+tabNameTextBox.Text+"[] = {\n";
            for(int i = 0; i < lC.Content.Length; i++)
            {
                string number = Convert.ToString( lC.Content[i], toBase: 2).PadLeft(8,'0');
                tabContentTextBox.AppendText(Environment.NewLine);
                tabContentTextBox.AppendText( "\tB" + number+",");
            }
            tabContentTextBox.AppendText(Environment.NewLine);
            tabContentTextBox.Text +=  "};";
        }

        private void tabContentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void charMatrixflowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        lcdContent lC = new lcdContent(8);
        byte width = 20;
        byte height = 20;
        byte x = 100;
        byte y = 100;
        static byte quantityOfMatrix = 1;
        Button[,,] buttons = new Button[quantityOfMatrix,8,5];
        Color buttonBackColor = Color.Lime;
        Color buttonClickColor = Color.Gray;
        Color buttonBorderColor = Color.Green;
        byte takeNumber(string text, byte place)
        {
            string number = "";
            char letter = text[place];
            do
            {
                number += letter;
                place++;
                if (place < text.Length)
                    letter = text[place];
                else
                    break;
            } while (char.IsDigit(letter));
            return byte.Parse(number);
        }
        void bClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string name = b.Name;
            byte matrixNumber = takeNumber(name, 0);
            byte place = (byte)(takeNumber(name, 0).ToString().Length + 1);
            byte row = takeNumber(name, place);
            place += (byte)((row.ToString().Length) + 1);
            byte col = takeNumber(name, place);
            bool status = !lC.get(row, (byte)(4 - col));
            lC.set(row, (byte)(4-col), status);
            if (status == true)
                b.BackColor = buttonClickColor;
            else
                b.BackColor = buttonBackColor;
        }

        Button btn(string name, byte width, byte height)
        {
            Button b = new Button();
            b.Name = name;
            b.Size = new Size(width, height);
            b.BackColor = Color.Lime;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 1;
            b.FlatAppearance.BorderColor = Color.Green;
            b.Click += bClick;
            return b;
        }

        void generateButtonMatrix(byte matrixNumber, byte startPointY, byte startPointX)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button b = btn(matrixNumber.ToString()+" "+i.ToString() + " " + j.ToString(), width, height);
                    b.Location = new Point(startPointY + j * width, startPointX + i * height);
                    Controls.Add(b);
                    buttons[matrixNumber-1, i, j] = b;
                }
            }
        }
        private void btnPutOnForm(object sender, EventArgs e)
        {
            switch (quantityOfMatrix)
            {
                case 1:
                    generateButtonMatrix(1,x, y);
                    break;

                case 2:
                    generateButtonMatrix(1,(byte)(x-40), y);
                    generateButtonMatrix(2,(byte)(x - 40 + width * 5 + 5), y);
                    break;
                case 4:
                    generateButtonMatrix(1,(byte)(x - 40), (byte)(y - 70));
                    generateButtonMatrix(2,(byte)(x - 40+width*5+5), (byte)(y - 70));
                    generateButtonMatrix(3,(byte)(x - 40), (byte)(y - 70+height*8+5));
                    generateButtonMatrix(4,(byte)(x - 40 + width * 5 + 5), (byte)(y - 70 + height * 8 + 5));
                    break;
                default:
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            greenToolStripMenuItem.Checked = true;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greyToolStripMenuItem.Checked = false;
            buttonBackColor = Color.Lime;
            foreach (Button b in buttons)
            {
                b.BackColor= Color.Lime;
                b.FlatAppearance.BorderColor = Color.Green;
            }
        }

        private void appearenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            greenToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = true;
            blueToolStripMenuItem.Checked = false;
            greyToolStripMenuItem.Checked = false;
            buttonBackColor = Color.Red;
            foreach (Button b in buttons)
            {
                b.BackColor = Color.Red;
                b.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            greenToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = true;
            greyToolStripMenuItem.Checked = false;
            buttonBackColor = Color.FromArgb(0, 192, 192);
            foreach (Button b in buttons)
            {
                b.BackColor = Color.FromArgb(0,192,192);
                b.FlatAppearance.BorderColor = Color.FromArgb(0,64,64);
            }
        }

        private void greyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            greenToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greyToolStripMenuItem.Checked = true;
            buttonBackColor = Color.FromArgb(224, 224, 224);
            foreach (Button b in buttons)
            {
                b.BackColor = Color.FromArgb(224,224,224);
                b.FlatAppearance.BorderColor = Color.FromArgb(64,64,64);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Button b in buttons)
            {
                b.BackColor = buttonClickColor;
            }
            for (byte i = 0; i < 8; i++)
            {
                lC.Content[i] = 0xFF;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (Button b in buttons)
            {
                b.BackColor = buttonBackColor;
            }
            for(byte i = 0; i < 8; i++)
            {
                lC.Content[i] = 0;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            quantityOfMatrix = 1;
            
            btnPutOnForm(sender, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            quantityOfMatrix = 2;
            btnPutOnForm(sender, e);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            quantityOfMatrix = 4;
            btnPutOnForm(sender, e);
        }
    }
    public class lcdContent
    {
        private byte[] content;
        public lcdContent(byte rows)
        {
            this.content = new byte[rows];

            for (int i = 0; i < this.content.Length; i++)
            {
                content[i] = 0;
            }
        }
        public byte[] Content
        {
            get { return content; }
            set { }
        }
        public void set(byte row, byte col, bool value)
        {
            byte mask = (byte)(1 << col);
            if (value == true)
                content[row] |= mask;
            else
                content[row] &= (byte)~mask;
        }

        public bool get(byte row, byte col)
        {
            byte rowValue = content[row];
            bool value = false;
            if ((rowValue & ( 1 << col)) > 0)
                value = true;

            return value;
            
        }
    };
}
