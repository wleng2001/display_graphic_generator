namespace display_graphic_generator
{
    partial class dimensionsForm
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
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.widthLabel.Location = new System.Drawing.Point(40, 29);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(57, 25);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "width";
            this.widthLabel.Click += new System.EventHandler(this.widthLabel_Click);
            // 
            // widthTextBox
            // 
            this.widthTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.widthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthTextBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.widthTextBox.Location = new System.Drawing.Point(45, 73);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(46, 26);
            this.widthTextBox.TabIndex = 1;
            this.widthTextBox.Text = "6";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmButton.Location = new System.Drawing.Point(179, 116);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(94, 31);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // heightTextBox
            // 
            this.heightTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.heightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightTextBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.heightTextBox.Location = new System.Drawing.Point(185, 73);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(46, 26);
            this.heightTextBox.TabIndex = 2;
            this.heightTextBox.Text = "8";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.heightLabel.Location = new System.Drawing.Point(180, 29);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(65, 25);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "height";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xLabel.Location = new System.Drawing.Point(126, 73);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(26, 25);
            this.xLabel.TabIndex = 5;
            this.xLabel.Text = "X";
            // 
            // dimensionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 159);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.widthLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dimensionsForm";
            this.Text = "dimensions";
            this.Load += new System.EventHandler(this.dimensionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label xLabel;
    }
}