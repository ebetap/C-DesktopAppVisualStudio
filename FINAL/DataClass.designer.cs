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

namespace FINAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="appbookstore")]
	public partial class DataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBuku(Buku instance);
    partial void UpdateBuku(Buku instance);
    partial void DeleteBuku(Buku instance);
    partial void InsertPenjualan(Penjualan instance);
    partial void UpdatePenjualan(Penjualan instance);
    partial void DeletePenjualan(Penjualan instance);
    #endregion
		
		public DataClassDataContext() : 
				base(global::FINAL.Properties.Settings.Default.appbookstoreConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Buku> Bukus
		{
			get
			{
				return this.GetTable<Buku>();
			}
		}
		
		public System.Data.Linq.Table<Penjualan> Penjualans
		{
			get
			{
				return this.GetTable<Penjualan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Buku")]
	public partial class Buku : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _kode_buku;
		
		private string _nama_buku;
		
		private int _harga;
		
		private int _thn_terbit;
		
		private string _pengarang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void Onkode_bukuChanging(string value);
    partial void Onkode_bukuChanged();
    partial void Onnama_bukuChanging(string value);
    partial void Onnama_bukuChanged();
    partial void OnhargaChanging(int value);
    partial void OnhargaChanged();
    partial void Onthn_terbitChanging(int value);
    partial void Onthn_terbitChanged();
    partial void OnpengarangChanging(string value);
    partial void OnpengarangChanged();
    #endregion
		
		public Buku()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kode_buku", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string kode_buku
		{
			get
			{
				return this._kode_buku;
			}
			set
			{
				if ((this._kode_buku != value))
				{
					this.Onkode_bukuChanging(value);
					this.SendPropertyChanging();
					this._kode_buku = value;
					this.SendPropertyChanged("kode_buku");
					this.Onkode_bukuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama_buku", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nama_buku
		{
			get
			{
				return this._nama_buku;
			}
			set
			{
				if ((this._nama_buku != value))
				{
					this.Onnama_bukuChanging(value);
					this.SendPropertyChanging();
					this._nama_buku = value;
					this.SendPropertyChanged("nama_buku");
					this.Onnama_bukuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_harga", DbType="Int NOT NULL")]
		public int harga
		{
			get
			{
				return this._harga;
			}
			set
			{
				if ((this._harga != value))
				{
					this.OnhargaChanging(value);
					this.SendPropertyChanging();
					this._harga = value;
					this.SendPropertyChanged("harga");
					this.OnhargaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_thn_terbit", DbType="Int NOT NULL")]
		public int thn_terbit
		{
			get
			{
				return this._thn_terbit;
			}
			set
			{
				if ((this._thn_terbit != value))
				{
					this.Onthn_terbitChanging(value);
					this.SendPropertyChanging();
					this._thn_terbit = value;
					this.SendPropertyChanged("thn_terbit");
					this.Onthn_terbitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pengarang", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string pengarang
		{
			get
			{
				return this._pengarang;
			}
			set
			{
				if ((this._pengarang != value))
				{
					this.OnpengarangChanging(value);
					this.SendPropertyChanging();
					this._pengarang = value;
					this.SendPropertyChanged("pengarang");
					this.OnpengarangChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Penjualan")]
	public partial class Penjualan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _id_transaksi;
		
		private System.DateTime _tanggal;
		
		private string _judul_buku;
		
		private int _jumlah;
		
		private int _total;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void Onid_transaksiChanging(string value);
    partial void Onid_transaksiChanged();
    partial void OntanggalChanging(System.DateTime value);
    partial void OntanggalChanged();
    partial void Onjudul_bukuChanging(string value);
    partial void Onjudul_bukuChanged();
    partial void OnjumlahChanging(int value);
    partial void OnjumlahChanged();
    partial void OntotalChanging(int value);
    partial void OntotalChanged();
    #endregion
		
		public Penjualan()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_transaksi", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string id_transaksi
		{
			get
			{
				return this._id_transaksi;
			}
			set
			{
				if ((this._id_transaksi != value))
				{
					this.Onid_transaksiChanging(value);
					this.SendPropertyChanging();
					this._id_transaksi = value;
					this.SendPropertyChanged("id_transaksi");
					this.Onid_transaksiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tanggal", DbType="Date NOT NULL")]
		public System.DateTime tanggal
		{
			get
			{
				return this._tanggal;
			}
			set
			{
				if ((this._tanggal != value))
				{
					this.OntanggalChanging(value);
					this.SendPropertyChanging();
					this._tanggal = value;
					this.SendPropertyChanged("tanggal");
					this.OntanggalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_judul_buku", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string judul_buku
		{
			get
			{
				return this._judul_buku;
			}
			set
			{
				if ((this._judul_buku != value))
				{
					this.Onjudul_bukuChanging(value);
					this.SendPropertyChanging();
					this._judul_buku = value;
					this.SendPropertyChanged("judul_buku");
					this.Onjudul_bukuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jumlah", DbType="Int NOT NULL")]
		public int jumlah
		{
			get
			{
				return this._jumlah;
			}
			set
			{
				if ((this._jumlah != value))
				{
					this.OnjumlahChanging(value);
					this.SendPropertyChanging();
					this._jumlah = value;
					this.SendPropertyChanged("jumlah");
					this.OnjumlahChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total", DbType="Int NOT NULL")]
		public int total
		{
			get
			{
				return this._total;
			}
			set
			{
				if ((this._total != value))
				{
					this.OntotalChanging(value);
					this.SendPropertyChanging();
					this._total = value;
					this.SendPropertyChanged("total");
					this.OntotalChanged();
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