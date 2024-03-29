using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2
{
    public class PersonPresenter
    {
        private readonly PersonModel _model;
        private readonly PersonView _view;

        public PersonPresenter(PersonModel model, PersonView view)
        {
            _model = model;
            _view = view;

            // subscribe
            _view.OnUserInputEntered += OnUserInputEntered;
            _model.OnPersonUpdated += OnPersonUpdated;
        }

        private void OnUserInputEntered(string name)
        {
            _model.UpdatePerson(name);
        }

        private void OnPersonUpdated(string name)
        {
            _view.PrintUpdatedInfo(name);
        }
    }
}