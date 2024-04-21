namespace display_graphic_generator
{
    partial class Form7Segment
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.appeaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantityDisplay1ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.quantityDisplay2ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varName7textBox = new System.Windows.Forms.TextBox();
            this.varNameTextBox = new System.Windows.Forms.Label();
            this.varContentLabel = new System.Windows.Forms.Label();
            this.varContentTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.negativeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appeaToolStripMenuItem,
            this.functionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // appeaToolStripMenuItem
            // 
            this.appeaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayColorToolStripMenuItem,
            this.displayQuantityToolStripMenuItem});
            this.appeaToolStripMenuItem.Name = "appeaToolStripMenuItem";
            this.appeaToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.appeaToolStripMenuItem.Text = "appearance";
            // 
            // displayColorToolStripMenuItem
            // 
            this.displayColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.yellowToolStripMenuItem});
            this.displayColorToolStripMenuItem.Name = "displayColorToolStripMenuItem";
            this.displayColorToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.displayColorToolStripMenuItem.Text = "display color";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Checked = true;
            this.redToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.redToolStripMenuItem.Text = "red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.blueToolStripMenuItem.Text = "blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.greenToolStripMenuItem.Text = "green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.yellowToolStripMenuItem.Text = "yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // displayQuantityToolStripMenuItem
            // 
            this.displayQuantityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quantityDisplay1ToolStrip,
            this.quantityDisplay2ToolStrip});
            this.displayQuantityToolStripMenuItem.Name = "displayQuantityToolStripMenuItem";
            this.displayQuantityToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.displayQuantityToolStripMenuItem.Text = "display quantity";
            // 
            // quantityDisplay1ToolStrip
            // 
            this.quantityDisplay1ToolStrip.Checked = true;
            this.quantityDisplay1ToolStrip.CheckOnClick = true;
            this.quantityDisplay1ToolStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.quantityDisplay1ToolStrip.Name = "quantityDisplay1ToolStrip";
            this.quantityDisplay1ToolStrip.Size = new System.Drawing.Size(100, 26);
            this.quantityDisplay1ToolStrip.Text = "1";
            this.quantityDisplay1ToolStrip.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // quantityDisplay2ToolStrip
            // 
            this.quantityDisplay2ToolStrip.Name = "quantityDisplay2ToolStrip";
            this.quantityDisplay2ToolStrip.Size = new System.Drawing.Size(100, 26);
            this.quantityDisplay2ToolStrip.Text = "2";
            this.quantityDisplay2ToolStrip.Click += new System.EventHandler(this.quantityDisplay2ToolStrip_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoRefreshToolStripMenuItem,
            this.negativeToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.functionsToolStripMenuItem.Text = "functions";
            // 
            // autoRefreshToolStripMenuItem
            // 
            this.autoRefreshToolStripMenuItem.Checked = true;
            this.autoRefreshToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRefreshToolStripMenuItem.Name = "autoRefreshToolStripMenuItem";
            this.autoRefreshToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.autoRefreshToolStripMenuItem.Text = "auto refresh";
            this.autoRefreshToolStripMenuItem.Click += new System.EventHandler(this.autoRefreshToolStripMenuItem_Click);
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Checked = true;
            this.negativeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.negativeToolStripMenuItem.Text = "negative";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // varName7textBox
            // 
            this.varName7textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.varName7textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.varName7textBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varName7textBox.Location = new System.Drawing.Point(452, 96);
            this.varName7textBox.Name = "varName7textBox";
            this.varName7textBox.Size = new System.Drawing.Size(323, 26);
            this.varName7textBox.TabIndex = 1;
            this.varName7textBox.Text = "varName";
            this.varName7textBox.ModifiedChanged += new System.EventHandler(this.varName7textBox_ModifiedChanged);
            this.varName7textBox.Enter += new System.EventHandler(this.varName7textBox_Enter);
            // 
            // varNameTextBox
            // 
            this.varNameTextBox.AutoSize = true;
            this.varNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varNameTextBox.Location = new System.Drawing.Point(447, 68);
            this.varNameTextBox.Name = "varNameTextBox";
            this.varNameTextBox.Size = new System.Drawing.Size(134, 25);
            this.varNameTextBox.TabIndex = 2;
            this.varNameTextBox.Text = "variable name";
            this.varNameTextBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // varContentLabel
            // 
            this.varContentLabel.AutoSize = true;
            this.varContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varContentLabel.Location = new System.Drawing.Point(447, 127);
            this.varContentLabel.Name = "varContentLabel";
            this.varContentLabel.Size = new System.Drawing.Size(149, 25);
            this.varContentLabel.TabIndex = 4;
            this.varContentLabel.Text = "variable content";
            // 
            // varContentTextBox
            // 
            this.varContentTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.varContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.varContentTextBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varContentTextBox.Location = new System.Drawing.Point(452, 155);
            this.varContentTextBox.Multiline = true;
            this.varContentTextBox.Name = "varContentTextBox";
            this.varContentTextBox.Size = new System.Drawing.Size(323, 235);
            this.varContentTextBox.TabIndex = 3;
            this.varContentTextBox.Text = "uint8_t varName0 = B11111111;";
            this.varContentTextBox.TextChanged += new System.EventHandler(this.tabContentTextBox_TextChanged);
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateButton.Location = new System.Drawing.Point(674, 397);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(100, 31);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // negativeButton
            // 
            this.negativeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.negativeButton.Location = new System.Drawing.Point(563, 397);
            this.negativeButton.Name = "negativeButton";
            this.negativeButton.Size = new System.Drawing.Size(100, 31);
            this.negativeButton.TabIndex = 6;
            this.negativeButton.Text = "negative";
            this.negativeButton.UseVisualStyleBackColor = true;
            this.negativeButton.Click += new System.EventHandler(this.negativeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(452, 396);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 31);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form7Segment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.negativeButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.varContentLabel);
            this.Controls.Add(this.varContentTextBox);
            this.Controls.Add(this.varNameTextBox);
            this.Controls.Add(this.varName7textBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form7Segment";
            this.Text = "7 segment";
            this.Load += new System.EventHandler(this.Form7Segment_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem appeaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayQuantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantityDisplay1ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem quantityDisplay2ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoRefreshToolStripMenuItem;
        private System.Windows.Forms.TextBox varName7textBox;
        private System.Windows.Forms.Label varNameTextBox;
        private System.Windows.Forms.Label varContentLabel;
        private System.Windows.Forms.TextBox varContentTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button negativeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
    }
}