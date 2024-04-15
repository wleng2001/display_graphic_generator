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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.appearenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantityOfMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNameTextBox
            // 
            this.tabNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabNameTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabNameTextBox.Location = new System.Drawing.Point(419, 58);
            this.tabNameTextBox.Name = "tabNameTextBox";
            this.tabNameTextBox.Size = new System.Drawing.Size(334, 27);
            this.tabNameTextBox.TabIndex = 0;
            this.tabNameTextBox.Text = "tabName";
            this.tabNameTextBox.TextChanged += new System.EventHandler(this.tabNameTextBox_Enter);
            this.tabNameTextBox.Enter += new System.EventHandler(this.tabNameTextBox_Enter);
            // 
            // tabContentTextBox
            // 
            this.tabContentTextBox.AcceptsTab = true;
            this.tabContentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabContentTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabContentTextBox.Location = new System.Drawing.Point(419, 116);
            this.tabContentTextBox.Multiline = true;
            this.tabContentTextBox.Name = "tabContentTextBox";
            this.tabContentTextBox.Size = new System.Drawing.Size(334, 268);
            this.tabContentTextBox.TabIndex = 1;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appearenceToolStripMenuItem,
            this.functionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // appearenceToolStripMenuItem
            // 
            this.appearenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matrixColorToolStripMenuItem,
            this.quantityOfMatrixToolStripMenuItem});
            this.appearenceToolStripMenuItem.Name = "appearenceToolStripMenuItem";
            this.appearenceToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.appearenceToolStripMenuItem.Text = "appearence";
            this.appearenceToolStripMenuItem.Click += new System.EventHandler(this.appearenceToolStripMenuItem_Click);
            // 
            // matrixColorToolStripMenuItem
            // 
            this.matrixColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greyToolStripMenuItem});
            this.matrixColorToolStripMenuItem.Name = "matrixColorToolStripMenuItem";
            this.matrixColorToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.matrixColorToolStripMenuItem.Text = "matrix color";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.redToolStripMenuItem.Text = "red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Checked = true;
            this.greenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.greenToolStripMenuItem.Text = "green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.blueToolStripMenuItem.Text = "blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greyToolStripMenuItem
            // 
            this.greyToolStripMenuItem.Name = "greyToolStripMenuItem";
            this.greyToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.greyToolStripMenuItem.Text = "gray";
            this.greyToolStripMenuItem.Click += new System.EventHandler(this.greyToolStripMenuItem_Click);
            // 
            // quantityOfMatrixToolStripMenuItem
            // 
            this.quantityOfMatrixToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5});
            this.quantityOfMatrixToolStripMenuItem.Name = "quantityOfMatrixToolStripMenuItem";
            this.quantityOfMatrixToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.quantityOfMatrixToolStripMenuItem.Text = "quantity of matrix";
            this.quantityOfMatrixToolStripMenuItem.Click += new System.EventHandler(this.quantityOfMatrixToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.Checked = true;
            this.functionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoRefreshToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.functionsToolStripMenuItem.Text = "functions";
            // 
            // autoRefreshToolStripMenuItem
            // 
            this.autoRefreshToolStripMenuItem.Checked = true;
            this.autoRefreshToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRefreshToolStripMenuItem.Name = "autoRefreshToolStripMenuItem";
            this.autoRefreshToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.autoRefreshToolStripMenuItem.Text = "auto refresh";
            this.autoRefreshToolStripMenuItem.Click += new System.EventHandler(this.autoRefreshToolStripMenuItem_Click);
            // 
            // negativeButton
            // 
            this.negativeButton.Location = new System.Drawing.Point(541, 390);
            this.negativeButton.Name = "negativeButton";
            this.negativeButton.Size = new System.Drawing.Size(91, 39);
            this.negativeButton.TabIndex = 52;
            this.negativeButton.Text = "negative";
            this.negativeButton.UseVisualStyleBackColor = true;
            this.negativeButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(419, 390);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(91, 39);
            this.clearButton.TabIndex = 53;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // FormLcd16x2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.negativeButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.tableContentLabel);
            this.Controls.Add(this.tabNameLabel);
            this.Controls.Add(this.tabContentTextBox);
            this.Controls.Add(this.tabNameTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormLcd16x2";
            this.Text = "char";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.FormLcd16x2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tabNameTextBox;
        private System.Windows.Forms.TextBox tabContentTextBox;
        private System.Windows.Forms.Label tabNameLabel;
        private System.Windows.Forms.Label tableContentLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem appearenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantityOfMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Button negativeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoRefreshToolStripMenuItem;
    }
}