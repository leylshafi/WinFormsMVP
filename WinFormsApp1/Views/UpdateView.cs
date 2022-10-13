using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Views
{
    public partial class UpdateView : Form,IUpdateView
    {
        public UpdateView()
        {
            InitializeComponent();
        }
        public string FirstName => txt_FirstName.Text;

        public string LastName => txt_LastName.Text;

        public decimal Score => ScoreNm.Value;

        public DateTime BirthDate => monthCalendar1.SelectionStart;

        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;



        private void btn_save_Click(object sender, EventArgs e) => SaveEvent?.Invoke(sender, e);

        private void btn_cancel_Click(object sender, EventArgs e) => CancelEvent?.Invoke(sender, e);
    }
}
