using System;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Threading;
using TrafficLightSim.ViewModel;

namespace TrafficLightSim.View
{
    /// <summary>
    /// Interaction logic for LightDisplayControl.xaml
    /// </summary>
    public partial class LightDisplayControl : UserControl
    {
        private static LightTimer lightTimer = new LightTimer();

        public LightDisplayControl()
        {
            InitializeComponent();

            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = System.TimeSpan.FromSeconds(4);
            dt.Tick += LightSwitch;
            dt.Start();
        }

        private int updateSelector = 0;

        public void LightSwitch(object sender, EventArgs e)
        {
            updateSelector++;
            LightUpdater();
        }

        public void LightUpdater()
        {
            if (GreenLightOpacity == 1.0)
            {
                GreenLightOpacity = 0.1;
                YellowLightOpacity = 1.0;
            }
            else if (YellowLightOpacity == 1.0)
            {
                YellowLightOpacity = 0.1;
                RedLightOpacity = 1.0;
            }
            else
            {
                RedLightOpacity = 0.1;
                GreenLightOpacity = 1.0;
            }
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
            DependencyProperty.Register("GreenLightOpacity", typeof(double), typeof(LightDisplayControl), new FrameworkPropertyMetadata(lightTimer.GreenOpac, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

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
        DependencyProperty.Register("YellowLightOpacity", typeof(double), typeof(LightDisplayControl), new FrameworkPropertyMetadata(lightTimer.YellowOpac, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

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
        DependencyProperty.Register("RedLightOpacity", typeof(double), typeof(LightDisplayControl), new FrameworkPropertyMetadata(lightTimer.RedOpac, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
    }
}