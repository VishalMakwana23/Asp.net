﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ASS3_Q5")]
public partial class studDataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Insertclass(@class instance);
  partial void Updateclass(@class instance);
  partial void Deleteclass(@class instance);
  partial void Insertcourse(course instance);
  partial void Updatecourse(course instance);
  partial void Deletecourse(course instance);
  partial void Insertstudent(student instance);
  partial void Updatestudent(student instance);
  partial void Deletestudent(student instance);
  #endregion
	
	public studDataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ASS3_Q5ConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public studDataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public studDataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public studDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public studDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<@class> classes
	{
		get
		{
			return this.GetTable<@class>();
		}
	}
	
	public System.Data.Linq.Table<course> courses
	{
		get
		{
			return this.GetTable<course>();
		}
	}
	
	public System.Data.Linq.Table<student> students
	{
		get
		{
			return this.GetTable<student>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.class")]
public partial class @class : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private decimal _class_id;
	
	private System.Nullable<decimal> _course_id;
	
	private string _class_name;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onclass_idChanging(decimal value);
    partial void Onclass_idChanged();
    partial void Oncourse_idChanging(System.Nullable<decimal> value);
    partial void Oncourse_idChanged();
    partial void Onclass_nameChanging(string value);
    partial void Onclass_nameChanged();
    #endregion
	
	public @class()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_class_id", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
	public decimal class_id
	{
		get
		{
			return this._class_id;
		}
		set
		{
			if ((this._class_id != value))
			{
				this.Onclass_idChanging(value);
				this.SendPropertyChanging();
				this._class_id = value;
				this.SendPropertyChanged("class_id");
				this.Onclass_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_course_id", DbType="Decimal(18,0)")]
	public System.Nullable<decimal> course_id
	{
		get
		{
			return this._course_id;
		}
		set
		{
			if ((this._course_id != value))
			{
				this.Oncourse_idChanging(value);
				this.SendPropertyChanging();
				this._course_id = value;
				this.SendPropertyChanged("course_id");
				this.Oncourse_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_class_name", DbType="NVarChar(50)")]
	public string class_name
	{
		get
		{
			return this._class_name;
		}
		set
		{
			if ((this._class_name != value))
			{
				this.Onclass_nameChanging(value);
				this.SendPropertyChanging();
				this._class_name = value;
				this.SendPropertyChanged("class_name");
				this.Onclass_nameChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.course")]
public partial class course : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private decimal _course_id;
	
	private string _course_name;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncourse_idChanging(decimal value);
    partial void Oncourse_idChanged();
    partial void Oncourse_nameChanging(string value);
    partial void Oncourse_nameChanged();
    #endregion
	
	public course()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_course_id", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
	public decimal course_id
	{
		get
		{
			return this._course_id;
		}
		set
		{
			if ((this._course_id != value))
			{
				this.Oncourse_idChanging(value);
				this.SendPropertyChanging();
				this._course_id = value;
				this.SendPropertyChanged("course_id");
				this.Oncourse_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_course_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string course_name
	{
		get
		{
			return this._course_name;
		}
		set
		{
			if ((this._course_name != value))
			{
				this.Oncourse_nameChanging(value);
				this.SendPropertyChanging();
				this._course_name = value;
				this.SendPropertyChanged("course_name");
				this.Oncourse_nameChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.student")]
public partial class student : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private decimal _enrollno;
	
	private System.Nullable<decimal> _rollno;
	
	private string _name;
	
	private string _class;
	
	private string _course;
	
	private string _email;
	
	private string _mobile;
	
	private string _dob;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnenrollnoChanging(decimal value);
    partial void OnenrollnoChanged();
    partial void OnrollnoChanging(System.Nullable<decimal> value);
    partial void OnrollnoChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnclassChanging(string value);
    partial void OnclassChanged();
    partial void OncourseChanging(string value);
    partial void OncourseChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnmobileChanging(string value);
    partial void OnmobileChanged();
    partial void OndobChanging(string value);
    partial void OndobChanged();
    #endregion
	
	public student()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_enrollno", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
	public decimal enrollno
	{
		get
		{
			return this._enrollno;
		}
		set
		{
			if ((this._enrollno != value))
			{
				this.OnenrollnoChanging(value);
				this.SendPropertyChanging();
				this._enrollno = value;
				this.SendPropertyChanged("enrollno");
				this.OnenrollnoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rollno", DbType="Decimal(18,0)")]
	public System.Nullable<decimal> rollno
	{
		get
		{
			return this._rollno;
		}
		set
		{
			if ((this._rollno != value))
			{
				this.OnrollnoChanging(value);
				this.SendPropertyChanging();
				this._rollno = value;
				this.SendPropertyChanged("rollno");
				this.OnrollnoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50)")]
	public string name
	{
		get
		{
			return this._name;
		}
		set
		{
			if ((this._name != value))
			{
				this.OnnameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("name");
				this.OnnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="class", Storage="_class", DbType="NVarChar(50)")]
	public string @class
	{
		get
		{
			return this._class;
		}
		set
		{
			if ((this._class != value))
			{
				this.OnclassChanging(value);
				this.SendPropertyChanging();
				this._class = value;
				this.SendPropertyChanged("@class");
				this.OnclassChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_course", DbType="NVarChar(50)")]
	public string course
	{
		get
		{
			return this._course;
		}
		set
		{
			if ((this._course != value))
			{
				this.OncourseChanging(value);
				this.SendPropertyChanging();
				this._course = value;
				this.SendPropertyChanged("course");
				this.OncourseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50)")]
	public string email
	{
		get
		{
			return this._email;
		}
		set
		{
			if ((this._email != value))
			{
				this.OnemailChanging(value);
				this.SendPropertyChanging();
				this._email = value;
				this.SendPropertyChanged("email");
				this.OnemailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mobile", DbType="NVarChar(50)")]
	public string mobile
	{
		get
		{
			return this._mobile;
		}
		set
		{
			if ((this._mobile != value))
			{
				this.OnmobileChanging(value);
				this.SendPropertyChanging();
				this._mobile = value;
				this.SendPropertyChanged("mobile");
				this.OnmobileChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dob", DbType="NVarChar(50)")]
	public string dob
	{
		get
		{
			return this._dob;
		}
		set
		{
			if ((this._dob != value))
			{
				this.OndobChanging(value);
				this.SendPropertyChanging();
				this._dob = value;
				this.SendPropertyChanged("dob");
				this.OndobChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#pragma warning restore 1591
