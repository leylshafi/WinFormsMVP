using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories;
using WinFormsApp1.Views;

namespace WinFormsApp1.Presenters;
public class MainPresenter
{
    private readonly BindingSource _bindingSource;
    private readonly IMainView _mainView;
    private readonly IAddView _addView;
    private readonly IUpdateView _updateView;
    private readonly IStudentRepository _repository;

    public MainPresenter(IMainView mainView, IAddView addView, IUpdateView updateView, IStudentRepository repository)
    {
        _mainView = mainView;
        _addView = addView;
        _updateView = updateView;
        _repository = repository;


        _bindingSource = new();

        _bindingSource.DataSource = _repository.GetList();
        _mainView.SetStudentListBindingSource(_bindingSource);

        //Events
        _mainView.SearchEvent += _mainView_SearchEvent;
        _mainView.DeleteEvent += _mainView_DeleteEvent;
        _mainView.AddEvent += _mainView_AddEvent;
        _mainView.UpdateEvent += _mainView_UpdateEvent;
        
    }


    private void _mainView_SearchEvent(object? sender, EventArgs e)
    {
        var searchValue = _mainView.SearchValue;

        if (!string.IsNullOrWhiteSpace(searchValue))
            _bindingSource.DataSource = _repository.GetList().Where(s => s.FirstName.ToLower().Contains(searchValue.ToLower()) || s.LastName.ToLower().Contains(searchValue.ToLower())).ToList();
        else
            _bindingSource.DataSource = _repository.GetList();
    }

    private void _mainView_DeleteEvent(object? sender, EventArgs e)
    {
        if (_bindingSource.Current is null)
        {
            MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }

        _bindingSource.Remove(_bindingSource.Current);
        MessageBox.Show("Successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void _mainView_AddEvent(object? sender, EventArgs e)
    {
        var result = _addView.ShowDialog();

        if (result == DialogResult.Cancel)
            return;

        var student = new Student()
        {
            FirstName = _addView.FirstName,
            LastName = _addView.LastName,
            BirthOfDate = _addView.BirthDate,
            Score = (float)_addView.Score
        };

        _bindingSource.Add(student);
        MessageBox.Show("Successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void _mainView_UpdateEvent(object? sender, EventArgs e)
    {
        var student = _bindingSource.Current as Student;
        if (student is null)
        {
            MessageBox.Show("No selected student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _updateView.FirstName = student.FirstName;
        _updateView.LastName = student.LastName;
        _updateView.Score = (decimal)student.Score;
        _updateView.BirthDate = student.BirthOfDate;

        var result = _updateView.ShowDialog();

        if (result == DialogResult.Cancel)
            return;

        student.FirstName = _updateView.FirstName;
        student.LastName = _updateView.LastName;
        student.BirthOfDate = _updateView.BirthDate;
        student.Score = (float)_updateView.Score;

        _bindingSource.ResetCurrentItem();
        MessageBox.Show("Successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

