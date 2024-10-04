using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace display_graphic_generator
{

    public partial class Form7Segment : Form
    {
        static int yLocationDisplay = 125;
        static int xLocationDisplayAlone = 125;
        static int xLocationDisplayTwo = 65;
        byte displaysQuantity = 1;
        bool autoRefresh = true;
        segment7Display d1;
        segment7Display d2;
        segment7Display[] d = new segment7Display[2];
        Color shineColor = Color.Red;
        public Form7Segment()
        {
            d1 = new segment7Display(xLocationDisplayAlone, yLocationDisplay);
            d2 = new segment7Display(xLocationDisplayTwo + 130, yLocationDisplay);
            d[0] = d1;
            d[1] = d2;
            InitializeComponent();
            for(int i = 0; i < 8; i++)
            {
                Controls.Add(d1[i]);
            }
            d1.UpdateTab = generateTextBoxContent;
            d2.UpdateTab = generateTextBoxContent;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
                private void Form7Segment_Load(object sender, EventArgs e)
        {

        }

        private void DButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach(var i in d)
            {
                i.restart();
            }
            generateTextBoxContent(autoRefresh);

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            d1.delete();
            d2.delete();
            quantityDisplay1ToolStrip.Checked = true;
            quantityDisplay2ToolStrip.Checked = false;
            displaysQuantity = 1;
            d1 = new segment7Display(xLocationDisplayAlone, yLocationDisplay);
            d[0] = d1;
            d1.UpdateTab = generateTextBoxContent;
            d1.changeColor(shineColor);
            for (int i = 0;i < 8; i++)
            {
                Controls.Add(d1[i]);
            }
            generateTextBoxContent(autoRefresh);
        }

        private void quantityDisplay2ToolStrip_Click(object sender, EventArgs e)
        {
            d1.delete();
            d2.delete();
            quantityDisplay1ToolStrip.Checked = false;
            quantityDisplay2ToolStrip.Checked = true;
            displaysQuantity = 2;
            d1 = new segment7Display(xLocationDisplayTwo, yLocationDisplay);
            d2 = new segment7Display(xLocationDisplayTwo+130, yLocationDisplay);
            d[0] = d1;
            d[1] = d2;
            d1.UpdateTab = generateTextBoxContent;
            d2.UpdateTab = generateTextBoxContent;
            d1.changeColor(shineColor);
            d2.changeColor(shineColor);
            for (int i = 0; i < 8; i++)
            {
                Controls.Add(d1[i]);
                Controls.Add(d2[i]);
            }
            generateTextBoxContent(autoRefresh);
        }

        private void negativeButton_Click(object sender, EventArgs e)
        {
            foreach(var i in d)
            {
                i.restart(true);
            }
            generateTextBoxContent(autoRefresh);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d1.changeColor(Color.Red);
            d2.changeColor(Color.Red);
            shineColor = Color.Red;
            redToolStripMenuItem.Checked = true;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d1.changeColor(Color.Cyan);
            d2.changeColor(Color.Cyan);
            shineColor = Color.Cyan;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = true;
            greenToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d1.changeColor(Color.Lime);
            d2.changeColor(Color.Lime);
            shineColor = Color.Lime;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = true;
            yellowToolStripMenuItem.Checked = false;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d1.changeColor(Color.Yellow);
            d2.changeColor(Color.Yellow);
            shineColor = Color.Yellow;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = true;
        }

        private void tabContentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void generateTextBoxContent(bool refresh)
        {
            
            if (refresh)
            {
                varContentTextBox.Text = "";
                for (byte i = 0; i < displaysQuantity; i++)
                {
                    varContentTextBox.Text += "uint8_t " + varName7textBox.Text+i+" = 0b";
                    for(byte k = 8; k>0; k--)
                    {
                        bool j = d[i].Status[k-1];
                        if (j)
                        {
                            varContentTextBox.Text += "1";
                        }
                        else
                        {
                            varContentTextBox.Text += "0";
                        }
                    }
                    varContentTextBox.Text += ";\r\n";
                }
            }
        }
        private void generateButton_Click(object sender, EventArgs e)
        {
            generateTextBoxContent(true);
        }

        private void autoRefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autoRefreshToolStripMenuItem.Checked)
            {
                autoRefreshToolStripMenuItem.Checked = false;
                autoRefresh = false;


            }
            else
            {
                autoRefresh = true;
                autoRefreshToolStripMenuItem.Checked = true;
            }
            foreach (var d in d)
            {
                d.autoRefresh = autoRefresh;
            }
        }

        private void varName7textBox_Enter(object sender, EventArgs e)
        {
            generateTextBoxContent(autoRefresh);
        }

        private void varName7textBox_ModifiedChanged(object sender, EventArgs e)
        {
            generateTextBoxContent(autoRefresh);
        }

        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (negativeToolStripMenuItem.Checked)
            {
                negativeToolStripMenuItem.Checked = false;
                foreach(var d in d)
                {
                    d.PositiveDisplay = true;
                }
            }
            else
            {
                negativeToolStripMenuItem.Checked= true;
                foreach (var d in d)
                {
                    d.PositiveDisplay = false;
                }
            }
            generateTextBoxContent(autoRefresh);
        }

        private void varName7textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void varContentLabel_Click(object sender, EventArgs e)
        {

        }
    };

    public class segment7Display
    {
        public delegate void updateTab(bool update);
        public updateTab UpdateTab;
        public bool autoRefresh = true;
        Color clickColor = Color.Red;
        Color BackColor = Color.FromArgb(64, 64, 64);
        Color BorderColor = Color.Gray;
        Button[] buttons = new Button[8];
        private bool positiveDisplay;
        public bool PositiveDisplay
        {
            get
            {
                return positiveDisplay;
            }
            set
            {
                positiveDisplay = value;
                for(int i = 0;i < 8; i++)
                {
                    status[i] = !status[i];
                }
            }
        }
        private bool[] status = new bool[8];
        public bool[] Status
        {
            get { return status; }
            set { }
        }
        int thick = 15;
        int len = 50;

        public Button this[int i]
        {
            get
            {
                return buttons[i];
            }
            set
            {
                buttons[i] = value;
            }
        }

        public void setLocation(int x, int y)
        {
            //A
            buttons[0].Size = new Size(len, thick);
            buttons[0].Location = new Point(x + thick, y);
            //B
            buttons[1].Size = new Size(thick, len);
            buttons[1].Location = new Point(x + thick + len, y + thick);
            //C
            buttons[2].Size = new Size(thick, len);
            buttons[2].Location = new Point(x + thick + len, y + thick + len + thick);
            //D
            buttons[3].Size = new Size(len, thick);
            buttons[3].Location = new Point(x + thick, y + thick + len + thick + len);
            //E
            buttons[4].Size = new Size(thick, len);
            buttons[4].Location = new Point(x, y + thick + len + thick);
            //F
            buttons[5].Size = new Size(thick, len);
            buttons[5].Location = new Point(x, y + thick);
            //G
            buttons[6].Size = new Size(len, thick);
            buttons[6].Location = new Point(x + thick, y + thick + len);
            //DP
            buttons[7].Size = new Size(thick, thick);
            buttons[7].Location = new Point(x + thick + len + thick, y + thick + len + thick + len);
        }
        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int name = int.Parse(b.Name);

            if (b.BackColor == BackColor)
            {
                b.BackColor = clickColor;
                if (positiveDisplay)
                {
                    status[name] = true;
                }
                else
                {
                    status[name] = false;
                }
            }
            else
            {
                b.BackColor = BackColor;
                if (positiveDisplay)
                {
                    status[name] = false;
                }
                else
                {
                    status[name] = true;
                }
            }
            UpdateTab(autoRefresh);

        }
        public segment7Display(int x, int y, bool positiveDisplay = false)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button();
                buttons[i].BackColor = BackColor;
                buttons[i].FlatAppearance.BorderColor = BorderColor;
                buttons[i].FlatStyle = FlatStyle.Standard;
                buttons[i].Click += buttonClick;
                buttons[i].Name = i.ToString();
                if(positiveDisplay)
                {
                    status[i] = false;
                }
                else
                {
                    status[i] = true;
                }
            }
            setLocation(x, y);
            this.positiveDisplay = positiveDisplay;
        }

        private void restartStatus(bool negative = false)
        {
            bool restartStatus = negative;
            if (!PositiveDisplay)
            {
                restartStatus =! restartStatus;
            }
            for (int i = 0; i < status.Length; i++)
            {
                status[i] = restartStatus;
            }
        }
        public void changeColor(Color shineColor, Color muteColor)
        {
            clickColor = shineColor;
            BackColor = muteColor;
            foreach(var button in buttons)
            {
                if(button.BackColor == muteColor)
                {

                }
                else
                {
                    button.BackColor = shineColor;
                }
            }
        }

        public void changeColor(Color shineColor)
        {
            changeColor(shineColor, BackColor);
        }

        public void restartColor(bool negative)
        { 
            foreach(var button in buttons)
            {
                if (negative)
                {
                    button.BackColor = clickColor;
                }
                else
                {
                    button.BackColor = BackColor;
                }
            }
        }

        public void restart(bool negative = false)
        {
            bool value;
            Color tempBackColor = BackColor;
            restartStatus(negative);
            restartColor(negative);
            BackColor = tempBackColor;
        }

        public void delete(){
            foreach(var button in buttons)
            {
                button.Dispose();
            }
        }

    };
}
