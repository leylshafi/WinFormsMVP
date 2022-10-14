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

        public string FirstName { 
            get=>txt_FirstName.Text; 
            set=> txt_FirstName.Text = value;
        }

        public string LastName {
            get => txt_LastName.Text;
            set => txt_LastName.Text = value; 
        }

        public decimal Score { 
            get => ScoreNm.Value; 
            set => ScoreNm.Value = value;
        }

        public DateTime BirthDate { 
            get=>monthCalendar1.SelectionStart; 
            set => monthCalendar1.SelectionStart=value; 
        }


        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;



        private void btn_save_Click(object sender, EventArgs e) => SaveEvent?.Invoke(sender, e);

        private void btn_cancel_Click(object sender, EventArgs e) => CancelEvent?.Invoke(sender, e);
    }
}
