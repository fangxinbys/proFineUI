﻿using System;
using Smobiler.Core;
namespace smbApp
{
    partial class frmMenuMain : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Smobiler.Core.Controls.ToolBarItem toolBarItem5 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem6 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem7 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem8 = new Smobiler.Core.Controls.ToolBarItem();
            this.panTop = new Smobiler.Core.Controls.Panel();
            this.panNav = new Smobiler.Core.Controls.Panel();
            this.imgBtnNav = new Smobiler.Core.Controls.ImageButton();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.panelBottom = new Smobiler.Core.Controls.Panel();
            this.toolBarMain = new Smobiler.Core.Controls.ToolBar();
            this.panelMain = new Smobiler.Core.Controls.Panel();
            this.panelBanner = new Smobiler.Core.Controls.Panel();
            this.pageMainView = new Smobiler.Core.Controls.PageView();
            this.panelIcon = new Smobiler.Core.Controls.Panel();
            this.iconMenuView = new Smobiler.Core.Controls.IconMenuView();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.Maroon;
            this.panTop.BorderColor = System.Drawing.Color.Transparent;
            this.panTop.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panNav,
            this.labTitle});
            this.panTop.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 100);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(300, 35);
            // 
            // panNav
            // 
            this.panNav.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgBtnNav});
            this.panNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panNav.Name = "panNav";
            this.panNav.Size = new System.Drawing.Size(60, 100);
            // 
            // imgBtnNav
            // 
            this.imgBtnNav.BackColor = System.Drawing.Color.Maroon;
            this.imgBtnNav.BorderColor = System.Drawing.Color.Transparent;
            this.imgBtnNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBtnNav.ForeColor = System.Drawing.Color.White;
            this.imgBtnNav.IconColor = System.Drawing.Color.White;
            this.imgBtnNav.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imgBtnNav.Location = new System.Drawing.Point(17, 11);
            this.imgBtnNav.Name = "imgBtnNav";
            this.imgBtnNav.ResourceID = "bars";
            this.imgBtnNav.Size = new System.Drawing.Size(100, 30);
            this.imgBtnNav.Press += new System.EventHandler(this.imgBtnNav_Press);
            // 
            // labTitle
            // 
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labTitle.FontSize = 16F;
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.labTitle.Location = new System.Drawing.Point(0, 10);
            this.labTitle.Name = "labTitle";
            this.labTitle.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 50F, 0F);
            this.labTitle.Size = new System.Drawing.Size(100, 35);
            this.labTitle.Text = "功能列表";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.toolBarMain});
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(57, 469);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(300, 50);
            // 
            // toolBarMain
            // 
            this.toolBarMain.BackColor = System.Drawing.Color.White;
            this.toolBarMain.Dock = System.Windows.Forms.DockStyle.Fill;
            toolBarItem5.IconColor = System.Drawing.Color.Maroon;
            toolBarItem5.IconID = "home";
            toolBarItem5.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem5.Name = "主页";
            toolBarItem5.SelectIconColor = System.Drawing.Color.White;
            toolBarItem5.Text = "主页";
            toolBarItem6.IconColor = System.Drawing.Color.Maroon;
            toolBarItem6.IconID = "bell";
            toolBarItem6.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem6.Name = "通知";
            toolBarItem6.SelectIconColor = System.Drawing.Color.White;
            toolBarItem6.Text = "通知";
            toolBarItem7.IconColor = System.Drawing.Color.Maroon;
            toolBarItem7.IconID = "book";
            toolBarItem7.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem7.Name = "我的";
            toolBarItem7.SelectIconColor = System.Drawing.Color.White;
            toolBarItem7.Text = "我的";
            toolBarItem8.IconColor = System.Drawing.Color.Maroon;
            toolBarItem8.IconID = "asterisk";
            toolBarItem8.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem8.Name = "设置";
            toolBarItem8.SelectIconColor = System.Drawing.Color.White;
            toolBarItem8.Text = "设置";
            this.toolBarMain.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem5,
            toolBarItem6,
            toolBarItem7,
            toolBarItem8});
            this.toolBarMain.Name = "toolBarMain";
            this.toolBarMain.SelectBackColor = System.Drawing.Color.Maroon;
            this.toolBarMain.SelectForeColor = System.Drawing.Color.White;
            this.toolBarMain.Size = new System.Drawing.Size(100, 40);
            this.toolBarMain.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBarMain_ToolbarItemClick);
            // 
            // panelMain
            // 
            this.panelMain.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panelBanner,
            this.panelIcon});
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(21, 211);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(300, 300);
            // 
            // panelBanner
            // 
            this.panelBanner.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.pageMainView});
            this.panelBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(300, 115);
            // 
            // pageMainView
            // 
            this.pageMainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageMainView.Location = new System.Drawing.Point(65, 38);
            this.pageMainView.Name = "pageMainView";
            this.pageMainView.Size = new System.Drawing.Size(300, 300);
            this.pageMainView.TemplateControlName = "mainBanner";
            // 
            // panelIcon
            // 
            this.panelIcon.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.iconMenuView});
            this.panelIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(300, 115);
            // 
            // iconMenuView
            // 
            this.iconMenuView.BorderRadius = 1;
            this.iconMenuView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconMenuView.GridLines = true;
            this.iconMenuView.Location = new System.Drawing.Point(39, 28);
            this.iconMenuView.MenuItemHeight = 65;
            this.iconMenuView.MessageForeColor = System.Drawing.Color.White;
            this.iconMenuView.Name = "iconMenuView";
            this.iconMenuView.Size = new System.Drawing.Size(174, 125);
            this.iconMenuView.ItemPress += new Smobiler.Core.Controls.IconMenuViewItemPressClickHandler(this.iconMenuView_ItemPress);
            // 
            // frmMenuMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panTop,
            this.panelBottom,
            this.panelMain});
            this.DrawerWidth = 200;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmMenuMain_KeyDown);
            this.Load += new System.EventHandler(this.frmMenuMain_Load);
            this.Name = "frmMenuMain";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panTop;
        private Smobiler.Core.Controls.Panel panNav;
        private Smobiler.Core.Controls.ImageButton imgBtnNav;
        private Smobiler.Core.Controls.Label labTitle;
        private Smobiler.Core.Controls.Panel panelBottom;
        private Smobiler.Core.Controls.ToolBar toolBarMain;
        private Smobiler.Core.Controls.Panel panelMain;
        private Smobiler.Core.Controls.Panel panelBanner;
        private Smobiler.Core.Controls.Panel panelIcon;
        private Smobiler.Core.Controls.IconMenuView iconMenuView;
        private Smobiler.Core.Controls.PageView pageMainView;
    }
}