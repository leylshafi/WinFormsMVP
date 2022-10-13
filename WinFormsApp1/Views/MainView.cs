﻿using System;
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
    public partial class MainView : Form,IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public string SearchValue => txtBox_search.Text;

        public event EventHandler SearchEvent;
        public event EventHandler AddEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;

        public void SetStudentListBindingSource(BindingSource source) => listBox_Students.DataSource = source;




        private void btn_search_Click(object sender, EventArgs e) => SearchEvent?.Invoke(sender, e);

        private void btn_add_Click(object sender, EventArgs e) => AddEvent?.Invoke(sender, e);

        private void btn_update_Click(object sender, EventArgs e) => UpdateEvent.Invoke(sender, e);

        private void btn_delete_Click(object sender, EventArgs e) => DeleteEvent?.Invoke(sender, e);
    }
}
