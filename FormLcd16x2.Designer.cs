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
            this.outputTextTextBox = new System.Windows.Forms.TextBox();
            this.tabNameTextBox = new System.Windows.Forms.TextBox();
            this.labelTabName = new System.Windows.Forms.Label();
            this.LabelTabContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputTextTextBox
            // 
            this.outputTextTextBox.AcceptsTab = true;
            this.outputTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputTextTextBox.Location = new System.Drawing.Point(517, 140);
            this.outputTextTextBox.Multiline = true;
            this.outputTextTextBox.Name = "outputTextTextBox";
            this.outputTextTextBox.Size = new System.Drawing.Size(221, 259);
            this.outputTextTextBox.TabIndex = 0;
            // 
            // tabNameTextBox
            // 
            this.tabNameTextBox.Location = new System.Drawing.Point(517, 66);
            this.tabNameTextBox.Name = "tabNameTextBox";
            this.tabNameTextBox.Size = new System.Drawing.Size(221, 22);
            this.tabNameTextBox.TabIndex = 1;
            // 
            // labelTabName
            // 
            this.labelTabName.AutoSize = true;
            this.labelTabName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTabName.Location = new System.Drawing.Point(512, 27);
            this.labelTabName.Name = "labelTabName";
            this.labelTabName.Size = new System.Drawing.Size(108, 25);
            this.labelTabName.TabIndex = 2;
            this.labelTabName.Text = "table name";
            this.labelTabName.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelTabContent
            // 
            this.LabelTabContent.AutoSize = true;
            this.LabelTabContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelTabContent.Location = new System.Drawing.Point(512, 101);
            this.LabelTabContent.Name = "LabelTabContent";
            this.LabelTabContent.Size = new System.Drawing.Size(123, 25);
            this.LabelTabContent.TabIndex = 3;
            this.LabelTabContent.Text = "table content";
            // 
            // FormLcd16x2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelTabContent);
            this.Controls.Add(this.labelTabName);
            this.Controls.Add(this.tabNameTextBox);
            this.Controls.Add(this.outputTextTextBox);
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

        private System.Windows.Forms.TextBox outputTextTextBox;
        private System.Windows.Forms.TextBox tabNameTextBox;
        private System.Windows.Forms.Label labelTabName;
        private System.Windows.Forms.Label LabelTabContent;
    }
}