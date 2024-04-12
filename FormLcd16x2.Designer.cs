namespace display_graphic_generator
{
    partial class FormLcd16x2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabNameTextBox = new System.Windows.Forms.TextBox();
            this.tabContentTextBox = new System.Windows.Forms.TextBox();
            this.tabNameLabel = new System.Windows.Forms.Label();
            this.tableContentLabel = new System.Windows.Forms.Label();
            this.char0x0Button = new System.Windows.Forms.Button();
            this.char0x1Button = new System.Windows.Forms.Button();
            this.char0x2Button = new System.Windows.Forms.Button();
            this.char0x4Button = new System.Windows.Forms.Button();
            this.char0x3Button = new System.Windows.Forms.Button();
            this.char1x4Button = new System.Windows.Forms.Button();
            this.char1x3Button = new System.Windows.Forms.Button();
            this.char1x2Button = new System.Windows.Forms.Button();
            this.char1x1Button = new System.Windows.Forms.Button();
            this.char1x0Button = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabNameTextBox
            // 
            this.tabNameTextBox.BackColor = System.Drawing.Color.White;
            this.tabNameTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabNameTextBox.Location = new System.Drawing.Point(419, 58);
            this.tabNameTextBox.Name = "tabNameTextBox";
            this.tabNameTextBox.Size = new System.Drawing.Size(334, 27);
            this.tabNameTextBox.TabIndex = 0;
            this.tabNameTextBox.Text = "tabName";
            // 
            // tabContentTextBox
            // 
            this.tabContentTextBox.AcceptsTab = true;
            this.tabContentTextBox.BackColor = System.Drawing.Color.White;
            this.tabContentTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabContentTextBox.Location = new System.Drawing.Point(419, 116);
            this.tabContentTextBox.Multiline = true;
            this.tabContentTextBox.Name = "tabContentTextBox";
            this.tabContentTextBox.Size = new System.Drawing.Size(334, 268);
            this.tabContentTextBox.TabIndex = 1;
            this.tabContentTextBox.Text = "uint8_t tabName[] = {\r\n    B00000000,\r\n    B00000000,\r\n    B00000000,\r\n    B00000" +
    "000,\r\n    B00000000,\r\n    B00000000,\r\n    B00000000,\r\n    B00000000\r\n};";
            this.tabContentTextBox.TextChanged += new System.EventHandler(this.tabContentTextBox_TextChanged);
            // 
            // tabNameLabel
            // 
            this.tabNameLabel.AutoSize = true;
            this.tabNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabNameLabel.Location = new System.Drawing.Point(414, 30);
            this.tabNameLabel.Name = "tabNameLabel";
            this.tabNameLabel.Size = new System.Drawing.Size(108, 25);
            this.tabNameLabel.TabIndex = 2;
            this.tabNameLabel.Text = "table name";
            // 
            // tableContentLabel
            // 
            this.tableContentLabel.AutoSize = true;
            this.tableContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableContentLabel.Location = new System.Drawing.Point(414, 88);
            this.tableContentLabel.Name = "tableContentLabel";
            this.tableContentLabel.Size = new System.Drawing.Size(123, 25);
            this.tableContentLabel.TabIndex = 3;
            this.tableContentLabel.Text = "table content";
            // 
            // char0x0Button
            // 
            this.char0x0Button.BackColor = System.Drawing.Color.Lime;
            this.char0x0Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.char0x0Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.char0x0Button.Location = new System.Drawing.Point(135, 85);
            this.char0x0Button.Name = "char0x0Button";
            this.char0x0Button.Size = new System.Drawing.Size(30, 30);
            this.char0x0Button.TabIndex = 10;
            this.char0x0Button.UseVisualStyleBackColor = false;
            this.char0x0Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // char0x1Button
            // 
            this.char0x1Button.BackColor = System.Drawing.Color.Lime;
            this.char0x1Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.char0x1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.char0x1Button.Location = new System.Drawing.Point(165, 85);
            this.char0x1Button.Name = "char0x1Button";
            this.char0x1Button.Size = new System.Drawing.Size(30, 30);
            this.char0x1Button.TabIndex = 11;
            this.char0x1Button.UseVisualStyleBackColor = false;
            this.char0x1Button.Click += new System.EventHandler(this.char0x1Button_Click);
            // 
            // char0x2Button
            // 
            this.char0x2Button.BackColor = System.Drawing.Color.Lime;
            this.char0x2Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.char0x2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.char0x2Button.Location = new System.Drawing.Point(195, 85);
            this.char0x2Button.Name = "char0x2Button";
            this.char0x2Button.Size = new System.Drawing.Size(30, 30);
            this.char0x2Button.TabIndex = 12;
            this.char0x2Button.UseVisualStyleBackColor = false;
            this.char0x2Button.Click += new System.EventHandler(this.char0x2Button_Click);
            // 
            // char0x4Button
            // 
            this.char0x4Button.BackColor = System.Drawing.Color.Lime;
            this.char0x4Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.char0x4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.char0x4Button.Location = new System.Drawing.Point(255, 85);
            this.char0x4Button.Name = "char0x4Button";
            this.char0x4Button.Size = new System.Drawing.Size(30, 30);
            this.char0x4Button.TabIndex = 14;
            this.char0x4Button.UseVisualStyleBackColor = false;
            this.char0x4Button.Click += new System.EventHandler(this.char0x4Button_Click);
            // 
            // char0x3Button
            // 
            this.char0x3Button.BackColor = System.Drawing.Color.Lime;
            this.char0x3Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.char0x3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.char0x3Button.Location = new System.Drawing.Point(225, 85);
            this.char0x3Button.Name = "char0x3Button";
            this.char0x3Button.Size = new System.Drawing.Size(30, 30);
            this.char0x3Button.TabIndex = 13;
            this.char0x3Button.UseVisualStyleBackColor = false;
            this.char0x3Button.Click += new System.EventHandler(this.char0x3Button_Click);
            // 
            // char1x4Button
            // 
            this.char1x4Button.BackColor = System.Drawing.Color.Lime;
            this.char1x4Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.char1x4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.char1x4Button.Location = new System.Drawing.Point(255, 115);
            this.char1x4Button.Name = "char1x4Button";
            this.char1x4Button.Size = new System.Drawing.Size(30, 30);
            this.char1x4Button.TabIndex = 19;
            this.char1x4Button.UseVisualStyleBackColor = false;
            // 
            // char1x3Button
            // 
            this.char1x3Button.BackColor = System.Drawing.Color.Lime;
            this.char1x3Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.char1x3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.char1x3Button.Location = new System.Drawing.Point(225, 115);
            this.char1x3Button.Name = "char1x3Button";
            this.char1x3Button.Size = new System.Drawing.Size(30, 30);
            this.char1x3Button.TabIndex = 18;
            this.char1x3Button.UseVisualStyleBackColor = false;
            // 
            // char1x2Button
            // 
            this.char1x2Button.BackColor = System.Drawing.Color.Lime;
            this.char1x2Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.char1x2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.char1x2Button.Location = new System.Drawing.Point(195, 115);
            this.char1x2Button.Name = "char1x2Button";
            this.char1x2Button.Size = new System.Drawing.Size(30, 30);
            this.char1x2Button.TabIndex = 17;
            this.char1x2Button.UseVisualStyleBackColor = false;
            // 
            // char1x1Button
            // 
            this.char1x1Button.BackColor = System.Drawing.Color.Lime;
            this.char1x1Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.char1x1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.char1x1Button.Location = new System.Drawing.Point(165, 115);
            this.char1x1Button.Name = "char1x1Button";
            this.char1x1Button.Size = new System.Drawing.Size(30, 30);
            this.char1x1Button.TabIndex = 16;
            this.char1x1Button.UseVisualStyleBackColor = false;
            // 
            // char1x0Button
            // 
            this.char1x0Button.BackColor = System.Drawing.Color.Lime;
            this.char1x0Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.char1x0Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.char1x0Button.Location = new System.Drawing.Point(135, 115);
            this.char1x0Button.Name = "char1x0Button";
            this.char1x0Button.Size = new System.Drawing.Size(30, 30);
            this.char1x0Button.TabIndex = 15;
            this.char1x0Button.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Lime;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(255, 175);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(30, 30);
            this.button11.TabIndex = 29;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Lime;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(225, 175);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(30, 30);
            this.button12.TabIndex = 28;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Lime;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(195, 175);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(30, 30);
            this.button13.TabIndex = 27;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Lime;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(165, 175);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(30, 30);
            this.button14.TabIndex = 26;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Lime;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(135, 175);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(30, 30);
            this.button15.TabIndex = 25;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Lime;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(255, 145);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(30, 30);
            this.button16.TabIndex = 24;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Lime;
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(225, 145);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(30, 30);
            this.button17.TabIndex = 23;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Lime;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(195, 145);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(30, 30);
            this.button18.TabIndex = 22;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Lime;
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(165, 145);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(30, 30);
            this.button19.TabIndex = 21;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Lime;
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(135, 145);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(30, 30);
            this.button20.TabIndex = 20;
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Lime;
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Location = new System.Drawing.Point(255, 295);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(30, 30);
            this.button21.TabIndex = 49;
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Lime;
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Location = new System.Drawing.Point(225, 295);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(30, 30);
            this.button22.TabIndex = 48;
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Lime;
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Location = new System.Drawing.Point(195, 295);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(30, 30);
            this.button23.TabIndex = 47;
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Lime;
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Location = new System.Drawing.Point(165, 295);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(30, 30);
            this.button24.TabIndex = 46;
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Lime;
            this.button25.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Location = new System.Drawing.Point(135, 295);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(30, 30);
            this.button25.TabIndex = 45;
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Lime;
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Location = new System.Drawing.Point(255, 265);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(30, 30);
            this.button26.TabIndex = 44;
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Lime;
            this.button27.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Location = new System.Drawing.Point(225, 265);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(30, 30);
            this.button27.TabIndex = 43;
            this.button27.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Lime;
            this.button28.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Location = new System.Drawing.Point(195, 265);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(30, 30);
            this.button28.TabIndex = 42;
            this.button28.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Lime;
            this.button29.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Location = new System.Drawing.Point(165, 265);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(30, 30);
            this.button29.TabIndex = 41;
            this.button29.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.Lime;
            this.button30.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Location = new System.Drawing.Point(135, 265);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(30, 30);
            this.button30.TabIndex = 40;
            this.button30.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.Lime;
            this.button31.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Location = new System.Drawing.Point(255, 235);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(30, 30);
            this.button31.TabIndex = 39;
            this.button31.UseVisualStyleBackColor = false;
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.Lime;
            this.button32.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Location = new System.Drawing.Point(225, 235);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(30, 30);
            this.button32.TabIndex = 38;
            this.button32.UseVisualStyleBackColor = false;
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.Lime;
            this.button33.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Location = new System.Drawing.Point(195, 235);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(30, 30);
            this.button33.TabIndex = 37;
            this.button33.UseVisualStyleBackColor = false;
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.Lime;
            this.button34.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Location = new System.Drawing.Point(165, 235);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(30, 30);
            this.button34.TabIndex = 36;
            this.button34.UseVisualStyleBackColor = false;
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.Lime;
            this.button35.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Location = new System.Drawing.Point(135, 235);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(30, 30);
            this.button35.TabIndex = 35;
            this.button35.UseVisualStyleBackColor = false;
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.Lime;
            this.button36.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Location = new System.Drawing.Point(255, 205);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(30, 30);
            this.button36.TabIndex = 34;
            this.button36.UseVisualStyleBackColor = false;
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.Lime;
            this.button37.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.Location = new System.Drawing.Point(225, 205);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(30, 30);
            this.button37.TabIndex = 33;
            this.button37.UseVisualStyleBackColor = false;
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.Lime;
            this.button38.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button38.Location = new System.Drawing.Point(195, 205);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(30, 30);
            this.button38.TabIndex = 32;
            this.button38.UseVisualStyleBackColor = false;
            // 
            // button39
            // 
            this.button39.BackColor = System.Drawing.Color.Lime;
            this.button39.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button39.Location = new System.Drawing.Point(165, 205);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(30, 30);
            this.button39.TabIndex = 31;
            this.button39.UseVisualStyleBackColor = false;
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.Color.Lime;
            this.button40.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.Location = new System.Drawing.Point(135, 205);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(30, 30);
            this.button40.TabIndex = 30;
            this.button40.UseVisualStyleBackColor = false;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(678, 401);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 33);
            this.generateButton.TabIndex = 50;
            this.generateButton.Text = "generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.button41_Click);
            // 
            // FormLcd16x2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.char1x4Button);
            this.Controls.Add(this.char1x3Button);
            this.Controls.Add(this.char1x2Button);
            this.Controls.Add(this.char1x1Button);
            this.Controls.Add(this.char1x0Button);
            this.Controls.Add(this.char0x4Button);
            this.Controls.Add(this.char0x3Button);
            this.Controls.Add(this.char0x2Button);
            this.Controls.Add(this.char0x1Button);
            this.Controls.Add(this.char0x0Button);
            this.Controls.Add(this.tableContentLabel);
            this.Controls.Add(this.tabNameLabel);
            this.Controls.Add(this.tabContentTextBox);
            this.Controls.Add(this.tabNameTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLcd16x2";
            this.Text = "char";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.FormLcd16x2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tabNameTextBox;
        private System.Windows.Forms.TextBox tabContentTextBox;
        private System.Windows.Forms.Label tabNameLabel;
        private System.Windows.Forms.Label tableContentLabel;
        private System.Windows.Forms.Button char0x0Button;
        private System.Windows.Forms.Button char0x1Button;
        private System.Windows.Forms.Button char0x2Button;
        private System.Windows.Forms.Button char0x4Button;
        private System.Windows.Forms.Button char0x3Button;
        private System.Windows.Forms.Button char1x4Button;
        private System.Windows.Forms.Button char1x3Button;
        private System.Windows.Forms.Button char1x2Button;
        private System.Windows.Forms.Button char1x1Button;
        private System.Windows.Forms.Button char1x0Button;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button generateButton;
    }
}