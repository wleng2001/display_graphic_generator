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
            this.generateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabNameTextBox
            // 
            this.tabNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabNameTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabNameTextBox.Location = new System.Drawing.Point(419, 58);
            this.tabNameTextBox.Name = "tabNameTextBox";
            this.tabNameTextBox.Size = new System.Drawing.Size(334, 27);
            this.tabNameTextBox.TabIndex = 0;
            this.tabNameTextBox.Text = "tabName";
            this.tabNameTextBox.TextChanged += new System.EventHandler(this.tabNameTextBox_TextChanged);
            // 
            // tabContentTextBox
            // 
            this.tabContentTextBox.AcceptsTab = true;
            this.tabContentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(662, 390);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(91, 39);
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
        private System.Windows.Forms.Button generateButton;
    }
}