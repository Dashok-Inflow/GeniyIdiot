using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ГенийИдиотClassLibrary1;

namespace ГенийИдиотWindowsFormsApp1
{
    public partial class ResultsForm : Form
    {
        private List<User> users;
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void UsersResultsForm_Load(object sender, EventArgs e)
        {
            users = UserStorage.GetUsersResults();

            ShowUsersResults();
        }

        private void ShowUsersResults()
        {
            foreach(User user in users)
            {
                showUsersResultsDataGridView.Rows.Add(user.Name,user.CountRightAnswers,user.Diagnose);
            }
        }
    }
}
