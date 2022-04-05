namespace Formos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skaicius1 = new System.Windows.Forms.TextBox();
            this.skaicius2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pirmasLabel = new System.Windows.Forms.Label();
            this.antrasLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ats = new System.Windows.Forms.TextBox();
            this.atsLabel = new System.Windows.Forms.Label();
            this.dauginam = new System.Windows.Forms.Button();
            this.dalinam = new System.Windows.Forms.Button();
            this.atimam = new System.Windows.Forms.Button();
            this.sudedam = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.laikas = new System.Windows.Forms.ProgressBar();
            this.stop = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.laikoText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // skaicius1
            // 
            this.skaicius1.Location = new System.Drawing.Point(128, 33);
            this.skaicius1.Name = "skaicius1";
            this.skaicius1.Size = new System.Drawing.Size(97, 27);
            this.skaicius1.TabIndex = 0;
            // 
            // skaicius2
            // 
            this.skaicius2.Location = new System.Drawing.Point(128, 72);
            this.skaicius2.Name = "skaicius2";
            this.skaicius2.Size = new System.Drawing.Size(97, 27);
            this.skaicius2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pabandom";
            // 
            // pirmasLabel
            // 
            this.pirmasLabel.AutoSize = true;
            this.pirmasLabel.Location = new System.Drawing.Point(11, 36);
            this.pirmasLabel.Name = "pirmasLabel";
            this.pirmasLabel.Size = new System.Drawing.Size(111, 20);
            this.pirmasLabel.TabIndex = 9;
            this.pirmasLabel.Text = "pirmas skaicius:";
            // 
            // antrasLabel
            // 
            this.antrasLabel.AutoSize = true;
            this.antrasLabel.Location = new System.Drawing.Point(16, 75);
            this.antrasLabel.Name = "antrasLabel";
            this.antrasLabel.Size = new System.Drawing.Size(106, 20);
            this.antrasLabel.TabIndex = 10;
            this.antrasLabel.Text = "antras skaicius:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ats);
            this.groupBox1.Controls.Add(this.atsLabel);
            this.groupBox1.Controls.Add(this.dauginam);
            this.groupBox1.Controls.Add(this.dalinam);
            this.groupBox1.Controls.Add(this.atimam);
            this.groupBox1.Controls.Add(this.sudedam);
            this.groupBox1.Controls.Add(this.antrasLabel);
            this.groupBox1.Controls.Add(this.pirmasLabel);
            this.groupBox1.Controls.Add(this.skaicius2);
            this.groupBox1.Controls.Add(this.skaicius1);
            this.groupBox1.Location = new System.Drawing.Point(81, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 199);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SKAICIUOJAM";
            // 
            // ats
            // 
            this.ats.Location = new System.Drawing.Point(58, 163);
            this.ats.Name = "ats";
            this.ats.Size = new System.Drawing.Size(146, 27);
            this.ats.TabIndex = 14;
            // 
            // atsLabel
            // 
            this.atsLabel.AutoSize = true;
            this.atsLabel.Location = new System.Drawing.Point(91, 140);
            this.atsLabel.Name = "atsLabel";
            this.atsLabel.Size = new System.Drawing.Size(80, 20);
            this.atsLabel.TabIndex = 13;
            this.atsLabel.Text = "atsakymas:";
            // 
            // dauginam
            // 
            this.dauginam.Location = new System.Drawing.Point(183, 109);
            this.dauginam.Name = "dauginam";
            this.dauginam.Size = new System.Drawing.Size(30, 28);
            this.dauginam.TabIndex = 12;
            this.dauginam.Text = "*";
            this.dauginam.UseVisualStyleBackColor = true;
            this.dauginam.Click += new System.EventHandler(this.dauginam_Click);
            // 
            // dalinam
            // 
            this.dalinam.Location = new System.Drawing.Point(138, 109);
            this.dalinam.Name = "dalinam";
            this.dalinam.Size = new System.Drawing.Size(30, 28);
            this.dalinam.TabIndex = 12;
            this.dalinam.Text = "/";
            this.dalinam.UseVisualStyleBackColor = true;
            this.dalinam.Click += new System.EventHandler(this.dalinam_Click);
            // 
            // atimam
            // 
            this.atimam.Location = new System.Drawing.Point(92, 109);
            this.atimam.Name = "atimam";
            this.atimam.Size = new System.Drawing.Size(30, 28);
            this.atimam.TabIndex = 12;
            this.atimam.Text = "-";
            this.atimam.UseVisualStyleBackColor = true;
            this.atimam.Click += new System.EventHandler(this.atimam_Click);
            // 
            // sudedam
            // 
            this.sudedam.Location = new System.Drawing.Point(47, 109);
            this.sudedam.Name = "sudedam";
            this.sudedam.Size = new System.Drawing.Size(30, 28);
            this.sudedam.TabIndex = 11;
            this.sudedam.Text = "+";
            this.sudedam.UseVisualStyleBackColor = true;
            this.sudedam.Click += new System.EventHandler(this.sudedam_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Lime;
            this.start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start.Location = new System.Drawing.Point(48, 53);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(90, 30);
            this.start.TabIndex = 12;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // laikas
            // 
            this.laikas.Location = new System.Drawing.Point(48, 159);
            this.laikas.Maximum = 10;
            this.laikas.Name = "laikas";
            this.laikas.Size = new System.Drawing.Size(390, 31);
            this.laikas.Step = 1;
            this.laikas.TabIndex = 13;
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Yellow;
            this.stop.Location = new System.Drawing.Point(199, 53);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(90, 30);
            this.stop.TabIndex = 14;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.Tomato;
            this.pause.Location = new System.Drawing.Point(348, 53);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(90, 30);
            this.pause.TabIndex = 15;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.laikoText);
            this.groupBox2.Controls.Add(this.pause);
            this.groupBox2.Controls.Add(this.stop);
            this.groupBox2.Controls.Add(this.laikas);
            this.groupBox2.Controls.Add(this.start);
            this.groupBox2.Location = new System.Drawing.Point(419, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 199);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LAIKAS";
            // 
            // laikoText
            // 
            this.laikoText.Location = new System.Drawing.Point(184, 126);
            this.laikoText.Name = "laikoText";
            this.laikoText.Size = new System.Drawing.Size(117, 27);
            this.laikoText.TabIndex = 16;
            this.laikoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 499);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Forma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox skaicius1;
        private TextBox skaicius2;
        private Label label1;
        private Label pirmasLabel;
        private Label antrasLabel;
        private GroupBox groupBox1;
        private TextBox ats;
        private Label atsLabel;
        private Button dauginam;
        private Button dalinam;
        private Button atimam;
        private Button sudedam;
        private System.Windows.Forms.Timer timer1;
        private Button start;
        private ProgressBar laikas;
        private Button stop;
        private Button pause;
        private GroupBox groupBox2;
        private TextBox laikoText;
    }
}