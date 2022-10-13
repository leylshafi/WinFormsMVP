using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Views;
public interface IUpdateView
{
    string FirstName { get; }
    string LastName { get; }
    decimal Score { get; }
    DateTime BirthDate { get; }

    event EventHandler SaveEvent;
    event EventHandler CancelEvent;
}