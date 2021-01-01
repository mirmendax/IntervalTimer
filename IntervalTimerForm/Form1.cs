using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntervalTimerLib;
using ITimerLib = IntervalTimerLib;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool _isSettings = false;
        private readonly ITimerLib.SettingsContext setContext = ITimerLib.SettingsContext.GetSettings();
        private static IntervalTimer _intervalTimerList;
        private Task TimerStartTask { get; set; }

        private const int HeightMax = 343;
        private const int HeightMin = 200;
        
        public Form1()
        {
            InitializeComponent();
            mtbTransitTimer.Enabled = cbTransit.Checked;
            
            this.Size = new Size(this.Size.Width, HeightMin);
        }

        private async void StopTimers()
        {
            if (_intervalTimerList != null)
            {
                IntervalTimer.Cancel = true;
                TimerStartTask.Wait();
                await Task.Delay(5000);
                _intervalTimerList.Reset();
            }
            button3.Enabled = true;
            button5.Enabled = true;
            button2.Enabled = true;
        }

        private void cbTransit_CheckStateChanged(object sender, EventArgs e)
        {
            mtbTransitTimer.Enabled = cbTransit.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _isSettings = !_isSettings;
            if (_isSettings)
            {
                
                this.Size = new Size(this.Size.Width, HeightMax);
            }
            else
            {
                this.Size = new Size(this.Size.Width, HeightMin);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ofdSoundFile = new OpenFileDialog();
            var dialogResult = ofdSoundFile.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var fullfilename = ofdSoundFile.FileName;
                var filename = fullfilename.Split('\\').Last();
                var ext_file = filename.Split('.').Last();
                if (ext_file != "wav")
                {
                    MessageBox.Show("Необходимо выбрать файл формата wav");
                    return;
                }

                setContext.Settings.ListSound.Add(fullfilename);
                cbFileName.Items.Add(fullfilename.Split('\\').Last());
                cbFileName.SelectedIndex = setContext.Settings.CurrentSound = cbFileName.Items.Count - 1;
                setContext.Save();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setContext.Load();
            // Звук
            if (setContext.Settings.ListSound != null)
            {
                cbFileName.Items.Clear();
                foreach (var sound in setContext.Settings.ListSound)
                {
                    var fullfilename = sound;
                    var filename = fullfilename.Split('\\').Last();
                    cbFileName.Items.Add(filename);
                }
            }

            cbFileName.SelectedIndex = setContext.Settings.CurrentSound;
            //Переходной таймер
            cbTransit.Checked = setContext.Settings.IsTransitTimer;
            
            var tempTransitTimer = setContext.Settings.TransitTimer;
            var hour_timer_transit = (tempTransitTimer.Hour.ToString().Length == 1)
                ? $"0{tempTransitTimer.Hour}"
                : tempTransitTimer.Hour.ToString();
            var min_timer_transit = (tempTransitTimer.Min.ToString().Length == 1)
                ? $"0{tempTransitTimer.Min}"
                : tempTransitTimer.Min.ToString();
            var sec_timer_transit = (tempTransitTimer.Sec.ToString().Length == 1)
                ? $"0{tempTransitTimer.Sec}"
                : tempTransitTimer.Sec.ToString();
            mtbTransitTimer.Text = $"{hour_timer_transit}" +
                                   $":{min_timer_transit}" +
                                   $":{sec_timer_transit}";
            //Таймеры

            if (setContext.Settings.ListTimers != null 
                && setContext.Settings.ListTimers.Count != 0)
            {
                var tempTimer = setContext.Settings.ListTimers[0];
                var hourTimer = (tempTimer.Hour.ToString().Length == 1)
                    ? $"0{tempTimer.Hour}"
                    : tempTimer.Hour.ToString();
                var minTimer = (tempTimer.Min.ToString().Length == 1)
                    ? $"0{tempTimer.Min}"
                    : tempTimer.Min.ToString();
                var secTimer = (tempTimer.Sec.ToString().Length == 1)
                    ? $"0{tempTimer.Sec}"
                    : tempTimer.Sec.ToString();
                mtbTimer.Text = $"{hourTimer}:{minTimer}:{secTimer}";
                nudCountTimers.Value = setContext.Settings.ListTimers.Count;

                //Добавление таймеров
            }
            _intervalTimerList = new IntervalTimer(setContext.Settings.ListTimers, 
                setContext.Settings.IsTransitTimer, setContext.Settings.TransitTimer);
            _intervalTimerList.IntervalTimerIsDone += (o, args) =>
            {
                StopTimers();
            };
            _intervalTimerList.TimerIsDone += (o, args) =>
            {
                var showForm = new Task(() =>
                {
                    var notificationForm = new NotificationForm();
                    notificationForm.ShowDialog();
                
                });
                showForm.Start();
            };

            lCountTimers.Text = $"1/{_intervalTimerList.MaxCount}";


        }
        //Button OK click
        private void button5_Click(object sender, EventArgs e)
        {
            //Добоваление таймеров
            var timerText = mtbTimer.Text;
            var timer = timerText.Split(':');
            try
            {
                var t = new Time(int.Parse(timer[0]), int.Parse(timer[1]),int.Parse(timer[2]));
                var count = nudCountTimers.Value;
                var timers = setContext.Settings.ListTimers = new List<Time>();
               
                for (var i = 0; i < count; i++)
                {
                    timers.Add(t);
                }
                
                setContext.Settings.ListTimers = timers;
                
            }
            catch
            {
                MessageBox.Show("Неверный формат");
            }
            //Таймер перехода
            setContext.Settings.IsTransitTimer = cbTransit.Checked;
            timerText = mtbTransitTimer.Text;
            timer = timerText.Split(':');
            try
            {
                var t = new Time(int.Parse(timer[0]), int.Parse(timer[1]), int.Parse(timer[2]));
                setContext.Settings.TransitTimer = t;
            }
            catch 
            {
                MessageBox.Show("Неверный формат");
            }
            setContext.Save();
            _intervalTimerList = new IntervalTimer(setContext.Settings.ListTimers, 
                setContext.Settings.IsTransitTimer, setContext.Settings.TransitTimer);
            Form1_Load(this, EventArgs.Empty);
            
        }
        //Start button click
        private void button2_Click(object sender, EventArgs e)
        {
            if (_intervalTimerList != null)
            {
                timer1.Enabled = true;
                TimerStartTask = new Task(() => { _intervalTimerList.Start(); });
                TimerStartTask.Start();
                button3.Enabled = false;
                button5.Enabled = false;
                button2.Enabled = false;
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_intervalTimerList != null)
            {
                if (_intervalTimerList.CurrentTimer != null)
                    lCurTimer.Text = _intervalTimerList.CurrentTimer.ToString();
                if (_intervalTimerList.IsTransitTime)
                    lTransitTimer.Text = _intervalTimerList.TransitTime.ToString();
                else lTransitTimer.Text = "--:--:--";
                lCountTimers.Text = $"{_intervalTimerList.Count + 1}/{_intervalTimerList.MaxCount}";
            }
        }
        //Stop button click
        private void button1_Click(object sender, EventArgs e)
        {
            StopTimers();
            //timer1.Enabled = false;
        }

        private void cbFileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedText = (string)cbFileName.SelectedItem;
            var findSound = setContext.Settings.ListSound.IndexOf(
                setContext.Settings.ListSound.Find(
                    sound => sound.Contains(selectedText)));
            if (findSound != -1)
            {
                setContext.Settings.CurrentSound = findSound;
                setContext.Save();
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}