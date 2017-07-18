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

namespace MediaPustaka.net.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MediaPustaka")]
	public partial class OperationDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertCart(Cart instance);
    partial void UpdateCart(Cart instance);
    partial void DeleteCart(Cart instance);
    partial void InsertInvoice(Invoice instance);
    partial void UpdateInvoice(Invoice instance);
    partial void DeleteInvoice(Invoice instance);
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertAdminPanel(AdminPanel instance);
    partial void UpdateAdminPanel(AdminPanel instance);
    partial void DeleteAdminPanel(AdminPanel instance);
    #endregion
		
		public OperationDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MediaPustakaConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public OperationDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OperationDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OperationDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OperationDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Cart> Carts
		{
			get
			{
				return this.GetTable<Cart>();
			}
		}
		
		public System.Data.Linq.Table<Invoice> Invoices
		{
			get
			{
				return this.GetTable<Invoice>();
			}
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<AdminPanel> AdminPanels
		{
			get
			{
				return this.GetTable<AdminPanel>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_Admin;
		
		private string _Name;
		
		private string _Password;
		
		private string _Email;
		
		private System.Nullable<bool> _Status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_AdminChanging(int value);
    partial void OnID_AdminChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnStatusChanging(System.Nullable<bool> value);
    partial void OnStatusChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Admin", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_Admin
		{
			get
			{
				return this._ID_Admin;
			}
			set
			{
				if ((this._ID_Admin != value))
				{
					this.OnID_AdminChanging(value);
					this.SendPropertyChanging();
					this._ID_Admin = value;
					this.SendPropertyChanged("ID_Admin");
					this.OnID_AdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Bit")]
		public System.Nullable<bool> Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Carts")]
	public partial class Cart : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_Cart;
		
		private string @__title;
		
		private string @__genre;
		
		private double @__discount;
		
		private decimal @__price;
		
		private string @__shelves;
		
		private int _Book_ID;
		
		private string _Username;
		
		private decimal _priceAD;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_CartChanging(int value);
    partial void OnID_CartChanged();
    partial void On_titleChanging(string value);
    partial void On_titleChanged();
    partial void On_genreChanging(string value);
    partial void On_genreChanged();
    partial void On_discountChanging(double value);
    partial void On_discountChanged();
    partial void On_priceChanging(decimal value);
    partial void On_priceChanged();
    partial void On_shelvesChanging(string value);
    partial void On_shelvesChanged();
    partial void OnBook_IDChanging(int value);
    partial void OnBook_IDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnpriceADChanging(decimal value);
    partial void OnpriceADChanged();
    #endregion
		
		public Cart()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Cart", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_Cart
		{
			get
			{
				return this._ID_Cart;
			}
			set
			{
				if ((this._ID_Cart != value))
				{
					this.OnID_CartChanging(value);
					this.SendPropertyChanging();
					this._ID_Cart = value;
					this.SendPropertyChanged("ID_Cart");
					this.OnID_CartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[_title]", Storage="__title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string _title
		{
			get
			{
				return this.@__title;
			}
			set
			{
				if ((this.@__title != value))
				{
					this.On_titleChanging(value);
					this.SendPropertyChanging();
					this.@__title = value;
					this.SendPropertyChanged("_title");
					this.On_titleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[_genre]", Storage="__genre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string _genre
		{
			get
			{
				return this.@__genre;
			}
			set
			{
				if ((this.@__genre != value))
				{
					this.On_genreChanging(value);
					this.SendPropertyChanging();
					this.@__genre = value;
					this.SendPropertyChanged("_genre");
					this.On_genreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[_discount]", Storage="__discount", DbType="Float NOT NULL")]
		public double _discount
		{
			get
			{
				return this.@__discount;
			}
			set
			{
				if ((this.@__discount != value))
				{
					this.On_discountChanging(value);
					this.SendPropertyChanging();
					this.@__discount = value;
					this.SendPropertyChanged("_discount");
					this.On_discountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[_price]", Storage="__price", DbType="Decimal(18,2) NOT NULL")]
		public decimal _price
		{
			get
			{
				return this.@__price;
			}
			set
			{
				if ((this.@__price != value))
				{
					this.On_priceChanging(value);
					this.SendPropertyChanging();
					this.@__price = value;
					this.SendPropertyChanged("_price");
					this.On_priceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[_shelves]", Storage="__shelves", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string _shelves
		{
			get
			{
				return this.@__shelves;
			}
			set
			{
				if ((this.@__shelves != value))
				{
					this.On_shelvesChanging(value);
					this.SendPropertyChanging();
					this.@__shelves = value;
					this.SendPropertyChanged("_shelves");
					this.On_shelvesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Book_ID", DbType="Int NOT NULL")]
		public int Book_ID
		{
			get
			{
				return this._Book_ID;
			}
			set
			{
				if ((this._Book_ID != value))
				{
					this.OnBook_IDChanging(value);
					this.SendPropertyChanging();
					this._Book_ID = value;
					this.SendPropertyChanged("Book_ID");
					this.OnBook_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_priceAD", DbType="Decimal(18,2) NOT NULL")]
		public decimal priceAD
		{
			get
			{
				return this._priceAD;
			}
			set
			{
				if ((this._priceAD != value))
				{
					this.OnpriceADChanging(value);
					this.SendPropertyChanging();
					this._priceAD = value;
					this.SendPropertyChanged("priceAD");
					this.OnpriceADChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Invoices")]
	public partial class Invoice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Order_id;
		
		private string @__username;
		
		private int _Jumlah_buku;
		
		private decimal _Jumlah_harga;
		
		private int _Diskon_global;
		
		private double _Total;
		
		private string _Kasir;
		
		private System.DateTime _Tanggal;
		
		private string _Pembayaran;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrder_idChanging(int value);
    partial void OnOrder_idChanged();
    partial void On_usernameChanging(string value);
    partial void On_usernameChanged();
    partial void OnJumlah_bukuChanging(int value);
    partial void OnJumlah_bukuChanged();
    partial void OnJumlah_hargaChanging(decimal value);
    partial void OnJumlah_hargaChanged();
    partial void OnDiskon_globalChanging(int value);
    partial void OnDiskon_globalChanged();
    partial void OnTotalChanging(double value);
    partial void OnTotalChanged();
    partial void OnKasirChanging(string value);
    partial void OnKasirChanged();
    partial void OnTanggalChanging(System.DateTime value);
    partial void OnTanggalChanged();
    partial void OnPembayaranChanging(string value);
    partial void OnPembayaranChanged();
    #endregion
		
		public Invoice()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Order_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Order_id
		{
			get
			{
				return this._Order_id;
			}
			set
			{
				if ((this._Order_id != value))
				{
					this.OnOrder_idChanging(value);
					this.SendPropertyChanging();
					this._Order_id = value;
					this.SendPropertyChanged("Order_id");
					this.OnOrder_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[_username]", Storage="__username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string _username
		{
			get
			{
				return this.@__username;
			}
			set
			{
				if ((this.@__username != value))
				{
					this.On_usernameChanging(value);
					this.SendPropertyChanging();
					this.@__username = value;
					this.SendPropertyChanged("_username");
					this.On_usernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Jumlah_buku", DbType="Int NOT NULL")]
		public int Jumlah_buku
		{
			get
			{
				return this._Jumlah_buku;
			}
			set
			{
				if ((this._Jumlah_buku != value))
				{
					this.OnJumlah_bukuChanging(value);
					this.SendPropertyChanging();
					this._Jumlah_buku = value;
					this.SendPropertyChanged("Jumlah_buku");
					this.OnJumlah_bukuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Jumlah_harga", DbType="Decimal(18,2) NOT NULL")]
		public decimal Jumlah_harga
		{
			get
			{
				return this._Jumlah_harga;
			}
			set
			{
				if ((this._Jumlah_harga != value))
				{
					this.OnJumlah_hargaChanging(value);
					this.SendPropertyChanging();
					this._Jumlah_harga = value;
					this.SendPropertyChanged("Jumlah_harga");
					this.OnJumlah_hargaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diskon_global", DbType="Int NOT NULL")]
		public int Diskon_global
		{
			get
			{
				return this._Diskon_global;
			}
			set
			{
				if ((this._Diskon_global != value))
				{
					this.OnDiskon_globalChanging(value);
					this.SendPropertyChanging();
					this._Diskon_global = value;
					this.SendPropertyChanged("Diskon_global");
					this.OnDiskon_globalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Float NOT NULL")]
		public double Total
		{
			get
			{
				return this._Total;
			}
			set
			{
				if ((this._Total != value))
				{
					this.OnTotalChanging(value);
					this.SendPropertyChanging();
					this._Total = value;
					this.SendPropertyChanged("Total");
					this.OnTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kasir", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Kasir
		{
			get
			{
				return this._Kasir;
			}
			set
			{
				if ((this._Kasir != value))
				{
					this.OnKasirChanging(value);
					this.SendPropertyChanging();
					this._Kasir = value;
					this.SendPropertyChanged("Kasir");
					this.OnKasirChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tanggal", DbType="Date NOT NULL")]
		public System.DateTime Tanggal
		{
			get
			{
				return this._Tanggal;
			}
			set
			{
				if ((this._Tanggal != value))
				{
					this.OnTanggalChanging(value);
					this.SendPropertyChanging();
					this._Tanggal = value;
					this.SendPropertyChanged("Tanggal");
					this.OnTanggalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pembayaran", DbType="NChar(10)")]
		public string Pembayaran
		{
			get
			{
				return this._Pembayaran;
			}
			set
			{
				if ((this._Pembayaran != value))
				{
					this.OnPembayaranChanging(value);
					this.SendPropertyChanging();
					this._Pembayaran = value;
					this.SendPropertyChanged("Pembayaran");
					this.OnPembayaranChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Books")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_Book;
		
		private string _Title;
		
		private string _Author;
		
		private string _Genre;
		
		private double _Rating;
		
		private string _Sinopsis;
		
		private decimal _Price;
		
		private int _Stock;
		
		private string _Shelves;
		
		private string _Images;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_BookChanging(int value);
    partial void OnID_BookChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnGenreChanging(string value);
    partial void OnGenreChanged();
    partial void OnRatingChanging(double value);
    partial void OnRatingChanged();
    partial void OnSinopsisChanging(string value);
    partial void OnSinopsisChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnStockChanging(int value);
    partial void OnStockChanged();
    partial void OnShelvesChanging(string value);
    partial void OnShelvesChanged();
    partial void OnImagesChanging(string value);
    partial void OnImagesChanged();
    #endregion
		
		public Book()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Book", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_Book
		{
			get
			{
				return this._ID_Book;
			}
			set
			{
				if ((this._ID_Book != value))
				{
					this.OnID_BookChanging(value);
					this.SendPropertyChanging();
					this._ID_Book = value;
					this.SendPropertyChanged("ID_Book");
					this.OnID_BookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genre", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Genre
		{
			get
			{
				return this._Genre;
			}
			set
			{
				if ((this._Genre != value))
				{
					this.OnGenreChanging(value);
					this.SendPropertyChanging();
					this._Genre = value;
					this.SendPropertyChanged("Genre");
					this.OnGenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rating", DbType="Float NOT NULL")]
		public double Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this.OnRatingChanging(value);
					this.SendPropertyChanging();
					this._Rating = value;
					this.SendPropertyChanged("Rating");
					this.OnRatingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sinopsis", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Sinopsis
		{
			get
			{
				return this._Sinopsis;
			}
			set
			{
				if ((this._Sinopsis != value))
				{
					this.OnSinopsisChanging(value);
					this.SendPropertyChanging();
					this._Sinopsis = value;
					this.SendPropertyChanged("Sinopsis");
					this.OnSinopsisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(18,2) NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Stock", DbType="Int NOT NULL")]
		public int Stock
		{
			get
			{
				return this._Stock;
			}
			set
			{
				if ((this._Stock != value))
				{
					this.OnStockChanging(value);
					this.SendPropertyChanging();
					this._Stock = value;
					this.SendPropertyChanged("Stock");
					this.OnStockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Shelves", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Shelves
		{
			get
			{
				return this._Shelves;
			}
			set
			{
				if ((this._Shelves != value))
				{
					this.OnShelvesChanging(value);
					this.SendPropertyChanging();
					this._Shelves = value;
					this.SendPropertyChanged("Shelves");
					this.OnShelvesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Images", DbType="NVarChar(50)")]
		public string Images
		{
			get
			{
				return this._Images;
			}
			set
			{
				if ((this._Images != value))
				{
					this.OnImagesChanging(value);
					this.SendPropertyChanging();
					this._Images = value;
					this.SendPropertyChanged("Images");
					this.OnImagesChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AdminPanel")]
	public partial class AdminPanel : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _Diskon_global;
		
		private string _Progam;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnDiskon_globalChanging(int value);
    partial void OnDiskon_globalChanged();
    partial void OnProgamChanging(string value);
    partial void OnProgamChanged();
    #endregion
		
		public AdminPanel()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diskon_global", DbType="Int NOT NULL")]
		public int Diskon_global
		{
			get
			{
				return this._Diskon_global;
			}
			set
			{
				if ((this._Diskon_global != value))
				{
					this.OnDiskon_globalChanging(value);
					this.SendPropertyChanging();
					this._Diskon_global = value;
					this.SendPropertyChanged("Diskon_global");
					this.OnDiskon_globalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Progam", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Progam
		{
			get
			{
				return this._Progam;
			}
			set
			{
				if ((this._Progam != value))
				{
					this.OnProgamChanging(value);
					this.SendPropertyChanging();
					this._Progam = value;
					this.SendPropertyChanged("Progam");
					this.OnProgamChanged();
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
}
#pragma warning restore 1591
