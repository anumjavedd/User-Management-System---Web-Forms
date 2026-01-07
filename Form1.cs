using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;
using BusinessLogicLayer;
using AppProps;

namespace PresentationLayerWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGridView();
            LoadDDLUsers();
        }
        private void LoadGridView()
        {
            DataTable Dt = new UserBLL().GetUsersBLL();
            GVUsers.DataSource = Dt;
        }

        private void LoadDDLUsers()
        {
            DataTable Dt = new UserBLL().GetUsersBLL();
            CBBUsers.DataSource = Dt;
            CBBUsers.DisplayMember = "FirstName";
            CBBUsers.ValueMember = "ID";
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            User U = new User()
            {
                FirstName = TxtFirstName.Text,
                LastName = TxtLastName.Text,
                Email = TxtEmail.Text,
                Address = TxtAddress.Text,
                Age = TxtAge.Text,
                Gender = TxtGender.Text,
                Country = TxtCountry.Text
            };

            if (new UserBLL().InsertUserBLL(U))
            {
                MessageBox.Show("Data Saved Successfully");
                LoadGridView();
                LoadDDLUsers();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error: Data not Saved");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (CBBUsers.SelectedValue == null)
            {
                MessageBox.Show("Select a user first");
                return;
            }

            User U = new User()
            {
                ID = Convert.ToInt32(CBBUsers.SelectedValue),
                FirstName = TxtFirstName.Text,
                LastName = TxtLastName.Text,
                Email = TxtEmail.Text,
                Address = TxtAddress.Text,
                Age = TxtAge.Text,
                Gender = TxtGender.Text,
                Country = TxtCountry.Text
            };

            if (new UserBLL().UpdateUserBLL(U))
            {
                MessageBox.Show("Data Updated Successfully");
                LoadGridView();
                LoadDDLUsers();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error: Data not Updated");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CBBUsers.SelectedValue == null)
            {
                MessageBox.Show("Select a user first");
                return;
            }

            User U = new User()
            {
                ID = Convert.ToInt32(CBBUsers.SelectedValue)
            };

            if (new UserBLL().DeleteUserBLL(U))
            {
                MessageBox.Show("Data Deleted Successfully");
                LoadGridView();
                LoadDDLUsers();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error: Data not Deleted");
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            TxtFirstName.Clear();
            TxtLastName.Clear();
            TxtEmail.Clear();
            TxtAddress.Clear();
            TxtAge.Clear();
            TxtGender.Clear();
            TxtCountry.Clear();
        }
    }
}
