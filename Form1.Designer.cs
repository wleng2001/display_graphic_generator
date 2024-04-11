namespace display_graphic_generator
{
    partial class chooseDisplayForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chooseDisplayForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lcd16x2Picture = new System.Windows.Forms.PictureBox();
            this.graphicDisplayPicture = new System.Windows.Forms.PictureBox();
            this.segment7Picture = new System.Windows.Forms.PictureBox();
            this.radioLcd16x2 = new System.Windows.Forms.RadioButton();
            this.radioGraphicDisplay = new System.Windows.Forms.RadioButton();
            this.radio7Segment = new System.Windows.Forms.RadioButton();
            this.confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lcd16x2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphicDisplayPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment7Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(268, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose display type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lcd16x2Picture
            // 
            this.lcd16x2Picture.Image = ((System.Drawing.Image)(resources.GetObject("lcd16x2Picture.Image")));
            this.lcd16x2Picture.Location = new System.Drawing.Point(37, 105);
            this.lcd16x2Picture.Name = "lcd16x2Picture";
            this.lcd16x2Picture.Size = new System.Drawing.Size(220, 220);
            this.lcd16x2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lcd16x2Picture.TabIndex = 1;
            this.lcd16x2Picture.TabStop = false;
            // 
            // graphicDisplayPicture
            // 
            this.graphicDisplayPicture.Image = ((System.Drawing.Image)(resources.GetObject("graphicDisplayPicture.Image")));
            this.graphicDisplayPicture.Location = new System.Drawing.Point(290, 105);
            this.graphicDisplayPicture.Name = "graphicDisplayPicture";
            this.graphicDisplayPicture.Size = new System.Drawing.Size(220, 220);
            this.graphicDisplayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.graphicDisplayPicture.TabIndex = 2;
            this.graphicDisplayPicture.TabStop = false;
            // 
            // segment7Picture
            // 
            this.segment7Picture.Image = ((System.Drawing.Image)(resources.GetObject("segment7Picture.Image")));
            this.segment7Picture.Location = new System.Drawing.Point(540, 105);
            this.segment7Picture.Name = "segment7Picture";
            this.segment7Picture.Size = new System.Drawing.Size(220, 220);
            this.segment7Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.segment7Picture.TabIndex = 3;
            this.segment7Picture.TabStop = false;
            // 
            // radioLcd16x2
            // 
            this.radioLcd16x2.AutoSize = true;
            this.radioLcd16x2.Location = new System.Drawing.Point(114, 340);
            this.radioLcd16x2.Name = "radioLcd16x2";
            this.radioLcd16x2.Size = new System.Drawing.Size(54, 20);
            this.radioLcd16x2.TabIndex = 4;
            this.radioLcd16x2.TabStop = true;
            this.radioLcd16x2.Text = "char";
            this.radioLcd16x2.UseVisualStyleBackColor = true;
            this.radioLcd16x2.CheckedChanged += new System.EventHandler(this.radioLcd16x2_CheckedChanged);
            // 
            // radioGraphicDisplay
            // 
            this.radioGraphicDisplay.AutoSize = true;
            this.radioGraphicDisplay.Location = new System.Drawing.Point(364, 340);
            this.radioGraphicDisplay.Name = "radioGraphicDisplay";
            this.radioGraphicDisplay.Size = new System.Drawing.Size(73, 20);
            this.radioGraphicDisplay.TabIndex = 5;
            this.radioGraphicDisplay.TabStop = true;
            this.radioGraphicDisplay.Text = "graphic";
            this.radioGraphicDisplay.UseVisualStyleBackColor = true;
            this.radioGraphicDisplay.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radio7Segment
            // 
            this.radio7Segment.AutoSize = true;
            this.radio7Segment.Location = new System.Drawing.Point(603, 340);
            this.radio7Segment.Name = "radio7Segment";
            this.radio7Segment.Size = new System.Drawing.Size(90, 20);
            this.radio7Segment.TabIndex = 6;
            this.radio7Segment.TabStop = true;
            this.radio7Segment.Text = "7 segment";
            this.radio7Segment.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(692, 402);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(86, 39);
            this.confirm.TabIndex = 7;
            this.confirm.Text = "confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // chooseDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.radio7Segment);
            this.Controls.Add(this.radioGraphicDisplay);
            this.Controls.Add(this.radioLcd16x2);
            this.Controls.Add(this.segment7Picture);
            this.Controls.Add(this.graphicDisplayPicture);
            this.Controls.Add(this.lcd16x2Picture);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "chooseDisplayForm";
            this.Text = "display selection";
            this.Load += new System.EventHandler(this.chooseDisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcd16x2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphicDisplayPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment7Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox lcd16x2Picture;
        private System.Windows.Forms.PictureBox graphicDisplayPicture;
        private System.Windows.Forms.PictureBox segment7Picture;
        private System.Windows.Forms.RadioButton radioLcd16x2;
        private System.Windows.Forms.RadioButton radioGraphicDisplay;
        private System.Windows.Forms.RadioButton radio7Segment;
        private System.Windows.Forms.Button confirm;
    }
}

