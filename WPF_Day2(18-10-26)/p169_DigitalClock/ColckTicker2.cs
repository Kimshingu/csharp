﻿using System;
using System.Windows;
using System.Windows.Threading;
using System.ComponentModel;

namespace p169_DigitalClock
{
    public class ClockTicker2 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime DateTime { get { return DateTime.Now; } }

        public ClockTicker2() {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += TimerOnTick;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }

        void TimerOnTick(object sender, EventArgs e) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
            }
        }
    }
}
