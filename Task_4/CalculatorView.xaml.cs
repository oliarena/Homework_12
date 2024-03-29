using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Task_4
{
    /// <summary>
    /// Interaction logic for CalculatorView.xaml
    /// </summary>
    public partial class CalculatorView : Window
    {
        private EventHandler? _plus;
        private EventHandler? _minus;
        private EventHandler? _div;
        private EventHandler? _mult;

        public string? Value1 => InputValue1?.Text;
        public string? Value2 => InputValue2?.Text;

        public event EventHandler Plus
        {
            add { _plus += value; }
            remove { _plus += value; }
        }

        public event EventHandler Minus
        {
            add { _minus += value; }
            remove { _minus += value; }
        }

        public event EventHandler Div
        {
            add { _div += value; }
            remove { _div += value; }
        }

        public event EventHandler Mult
        {
            add { _mult += value; }
            remove { _mult += value; }
        }

        public void ShowResult(double? result)
        {
            LblResult.Content = result == null ? "Error!" : String.Format($"{result:N}");
        }

        public CalculatorView()
        {
            InitializeComponent();
            new CalculatorPresenter(this);
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            _plus?.Invoke(sender, e);
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            _minus?.Invoke(sender, e);
        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {
            _div?.Invoke(sender, e);
        }

        private void BtnMult_Click(object sender, RoutedEventArgs e)
        {
            _mult?.Invoke(sender, e);
        }

        private void InputValue1_TextChanged(object sender, TextChangedEventArgs e)
        {
            LblResult.Content = String.Empty;
        }

        private void InputValue2_TextChanged(object sender, TextChangedEventArgs e)
        {
            LblResult.Content = String.Empty;
        }
    }
}