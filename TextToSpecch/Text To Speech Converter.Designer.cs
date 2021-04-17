namespace TextToSpecch
{
    partial class TextToSpeech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextToSpeech));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.trkSpeed = new System.Windows.Forms.TrackBar();
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnResume = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnRecord = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(776, 257);
            this.textBox1.TabIndex = 0;
            // 
            // trkVolume
            // 
            this.trkVolume.Location = new System.Drawing.Point(202, 309);
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Size = new System.Drawing.Size(127, 45);
            this.trkVolume.TabIndex = 1;
            // 
            // trkSpeed
            // 
            this.trkSpeed.Location = new System.Drawing.Point(36, 309);
            this.trkSpeed.Name = "trkSpeed";
            this.trkSpeed.Size = new System.Drawing.Size(131, 45);
            this.trkSpeed.TabIndex = 2;
            // 
            // BtnRead
            // 
            this.BtnRead.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnRead.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRead.Location = new System.Drawing.Point(455, 385);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(75, 25);
            this.BtnRead.TabIndex = 3;
            this.BtnRead.Text = "Convert";
            this.BtnRead.UseVisualStyleBackColor = false;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnPause.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPause.Location = new System.Drawing.Point(536, 385);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(75, 25);
            this.BtnPause.TabIndex = 4;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = false;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnResume
            // 
            this.BtnResume.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnResume.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnResume.Location = new System.Drawing.Point(617, 385);
            this.BtnResume.Name = "BtnResume";
            this.BtnResume.Size = new System.Drawing.Size(75, 25);
            this.BtnResume.TabIndex = 5;
            this.BtnResume.Text = "Resume";
            this.BtnResume.UseVisualStyleBackColor = false;
            this.BtnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnOpen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnOpen.Location = new System.Drawing.Point(455, 414);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(75, 25);
            this.BtnOpen.TabIndex = 6;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = false;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnRecord
            // 
            this.BtnRecord.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnRecord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRecord.Location = new System.Drawing.Point(536, 414);
            this.BtnRecord.Name = "BtnRecord";
            this.BtnRecord.Size = new System.Drawing.Size(75, 25);
            this.BtnRecord.TabIndex = 7;
            this.BtnRecord.Text = "Save";
            this.BtnRecord.UseVisualStyleBackColor = false;
            this.BtnRecord.Click += new System.EventHandler(this.BtnRecord_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnExit.Location = new System.Drawing.Point(617, 414);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 25);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.DropDownWidth = 150;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 387);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Voice Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Volume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Voices";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(413, 294);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(375, 48);
            this.axWindowsMediaPlayer1.TabIndex = 14;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // TextToSpeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnRecord);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.BtnResume);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.trkSpeed);
            this.Controls.Add(this.trkVolume);
            this.Controls.Add(this.textBox1);
            this.Name = "TextToSpeech";
            this.Text = "Text Converter";
            this.Load += new System.EventHandler(this.TextToSpeech_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.TrackBar trkSpeed;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnResume;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnRecord;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

