﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DBSystem.BLL;
using DBSystem.ENTITIES;

namespace WebApp.Pages
{
    public partial class CRUDPage : System.Web.UI.Page
    {
        private static List<Entity02> Entity02List = new List<Entity02>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string pid = Request.QueryString["pid"];
                if (string.IsNullOrEmpty(pid))
                {
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    MessageLabel.Text = "you passed the following data: >" + pid + "<";
                }
            }

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }




        protected void Add_Click(object sender, EventArgs e)
        {
            //MessageLabel.Text = "SIN = " + SIN.Text + " Name = " + Name.Text;
            //if (Page.IsValid)
            //{
            //    bool found = false;
            //    foreach (var item in Entity02List)
            //    {
            //        if (item.ProductID == ID.Text)
            //        {
            //            found = true;
            //        }
            //    }
            //    if (found)
            //    {
            //        MessageLabel.Text = "Record already exists.";
            //    }
            //    else
            //    {
            //        Person newitem = new Person(SIN.Text, Name.Text, int.Parse(Age.Text), double.Parse(Wage.Text), Phone.Text);
            //        People.Add(newitem);
            //        PeopleGridView.DataSource = People;
            //        PeopleGridView.DataBind();
            //    }
            //}
        }
        protected void Clear_Click(object sender, EventArgs e)
        {
            
        }
    }
}