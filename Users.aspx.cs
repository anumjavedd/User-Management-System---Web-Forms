using AppProps;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace PresentationLayerWebb
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGridView();
                LoadDDLUser();
            }
        }
        //additional funtions
        public void LoadGridView()
        {
            GVUsers.DataSource = new UserBLL().GetUsersBLL();
            GVUsers.DataBind();
        }
        public void LoadDDLUser()
        {
            DDLUsers.DataSource = new UserBLL().GetUsersBLL();
            DDLUsers.DataValueField = "ID";
            DDLUsers.DataTextField = "FirstName";
            DDLUsers.DataBind();
        }

        protected void BtnSave_Click(object sender, EventArgs e)
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
                LabResult.Text = "Data Saved Successfully";
                LoadGridView();
                LoadDDLUser();  
            }
            else
            {
                LabResult.Text = "Error, Data not Saved";
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            User U = new User()
            {
                ID = Int32.Parse(DDLUsers.SelectedValue.ToString()),
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
                LabResult.Text = "Data Updated Successfully";
                LoadGridView();
                LoadDDLUser();
            }
            else
            {
                LabResult.Text = "Error, Data not Saved";
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            User U = new User()
            {
                ID = Int32.Parse(DDLUsers.SelectedValue.ToString())
            };
            if (new UserBLL().DeleteUserBLL(U))
            {
                LabResult.Text = "Data Deleted Successfully";
                LoadGridView();
                LoadDDLUser();
            }

        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            TxtEmail.Text = "";
            TxtAddress.Text = "";
            TxtAge.Text = "";
            TxtGender.Text = "";
            TxtCountry.Text = "";
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            User U = new User() { ID = Int32.Parse(DDLUsers.SelectedValue.ToString()) };
            DataTable Dt = new UserBLL().GerUserBLL(U);
            if (Dt.Rows.Count > 0)
            {
                TxtFirstName.Text = Dt.Rows[0]["FirstName"].ToString();
                TxtLastName.Text = Dt.Rows[0]["LastName"].ToString();
                TxtEmail.Text = Dt.Rows[0]["Email"].ToString();
                TxtAddress.Text = Dt.Rows[0]["Address"].ToString();
                TxtAge.Text = Dt.Rows[0]["Age"].ToString();
                TxtGender.Text = Dt.Rows[0]["Gender"].ToString();
                TxtCountry.Text = Dt.Rows[0]["Country"].ToString();

            }
        }
    }
}