namespace Task_4
{
    internal class CalculatorPresenter
    {
        private readonly CalculatorModel _model;
        private readonly CalculatorView _view;

        public CalculatorPresenter(CalculatorView view)
        {
            _view = view;
            _model = new CalculatorModel();

            _view.Plus += OnPlus;
            _view.Minus += OnMinus;
            _view.Div += OnDiv;
            _view.Mult += OnMult;
        }

        public void OnPlus(object? sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(_view.Value1);
            double value2 = Convert.ToDouble(_view.Value2);

            _view.ShowResult(_model.Plus(value1, value2));
        }

        public void OnMinus(object? sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(_view.Value1);
            double value2 = Convert.ToDouble(_view.Value2);

            _view.ShowResult(_model.Minus(value1, value2));
        }

        public void OnDiv(object? sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(_view.Value1);
            double value2 = Convert.ToDouble(_view.Value2);

            _view.ShowResult(_model.Div(value1, value2));
        }

        public void OnMult(object? sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(_view.Value1);
            double value2 = Convert.ToDouble(_view.Value2);

            _view.ShowResult(_model.Mult(value1, value2));
        }
    }
}
