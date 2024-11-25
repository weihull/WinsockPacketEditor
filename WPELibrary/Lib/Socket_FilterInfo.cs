﻿using System;

namespace WPELibrary.Lib
{
    public class Socket_FilterInfo
    {
        #region//序号

        protected int fnum;

        public int FNum
        {
            get { return fnum; }
            set { fnum = value; }
        }

        #endregion

        #region//是否启用

        protected bool isenable;

        public bool IsEnable
        {
            get { return isenable; }
            set { isenable = value; }
        }

        #endregion

        #region//滤镜名称

        protected string fname;

        public string FName
        {
            get { return fname; }
            set { fname = value; }
        }

        #endregion

        #region//是否指定包头

        protected bool appointheader;

        public bool AppointHeader
        {
            get { return appointheader; }
            set { appointheader = value; }
        }

        #endregion

        #region//包头内容

        protected string headercontent;

        public string HeaderContent
        {
            get { return headercontent; }
            set { headercontent = value; }
        }

        #endregion        

        #region//模式

        protected Socket_Cache.Filter.FilterMode fmode;

        public Socket_Cache.Filter.FilterMode FMode
        {
            get { return fmode; }
            set { fmode = value; }
        }

        #endregion        

        #region//动作

        protected Socket_Cache.Filter.FilterAction faction;

        public Socket_Cache.Filter.FilterAction FAction
        {
            get { return faction; }
            set { faction = value; }
        }

        #endregion        

        #region//作用类别

        protected Socket_Cache.Filter.FilterFunction ffunction;

        public Socket_Cache.Filter.FilterFunction FFunction
        {
            get { return ffunction; }
            set { ffunction = value; }
        }

        #endregion        

        #region//修改起始于

        protected Socket_Cache.Filter.FilterStartFrom fstartfrom;

        public Socket_Cache.Filter.FilterStartFrom FStartFrom
        {
            get { return fstartfrom; }
            set { fstartfrom = value; }
        }

        #endregion        

        #region//搜索内容

        protected string fsearch;

        public string FSearch
        {
            get { return fsearch; }
            set { fsearch = value; }
        }

        #endregion        

        #region//修改内容

        protected string fmodify;

        public string FModify
        {
            get { return fmodify; }
            set { fmodify = value; }
        }

        #endregion        

        #region//Socket_FilterInfo

        public Socket_FilterInfo(bool IsEnable, int FNum, string FName, bool AppointHeader, string HeaderContent, Socket_Cache.Filter.FilterMode FMode, Socket_Cache.Filter.FilterAction FAction, Socket_Cache.Filter.FilterFunction FFunction, Socket_Cache.Filter.FilterStartFrom FStartFrom, string FSearch, string FModify) 
        {
            this.isenable = IsEnable;
            this.fnum = FNum;            
            this.fname = FName;
            this.appointheader = AppointHeader;
            this.headercontent = HeaderContent;
            this.fmode = FMode;
            this.faction = FAction;
            this.ffunction = FFunction;
            this.fstartfrom = FStartFrom;            
            this.fsearch = FSearch;          
            this.fmodify = FModify;         
        }

        #endregion
    }
}
