using Xamarin.Forms;

namespace PASSAnomalyDetectionDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.AnomalyDetectorView();
        }
    }
}
