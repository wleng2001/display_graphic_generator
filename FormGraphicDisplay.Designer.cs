namespace display_graphic_generator
{
    partial class FormGraphicDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGraphicDisplay));
            this.tabNameTextBox = new System.Windows.Forms.TextBox();
            this.tabNameLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.appearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixDimensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dimensions48x48ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dimensions10x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dimensionsOwnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabContentTextBox = new System.Windows.Forms.TextBox();
            this.tableContentLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.negativeButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNameTextBox
            // 
            this.tabNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabNameTextBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabNameTextBox.Location = new System.Drawing.Point(507, 56);
            this.tabNameTextBox.Name = "tabNameTextBox";
            this.tabNameTextBox.Size = new System.Drawing.Size(281, 26);
            this.tabNameTextBox.TabIndex = 0;
            this.tabNameTextBox.Text = "tabName";
            this.tabNameTextBox.TextChanged += new System.EventHandler(this.tabNameTextBox_TextChanged);
            // 
            // tabNameLabel
            // 
            this.tabNameLabel.AutoSize = true;
            this.tabNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabNameLabel.Location = new System.Drawing.Point(502, 28);
            this.tabNameLabel.Name = "tabNameLabel";
            this.tabNameLabel.Size = new System.Drawing.Size(108, 25);
            this.tabNameLabel.TabIndex = 1;
            this.tabNameLabel.Text = "table name";
            this.tabNameLabel.Click += new System.EventHandler(this.tabNameLabel_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(694, 415);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(90, 33);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appearanceToolStripMenuItem,
            this.functionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // appearanceToolStripMenuItem
            // 
            this.appearanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.matrixDimensionsToolStripMenuItem});
            this.appearanceToolStripMenuItem.Name = "appearanceToolStripMenuItem";
            this.appearanceToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.appearanceToolStripMenuItem.Text = "appearance";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.yellowToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.colorToolStripMenuItem.Text = "color";
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Checked = true;
            this.whiteToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.whiteToolStripMenuItem.Text = "white";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.blueToolStripMenuItem.Text = "blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.yellowToolStripMenuItem.Text = "yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // matrixDimensionsToolStripMenuItem
            // 
            this.matrixDimensionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dimensions48x48ToolStripMenuItem,
            this.dimensions10x10ToolStripMenuItem,
            this.dimensionsOwnToolStripMenuItem});
            this.matrixDimensionsToolStripMenuItem.Name = "matrixDimensionsToolStripMenuItem";
            this.matrixDimensionsToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.matrixDimensionsToolStripMenuItem.Text = "matrix dimensions";
            // 
            // dimensions48x48ToolStripMenuItem
            // 
            this.dimensions48x48ToolStripMenuItem.Checked = true;
            this.dimensions48x48ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dimensions48x48ToolStripMenuItem.Name = "dimensions48x48ToolStripMenuItem";
            this.dimensions48x48ToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.dimensions48x48ToolStripMenuItem.Text = "48x48";
            this.dimensions48x48ToolStripMenuItem.Click += new System.EventHandler(this.dimensions48x48ToolStripMenuItem_Click);
            // 
            // dimensions10x10ToolStripMenuItem
            // 
            this.dimensions10x10ToolStripMenuItem.Name = "dimensions10x10ToolStripMenuItem";
            this.dimensions10x10ToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.dimensions10x10ToolStripMenuItem.Text = "10x10";
            this.dimensions10x10ToolStripMenuItem.Click += new System.EventHandler(this.dimensions10x10ToolStripMenuItem_Click);
            // 
            // dimensionsOwnToolStripMenuItem
            // 
            this.dimensionsOwnToolStripMenuItem.Name = "dimensionsOwnToolStripMenuItem";
            this.dimensionsOwnToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.dimensionsOwnToolStripMenuItem.Text = "own";
            this.dimensionsOwnToolStripMenuItem.Click += new System.EventHandler(this.dimensionsOwnToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
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
            // tabContentTextBox
            // 
            this.tabContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabContentTextBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabContentTextBox.Location = new System.Drawing.Point(507, 113);
            this.tabContentTextBox.Multiline = true;
            this.tabContentTextBox.Name = "tabContentTextBox";
            this.tabContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tabContentTextBox.Size = new System.Drawing.Size(280, 296);
            this.tabContentTextBox.TabIndex = 1;
            this.tabContentTextBox.TextChanged += new System.EventHandler(this.tabContentTextBox_TextChanged);
            // 
            // tableContentLabel
            // 
            this.tableContentLabel.AutoSize = true;
            this.tableContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableContentLabel.Location = new System.Drawing.Point(502, 85);
            this.tableContentLabel.Name = "tableContentLabel";
            this.tableContentLabel.Size = new System.Drawing.Size(123, 25);
            this.tableContentLabel.TabIndex = 5;
            this.tableContentLabel.Text = "table content";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(507, 415);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 33);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // negativeButton
            // 
            this.negativeButton.Location = new System.Drawing.Point(601, 415);
            this.negativeButton.Name = "negativeButton";
            this.negativeButton.Size = new System.Drawing.Size(90, 33);
            this.negativeButton.TabIndex = 3;
            this.negativeButton.Text = "negative";
            this.negativeButton.UseVisualStyleBackColor = true;
            this.negativeButton.Click += new System.EventHandler(this.negativeButton_Click);
            // 
            // FormGraphicDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.negativeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.tableContentLabel);
            this.Controls.Add(this.tabContentTextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.tabNameLabel);
            this.Controls.Add(this.tabNameTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormGraphicDisplay";
            this.Text = "graphic";
            this.Load += new System.EventHandler(this.FormGraphicDisplay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tabNameTextBox;
        private System.Windows.Forms.Label tabNameLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem appearanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixDimensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoRefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dimensions48x48ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dimensions10x10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dimensionsOwnToolStripMenuItem;
        private System.Windows.Forms.TextBox tabContentTextBox;
        private System.Windows.Forms.Label tableContentLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button negativeButton;
    }
}