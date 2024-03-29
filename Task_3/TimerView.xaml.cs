using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Task_3
{
    /// <summary>
    /// Interaction logic for TimerView.xaml
    /// </summary>
    /// 

    public partial class TimerView : Window
    {
        public DispatcherTimer timer;

        private EventHandler? _start;
        private EventHandler? _stop;
        private EventHandler? _reset;

        public TimerView()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            new TimerPresenter(this);

            //timer.Tick += Timer_Tick;
            //timer.Start();
        }

        public event EventHandler Start
        {
            add { _start += value; }
            remove { _start += value; }
        }

        public event EventHandler Stop
        {
            add { _stop += value; }
            remove { _stop += value; }
        }

        public event EventHandler Reset
        {
            add { _reset += value; }
            remove { _reset += value; }
        }

        public void timerReset()
        {
            LblTimer.Content = "0 : 0";
            timer.Stop();
        }

        public void UpdateTimer(string time)
        {
            LblTimer.Content = time;
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            _stop?.Invoke(sender, e);
            BtnStart.IsEnabled = true;
            BtnStop.IsEnabled = false;
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            _start?.Invoke(sender, e);
            BtnStart.IsEnabled = false;
            BtnStop.IsEnabled = true;
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            _reset?.Invoke(sender, e);
            BtnStart.IsEnabled = true;
            BtnStop.IsEnabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LblTimer.Content = DateTime.Now.ToLongTimeString();
        } 
    }
}