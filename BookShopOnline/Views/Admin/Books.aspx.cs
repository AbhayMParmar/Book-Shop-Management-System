﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShopOnline.Views.Admin
{
    public partial class Books : System.Web.UI.Page
    {
        Models.Function Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Function();
            if (!IsPostBack)
            {
                ShowBooks();
                GetCategories();
                GetAuthors();
                
            }

        }
        private void ShowBooks()
        {
            string Query = "Select * from BookTbl";
            BooksList.DataSource = Con.GetData(Query);
            BooksList.DataBind();
        }
        private void GetCategories()
        {
            string Query = "Select * from CategoryTbl";
            BCatCb.DataTextField = Con.GetData(Query).Columns["CatName"].ToString();
            BCatCb.DataValueField = Con.GetData(Query).Columns["CatId"].ToString();
            BCatCb.DataSource = Con.GetData(Query);
            BCatCb.DataBind();
        }
        private void GetAuthors()
        {
            string Query = "Select * from AuthorTbl1";
            BAuthCb.DataTextField = Con.GetData(Query).Columns["AutName"].ToString();
            BAuthCb.DataValueField = Con.GetData(Query).Columns["AutId"].ToString();
            BAuthCb.DataSource = Con.GetData(Query);
            BAuthCb.DataBind();
        }
        int Key = 0;    
        protected void AuthorsList_SelectedIndexChanged1(object sender, EventArgs e)
        {
            BNameTb.Value = BooksList.SelectedRow.Cells[2].Text;
            BAuthCb.SelectedValue = BooksList.SelectedRow.Cells[3].Text;
            BCatCb.SelectedValue = BooksList.SelectedRow.Cells[4].Text;
            QtyTb.Value = BooksList.SelectedRow.Cells[5].Text;
            PriceTb.Value = BooksList.SelectedRow.Cells[6].Text;
            if (BNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BooksList.SelectedRow.Cells[1].Text);
            }
        }

        protected void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (BNameTb.Value == "" || BAuthCb.SelectedIndex == -1 || BCatCb.SelectedIndex == -1 || QtyTb.Value == "" || PriceTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!!";
                }
                else
                {
                    string BName = BNameTb.Value;
                    string BAuth = BAuthCb.SelectedValue.ToString();
                    string BCategory = BCatCb.SelectedValue.ToString();
                    int Quantity = Convert.ToInt32(QtyTb.Value);
                    int Price = Convert.ToInt32(PriceTb.Value);

                    string Query = "insert into BookTbl values('{0}',{1},{2},{3},{4})";
                    Query = string.Format(Query, BName, BAuth, BCategory,Quantity,Price);
                    Con.SetData(Query);
                    ShowBooks();
                    ErrMsg.Text = "Books Inserted!!!";
                    BNameTb.Value = "";
                    BAuthCb.SelectedIndex = -1;
                    BCatCb.SelectedIndex = -1;
                    QtyTb.Value = "" ;
                    PriceTb.Value = "";
                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        protected void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (BNameTb.Value == "" || BAuthCb.SelectedIndex == -1 || BCatCb.SelectedIndex == -1 || QtyTb.Value == "" || PriceTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!!";
                }
                else
                {
                    string BName = BNameTb.Value;
                    string BAuth = BAuthCb.SelectedValue.ToString();
                    string BCategory = BCatCb.SelectedValue.ToString();
                    int Quantity = Convert.ToInt32(QtyTb.Value);
                    int Price = Convert.ToInt32(PriceTb.Value);

                    string Query = "Update BookTbl set BName = '{0}',BAuthor = {1},BCategory = {2},BQty = {3},BPrice = {4} where BId = {5}";
                    Query = string.Format(Query, BName, BAuth, BCategory, Quantity, Price, BooksList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowBooks();
                    ErrMsg.Text = "Books Updated!!!";
                    BNameTb.Value = "";
                    BAuthCb.SelectedIndex = -1;
                    BCatCb.SelectedIndex = -1;
                    QtyTb.Value = "";
                    PriceTb.Value = "";
                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        protected void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (BNameTb.Value == "" || BAuthCb.SelectedIndex == -1 || BCatCb.SelectedIndex == -1 || QtyTb.Value == "" || PriceTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!!";
                }
                else
                {
                    string BName = BNameTb.Value;
                    string BAuth = BAuthCb.SelectedValue.ToString();
                    string BCategory = BCatCb.SelectedValue.ToString();
                    int Quantity = Convert.ToInt32(QtyTb.Value);
                    int Price = Convert.ToInt32(PriceTb.Value);

                    string Query = "Delete from BookTbl  where BId = {0}";
                    Query = string.Format(Query, BooksList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowBooks();
                    ErrMsg.Text = "Books Deleted!!!";
                    BNameTb.Value = "";
                    BAuthCb.SelectedIndex = -1;
                    BCatCb.SelectedIndex = -1;
                    QtyTb.Value = "";
                    PriceTb.Value = "";
                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }
    }
}