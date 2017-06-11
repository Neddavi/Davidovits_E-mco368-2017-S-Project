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

namespace SaleTracker
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PROJECT")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertITEM(ITEM instance);
    partial void UpdateITEM(ITEM instance);
    partial void DeleteITEM(ITEM instance);
    partial void InsertORDER(ORDER instance);
    partial void UpdateORDER(ORDER instance);
    partial void DeleteORDER(ORDER instance);
    partial void InsertORDER_LINE(ORDER_LINE instance);
    partial void UpdateORDER_LINE(ORDER_LINE instance);
    partial void DeleteORDER_LINE(ORDER_LINE instance);
    partial void InsertPAYMENT(PAYMENT instance);
    partial void UpdatePAYMENT(PAYMENT instance);
    partial void DeletePAYMENT(PAYMENT instance);
    partial void InsertUSER(USER instance);
    partial void UpdateUSER(USER instance);
    partial void DeleteUSER(USER instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::SaleTracker.Properties.Settings.Default.PROJECTConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<ITEM> ITEMs
		{
			get
			{
				return this.GetTable<ITEM>();
			}
		}
		
		public System.Data.Linq.Table<ORDER> ORDERs
		{
			get
			{
				return this.GetTable<ORDER>();
			}
		}
		
		public System.Data.Linq.Table<ORDER_LINE> ORDER_LINEs
		{
			get
			{
				return this.GetTable<ORDER_LINE>();
			}
		}
		
		public System.Data.Linq.Table<PAYMENT> PAYMENTs
		{
			get
			{
				return this.GetTable<PAYMENT>();
			}
		}
		
		public System.Data.Linq.Table<USER> USERs
		{
			get
			{
				return this.GetTable<USER>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ITEM")]
	public partial class ITEM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Item_ID;
		
		private string _Description;
		
		private string _Category;
		
		private decimal _Price;
		
		private System.Nullable<int> _QTY_ITEM;
		
		private EntitySet<ORDER> _ORDERs;
		
		private EntitySet<ORDER_LINE> _ORDER_LINEs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItem_IDChanging(string value);
    partial void OnItem_IDChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnQTY_ITEMChanging(System.Nullable<int> value);
    partial void OnQTY_ITEMChanged();
    #endregion
		
		public ITEM()
		{
			this._ORDERs = new EntitySet<ORDER>(new Action<ORDER>(this.attach_ORDERs), new Action<ORDER>(this.detach_ORDERs));
			this._ORDER_LINEs = new EntitySet<ORDER_LINE>(new Action<ORDER_LINE>(this.attach_ORDER_LINEs), new Action<ORDER_LINE>(this.detach_ORDER_LINEs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_ID", DbType="NChar(4) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Item_ID
		{
			get
			{
				return this._Item_ID;
			}
			set
			{
				if ((this._Item_ID != value))
				{
					this.OnItem_IDChanging(value);
					this.SendPropertyChanging();
					this._Item_ID = value;
					this.SendPropertyChanged("Item_ID");
					this.OnItem_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="NChar(2) NOT NULL", CanBeNull=false)]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="SmallMoney NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QTY_ITEM", DbType="Int")]
		public System.Nullable<int> QTY_ITEM
		{
			get
			{
				return this._QTY_ITEM;
			}
			set
			{
				if ((this._QTY_ITEM != value))
				{
					this.OnQTY_ITEMChanging(value);
					this.SendPropertyChanging();
					this._QTY_ITEM = value;
					this.SendPropertyChanged("QTY_ITEM");
					this.OnQTY_ITEMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ITEM_ORDER", Storage="_ORDERs", ThisKey="Item_ID", OtherKey="ITEM_ID")]
		public EntitySet<ORDER> ORDERs
		{
			get
			{
				return this._ORDERs;
			}
			set
			{
				this._ORDERs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ITEM_ORDER_LINE", Storage="_ORDER_LINEs", ThisKey="Item_ID", OtherKey="Item_ID")]
		public EntitySet<ORDER_LINE> ORDER_LINEs
		{
			get
			{
				return this._ORDER_LINEs;
			}
			set
			{
				this._ORDER_LINEs.Assign(value);
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
		
		private void attach_ORDERs(ORDER entity)
		{
			this.SendPropertyChanging();
			entity.ITEM = this;
		}
		
		private void detach_ORDERs(ORDER entity)
		{
			this.SendPropertyChanging();
			entity.ITEM = null;
		}
		
		private void attach_ORDER_LINEs(ORDER_LINE entity)
		{
			this.SendPropertyChanging();
			entity.ITEM = this;
		}
		
		private void detach_ORDER_LINEs(ORDER_LINE entity)
		{
			this.SendPropertyChanging();
			entity.ITEM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[ORDER]")]
	public partial class ORDER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Order_ID;
		
		private System.DateTime _ORDER_DATE;
		
		private string _User_ID;
		
		private decimal _Total_Cost;
		
		private int _QTY;
		
		private string _ITEM_ID;
		
		private System.DateTime _DATE;
		
		private EntitySet<ORDER_LINE> _ORDER_LINEs;
		
		private EntityRef<ITEM> _ITEM;
		
		private EntityRef<USER> _USER;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrder_IDChanging(string value);
    partial void OnOrder_IDChanged();
    partial void OnORDER_DATEChanging(System.DateTime value);
    partial void OnORDER_DATEChanged();
    partial void OnUser_IDChanging(string value);
    partial void OnUser_IDChanged();
    partial void OnTotal_CostChanging(decimal value);
    partial void OnTotal_CostChanged();
    partial void OnQTYChanging(int value);
    partial void OnQTYChanged();
    partial void OnITEM_IDChanging(string value);
    partial void OnITEM_IDChanged();
    partial void OnDATEChanging(System.DateTime value);
    partial void OnDATEChanged();
    #endregion
		
		public ORDER()
		{
			this._ORDER_LINEs = new EntitySet<ORDER_LINE>(new Action<ORDER_LINE>(this.attach_ORDER_LINEs), new Action<ORDER_LINE>(this.detach_ORDER_LINEs));
			this._ITEM = default(EntityRef<ITEM>);
			this._USER = default(EntityRef<USER>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Order_ID", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Order_ID
		{
			get
			{
				return this._Order_ID;
			}
			set
			{
				if ((this._Order_ID != value))
				{
					this.OnOrder_IDChanging(value);
					this.SendPropertyChanging();
					this._Order_ID = value;
					this.SendPropertyChanged("Order_ID");
					this.OnOrder_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ORDER_DATE", DbType="SmallDateTime NOT NULL")]
		public System.DateTime ORDER_DATE
		{
			get
			{
				return this._ORDER_DATE;
			}
			set
			{
				if ((this._ORDER_DATE != value))
				{
					this.OnORDER_DATEChanging(value);
					this.SendPropertyChanging();
					this._ORDER_DATE = value;
					this.SendPropertyChanged("ORDER_DATE");
					this.OnORDER_DATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="NChar(3) NOT NULL", CanBeNull=false)]
		public string User_ID
		{
			get
			{
				return this._User_ID;
			}
			set
			{
				if ((this._User_ID != value))
				{
					if (this._USER.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUser_IDChanging(value);
					this.SendPropertyChanging();
					this._User_ID = value;
					this.SendPropertyChanged("User_ID");
					this.OnUser_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Cost", DbType="Decimal(7,2) NOT NULL")]
		public decimal Total_Cost
		{
			get
			{
				return this._Total_Cost;
			}
			set
			{
				if ((this._Total_Cost != value))
				{
					this.OnTotal_CostChanging(value);
					this.SendPropertyChanging();
					this._Total_Cost = value;
					this.SendPropertyChanged("Total_Cost");
					this.OnTotal_CostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QTY", DbType="Int NOT NULL")]
		public int QTY
		{
			get
			{
				return this._QTY;
			}
			set
			{
				if ((this._QTY != value))
				{
					this.OnQTYChanging(value);
					this.SendPropertyChanging();
					this._QTY = value;
					this.SendPropertyChanged("QTY");
					this.OnQTYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ITEM_ID", DbType="NChar(4) NOT NULL", CanBeNull=false)]
		public string ITEM_ID
		{
			get
			{
				return this._ITEM_ID;
			}
			set
			{
				if ((this._ITEM_ID != value))
				{
					if (this._ITEM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnITEM_IDChanging(value);
					this.SendPropertyChanging();
					this._ITEM_ID = value;
					this.SendPropertyChanged("ITEM_ID");
					this.OnITEM_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATE", DbType="Date NOT NULL")]
		public System.DateTime DATE
		{
			get
			{
				return this._DATE;
			}
			set
			{
				if ((this._DATE != value))
				{
					this.OnDATEChanging(value);
					this.SendPropertyChanging();
					this._DATE = value;
					this.SendPropertyChanged("DATE");
					this.OnDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ORDER_ORDER_LINE", Storage="_ORDER_LINEs", ThisKey="Order_ID", OtherKey="order_ID")]
		public EntitySet<ORDER_LINE> ORDER_LINEs
		{
			get
			{
				return this._ORDER_LINEs;
			}
			set
			{
				this._ORDER_LINEs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ITEM_ORDER", Storage="_ITEM", ThisKey="ITEM_ID", OtherKey="Item_ID", IsForeignKey=true)]
		public ITEM ITEM
		{
			get
			{
				return this._ITEM.Entity;
			}
			set
			{
				ITEM previousValue = this._ITEM.Entity;
				if (((previousValue != value) 
							|| (this._ITEM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ITEM.Entity = null;
						previousValue.ORDERs.Remove(this);
					}
					this._ITEM.Entity = value;
					if ((value != null))
					{
						value.ORDERs.Add(this);
						this._ITEM_ID = value.Item_ID;
					}
					else
					{
						this._ITEM_ID = default(string);
					}
					this.SendPropertyChanged("ITEM");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USER_ORDER", Storage="_USER", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
		public USER USER
		{
			get
			{
				return this._USER.Entity;
			}
			set
			{
				USER previousValue = this._USER.Entity;
				if (((previousValue != value) 
							|| (this._USER.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._USER.Entity = null;
						previousValue.ORDERs.Remove(this);
					}
					this._USER.Entity = value;
					if ((value != null))
					{
						value.ORDERs.Add(this);
						this._User_ID = value.User_ID;
					}
					else
					{
						this._User_ID = default(string);
					}
					this.SendPropertyChanged("USER");
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
		
		private void attach_ORDER_LINEs(ORDER_LINE entity)
		{
			this.SendPropertyChanging();
			entity.ORDER = this;
		}
		
		private void detach_ORDER_LINEs(ORDER_LINE entity)
		{
			this.SendPropertyChanging();
			entity.ORDER = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ORDER_LINE")]
	public partial class ORDER_LINE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _OrderLine_ID;
		
		private string _order_ID;
		
		private string _Item_ID;
		
		private short _QTY_ORDERED;
		
		private EntityRef<ITEM> _ITEM;
		
		private EntityRef<ORDER> _ORDER;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderLine_IDChanging(string value);
    partial void OnOrderLine_IDChanged();
    partial void Onorder_IDChanging(string value);
    partial void Onorder_IDChanged();
    partial void OnItem_IDChanging(string value);
    partial void OnItem_IDChanged();
    partial void OnQTY_ORDEREDChanging(short value);
    partial void OnQTY_ORDEREDChanged();
    #endregion
		
		public ORDER_LINE()
		{
			this._ITEM = default(EntityRef<ITEM>);
			this._ORDER = default(EntityRef<ORDER>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderLine_ID", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string OrderLine_ID
		{
			get
			{
				return this._OrderLine_ID;
			}
			set
			{
				if ((this._OrderLine_ID != value))
				{
					this.OnOrderLine_IDChanging(value);
					this.SendPropertyChanging();
					this._OrderLine_ID = value;
					this.SendPropertyChanged("OrderLine_ID");
					this.OnOrderLine_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_order_ID", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string order_ID
		{
			get
			{
				return this._order_ID;
			}
			set
			{
				if ((this._order_ID != value))
				{
					if (this._ORDER.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onorder_IDChanging(value);
					this.SendPropertyChanging();
					this._order_ID = value;
					this.SendPropertyChanged("order_ID");
					this.Onorder_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_ID", DbType="NChar(4) NOT NULL", CanBeNull=false)]
		public string Item_ID
		{
			get
			{
				return this._Item_ID;
			}
			set
			{
				if ((this._Item_ID != value))
				{
					if (this._ITEM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnItem_IDChanging(value);
					this.SendPropertyChanging();
					this._Item_ID = value;
					this.SendPropertyChanged("Item_ID");
					this.OnItem_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QTY_ORDERED", DbType="SmallInt NOT NULL")]
		public short QTY_ORDERED
		{
			get
			{
				return this._QTY_ORDERED;
			}
			set
			{
				if ((this._QTY_ORDERED != value))
				{
					this.OnQTY_ORDEREDChanging(value);
					this.SendPropertyChanging();
					this._QTY_ORDERED = value;
					this.SendPropertyChanged("QTY_ORDERED");
					this.OnQTY_ORDEREDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ITEM_ORDER_LINE", Storage="_ITEM", ThisKey="Item_ID", OtherKey="Item_ID", IsForeignKey=true)]
		public ITEM ITEM
		{
			get
			{
				return this._ITEM.Entity;
			}
			set
			{
				ITEM previousValue = this._ITEM.Entity;
				if (((previousValue != value) 
							|| (this._ITEM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ITEM.Entity = null;
						previousValue.ORDER_LINEs.Remove(this);
					}
					this._ITEM.Entity = value;
					if ((value != null))
					{
						value.ORDER_LINEs.Add(this);
						this._Item_ID = value.Item_ID;
					}
					else
					{
						this._Item_ID = default(string);
					}
					this.SendPropertyChanged("ITEM");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ORDER_ORDER_LINE", Storage="_ORDER", ThisKey="order_ID", OtherKey="Order_ID", IsForeignKey=true)]
		public ORDER ORDER
		{
			get
			{
				return this._ORDER.Entity;
			}
			set
			{
				ORDER previousValue = this._ORDER.Entity;
				if (((previousValue != value) 
							|| (this._ORDER.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ORDER.Entity = null;
						previousValue.ORDER_LINEs.Remove(this);
					}
					this._ORDER.Entity = value;
					if ((value != null))
					{
						value.ORDER_LINEs.Add(this);
						this._order_ID = value.Order_ID;
					}
					else
					{
						this._order_ID = default(string);
					}
					this.SendPropertyChanged("ORDER");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PAYMENT")]
	public partial class PAYMENT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Payment_ID;
		
		private string _User_ID;
		
		private System.DateTime _Date;
		
		private decimal _Amount;
		
		private EntityRef<USER> _USER;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPayment_IDChanging(string value);
    partial void OnPayment_IDChanged();
    partial void OnUser_IDChanging(string value);
    partial void OnUser_IDChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnAmountChanging(decimal value);
    partial void OnAmountChanged();
    #endregion
		
		public PAYMENT()
		{
			this._USER = default(EntityRef<USER>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Payment_ID", DbType="VarChar(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Payment_ID
		{
			get
			{
				return this._Payment_ID;
			}
			set
			{
				if ((this._Payment_ID != value))
				{
					this.OnPayment_IDChanging(value);
					this.SendPropertyChanging();
					this._Payment_ID = value;
					this.SendPropertyChanged("Payment_ID");
					this.OnPayment_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="NChar(3) NOT NULL", CanBeNull=false)]
		public string User_ID
		{
			get
			{
				return this._User_ID;
			}
			set
			{
				if ((this._User_ID != value))
				{
					if (this._USER.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUser_IDChanging(value);
					this.SendPropertyChanging();
					this._User_ID = value;
					this.SendPropertyChanged("User_ID");
					this.OnUser_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Decimal(7,2) NOT NULL")]
		public decimal Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USER_PAYMENT", Storage="_USER", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
		public USER USER
		{
			get
			{
				return this._USER.Entity;
			}
			set
			{
				USER previousValue = this._USER.Entity;
				if (((previousValue != value) 
							|| (this._USER.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._USER.Entity = null;
						previousValue.PAYMENTs.Remove(this);
					}
					this._USER.Entity = value;
					if ((value != null))
					{
						value.PAYMENTs.Add(this);
						this._User_ID = value.User_ID;
					}
					else
					{
						this._User_ID = default(string);
					}
					this.SendPropertyChanged("USER");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[USER]")]
	public partial class USER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _User_ID;
		
		private string _UserName_Email;
		
		private string _REP_LNAME;
		
		private string _REP_FNAME;
		
		private char _Gender;
		
		private decimal _Balance;
		
		private EntitySet<ORDER> _ORDERs;
		
		private EntitySet<PAYMENT> _PAYMENTs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(string value);
    partial void OnUser_IDChanged();
    partial void OnUserName_EmailChanging(string value);
    partial void OnUserName_EmailChanged();
    partial void OnREP_LNAMEChanging(string value);
    partial void OnREP_LNAMEChanged();
    partial void OnREP_FNAMEChanging(string value);
    partial void OnREP_FNAMEChanged();
    partial void OnGenderChanging(char value);
    partial void OnGenderChanged();
    partial void OnBalanceChanging(decimal value);
    partial void OnBalanceChanged();
    #endregion
		
		public USER()
		{
			this._ORDERs = new EntitySet<ORDER>(new Action<ORDER>(this.attach_ORDERs), new Action<ORDER>(this.detach_ORDERs));
			this._PAYMENTs = new EntitySet<PAYMENT>(new Action<PAYMENT>(this.attach_PAYMENTs), new Action<PAYMENT>(this.detach_PAYMENTs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="NChar(3) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string User_ID
		{
			get
			{
				return this._User_ID;
			}
			set
			{
				if ((this._User_ID != value))
				{
					this.OnUser_IDChanging(value);
					this.SendPropertyChanging();
					this._User_ID = value;
					this.SendPropertyChanged("User_ID");
					this.OnUser_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[UserName/Email]", Storage="_UserName_Email", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string UserName_Email
		{
			get
			{
				return this._UserName_Email;
			}
			set
			{
				if ((this._UserName_Email != value))
				{
					this.OnUserName_EmailChanging(value);
					this.SendPropertyChanging();
					this._UserName_Email = value;
					this.SendPropertyChanged("UserName_Email");
					this.OnUserName_EmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_REP_LNAME", DbType="NChar(15) NOT NULL", CanBeNull=false)]
		public string REP_LNAME
		{
			get
			{
				return this._REP_LNAME;
			}
			set
			{
				if ((this._REP_LNAME != value))
				{
					this.OnREP_LNAMEChanging(value);
					this.SendPropertyChanging();
					this._REP_LNAME = value;
					this.SendPropertyChanged("REP_LNAME");
					this.OnREP_LNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_REP_FNAME", DbType="NChar(15) NOT NULL", CanBeNull=false)]
		public string REP_FNAME
		{
			get
			{
				return this._REP_FNAME;
			}
			set
			{
				if ((this._REP_FNAME != value))
				{
					this.OnREP_FNAMEChanging(value);
					this.SendPropertyChanging();
					this._REP_FNAME = value;
					this.SendPropertyChanged("REP_FNAME");
					this.OnREP_FNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NChar(1) NOT NULL")]
		public char Gender
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balance", DbType="Decimal(7,2) NOT NULL")]
		public decimal Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				if ((this._Balance != value))
				{
					this.OnBalanceChanging(value);
					this.SendPropertyChanging();
					this._Balance = value;
					this.SendPropertyChanged("Balance");
					this.OnBalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USER_ORDER", Storage="_ORDERs", ThisKey="User_ID", OtherKey="User_ID")]
		public EntitySet<ORDER> ORDERs
		{
			get
			{
				return this._ORDERs;
			}
			set
			{
				this._ORDERs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USER_PAYMENT", Storage="_PAYMENTs", ThisKey="User_ID", OtherKey="User_ID")]
		public EntitySet<PAYMENT> PAYMENTs
		{
			get
			{
				return this._PAYMENTs;
			}
			set
			{
				this._PAYMENTs.Assign(value);
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
		
		private void attach_ORDERs(ORDER entity)
		{
			this.SendPropertyChanging();
			entity.USER = this;
		}
		
		private void detach_ORDERs(ORDER entity)
		{
			this.SendPropertyChanging();
			entity.USER = null;
		}
		
		private void attach_PAYMENTs(PAYMENT entity)
		{
			this.SendPropertyChanging();
			entity.USER = this;
		}
		
		private void detach_PAYMENTs(PAYMENT entity)
		{
			this.SendPropertyChanging();
			entity.USER = null;
		}
	}
}
#pragma warning restore 1591
