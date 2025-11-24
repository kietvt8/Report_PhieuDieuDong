using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Report_PhieuDieuDong;

[Serializable]
[HelpKeyword("vs.data.DataSet")]
[XmlRoot("rep_PhieuDD")]
[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
public class rep_PhieuDD : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void DataTable1RowChangeEventHandler(object sender, DataTable1RowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void DataTable2RowChangeEventHandler(object sender, DataTable2RowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable1DataTable : TypedTableBase<DataTable1Row>
	{
		private DataColumn columnTenCoSo;

		private DataColumn columnDiaChi;

		private DataColumn columnLogo;

		private DataColumn columnSoPhieuDieuDong;

		private DataColumn columnHoTenVanChuyen;

		private DataColumn columnHangVanChuyen;

		private DataColumn columnPhuongTienVanChuyen;

		private DataColumn columnThoiGianVanChuyen;

		private DataColumn columnXuatHangTaiKho;

		private DataColumn columnNhanHangTaiKho;

		private DataColumn columnNgayDieuDong;

		private DataColumn columnGDCungUng;

		private DataColumn columnNguoiDeNghi;

		private DataColumn columnSoHD;

		private DataColumn columnTongCong;

		private DataColumn columnNguoiDuyetDeNghi;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TenCoSoColumn => columnTenCoSo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DiaChiColumn => columnDiaChi;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn LogoColumn => columnLogo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SoPhieuDieuDongColumn => columnSoPhieuDieuDong;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn HoTenVanChuyenColumn => columnHoTenVanChuyen;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn HangVanChuyenColumn => columnHangVanChuyen;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PhuongTienVanChuyenColumn => columnPhuongTienVanChuyen;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ThoiGianVanChuyenColumn => columnThoiGianVanChuyen;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn XuatHangTaiKhoColumn => columnXuatHangTaiKho;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NhanHangTaiKhoColumn => columnNhanHangTaiKho;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NgayDieuDongColumn => columnNgayDieuDong;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn GDCungUngColumn => columnGDCungUng;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NguoiDeNghiColumn => columnNguoiDeNghi;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SoHDColumn => columnSoHD;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TongCongColumn => columnTongCong;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NguoiDuyetDeNghiColumn => columnNguoiDuyetDeNghi;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable1Row this[int index] => (DataTable1Row)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable1RowChangeEventHandler DataTable1RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable1RowChangeEventHandler DataTable1RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable1RowChangeEventHandler DataTable1RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable1RowChangeEventHandler DataTable1RowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable1DataTable()
		{
			base.TableName = "DataTable1";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal DataTable1DataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected DataTable1DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddDataTable1Row(DataTable1Row row)
		{
			base.Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable1Row AddDataTable1Row(string TenCoSo, string DiaChi, string Logo, string SoPhieuDieuDong, string HoTenVanChuyen, string HangVanChuyen, string PhuongTienVanChuyen, string ThoiGianVanChuyen, string XuatHangTaiKho, string NhanHangTaiKho, string NgayDieuDong, string GDCungUng, string NguoiDeNghi, string SoHD, string TongCong, string NguoiDuyetDeNghi)
		{
			DataTable1Row dataTable1Row = (DataTable1Row)NewRow();
			object[] itemArray = new object[16]
			{
				TenCoSo, DiaChi, Logo, SoPhieuDieuDong, HoTenVanChuyen, HangVanChuyen, PhuongTienVanChuyen, ThoiGianVanChuyen, XuatHangTaiKho, NhanHangTaiKho,
				NgayDieuDong, GDCungUng, NguoiDeNghi, SoHD, TongCong, NguoiDuyetDeNghi
			};
			dataTable1Row.ItemArray = itemArray;
			base.Rows.Add(dataTable1Row);
			return dataTable1Row;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			DataTable1DataTable dataTable1DataTable = (DataTable1DataTable)base.Clone();
			dataTable1DataTable.InitVars();
			return dataTable1DataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new DataTable1DataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnTenCoSo = base.Columns["TenCoSo"];
			columnDiaChi = base.Columns["DiaChi"];
			columnLogo = base.Columns["Logo"];
			columnSoPhieuDieuDong = base.Columns["SoPhieuDieuDong"];
			columnHoTenVanChuyen = base.Columns["HoTenVanChuyen"];
			columnHangVanChuyen = base.Columns["HangVanChuyen"];
			columnPhuongTienVanChuyen = base.Columns["PhuongTienVanChuyen"];
			columnThoiGianVanChuyen = base.Columns["ThoiGianVanChuyen"];
			columnXuatHangTaiKho = base.Columns["XuatHangTaiKho"];
			columnNhanHangTaiKho = base.Columns["NhanHangTaiKho"];
			columnNgayDieuDong = base.Columns["NgayDieuDong"];
			columnGDCungUng = base.Columns["GDCungUng"];
			columnNguoiDeNghi = base.Columns["NguoiDeNghi"];
			columnSoHD = base.Columns["SoHD"];
			columnTongCong = base.Columns["TongCong"];
			columnNguoiDuyetDeNghi = base.Columns["columnNguoiDuyetDeNghi"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnTenCoSo = new DataColumn("TenCoSo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTenCoSo);
			columnDiaChi = new DataColumn("DiaChi", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDiaChi);
			columnLogo = new DataColumn("Logo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLogo);
			columnSoPhieuDieuDong = new DataColumn("SoPhieuDieuDong", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSoPhieuDieuDong);
			columnHoTenVanChuyen = new DataColumn("HoTenVanChuyen", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHoTenVanChuyen);
			columnHangVanChuyen = new DataColumn("HangVanChuyen", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHangVanChuyen);
			columnPhuongTienVanChuyen = new DataColumn("PhuongTienVanChuyen", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPhuongTienVanChuyen);
			columnThoiGianVanChuyen = new DataColumn("ThoiGianVanChuyen", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnThoiGianVanChuyen);
			columnXuatHangTaiKho = new DataColumn("XuatHangTaiKho", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnXuatHangTaiKho);
			columnNhanHangTaiKho = new DataColumn("NhanHangTaiKho", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNhanHangTaiKho);
			columnNgayDieuDong = new DataColumn("NgayDieuDong", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNgayDieuDong);
			columnGDCungUng = new DataColumn("GDCungUng", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnGDCungUng);
			columnNguoiDeNghi = new DataColumn("NguoiDeNghi", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNguoiDeNghi);
			columnSoHD = new DataColumn("SoHD", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSoHD);
			columnTongCong = new DataColumn("TongCong", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTongCong);
			columnNguoiDuyetDeNghi = new DataColumn("NguoiDuyetDeNghi", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNguoiDuyetDeNghi);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable1Row NewDataTable1Row()
		{
			return (DataTable1Row)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable1Row(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(DataTable1Row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.DataTable1RowChanged != null)
			{
				this.DataTable1RowChanged(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.DataTable1RowChanging != null)
			{
				this.DataTable1RowChanging(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.DataTable1RowDeleted != null)
			{
				this.DataTable1RowDeleted(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.DataTable1RowDeleting != null)
			{
				this.DataTable1RowDeleting(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveDataTable1Row(DataTable1Row row)
		{
			base.Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			rep_PhieuDD rep_PhieuDD2 = new rep_PhieuDD();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = rep_PhieuDD2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable1DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = rep_PhieuDD2.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable2DataTable : TypedTableBase<DataTable2Row>
	{
		private DataColumn columnSTT;

		private DataColumn columnMaHang;

		private DataColumn columnMatHang;

		private DataColumn columnDVT;

		private DataColumn columnSL;

		private DataColumn columnLoSX;

		private DataColumn columnHanDung;

		private DataColumn columnQuyCach;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn STTColumn => columnSTT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MaHangColumn => columnMaHang;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn MatHangColumn => columnMatHang;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DVTColumn => columnDVT;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SLColumn => columnSL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LoSXColumn => columnLoSX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn HanDungColumn => columnHanDung;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QuyCachColumn => columnQuyCach;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable2Row this[int index] => (DataTable2Row)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable2RowChangeEventHandler DataTable2RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable2RowChangeEventHandler DataTable2RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable2RowChangeEventHandler DataTable2RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable2RowChangeEventHandler DataTable2RowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable2DataTable()
		{
			base.TableName = "DataTable2";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal DataTable2DataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected DataTable2DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddDataTable2Row(DataTable2Row row)
		{
			base.Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable2Row AddDataTable2Row(string STT, string MaHang, string MatHang, string DVT, string SL, string LoSX, string HanDung, string QuyCach)
		{
			DataTable2Row dataTable2Row = (DataTable2Row)NewRow();
			object[] itemArray = new object[8] { STT, MaHang, MatHang, DVT, SL, LoSX, HanDung, QuyCach };
			dataTable2Row.ItemArray = itemArray;
			base.Rows.Add(dataTable2Row);
			return dataTable2Row;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			DataTable2DataTable dataTable2DataTable = (DataTable2DataTable)base.Clone();
			dataTable2DataTable.InitVars();
			return dataTable2DataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new DataTable2DataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnSTT = base.Columns["STT"];
			columnMaHang = base.Columns["MaHang"];
			columnMatHang = base.Columns["MatHang"];
			columnDVT = base.Columns["DVT"];
			columnSL = base.Columns["SL"];
			columnLoSX = base.Columns["LoSX"];
			columnHanDung = base.Columns["HanDung"];
			columnQuyCach = base.Columns["QuyCach"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnSTT = new DataColumn("STT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSTT);
			columnMaHang = new DataColumn("MaHang", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMaHang);
			columnMatHang = new DataColumn("MatHang", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMatHang);
			columnDVT = new DataColumn("DVT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDVT);
			columnSL = new DataColumn("SL", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSL);
			columnLoSX = new DataColumn("LoSX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLoSX);
			columnHanDung = new DataColumn("HanDung", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHanDung);
			columnQuyCach = new DataColumn("QuyCach", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnQuyCach);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable2Row NewDataTable2Row()
		{
			return (DataTable2Row)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable2Row(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(DataTable2Row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.DataTable2RowChanged != null)
			{
				this.DataTable2RowChanged(this, new DataTable2RowChangeEvent((DataTable2Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.DataTable2RowChanging != null)
			{
				this.DataTable2RowChanging(this, new DataTable2RowChangeEvent((DataTable2Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.DataTable2RowDeleted != null)
			{
				this.DataTable2RowDeleted(this, new DataTable2RowChangeEvent((DataTable2Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.DataTable2RowDeleting != null)
			{
				this.DataTable2RowDeleting(this, new DataTable2RowChangeEvent((DataTable2Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveDataTable2Row(DataTable2Row row)
		{
			base.Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			rep_PhieuDD rep_PhieuDD2 = new rep_PhieuDD();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = rep_PhieuDD2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable2DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = rep_PhieuDD2.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	public class DataTable1Row : DataRow
	{
		private DataTable1DataTable tableDataTable1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TenCoSo
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.TenCoSoColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TenCoSo' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.TenCoSoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DiaChi
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.DiaChiColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DiaChi' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.DiaChiColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Logo
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.LogoColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Logo' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.LogoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SoPhieuDieuDong
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.SoPhieuDieuDongColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SoPhieuDieuDong' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.SoPhieuDieuDongColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string HoTenVanChuyen
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.HoTenVanChuyenColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HoTenVanChuyen' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.HoTenVanChuyenColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string HangVanChuyen
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.HangVanChuyenColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HangVanChuyen' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.HangVanChuyenColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string PhuongTienVanChuyen
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.PhuongTienVanChuyenColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'PhuongTienVanChuyen' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.PhuongTienVanChuyenColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ThoiGianVanChuyen
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.ThoiGianVanChuyenColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ThoiGianVanChuyen' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.ThoiGianVanChuyenColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string XuatHangTaiKho
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.XuatHangTaiKhoColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'XuatHangTaiKho' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.XuatHangTaiKhoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NhanHangTaiKho
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.NhanHangTaiKhoColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NhanHangTaiKho' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.NhanHangTaiKhoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NgayDieuDong
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.NgayDieuDongColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayDieuDong' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.NgayDieuDongColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string GDCungUng
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.GDCungUngColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'GDCungUng' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.GDCungUngColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NguoiDeNghi
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.NguoiDeNghiColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NguoiDeNghi' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.NguoiDeNghiColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SoHD
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.SoHDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SoHD' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.SoHDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TongCong
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.TongCongColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TongCong' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.TongCongColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal DataTable1Row(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable1 = (DataTable1DataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTenCoSoNull()
		{
			return IsNull(tableDataTable1.TenCoSoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTenCoSoNull()
		{
			base[tableDataTable1.TenCoSoColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDiaChiNull()
		{
			return IsNull(tableDataTable1.DiaChiColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDiaChiNull()
		{
			base[tableDataTable1.DiaChiColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLogoNull()
		{
			return IsNull(tableDataTable1.LogoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetLogoNull()
		{
			base[tableDataTable1.LogoColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSoPhieuDieuDongNull()
		{
			return IsNull(tableDataTable1.SoPhieuDieuDongColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSoPhieuDieuDongNull()
		{
			base[tableDataTable1.SoPhieuDieuDongColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsHoTenVanChuyenNull()
		{
			return IsNull(tableDataTable1.HoTenVanChuyenColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetHoTenVanChuyenNull()
		{
			base[tableDataTable1.HoTenVanChuyenColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsHangVanChuyenNull()
		{
			return IsNull(tableDataTable1.HangVanChuyenColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetHangVanChuyenNull()
		{
			base[tableDataTable1.HangVanChuyenColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPhuongTienVanChuyenNull()
		{
			return IsNull(tableDataTable1.PhuongTienVanChuyenColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPhuongTienVanChuyenNull()
		{
			base[tableDataTable1.PhuongTienVanChuyenColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsThoiGianVanChuyenNull()
		{
			return IsNull(tableDataTable1.ThoiGianVanChuyenColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetThoiGianVanChuyenNull()
		{
			base[tableDataTable1.ThoiGianVanChuyenColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsXuatHangTaiKhoNull()
		{
			return IsNull(tableDataTable1.XuatHangTaiKhoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetXuatHangTaiKhoNull()
		{
			base[tableDataTable1.XuatHangTaiKhoColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNhanHangTaiKhoNull()
		{
			return IsNull(tableDataTable1.NhanHangTaiKhoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNhanHangTaiKhoNull()
		{
			base[tableDataTable1.NhanHangTaiKhoColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNgayDieuDongNull()
		{
			return IsNull(tableDataTable1.NgayDieuDongColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNgayDieuDongNull()
		{
			base[tableDataTable1.NgayDieuDongColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsGDCungUngNull()
		{
			return IsNull(tableDataTable1.GDCungUngColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetGDCungUngNull()
		{
			base[tableDataTable1.GDCungUngColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNguoiDeNghiNull()
		{
			return IsNull(tableDataTable1.NguoiDeNghiColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNguoiDeNghiNull()
		{
			base[tableDataTable1.NguoiDeNghiColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSoHDNull()
		{
			return IsNull(tableDataTable1.SoHDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSoHDNull()
		{
			base[tableDataTable1.SoHDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTongCongNull()
		{
			return IsNull(tableDataTable1.TongCongColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTongCongNull()
		{
			base[tableDataTable1.TongCongColumn] = Convert.DBNull;
		}
	}

	public class DataTable2Row : DataRow
	{
		private DataTable2DataTable tableDataTable2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string STT
		{
			get
			{
				try
				{
					return (string)base[tableDataTable2.STTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'STT' in table 'DataTable2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable2.STTColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string MaHang
		{
			get
			{
				try
				{
					return (string)base[tableDataTable2.MaHangColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'MaHang' in table 'DataTable2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable2.MaHangColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string MatHang
		{
			get
			{
				try
				{
					return (string)base[tableDataTable2.MatHangColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'MatHang' in table 'DataTable2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable2.MatHangColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DVT
		{
			get
			{
				try
				{
					return (string)base[tableDataTable2.DVTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DVT' in table 'DataTable2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable2.DVTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SL
		{
			get
			{
				try
				{
					return (string)base[tableDataTable2.SLColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SL' in table 'DataTable2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable2.SLColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string LoSX
		{
			get
			{
				try
				{
					return (string)base[tableDataTable2.LoSXColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'LoSX' in table 'DataTable2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable2.LoSXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string HanDung
		{
			get
			{
				try
				{
					return (string)base[tableDataTable2.HanDungColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HanDung' in table 'DataTable2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable2.HanDungColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string QuyCach
		{
			get
			{
				try
				{
					return (string)base[tableDataTable2.QuyCachColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'QuyCach' in table 'DataTable2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable2.QuyCachColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal DataTable2Row(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable2 = (DataTable2DataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSTTNull()
		{
			return IsNull(tableDataTable2.STTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSTTNull()
		{
			base[tableDataTable2.STTColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMaHangNull()
		{
			return IsNull(tableDataTable2.MaHangColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetMaHangNull()
		{
			base[tableDataTable2.MaHangColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMatHangNull()
		{
			return IsNull(tableDataTable2.MatHangColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMatHangNull()
		{
			base[tableDataTable2.MatHangColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDVTNull()
		{
			return IsNull(tableDataTable2.DVTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDVTNull()
		{
			base[tableDataTable2.DVTColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSLNull()
		{
			return IsNull(tableDataTable2.SLColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSLNull()
		{
			base[tableDataTable2.SLColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLoSXNull()
		{
			return IsNull(tableDataTable2.LoSXColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetLoSXNull()
		{
			base[tableDataTable2.LoSXColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsHanDungNull()
		{
			return IsNull(tableDataTable2.HanDungColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetHanDungNull()
		{
			base[tableDataTable2.HanDungColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsQuyCachNull()
		{
			return IsNull(tableDataTable2.QuyCachColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetQuyCachNull()
		{
			base[tableDataTable2.QuyCachColumn] = Convert.DBNull;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class DataTable1RowChangeEvent : EventArgs
	{
		private DataTable1Row eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable1Row Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable1RowChangeEvent(DataTable1Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class DataTable2RowChangeEvent : EventArgs
	{
		private DataTable2Row eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable2Row Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable2RowChangeEvent(DataTable2Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private DataTable1DataTable tableDataTable1;

	private DataTable2DataTable tableDataTable2;

	private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DataTable1DataTable DataTable1 => tableDataTable1;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public DataTable2DataTable DataTable2 => tableDataTable2;

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public new DataTableCollection Tables => base.Tables;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DebuggerNonUserCode]
	public new DataRelationCollection Relations => base.Relations;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public rep_PhieuDD()
	{
		BeginInit();
		InitClass();
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected rep_PhieuDD(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		if (IsBinarySerialized(info, context))
		{
			InitVars(initTable: false);
			CollectionChangeEventHandler value = SchemaChanged;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = (string)info.GetValue("XmlSchema", typeof(string));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["DataTable1"] != null)
			{
				base.Tables.Add(new DataTable1DataTable(dataSet.Tables["DataTable1"]));
			}
			if (dataSet.Tables["DataTable2"] != null)
			{
				base.Tables.Add(new DataTable2DataTable(dataSet.Tables["DataTable2"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = SchemaChanged;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override DataSet Clone()
	{
		rep_PhieuDD rep_PhieuDD2 = (rep_PhieuDD)base.Clone();
		rep_PhieuDD2.InitVars();
		rep_PhieuDD2.SchemaSerializationMode = SchemaSerializationMode;
		return rep_PhieuDD2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["DataTable1"] != null)
			{
				base.Tables.Add(new DataTable1DataTable(dataSet.Tables["DataTable1"]));
			}
			if (dataSet.Tables["DataTable2"] != null)
			{
				base.Tables.Add(new DataTable2DataTable(dataSet.Tables["DataTable2"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXml(reader);
			InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars(bool initTable)
	{
		tableDataTable1 = (DataTable1DataTable)base.Tables["DataTable1"];
		if (initTable && tableDataTable1 != null)
		{
			tableDataTable1.InitVars();
		}
		tableDataTable2 = (DataTable2DataTable)base.Tables["DataTable2"];
		if (initTable && tableDataTable2 != null)
		{
			tableDataTable2.InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitClass()
	{
		base.DataSetName = "rep_PhieuDD";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/rep_PhieuDD.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableDataTable1 = new DataTable1DataTable();
		base.Tables.Add(tableDataTable1);
		tableDataTable2 = new DataTable2DataTable();
		base.Tables.Add(tableDataTable2);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeDataTable1()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeDataTable2()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		rep_PhieuDD rep_PhieuDD2 = new rep_PhieuDD();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = rep_PhieuDD2.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = rep_PhieuDD2.GetSchemaSerializable();
		if (xs.Contains(schemaSerializable.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema = null;
				schemaSerializable.Write(memoryStream);
				IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
				while (enumerator.MoveNext())
				{
					xmlSchema = (XmlSchema)enumerator.Current;
					memoryStream2.SetLength(0L);
					xmlSchema.Write(memoryStream2);
					if (memoryStream.Length == memoryStream2.Length)
					{
						memoryStream.Position = 0L;
						memoryStream2.Position = 0L;
						while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
						{
						}
						if (memoryStream.Position == memoryStream.Length)
						{
							return xmlSchemaComplexType;
						}
					}
				}
			}
			finally
			{
				memoryStream?.Close();
				memoryStream2?.Close();
			}
		}
		xs.Add(schemaSerializable);
		return xmlSchemaComplexType;
	}
}
