﻿using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// PocketBalance:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PocketBalance
	{
		public PocketBalance()
		{}
		#region Model
		private int _balanceid;
		private string _balanceuser;
		private decimal? _balancemoney;
		private DateTime? _balancetime;
		/// <summary>
		/// 
		/// </summary>
		public int balanceId
		{
			set{ _balanceid=value;}
			get{return _balanceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string balanceUser
		{
			set{ _balanceuser=value;}
			get{return _balanceuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? balanceMoney
		{
			set{ _balancemoney=value;}
			get{return _balancemoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? balanceTime
		{
			set{ _balancetime=value;}
			get{return _balancetime;}
		}
		#endregion Model

	}
}

