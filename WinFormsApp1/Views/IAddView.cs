using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Views;

public interface IAddView
{
    string FirstName { get; }
    string LastName { get; }
    decimal Score { get; }
    DateTime BirthDate { get; }

    DialogResult DialogResult { get; set; }

    event EventHandler SaveEvent;
    event EventHandler CancelEvent;

    DialogResult ShowDialog();
}

