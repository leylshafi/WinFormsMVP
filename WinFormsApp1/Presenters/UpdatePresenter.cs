using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WinFormsApp1.Views;

namespace WinFormsApp1.Presenters;
public class UpdatePresenter
{
    private IUpdateView _updateView;


    public UpdatePresenter(IUpdateView updateView)
    {
        _updateView = updateView;

        _updateView.SaveEvent += _updateView_SaveEvent;
        _updateView.CancelEvent += _updateView_CancelEvent;
    }

    private void _updateView_SaveEvent(object? sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();

        if (_updateView.FirstName.Length < 3)
            sb.Append($"Incorrect {nameof(_updateView.FirstName)}\n");

        if (_updateView.LastName.Length < 6)
            sb.Append($"Incorrect {nameof(_updateView.LastName)}\n");

        if (DateTime.Now.Year - _updateView.BirthDate.Year < 18)
            sb.Append($"Incorrect {nameof(_updateView.BirthDate)}\n");

        if (sb.Length > 0)
        {
            MessageBox.Show(sb.ToString(), "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _updateView.DialogResult = DialogResult.OK;
    }


    private void _updateView_CancelEvent(object? sender, EventArgs e) => ((Form)_updateView).DialogResult = DialogResult.Cancel;

}

