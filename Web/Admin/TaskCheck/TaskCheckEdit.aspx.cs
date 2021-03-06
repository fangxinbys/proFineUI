﻿using FineUIPro;
 
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

namespace Maticsoft.Web.Admin.TaskCheck
{
    public partial class TaskCheckEdit : PageBase
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                btnClose.OnClientClick = ActiveWindow.GetHideReference();

                DateTimeCh.SelectedDate = DateTime.Now;

                if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
                {

                    Maticsoft.BLL.PocketTaskSub bll = new Maticsoft.BLL.PocketTaskSub();
                    Maticsoft.Model.PocketTaskSub model = bll.GetModel(int.Parse(Request.QueryString["Id"]));
                    imgPhoto.ImageUrl = "../../smobiler/Resources/Upload/sub" + model.subInfo + ".jpg";
                    if (File.Exists(Server.MapPath("../../smobiler/Resources/Upload/sub" + model.subInfo2 + ".jpg")))
                    {

                        Image2.ImageUrl = "../../smobiler/Resources/Upload/sub" + model.subInfo2 + ".jpg";
                    }
                    if (File.Exists(Server.MapPath("../../smobiler/Resources/Upload/sub" + model.subInfo3 + ".jpg")))
                    {

                        Image3.ImageUrl = "../../smobiler/Resources/Upload/sub" + model.subInfo3 + ".jpg";
                    }
                    if (File.Exists(Server.MapPath("../../smobiler/Resources/Upload/sub" + model.subInfo4 + ".jpg")))
                    {

                        Image4.ImageUrl = "../../smobiler/Resources/Upload/sub" + model.subInfo4 + ".jpg";
                    }
                    if (File.Exists(Server.MapPath("../../smobiler/Resources/Upload/sub" + model.subInfo5 + ".jpg")))
                    {

                        Image5.ImageUrl = "../../smobiler/Resources/Upload/sub" + model.subInfo5 + ".jpg";
                    }
                    txtUser.Text = model.subUser;
                    if (model.examine==false)
                    {
                        CheckTask.SelectedValue = "0";
                    }
                    if (model.examine == true)
                    {
                        CheckTask.SelectedValue = "1";
                    }
                    Maticsoft.BLL.PocketTask bllTask = new Maticsoft.BLL.PocketTask();
                    Maticsoft.Model.PocketTask modelTask = bllTask.GetModel((int)model.subTaskId);
                    txtMoney.Text = modelTask.pocketTaskMoney.ToString();
                    DateTimeCh.SelectedDate = model.subTime;
                    txtRemark.Text = model.subRemake;
                }
            }
        }

        
 

        protected void btnSave_Click(object sender, EventArgs e)
        {
   
         

            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {

                Maticsoft.BLL.PocketTaskSub bll = new Maticsoft.BLL.PocketTaskSub();
                Maticsoft.Model.PocketTaskSub model = bll.GetModel(int.Parse(Request.QueryString["Id"]));

                model.examine = CheckTask.SelectedValue=="1" ? true : false;
                model.subRemake = txtRemark.Text;

                bll.Update(model);
                PageContext.RegisterStartupScript(ActiveWindow.GetHidePostBackReference());
            }
          
        }
    }
}