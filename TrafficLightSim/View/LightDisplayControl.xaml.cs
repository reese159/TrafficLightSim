using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using TrafficLightSim.ViewModel;

namespace TrafficLightSim.View
{
    /// <summary>
    /// Interaction logic for LightDisplayControl.xaml
    /// </summary>
    public partial class LightDisplayControl : UserControl
    {
        private Timer timer;

        public Timer Timer
        {
            get { return timer; }
            set { timer = value; }
        }

        private static LightTimer lightTimer = new LightTimer();

        public LightDisplayControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Property definition for Green Light Opacity
        /// </summary>
        public double GreenLightOpacity
        {
            get { return (double)GetValue(GreenLightOpacityProperty); }
            set { SetValue(GreenLightOpacityProperty, value); }
        }

        /// <summary>
        /// DependencyProperty set for Green Light Opacity
        /// </summary>
        public static readonly DependencyProperty GreenLightOpacityProperty =
            DependencyProperty.Register("GreenLightOpacity", typeof(double), typeof(LightDisplayControl), new FrameworkPropertyMetadata(lightTimer.GreenOpac));

        /// <summary>
        /// Property definition for Yellow Light Opacity
        /// </summary>
        public double YellowLightOpacity
        {
            get { return (double)GetValue(YellowLightOpacityProperty); }
            set { SetValue(YellowLightOpacityProperty, value); }
        }

        /// <summary>
        /// DependencyProperty set for Yellow Light Opacity
        /// </summary>
        public static readonly DependencyProperty YellowLightOpacityProperty =
        DependencyProperty.Register("YellowLightOpacity", typeof(double), typeof(LightDisplayControl), new FrameworkPropertyMetadata(lightTimer.YellowOpac));

        /// <summary>
        /// Property definition for Red Light Opacity
        /// </summary>
        public double RedLightOpacity
        {
            get { return (double)GetValue(RedLightOpacityProperty); }
            set { SetValue(RedLightOpacityProperty, value); }
        }

        /// <summary>
        /// DependencyProperty set for Red Light Opacity
        /// </summary>
        public static readonly DependencyProperty RedLightOpacityProperty =
        DependencyProperty.Register("RedLightOpacity", typeof(double), typeof(LightDisplayControl), new FrameworkPropertyMetadata(lightTimer.RedOpac));
    }
}