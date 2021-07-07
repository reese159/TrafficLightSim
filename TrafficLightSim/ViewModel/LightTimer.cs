using System.ComponentModel;

namespace TrafficLightSim.ViewModel
{
    public class LightTimer : INotifyPropertyChanged
    {
        /// <summary>
        /// Base constructor
        /// </summary>
        /// <param name="lightColor">Color of selected light</param>
        public LightTimer()
        {
        }

        #region private property defaults

        private double greenOpac = 1.0;
        private double redOpac = 0.1;
        private double yellowOpac = 0.1;

        #endregion private property defaults

        #region public property definitions

        public double GreenOpac
        {
            get => greenOpac;
            set
            {
                greenOpac = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("greenOpac"));
            }
        }

        public double YellowOpac
        {
            get { return yellowOpac; }
            set
            {
                yellowOpac = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("yellowOpac"));
            }
        }

        public double RedOpac
        {
            get { return redOpac; }
            set
            {
                redOpac = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("redOpac"));
            }
        }

        #endregion public property definitions

        // Public event updater
        public event PropertyChangedEventHandler PropertyChanged;
    }
}