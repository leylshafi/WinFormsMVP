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

        if (!string.IsNullOrWhiteSpace(_updateView.FirstName) && _updateView.FirstName.Length < 3)
            sb.Append("Incorrect Name\n");

        if (!string.IsNullOrWhiteSpace(_updateView.LastName) && _updateView.LastName.Length < 6)
            sb.Append("Incorrect LastName\n");
        if (sb.Length > 0)
        {
            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        ((Form)_updateView).DialogResult = DialogResult.OK;
    }


    private void _updateView_CancelEvent(object? sender, EventArgs e) => ((Form)_updateView).DialogResult = DialogResult.Cancel;

}

