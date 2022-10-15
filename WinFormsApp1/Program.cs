using WinFormsApp1.Presenters;
using WinFormsApp1.Repositories;
using WinFormsApp1.Views;

namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            IAddView addView = new AddView();
            IUpdateView updateView = new UpdateView();

            new AddPresenter(addView);
            new UpdatePresenter(updateView);

            IStudentRepository repository= new EfStudentRepository();
            IMainView mainView = new MainView();
            new MainPresenter(mainView, addView, updateView, repository);

            Application.Run((Form)mainView);
        }
    }
}