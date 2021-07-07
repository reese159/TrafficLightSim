using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using TrafficLightSim.ViewModel;

namespace TrafficLightSim.View
{
    /// <summary>
    /// Interaction logic for LightDisplayControl.xaml
    /// </summary>
    public partial class LightDisplayControl : UserControl
    {
        // lightTimer object currently binding opacities to
        private static LightTimer lightTimer = new LightTimer();

        // Base Constructor
        public LightDisplayControl()
        {
            InitializeComponent();

            // Handle running the timer
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = System.TimeSpan.FromSeconds(4);
            dt.Tick += LightUpdater;
            dt.Start();
        }

        //Update light cycle
        public void LightUpdater(object sender, EventArgs e)
        {
            if (GreenLightOpacity == 1.0)           // Rotate from green
            {
                GreenLightOpacity = 0.1;
                YellowLightOpacity = 1.0;
            }
            else if (YellowLightOpacity == 1.0)
            {
                YellowLightOpacity = 0.1;
                RedLightOpacity = 1.0;
            }   //Rotate from yellow
            else                                     // Rotate from Red
            {
                RedLightOpacity = 0.1;
                GreenLightOpacity = 1.0;
            }
        }

        #region Property definitions

        // Property definition for Green Light Opacity
        public double GreenLightOpacity
        {
            get { return (double)GetValue(GreenLightOpacityProperty); }
            set { SetValue(GreenLightOpacityProperty, value); }
        }

        // Property definition for Yellow Light Opacity
        public double YellowLightOpacity
        {
            get { return (double)GetValue(YellowLightOpacityProperty); }
            set { SetValue(YellowLightOpacityProperty, value); }
        }

        // Property definition for Red Light Opacity
        public double RedLightOpacity
        {
            get { return (double)GetValue(RedLightOpacityProperty); }
            set { SetValue(RedLightOpacityProperty, value); }
        }

        #endregion Property definitions

        #region Dependency Properties

        // DependencyProperty set for Green Light Opacity
        public static readonly DependencyProperty GreenLightOpacityProperty =
            DependencyProperty.Register("GreenLightOpacity", typeof(double), typeof(LightDisplayControl),
                new FrameworkPropertyMetadata(lightTimer.GreenOpac, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        // DependencyProperty set for Yellow Light Opacity
        public static readonly DependencyProperty YellowLightOpacityProperty =
        DependencyProperty.Register("YellowLightOpacity", typeof(double), typeof(LightDisplayControl),
            new FrameworkPropertyMetadata(lightTimer.YellowOpac, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        // DependencyProperty set for Red Light Opacity
        public static readonly DependencyProperty RedLightOpacityProperty =
        DependencyProperty.Register("RedLightOpacity", typeof(double), typeof(LightDisplayControl),
            new FrameworkPropertyMetadata(lightTimer.RedOpac, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        #endregion Dependency Properties
    }
}