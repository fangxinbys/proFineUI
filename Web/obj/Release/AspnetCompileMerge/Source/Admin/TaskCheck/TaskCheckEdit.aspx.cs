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
                    if (File.Exists(@"~/smobiler/Resources/Upload/" + model.subInfo + ".jpg"))
                    {
                        imgPhoto.ImageUrl = "~/smobiler/Resources/Upload/" + model.subInfo + ".jpg";
                    }
                    if (File.Exists(@"~/smobiler/Resources/Upload/" + model.subInfo + ".png"))
                    {
                        imgPhoto.ImageUrl = "~/smobiler/Resources/Upload/" + model.subInfo + ".png";
                    }
                  
                    txtUser.Text = model.subUser; 
                    CheckTask.Checked =  model.examine;
                    Maticsoft.BLL.PocketTask bllTask = new Maticsoft.BLL.PocketTask();
                    Maticsoft.Model.PocketTask modelTask = bllTask.GetModel((int)model.subTaskId);
                    txtMoney.Text = modelTask.pocketTaskMoney.ToString();
                    DateTimeCh.SelectedDate = model.subTime;
                   
                }
            }
        }

        
 

        protected void btnSave_Click(object sender, EventArgs e)
        {
   
         

            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {

                Maticsoft.BLL.PocketTaskSub bll = new Maticsoft.BLL.PocketTaskSub();
                Maticsoft.Model.PocketTaskSub model = bll.GetModel(int.Parse(Request.QueryString["Id"]));

                model.examine = CheckTask.Checked ? true : false;


                bll.Update(model);
                PageContext.RegisterStartupScript(ActiveWindow.GetHidePostBackReference());
            }
          
        }
    }
}