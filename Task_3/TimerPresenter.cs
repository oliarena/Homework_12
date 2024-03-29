using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class TimerPresenter
    {
        private readonly TimerModel _model;
        private readonly TimerView _view;

        public TimerPresenter(TimerView view)
        {
            _view = view;
            _model = new TimerModel();

            _view.Start += OnStart;
            _view.Stop += OnStop;
            _view.Reset += OnReset;
            _view.timer.Tick += OnTick;
            _view.timer.Start();
        }

        public void OnStart(object sender, EventArgs e)
        {
            _view.timer.IsEnabled = true;
        }

        public void OnStop(object sender, EventArgs e)
        {
            _view.timer.IsEnabled = false;
        }

        public void OnReset(object sender, EventArgs e)
        {
            _view.timerReset();
            _model.Reset();
        }

        public void OnTick(object sender, EventArgs e)
        {
            _view.UpdateTimer(_model.Tick());
        }
    }
}
