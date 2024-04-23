using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace display_graphic_generator
{
    internal class buttonMatrix
    {
        private int width;
        private int height;
        private int row;
        private int col;
        private Button[,] buttons;
        public Button[,] Buttons 
        { 
            get
            { 
                return buttons;
            }
            set { } 
        }

        public Button this[int col, int row]
        {
            get
            {
                return buttons[row, col];
            }
            set { }
        }
        private int buttonWidth = 5;
        public int ButtonWidth
        {
            get
            {
                return buttonWidth;
            }
            set
            {
                if(buttonWidth != value) 
                { 
                    buttonWidth = value;
                }
            }
        }
        private int buttonHeight = 5;
        public int ButtonHeight
        {
            get
            {
                return buttonHeight;
            }
            set
            {
                if (buttonHeight != value)
                {
                    buttonHeight = value;
                }
            }
        }
        bool[,] status;
        public Color muteColor = Color.Gray;
        public Color MuteColor
        {
            get
            {
                return muteColor;
            }
            set
            {
                muteColor = value;
                foreach (Button button in buttons)
                {
                    if (!(button.BackColor == shineColor))
                    {
                        button.BackColor = muteColor;
                    }
                }
            }
        }
        private Color shineColor = Color.White;
        public Color ShineColor
        {
            get
            {
                return shineColor;
            }
            set 
            {
                shineColor = value;
                foreach(Button button in buttons)
                {
                    if(!(button.BackColor == muteColor))
                    {
                        button.BackColor = shineColor;
                    }
                }
            }
        }
        public Color borderColor = Color.FromArgb(64,64,64);
        public bool update = true;
        public delegate void buttonClickTask(bool update);
        public buttonClickTask ButtonClickTask;

        int takeNumber(string text, int place)
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
        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int col = takeNumber(b.Name, 0);
            int row = takeNumber(b.Name, col.ToString().Length+1);
            status[col, row] =! status[col, row];
            if(b.BackColor == muteColor)
            {
                b.BackColor = shineColor;
            }
            else
            {
                b.BackColor = muteColor;
            }
            if(ButtonClickTask != null)
                ButtonClickTask(update);
        }
        public buttonMatrix(int col, int row)
        {
            this.col = row;
            this.row = col;
            buttons = new Button[this.col, this.row];
            status = new bool[this.col, this.row];
            for(int i = 0; i< buttons.GetLength(0); i++)
            {
                for(int j = 0; j< buttons.GetLength(1); j++)
                {
                    buttons[i, j] = new Button();
                    Button b = buttons[i, j];
                    b.BackColor = muteColor;
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderColor = borderColor;
                    b.Name = i + " " + j;
                    b.Click += buttonClick;
                    b.Size  = new Size(buttonWidth, buttonHeight);
                }

            }
            restartStatus();
        }

        public void setLocation(int width, int height)
        {
            this.width = width;
            this.height = height;
            for(int i = 0;i< buttons.GetLength(0); i++)
            {
                for(int j = 0;j< buttons.GetLength(1); j++)
                {
                    Button b = buttons[i,j];
                    b.Size = new Size(buttonWidth, buttonHeight);
                    b.Location = new Point(width+buttonWidth*i, height+buttonHeight*j);
                }
            }
        }

        private void restartStatus(bool negative = false)
        {
            for (int i = 0; i< status.GetLength(0); i++)
            {
                for(int j = 0; j< status.GetLength(1); j++)
                {
                    status[i,j] = negative;
                }
            }
        }

        private void restartButtons(bool negative = false)
        {
            foreach(Button button in buttons)
            {
                if(negative)
                {
                    button.BackColor = shineColor;
                }
                else
                {
                    button.BackColor= muteColor;
                }
            }
        }

        public void restart(bool negative = false)
        {
            restartStatus(negative);
            restartButtons(negative);
        }

        public void hideButtons()
        {
            foreach(Button button in buttons)
            {
                button.Hide();
            }
        }
        public void showButton()
        {
            foreach (Button button in buttons)
            {
                button.Show();
            }
        }
        public void remove()
        {
            foreach(Button b in buttons)
            {
                b.Dispose();
            }
        }
    }
}
