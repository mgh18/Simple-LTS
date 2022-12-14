#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simple_LTS
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="crudTest")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertstudent(student instance);
    partial void Updatestudent(student instance);
    partial void Deletestudent(student instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Simple_LTS.Properties.Settings.Default.crudTestConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<student> students
		{
			get
			{
				return this.GetTable<student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.student")]
	public sealed partial class student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _sid;
		
		private string _sname;
		
		private string _sfamily;
		
		private string _scmeli;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsidChanging(int value);
    partial void OnsidChanged();
    partial void OnsnameChanging(string value);
    partial void OnsnameChanged();
    partial void OnsfamilyChanging(string value);
    partial void OnsfamilyChanged();
    partial void OnscmeliChanging(string value);
    partial void OnscmeliChanged();
    #endregion
		
		public student()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sid", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int sid
		{
			get
			{
				return this._sid;
			}
			set
			{
				if ((this._sid != value))
				{
					this.OnsidChanging(value);
					this.SendPropertyChanging();
					this._sid = value;
					this.SendPropertyChanged("sid");
					this.OnsidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sname", DbType="NVarChar(30)")]
		public string sname
		{
			get
			{
				return this._sname;
			}
			set
			{
				if ((this._sname != value))
				{
					this.OnsnameChanging(value);
					this.SendPropertyChanging();
					this._sname = value;
					this.SendPropertyChanged("sname");
					this.OnsnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sfamily", DbType="NVarChar(50)")]
		public string sfamily
		{
			get
			{
				return this._sfamily;
			}
			set
			{
				if ((this._sfamily != value))
				{
					this.OnsfamilyChanging(value);
					this.SendPropertyChanging();
					this._sfamily = value;
					this.SendPropertyChanged("sfamily");
					this.OnsfamilyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_scmeli", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string scmeli
		{
			get
			{
				return this._scmeli;
			}
			set
			{
				if ((this._scmeli != value))
				{
					this.OnscmeliChanging(value);
					this.SendPropertyChanging();
					this._scmeli = value;
					this.SendPropertyChanged("scmeli");
					this.OnscmeliChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		private void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		private void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
