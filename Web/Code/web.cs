﻿using FineUIPro;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using qcloudsms_csharp;
using qcloudsms_csharp.json;
using qcloudsms_csharp.httpclient;
using System.Configuration;

namespace Maticsoft.Web.Code
{
    public class web
    {

        /// <summary>
        /// 短信验证码  {1}短信内容  {2}有效时间
        /// </summary>
        public void sendMsg(string[] phoneNumbers, int templateId)
        {

            // 短信应用SDK AppID
            int appid = int.Parse(ConfigurationManager.AppSettings["appid"]);

            // 短信应用SDK AppKey
            string appkey = ConfigurationManager.AppSettings["appkey"];

            // 需要发送短信的手机号码
            //string[] phoneNumbers = { "13839870291", "15290319652" }; 

            string strRs = "";

            string smsSign = ""; // NOTE: 这里默认签名 
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                try
                {
                    SmsSingleSender ssender = new SmsSingleSender(appid, appkey);
                    var result = ssender.sendWithParam("86", phoneNumbers[i],
                        templateId, new[] { "5678", "3" }, smsSign, "", "");
                    strRs += result;
                }
                catch (JSONException ex)
                {
                    strRs += ";" + ex;
                    Console.WriteLine(ex);
                }
                catch (HTTPException ex)
                {
                    strRs += ";" + ex;
                    Console.WriteLine(ex);
                }
                catch (Exception ex)
                {
                    strRs += ";" + ex;
                    Console.WriteLine(ex);
                }
            }
        }

        public void SetWebHeader(Page page)
        {
            Maticsoft.BLL.tSet bll = new Maticsoft.BLL.tSet();
            Maticsoft.Model.tSet model = bll.GetModel(1);
            HtmlMeta keywords = new HtmlMeta();
            keywords.Name = "keywords";
            keywords.Content = model.KeyWords;
            page.Header.Controls.Add(keywords);
            HtmlMeta description = new HtmlMeta();
            description.Name = "description";
            description.Content = model.Description;
            page.Header.Controls.Add(description);
        }


        public void AddStyle(Page page, int index)
        {
            Literal li = new Literal();

            li.Text = "<style type=\"text/css\"> </style>";
            page.Header.Controls.AddAt(index, li);
        }





    }
}