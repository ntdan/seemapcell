﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.488
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Linq2SqlGeography.LinqSql.ToMap
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SqlSpatialJiangmeng")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Linq2SqlGeography.Properties.Settings.Default.SqlSpatialTestConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EventLocating> EventLocating
		{
			get
			{
				return this.GetTable<EventLocating>();
			}
		}
		
		public System.Data.Linq.Table<CellTracing> CellTracing
		{
			get
			{
				return this.GetTable<CellTracing>();
			}
		}
		
		public System.Data.Linq.Table<CELLTRACINGqq> CELLTRACINGqq
		{
			get
			{
				return this.GetTable<CELLTRACINGqq>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EventLocating")]
	public partial class EventLocating
	{
		
		private string _SiteName;
		
		private string _MI_STYLE;
		
		private int _MI_PRINX;
		
		private Microsoft.SqlServer.Types.SqlGeometry _SP_GEOMETRY;
		
		public EventLocating()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiteName", DbType="VarChar(30)")]
		public string events
		{
			get
			{
				return this._SiteName;
			}
			set
			{
				if ((this._SiteName != value))
				{
					this._SiteName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MI_STYLE", DbType="VarChar(254)")]
		public string MI_STYLE
		{
			get
			{
				return this._MI_STYLE;
			}
			set
			{
				if ((this._MI_STYLE != value))
				{
					this._MI_STYLE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MI_PRINX", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int MI_PRINX
		{
			get
			{
				return this._MI_PRINX;
			}
			set
			{
				if ((this._MI_PRINX != value))
				{
					this._MI_PRINX = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SP_GEOMETRY", UpdateCheck=UpdateCheck.Never)]
		public Microsoft.SqlServer.Types.SqlGeometry SP_GEOMETRY
		{
			get
			{
				return this._SP_GEOMETRY;
			}
			set
			{
				if ((this._SP_GEOMETRY != value))
				{
					this._SP_GEOMETRY = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CellTracing")]
	public partial class CellTracing
	{
		
		private string _SiteName;
		
		private string _MI_STYLE;
		
		private int _MI_PRINX;
		
		private Microsoft.SqlServer.Types.SqlGeometry _SP_GEOMETRY;
		
		public CellTracing()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiteName", DbType="VarChar(30)")]
		public string cell
		{
			get
			{
				return this._SiteName;
			}
			set
			{
				if ((this._SiteName != value))
				{
					this._SiteName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MI_STYLE", DbType="VarChar(254)")]
		public string MI_STYLE
		{
			get
			{
				return this._MI_STYLE;
			}
			set
			{
				if ((this._MI_STYLE != value))
				{
					this._MI_STYLE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MI_PRINX", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int MI_PRINX
		{
			get
			{
				return this._MI_PRINX;
			}
			set
			{
				if ((this._MI_PRINX != value))
				{
					this._MI_PRINX = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SP_GEOMETRY", UpdateCheck=UpdateCheck.Never)]
		public Microsoft.SqlServer.Types.SqlGeometry SP_GEOMETRY
		{
			get
			{
				return this._SP_GEOMETRY;
			}
			set
			{
				if ((this._SP_GEOMETRY != value))
				{
					this._SP_GEOMETRY = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CELLTRACINGqq")]
	public partial class CELLTRACINGqq
	{
		
		private string _SiteName;
		
		private string _MI_STYLE;
		
		private int _MI_PRINX;
		
		private System.Data.Linq.Binary _SP_GEOMETRY;
		
		public CELLTRACINGqq()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiteName", DbType="VarChar(30)")]
		public string SiteName
		{
			get
			{
				return this._SiteName;
			}
			set
			{
				if ((this._SiteName != value))
				{
					this._SiteName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MI_STYLE", DbType="VarChar(254)")]
		public string MI_STYLE
		{
			get
			{
				return this._MI_STYLE;
			}
			set
			{
				if ((this._MI_STYLE != value))
				{
					this._MI_STYLE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MI_PRINX", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int MI_PRINX
		{
			get
			{
				return this._MI_PRINX;
			}
			set
			{
				if ((this._MI_PRINX != value))
				{
					this._MI_PRINX = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SP_GEOMETRY", DbType="VarBinary(1)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary SP_GEOMETRY
		{
			get
			{
				return this._SP_GEOMETRY;
			}
			set
			{
				if ((this._SP_GEOMETRY != value))
				{
					this._SP_GEOMETRY = value;
				}
			}
		}
	}
}
#pragma warning restore 1591