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

            IMainView mainView = new MainView();
            IAddView addView = new AddView();
            IUpdateView updateView = new UpdateView();
            IStudentRepository repository= new EfStudentRepository();

            new AddPresenter(addView);
            new UpdatePresenter(updateView);

            Application.Run((Form)mainView);
        }
    }
}