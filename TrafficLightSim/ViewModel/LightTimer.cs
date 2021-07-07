using System.ComponentModel;

namespace TrafficLightSim.ViewModel
{
    public class LightTimer : INotifyPropertyChanged
    {
        private double greenOpac;

        public double GreenOpac
        {
            get { return greenOpac; }
            set
            {
                greenOpac = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("greenOpac"));
            }
        }

        private double yellowOpac;

        public double YellowOpac
        {
            get { return yellowOpac; }
            set
            {
                yellowOpac = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("yellowOpac"));
            }
        }

        private double redOpac;

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
            GreenOpac = 1.0;
            YellowOpac = 1.0;
            RedOpac = 1.0;
            LightSwitch();
        }

        public void LightSwitch()
        {
            GreenOpac = 0.3;
            YellowOpac = 0.3;
            RedOpac = 0.3;
        }
    }
}