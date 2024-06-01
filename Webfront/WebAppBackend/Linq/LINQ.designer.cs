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

namespace WebAppBackend.Linq
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SPM")]
	public partial class LINQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPosition(Position instance);
    partial void UpdatePosition(Position instance);
    partial void DeletePosition(Position instance);
    partial void InsertTeacher(Teacher instance);
    partial void UpdateTeacher(Teacher instance);
    partial void DeleteTeacher(Teacher instance);
        #endregion

        public LINQDataContext() :
                base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SPMConnectionString"].ConnectionString, mappingSource)
        {
            OnCreated();
        }
        public LINQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Position> Positions
		{
			get
			{
				return this.GetTable<Position>();
			}
		}
		
		public System.Data.Linq.Table<Teacher> Teachers
		{
			get
			{
				return this.GetTable<Teacher>();
			}
		}
		
		public System.Data.Linq.Table<Table_City> Table_Cities
		{
			get
			{
				return this.GetTable<Table_City>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Position")]
	public partial class Position : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _PositionID;
		
		private string _PositionName;
		
		private System.Nullable<bool> _Active;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<System.DateTime> _Modified;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPositionIDChanging(string value);
    partial void OnPositionIDChanged();
    partial void OnPositionNameChanging(string value);
    partial void OnPositionNameChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedChanging(System.Nullable<System.DateTime> value);
    partial void OnModifiedChanged();
    #endregion
		
		public Position()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string PositionID
		{
			get
			{
				return this._PositionID;
			}
			set
			{
				if ((this._PositionID != value))
				{
					this.OnPositionIDChanging(value);
					this.SendPropertyChanging();
					this._PositionID = value;
					this.SendPropertyChanged("PositionID");
					this.OnPositionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionName", DbType="NVarChar(50)")]
		public string PositionName
		{
			get
			{
				return this._PositionName;
			}
			set
			{
				if ((this._PositionName != value))
				{
					this.OnPositionNameChanging(value);
					this.SendPropertyChanging();
					this._PositionName = value;
					this.SendPropertyChanged("PositionName");
					this.OnPositionNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modified", DbType="DateTime")]
		public System.Nullable<System.DateTime> Modified
		{
			get
			{
				return this._Modified;
			}
			set
			{
				if ((this._Modified != value))
				{
					this.OnModifiedChanging(value);
					this.SendPropertyChanging();
					this._Modified = value;
					this.SendPropertyChanged("Modified");
					this.OnModifiedChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Teacher")]
	public partial class Teacher : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TeacherID;
		
		private string _TeacherName;
		
		private string _Email;
		
		private string _PhoneNo;
		
		private string _Position;
		
		private string _City;
		
		private System.Nullable<int> _Age;
		
		private System.Nullable<System.DateTime> _StartDate;
		
		private System.Nullable<int> _Salary;
		
		private string _Gender;
		
		private System.Nullable<bool> _Myanmar;
		
		private System.Nullable<bool> _English;
		
		private System.Nullable<bool> _Mathematics;
		
		private System.Nullable<bool> _Chemistry;
		
		private System.Nullable<bool> _Physics;
		
		private System.Nullable<bool> _Biology;
		
		private System.Nullable<bool> _Active;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<System.DateTime> _Modified;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTeacherIDChanging(string value);
    partial void OnTeacherIDChanged();
    partial void OnTeacherNameChanging(string value);
    partial void OnTeacherNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneNoChanging(string value);
    partial void OnPhoneNoChanged();
    partial void OnPositionChanging(string value);
    partial void OnPositionChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    partial void OnStartDateChanging(System.Nullable<System.DateTime> value);
    partial void OnStartDateChanged();
    partial void OnSalaryChanging(System.Nullable<int> value);
    partial void OnSalaryChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnMyanmarChanging(System.Nullable<bool> value);
    partial void OnMyanmarChanged();
    partial void OnEnglishChanging(System.Nullable<bool> value);
    partial void OnEnglishChanged();
    partial void OnMathematicsChanging(System.Nullable<bool> value);
    partial void OnMathematicsChanged();
    partial void OnChemistryChanging(System.Nullable<bool> value);
    partial void OnChemistryChanged();
    partial void OnPhysicsChanging(System.Nullable<bool> value);
    partial void OnPhysicsChanged();
    partial void OnBiologyChanging(System.Nullable<bool> value);
    partial void OnBiologyChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedChanging(System.Nullable<System.DateTime> value);
    partial void OnModifiedChanged();
    #endregion
		
		public Teacher()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeacherID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TeacherID
		{
			get
			{
				return this._TeacherID;
			}
			set
			{
				if ((this._TeacherID != value))
				{
					this.OnTeacherIDChanging(value);
					this.SendPropertyChanging();
					this._TeacherID = value;
					this.SendPropertyChanged("TeacherID");
					this.OnTeacherIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeacherName", DbType="NVarChar(50)")]
		public string TeacherName
		{
			get
			{
				return this._TeacherName;
			}
			set
			{
				if ((this._TeacherName != value))
				{
					this.OnTeacherNameChanging(value);
					this.SendPropertyChanging();
					this._TeacherName = value;
					this.SendPropertyChanged("TeacherName");
					this.OnTeacherNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNo", DbType="NVarChar(50)")]
		public string PhoneNo
		{
			get
			{
				return this._PhoneNo;
			}
			set
			{
				if ((this._PhoneNo != value))
				{
					this.OnPhoneNoChanging(value);
					this.SendPropertyChanging();
					this._PhoneNo = value;
					this.SendPropertyChanged("PhoneNo");
					this.OnPhoneNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="NVarChar(50)")]
		public string Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this.OnPositionChanging(value);
					this.SendPropertyChanging();
					this._Position = value;
					this.SendPropertyChanged("Position");
					this.OnPositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this.OnStartDateChanging(value);
					this.SendPropertyChanging();
					this._StartDate = value;
					this.SendPropertyChanged("StartDate");
					this.OnStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Int")]
		public System.Nullable<int> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Myanmar", DbType="Bit")]
		public System.Nullable<bool> Myanmar
		{
			get
			{
				return this._Myanmar;
			}
			set
			{
				if ((this._Myanmar != value))
				{
					this.OnMyanmarChanging(value);
					this.SendPropertyChanging();
					this._Myanmar = value;
					this.SendPropertyChanged("Myanmar");
					this.OnMyanmarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_English", DbType="Bit")]
		public System.Nullable<bool> English
		{
			get
			{
				return this._English;
			}
			set
			{
				if ((this._English != value))
				{
					this.OnEnglishChanging(value);
					this.SendPropertyChanging();
					this._English = value;
					this.SendPropertyChanged("English");
					this.OnEnglishChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mathematics", DbType="Bit")]
		public System.Nullable<bool> Mathematics
		{
			get
			{
				return this._Mathematics;
			}
			set
			{
				if ((this._Mathematics != value))
				{
					this.OnMathematicsChanging(value);
					this.SendPropertyChanging();
					this._Mathematics = value;
					this.SendPropertyChanged("Mathematics");
					this.OnMathematicsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Chemistry", DbType="Bit")]
		public System.Nullable<bool> Chemistry
		{
			get
			{
				return this._Chemistry;
			}
			set
			{
				if ((this._Chemistry != value))
				{
					this.OnChemistryChanging(value);
					this.SendPropertyChanging();
					this._Chemistry = value;
					this.SendPropertyChanged("Chemistry");
					this.OnChemistryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Physics", DbType="Bit")]
		public System.Nullable<bool> Physics
		{
			get
			{
				return this._Physics;
			}
			set
			{
				if ((this._Physics != value))
				{
					this.OnPhysicsChanging(value);
					this.SendPropertyChanging();
					this._Physics = value;
					this.SendPropertyChanged("Physics");
					this.OnPhysicsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Biology", DbType="Bit")]
		public System.Nullable<bool> Biology
		{
			get
			{
				return this._Biology;
			}
			set
			{
				if ((this._Biology != value))
				{
					this.OnBiologyChanging(value);
					this.SendPropertyChanging();
					this._Biology = value;
					this.SendPropertyChanged("Biology");
					this.OnBiologyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modified", DbType="DateTime")]
		public System.Nullable<System.DateTime> Modified
		{
			get
			{
				return this._Modified;
			}
			set
			{
				if ((this._Modified != value))
				{
					this.OnModifiedChanging(value);
					this.SendPropertyChanging();
					this._Modified = value;
					this.SendPropertyChanged("Modified");
					this.OnModifiedChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Table_City")]
	public partial class Table_City
	{
		
		private string _CitydID;
		
		private string _CityName;
		
		private System.Nullable<bool> _Active;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<System.DateTime> _ModifiedOn;
		
		public Table_City()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CitydID", DbType="NVarChar(50)")]
		public string CitydID
		{
			get
			{
				return this._CitydID;
			}
			set
			{
				if ((this._CitydID != value))
				{
					this._CitydID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityName", DbType="NVarChar(50)")]
		public string CityName
		{
			get
			{
				return this._CityName;
			}
			set
			{
				if ((this._CityName != value))
				{
					this._CityName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this._Active = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this._CreatedOn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this._ModifiedOn = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
