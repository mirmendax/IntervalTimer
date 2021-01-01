namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lCurTimer = new System.Windows.Forms.Label();
            this.lCountTimers = new System.Windows.Forms.Label();
            this.lTransitTimer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbFileName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.ofdSoundFile = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbTimer = new System.Windows.Forms.MaskedTextBox();
            this.cbTransit = new System.Windows.Forms.CheckBox();
            this.mtbTransitTimer = new System.Windows.Forms.MaskedTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCountTimers = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.nudCountTimers)).BeginInit();
            this.SuspendLayout();
            // 
            // lCurTimer
            // 
            this.lCurTimer.AutoSize = true;
            this.lCurTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lCurTimer.ForeColor = System.Drawing.Color.Green;
            this.lCurTimer.Location = new System.Drawing.Point(7, 3);
            this.lCurTimer.Name = "lCurTimer";
            this.lCurTimer.Size = new System.Drawing.Size(120, 31);
            this.lCurTimer.TabIndex = 0;
            this.lCurTimer.Text = "00:00:00";
            // 
            // lCountTimers
            // 
            this.lCountTimers.AutoSize = true;
            this.lCountTimers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lCountTimers.Location = new System.Drawing.Point(196, 20);
            this.lCountTimers.Name = "lCountTimers";
            this.lCountTimers.Size = new System.Drawing.Size(52, 31);
            this.lCountTimers.TabIndex = 1;
            this.lCountTimers.Text = "1/5";
            // 
            // lTransitTimer
            // 
            this.lTransitTimer.AutoSize = true;
            this.lTransitTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lTransitTimer.ForeColor = System.Drawing.Color.DarkRed;
            this.lTransitTimer.Location = new System.Drawing.Point(9, 36);
            this.lTransitTimer.Name = "lTransitTimer";
            this.lTransitTimer.Size = new System.Drawing.Size(120, 31);
            this.lTransitTimer.TabIndex = 2;
            this.lTransitTimer.Text = "00:00:00";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button1.Location = new System.Drawing.Point(196, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Стоп";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button2.Location = new System.Drawing.Point(14, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Старт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button3.Location = new System.Drawing.Point(14, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(360, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "Настройки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbFileName
            // 
            this.cbFileName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFileName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.cbFileName.FormattingEnabled = true;
            this.cbFileName.Location = new System.Drawing.Point(51, 207);
            this.cbFileName.Name = "cbFileName";
            this.cbFileName.Size = new System.Drawing.Size(269, 24);
            this.cbFileName.TabIndex = 5;
            this.cbFileName.SelectedIndexChanged += new System.EventHandler(this.cbFileName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(7, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Звук";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button4.Location = new System.Drawing.Point(325, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 30);
            this.button4.TabIndex = 7;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ofdSoundFile
            // 
            this.ofdSoundFile.FileName = "openFileDialog1";
            this.ofdSoundFile.Filter = "Sound File|*.mp3";
            this.ofdSoundFile.SupportMultiDottedExtensions = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(14, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Таймер";
            // 
            // mtbTimer
            // 
            this.mtbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.mtbTimer.Location = new System.Drawing.Point(120, 240);
            this.mtbTimer.Mask = "00:00:00";
            this.mtbTimer.Name = "mtbTimer";
            this.mtbTimer.Size = new System.Drawing.Size(94, 23);
            this.mtbTimer.TabIndex = 8;
            this.mtbTimer.ValidatingType = typeof(System.DateTime);
            // 
            // cbTransit
            // 
            this.cbTransit.AutoSize = true;
            this.cbTransit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.cbTransit.Location = new System.Drawing.Point(16, 279);
            this.cbTransit.Name = "cbTransit";
            this.cbTransit.Size = new System.Drawing.Size(83, 21);
            this.cbTransit.TabIndex = 9;
            this.cbTransit.Text = "Переход";
            this.cbTransit.UseVisualStyleBackColor = true;
            this.cbTransit.CheckStateChanged += new System.EventHandler(this.cbTransit_CheckStateChanged);
            // 
            // mtbTransitTimer
            // 
            this.mtbTransitTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.mtbTransitTimer.Location = new System.Drawing.Point(120, 277);
            this.mtbTransitTimer.Mask = "00:00:00";
            this.mtbTransitTimer.Name = "mtbTransitTimer";
            this.mtbTransitTimer.Size = new System.Drawing.Size(94, 23);
            this.mtbTransitTimer.TabIndex = 8;
            this.mtbTransitTimer.ValidatingType = typeof(System.DateTime);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button5.Location = new System.Drawing.Point(241, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 98);
            this.button5.TabIndex = 3;
            this.button5.Text = "OK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(20, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кол-во";
            // 
            // nudCountTimers
            // 
            this.nudCountTimers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.nudCountTimers.Location = new System.Drawing.Point(120, 312);
            this.nudCountTimers.Maximum = new decimal(new int[] {99999, 0, 0, 0});
            this.nudCountTimers.Name = "nudCountTimers";
            this.nudCountTimers.Size = new System.Drawing.Size(94, 23);
            this.nudCountTimers.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 351);
            this.Controls.Add(this.nudCountTimers);
            this.Controls.Add(this.cbTransit);
            this.Controls.Add(this.mtbTransitTimer);
            this.Controls.Add(this.mtbTimer);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFileName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lTransitTimer);
            this.Controls.Add(this.lCountTimers);
            this.Controls.Add(this.lCurTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интервальный таймер";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.nudCountTimers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lCurTimer;
        private System.Windows.Forms.Label lCountTimers;
        private System.Windows.Forms.Label lTransitTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog ofdSoundFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbTimer;
        private System.Windows.Forms.CheckBox cbTransit;
        private System.Windows.Forms.MaskedTextBox mtbTransitTimer;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCountTimers;
        private System.Windows.Forms.Timer timer1;
    }
}