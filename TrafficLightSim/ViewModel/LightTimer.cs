using System;
using System.ComponentModel;
using System.Windows.Threading;

namespace TrafficLightSim.ViewModel
{
    public class LightTimer : INotifyPropertyChanged
    {
        public double greenOpac = 1.0;

        public double GreenOpac
        {
            get => greenOpac;
            set
            {
                greenOpac = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("greenOpac"));
            }
        }

        public double yellowOpac = 0.1;

        public double YellowOpac
        {
            get { return yellowOpac; }
            set
            {
                yellowOpac = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("yellowOpac"));
            }
        }

        public double redOpac = 0.1;

        public double RedOpac
        {
            get { return redOpac; }
            set
            {
                redOpac = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("redOpac"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Create timer based on color of selected light
        /// </summary>
        /// <param name="lightColor">Color of selected light</param>
        public LightTimer()
        {
            // DispatcherTimer dt = new DispatcherTimer();
            //dt.Interval = TimeSpan.FromSeconds(2);
            //dt.Tick += LightSwitch;
            //dt.Start();
        }
    }
}