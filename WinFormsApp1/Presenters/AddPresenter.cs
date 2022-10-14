using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WinFormsApp1.Views;

namespace WinFormsApp1.Presenters;

public class AddPresenter
{
    private IAddView _addView;

    public AddPresenter(IAddView addView)
    {
        _addView = addView;

        _addView.SaveEvent += _addView_SaveEvent;
        _addView.CancelEvent += _addView_CancelEvent;
    }


    private void _addView_SaveEvent(object? sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();

        if( _addView.FirstName.Length<3)
            sb.Append($"Incorrect {nameof(_addView.FirstName)}\n");

        if ( _addView.LastName.Length < 6)
            sb.Append($"Incorrect {nameof(_addView.LastName)}\n");

        if(DateTime.Now.Year-_addView.BirthDate.Year<18)
            sb.Append($"Incorrect {nameof(_addView.BirthDate)}\n");

        if (sb.Length > 0)
        {
            MessageBox.Show(sb.ToString(), "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _addView.DialogResult = DialogResult.OK;
    }

    private void _addView_CancelEvent(object? sender, EventArgs e) => _addView.DialogResult = DialogResult.Cancel;

}
