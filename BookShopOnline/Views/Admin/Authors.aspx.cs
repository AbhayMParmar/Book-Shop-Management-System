﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShopOnline.Views.Admin
{
	public partial class Authors : System.Web.UI.Page
	{
		Models.Function Con;
		protected void Page_Load(object sender, EventArgs e)
		{
			Con= new Models.Function();
			ShowAuthors();
		}
		private void ShowAuthors()
		{
			string Query = "Select * from AuthorTbl1";
			AuthorsList.DataSource = Con.GetData(Query);
			AuthorsList.DataBind();
		}
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
			try
			{
				if (ANameTb.Value == "" || GenCb.SelectedIndex == -1 || CountryCb.SelectedIndex ==-1)
				{
					ErrMsg.Text = "Missing Data!!!";
				}
				else
				{
					string AName = ANameTb.Value;
					string Gender = GenCb.SelectedItem.ToString();
					string Country = CountryCb.SelectedItem.ToString();

					string Query = "insert into AuthorTbl1 values('{0}','{1}','{2}')";
					Query = string.Format(Query, AName, Gender, Country);
					Con.SetData(Query);
					ShowAuthors();
					ErrMsg.Text = "Author Inserted!!!";
					ANameTb.Value = "";
					GenCb.SelectedIndex = -1;
					CountryCb.SelectedIndex = -1;
				}
				
			}
			catch(Exception Ex)  
			{
				ErrMsg.Text = Ex.Message;
			}	
        }

		int Key = 0;
        protected void AuthorsList_SelectedIndexChanged1(object sender, EventArgs e)
        {
            ANameTb.Value = AuthorsList.SelectedRow.Cells[2].Text;
            GenCb.SelectedItem.Value = AuthorsList.SelectedRow.Cells[3].Text;
            CountryCb.SelectedItem.Value = AuthorsList.SelectedRow.Cells[4].Text;
            if (ANameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AuthorsList.SelectedRow.Cells[1].Text);
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ANameTb.Value == "" || GenCb.SelectedIndex == -1 || CountryCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "Select Data!!!";
                }
                else
                {
                    string AName = ANameTb.Value;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Country = CountryCb.SelectedItem.ToString();

                    string Query = "update AuthorTbl1 set AutName = '{0}',AutGender = '{1}',AutCountry= '{2}' where AutId = {3}";
                    Query = string.Format(Query, AName, Gender, Country, AuthorsList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowAuthors();
                    ErrMsg.Text = "Author Updated!!!";
                    ANameTb.Value = "";
                    GenCb.SelectedIndex = -1;
                    CountryCb.SelectedIndex = -1;
                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ANameTb.Value == "" || GenCb.SelectedIndex == -1 || CountryCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "Select An Author!!!";
                }
                else
                {
                    string AName = ANameTb.Value;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Country = CountryCb.SelectedItem.ToString();

                    string Query = "delete from AuthorTbl1 where AutId = {0}";
                    Query = string.Format(Query,AuthorsList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowAuthors();
                    ErrMsg.Text = "Author Deleted!!!";
                    ANameTb.Value = "";
                    GenCb.SelectedIndex = -1;
                    CountryCb.SelectedIndex = -1;
                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }
    }
}