using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Threading;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using ServerShared;

namespace Report_PhieuDieuDong;

public class rpt_PhieuDieuDong : XtraReport, IReport
{
	private DataSet dset = new DataSet();

	private IContainer components = null;

	private DetailBand Detail;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private ReportHeaderBand ReportHeader;

	private XRLabel xrLabel1;

	private XRLabel xrLabel2;

	private XRLabel xrLabel6;

	private ReportFooterBand ReportFooter;

	private XRPictureBox xrPictureBox2;

	private XRTable xrTable2;

	private XRTableRow xrTableRow2;

	private XRTableCell xrTableCell9;

	private XRTableCell xrTableCell10;

	private XRTableCell xrTableCell11;

	private XRTableCell xrTableCell12;

	private XRTableCell xrTableCell13;

	private XRTableCell xrTableCell14;

	private XRTableCell xrTableCell15;

	private XRTableCell xrTableCell16;

	private XRLabel xrLabel17;

	private XRLabel xrLabel16;

	private XRLabel xrLabel15;

	private XRLabel xrLabel14;

	private XRLabel xrLabel13;

	private XRLabel xrLabel12;

	private XRLabel xrLabel11;

	private XRLabel xrLabel10;

	private XRLabel xrLabel9;

	private XRLabel xrLabel8;

	private XRLabel xrLabel7;

	private XRLabel xrLabel5;

	private XRLabel xrLabel4;

	private XRLabel xrLabel3;

	private XRLabel xrLabel21;

	private XRLabel xrLabel20;

	private XRLabel xrLabel19;

	private XRTable xrTable3;

	private XRTableRow xrTableRow3;

	private XRTableCell xrTableCell17;

	private XRTableCell xrTableCell18;

	private XRTableCell xrTableCell19;

	private XRTableCell xrTableCell20;

	private XRTableCell xrTableCell21;

	private XRTableCell xrTableCell22;

	private XRTableCell xrTableCell23;

	private XRTableCell xrTableCell24;

	private rep_PhieuDD rep_PhieuDD1;

	private XRLabel xrLabel25;

	private XRLabel xrLabel23;

	private XRLabel xrLabel22;

	private XRLabel xrLabel18;

	private XRTable xrTable1;

	private XRTableRow xrTableRow1;

	private XRTableCell xrTableCell4;

	private XRTableCell xrTableCell1;

	private XRTableCell xrTableCell5;

	private XRTableCell xrTableCell2;

	private XRTableCell xrTableCell7;

	private XRTableCell xrTableCell6;

	private XRTableCell xrTableCell8;

	private XRTableCell xrTableCell3;

	private XRLabel xrLabel24;

	private XRLabel xrLabel27;

	private XRLabel xrLabel26;

	private XRPanel footerPanel;

	private GroupFooterBand groupFooterBand1;

	public rpt_PhieuDieuDong()
	{
		InitializeComponent();
	}

	public ReportResult Generate(DataSet ds, string type)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		rep_PhieuDD rep_PhieuDD2 = new rep_PhieuDD();
		DataSetExtensions.ApplyDataSet((DataSet)rep_PhieuDD2, ds);
		dset = rep_PhieuDD2;
		base.DataSource = rep_PhieuDD2;
		MemoryStream memoryStream = new MemoryStream();
		if (type.ToUpper() == "PDF")
		{
			ExportToPdf(memoryStream);
		}
		if (type.ToUpper() == "XLS")
		{
			ExportToXls(memoryStream);
		}
		if (type.ToUpper() == "HTML")
		{
			ExportToHtml(memoryStream);
		}
		return new ReportResult(type, memoryStream.ToArray());
	}

	private void rpt_PhieuDieuDong_BeforePrint(object sender, PrintEventArgs e)
	{
		Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
		Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");
		string s = DataExtensions.FirstRow(dset.Tables[0])["Logo"].ToString();
		byte[] buffer = Convert.FromBase64String(s);
		Stream stream = new MemoryStream(buffer);
		Image image = Image.FromStream(stream);
		xrPictureBox2.Image = image;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(rpt_PhieuDieuDong));
		XRSummary xRSummary = new XRSummary();
		XRSummary xRSummary2 = new XRSummary();
		Detail = new DetailBand();
		xrTable2 = new XRTable();
		xrTableRow2 = new XRTableRow();
		xrTableCell9 = new XRTableCell();
		xrTableCell10 = new XRTableCell();
		xrTableCell11 = new XRTableCell();
		xrTableCell12 = new XRTableCell();
		xrTableCell13 = new XRTableCell();
		xrTableCell14 = new XRTableCell();
		xrTableCell15 = new XRTableCell();
		xrTableCell16 = new XRTableCell();
		TopMargin = new TopMarginBand();
		BottomMargin = new BottomMarginBand();
		ReportHeader = new ReportHeaderBand();
		xrLabel26 = new XRLabel();
		xrTable1 = new XRTable();
		xrTableRow1 = new XRTableRow();
		xrTableCell4 = new XRTableCell();
		xrTableCell1 = new XRTableCell();
		xrTableCell5 = new XRTableCell();
		xrTableCell2 = new XRTableCell();
		xrTableCell7 = new XRTableCell();
		xrTableCell6 = new XRTableCell();
		xrTableCell8 = new XRTableCell();
		xrTableCell3 = new XRTableCell();
		xrLabel17 = new XRLabel();
		xrLabel16 = new XRLabel();
		xrLabel15 = new XRLabel();
		xrLabel14 = new XRLabel();
		xrLabel13 = new XRLabel();
		xrLabel12 = new XRLabel();
		xrLabel11 = new XRLabel();
		xrLabel10 = new XRLabel();
		xrLabel9 = new XRLabel();
		xrLabel8 = new XRLabel();
		xrLabel7 = new XRLabel();
		xrLabel5 = new XRLabel();
		xrLabel4 = new XRLabel();
		xrLabel3 = new XRLabel();
		xrPictureBox2 = new XRPictureBox();
		xrLabel1 = new XRLabel();
		xrLabel2 = new XRLabel();
		xrLabel6 = new XRLabel();
		ReportFooter = new ReportFooterBand();
		xrLabel27 = new XRLabel();
		xrLabel24 = new XRLabel();
		xrLabel25 = new XRLabel();
		xrLabel23 = new XRLabel();
		xrLabel22 = new XRLabel();
		xrLabel21 = new XRLabel();
		xrLabel20 = new XRLabel();
		xrLabel19 = new XRLabel();
		xrTable3 = new XRTable();
		xrTableRow3 = new XRTableRow();
		xrTableCell17 = new XRTableCell();
		xrTableCell18 = new XRTableCell();
		xrTableCell19 = new XRTableCell();
		xrTableCell20 = new XRTableCell();
		xrTableCell21 = new XRTableCell();
		xrTableCell22 = new XRTableCell();
		xrTableCell23 = new XRTableCell();
		xrTableCell24 = new XRTableCell();
		xrLabel18 = new XRLabel();
		footerPanel = new XRPanel();
		((ISupportInitialize)xrTable2).BeginInit();
		((ISupportInitialize)xrTable1).BeginInit();
		((ISupportInitialize)xrTable3).BeginInit();
		((ISupportInitialize)this).BeginInit();
		Detail.Controls.AddRange(new XRControl[1] { xrTable2 });
		Detail.HeightF = 26.04167f;
		Detail.Name = "Detail";
		Detail.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		Detail.TextAlignment = TextAlignment.TopLeft;
		xrTable2.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
		xrTable2.Font = new Font("Times New Roman", 13f);
		xrTable2.LocationFloat = new PointFloat(10.00001f, 0f);
		xrTable2.Name = "xrTable2";
		xrTable2.Rows.AddRange(new XRTableRow[1] { xrTableRow2 });
		xrTable2.SizeF = new SizeF(1122f, 26.04167f);
		xrTable2.StylePriority.UseBorders = false;
		xrTable2.StylePriority.UseFont = false;
		xrTable2.StylePriority.UseTextAlignment = false;
		xrTable2.TextAlignment = TextAlignment.MiddleCenter;
		xrTableRow2.Cells.AddRange(new XRTableCell[8] { xrTableCell9, xrTableCell10, xrTableCell11, xrTableCell12, xrTableCell13, xrTableCell14, xrTableCell15, xrTableCell16 });
		xrTableRow2.Name = "xrTableRow2";
		xrTableRow2.Weight = 1.0;
		xrTableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[STT]")
		});
		xrTableCell9.Name = "xrTableCell9";
		xrTableCell9.Text = "xrTableCell9";
		xrTableCell9.Weight = 0.1155135731490828;
		xrTableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[MaHang]")
		});
		xrTableCell10.Name = "xrTableCell10";
		xrTableCell10.Text = "xrTableCell10";
		xrTableCell10.Weight = 0.3519057008132091;
		xrTableCell11.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[MatHang]")
		});
		xrTableCell11.Name = "xrTableCell11";
		xrTableCell11.Text = "xrTableCell11";
		xrTableCell11.Weight = 0.6872135790176994;
		xrTableCell12.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DVT]")
		});
		xrTableCell12.Name = "xrTableCell12";
		xrTableCell12.Text = "xrTableCell12";
		xrTableCell12.Weight = 0.2541075562385634;
		xrTableCell13.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SL]")
		});
		xrTableCell13.Name = "xrTableCell13";
		xrTableCell13.Text = "xrTableCell13";
		xrTableCell13.Weight = 0.3086785992323013;
		xrTableCell14.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[LoSX]")
		});
		xrTableCell14.Name = "xrTableCell14";
		xrTableCell14.Text = "xrTableCell14";
		xrTableCell14.Weight = 0.3198557494316101;
		xrTableCell15.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[HanDung]")
		});
		xrTableCell15.Name = "xrTableCell15";
		xrTableCell15.Text = "xrTableCell15";
		xrTableCell15.Weight = 0.322650039426963;
		xrTableCell16.Name = "xrTableCell16";
		xrTableCell16.Weight = 0.6497989480577242;
		TopMargin.HeightF = 23f;
		TopMargin.Name = "TopMargin";
		TopMargin.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		TopMargin.TextAlignment = TextAlignment.TopLeft;
		BottomMargin.HeightF = 26f;
		BottomMargin.Name = "BottomMargin";
		BottomMargin.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		BottomMargin.TextAlignment = TextAlignment.TopLeft;
		ReportHeader.Controls.AddRange(new XRControl[20]
		{
			xrLabel26, xrTable1, xrLabel17, xrLabel16, xrLabel15, xrLabel14, xrLabel13, xrLabel12, xrLabel11, xrLabel10,
			xrLabel9, xrLabel8, xrLabel7, xrLabel5, xrLabel4, xrLabel3, xrPictureBox2, xrLabel1, xrLabel2, xrLabel6
		});
		ReportHeader.HeightF = 351.3174f;
		ReportHeader.Name = "ReportHeader";
		xrLabel26.LocationFloat = new PointFloat(915.625f, 10.00001f);
		xrLabel26.Name = "xrLabel26";
		xrLabel26.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel26.SizeF = new SizeF(100f, 23f);
		xrLabel26.Text = "Số HĐ:";
		xrTable1.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
		xrTable1.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
		xrTable1.LocationFloat = new PointFloat(10.0001f, 325.2758f);
		xrTable1.Name = "xrTable1";
		xrTable1.Rows.AddRange(new XRTableRow[1] { xrTableRow1 });
		xrTable1.SizeF = new SizeF(1122f, 26.04167f);
		xrTable1.StylePriority.UseBorders = false;
		xrTable1.StylePriority.UseFont = false;
		xrTable1.StylePriority.UseTextAlignment = false;
		xrTable1.TextAlignment = TextAlignment.MiddleCenter;
		xrTableRow1.Cells.AddRange(new XRTableCell[8] { xrTableCell4, xrTableCell1, xrTableCell5, xrTableCell2, xrTableCell7, xrTableCell6, xrTableCell8, xrTableCell3 });
		xrTableRow1.Name = "xrTableRow1";
		xrTableRow1.Weight = 1.0;
		xrTableCell4.Name = "xrTableCell4";
		xrTableCell4.Text = "STT";
		xrTableCell4.Weight = 0.1155135731490828;
		xrTableCell1.Name = "xrTableCell1";
		xrTableCell1.Text = "Mã Hàng";
		xrTableCell1.Weight = 0.3519057008132091;
		xrTableCell5.Name = "xrTableCell5";
		xrTableCell5.Text = "Mặt hàng";
		xrTableCell5.Weight = 0.6872136293729758;
		xrTableCell2.Name = "xrTableCell2";
		xrTableCell2.Text = "ĐVT";
		xrTableCell2.Weight = 0.2541073989953629;
		xrTableCell7.Name = "xrTableCell7";
		xrTableCell7.Text = "SL";
		xrTableCell7.Weight = 0.30867894897101467;
		xrTableCell6.Name = "xrTableCell6";
		xrTableCell6.Text = "Lô SX";
		xrTableCell6.Weight = 0.31985579036276396;
		xrTableCell8.Name = "xrTableCell8";
		xrTableCell8.Text = "Hạn Dùng";
		xrTableCell8.Weight = 0.3226500748860569;
		xrTableCell3.Name = "xrTableCell3";
		xrTableCell3.Text = "Ghi Chú";
		xrTableCell3.Weight = 0.64979895626583;
		xrLabel17.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DataTable1.NhanHangTaiKho]")
		});
		xrLabel17.Font = new Font("Times New Roman", 13f);
		xrLabel17.LocationFloat = new PointFloat(202.7083f, 298.2758f);
		xrLabel17.Name = "xrLabel17";
		xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel17.SizeF = new SizeF(915.6665f, 23f);
		xrLabel17.StylePriority.UseFont = false;
		xrLabel17.StylePriority.UseTextAlignment = false;
		xrLabel17.Text = "xrLabel17";
		xrLabel17.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel16.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DataTable1.XuatHangTaiKho]")
		});
		xrLabel16.Font = new Font("Times New Roman", 13f);
		xrLabel16.LocationFloat = new PointFloat(202.7083f, 275.2759f);
		xrLabel16.Name = "xrLabel16";
		xrLabel16.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel16.SizeF = new SizeF(915.6665f, 23f);
		xrLabel16.StylePriority.UseFont = false;
		xrLabel16.StylePriority.UseTextAlignment = false;
		xrLabel16.Text = "xrLabel16";
		xrLabel16.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel15.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DataTable1.ThoiGianVanChuyen]")
		});
		xrLabel15.Font = new Font("Times New Roman", 13f);
		xrLabel15.LocationFloat = new PointFloat(311.0415f, 252.0415f);
		xrLabel15.Name = "xrLabel15";
		xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel15.SizeF = new SizeF(807.3331f, 23.00002f);
		xrLabel15.StylePriority.UseFont = false;
		xrLabel15.StylePriority.UseTextAlignment = false;
		xrLabel15.Text = "xrLabel15";
		xrLabel15.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel14.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DataTable1.PhuongTienVanChuyen]")
		});
		xrLabel14.Font = new Font("Times New Roman", 13f);
		xrLabel14.LocationFloat = new PointFloat(202.7083f, 229.0416f);
		xrLabel14.Name = "xrLabel14";
		xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel14.SizeF = new SizeF(915.6665f, 23f);
		xrLabel14.StylePriority.UseFont = false;
		xrLabel14.StylePriority.UseTextAlignment = false;
		xrLabel14.Text = "xrLabel14";
		xrLabel14.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel13.Font = new Font("Times New Roman", 12.75f, FontStyle.Underline, GraphicsUnit.Point, 0);
		xrLabel13.LocationFloat = new PointFloat(9.999997f, 298.2758f);
		xrLabel13.Name = "xrLabel13";
		xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel13.SizeF = new SizeF(192.7083f, 23f);
		xrLabel13.StylePriority.UseFont = false;
		xrLabel13.StylePriority.UseTextAlignment = false;
		xrLabel13.Text = "Nhận hàng tại kho:";
		xrLabel13.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel12.Font = new Font("Times New Roman", 12.75f, FontStyle.Underline, GraphicsUnit.Point, 0);
		xrLabel12.LocationFloat = new PointFloat(9.999997f, 275.0416f);
		xrLabel12.Name = "xrLabel12";
		xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel12.SizeF = new SizeF(192.7083f, 23f);
		xrLabel12.StylePriority.UseFont = false;
		xrLabel12.StylePriority.UseTextAlignment = false;
		xrLabel12.Text = "Xuất hàng tại kho:";
		xrLabel12.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel11.Font = new Font("Times New Roman", 13f);
		xrLabel11.LocationFloat = new PointFloat(10.0001f, 252.0416f);
		xrLabel11.Name = "xrLabel11";
		xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.SizeF = new SizeF(301.0414f, 22.99998f);
		xrLabel11.StylePriority.UseFont = false;
		xrLabel11.StylePriority.UseTextAlignment = false;
		xrLabel11.Text = "Thời gian chậm nhất trung tâm có hàng:";
		xrLabel11.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel10.Font = new Font("Times New Roman", 13f);
		xrLabel10.LocationFloat = new PointFloat(10.00001f, 229.0416f);
		xrLabel10.Name = "xrLabel10";
		xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel10.SizeF = new SizeF(192.7083f, 23f);
		xrLabel10.StylePriority.UseFont = false;
		xrLabel10.StylePriority.UseTextAlignment = false;
		xrLabel10.Text = "Phương tiện vận chuyển:";
		xrLabel10.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel9.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DataTable1.HangVanChuyen]")
		});
		xrLabel9.Font = new Font("Times New Roman", 13f);
		xrLabel9.LocationFloat = new PointFloat(202.7083f, 206.0416f);
		xrLabel9.Name = "xrLabel9";
		xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel9.SizeF = new SizeF(915.6665f, 23f);
		xrLabel9.StylePriority.UseFont = false;
		xrLabel9.StylePriority.UseTextAlignment = false;
		xrLabel9.Text = "xrLabel9";
		xrLabel9.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel8.Font = new Font("Times New Roman", 13f);
		xrLabel8.LocationFloat = new PointFloat(10.00001f, 206.0416f);
		xrLabel8.Name = "xrLabel8";
		xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.SizeF = new SizeF(192.7083f, 23f);
		xrLabel8.StylePriority.UseFont = false;
		xrLabel8.StylePriority.UseTextAlignment = false;
		xrLabel8.Text = "Hãng vận chuyển:";
		xrLabel8.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel7.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DataTable1.HoTenVanChuyen]")
		});
		xrLabel7.Font = new Font("Times New Roman", 13f);
		xrLabel7.LocationFloat = new PointFloat(202.75f, 183.0417f);
		xrLabel7.Name = "xrLabel7";
		xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel7.SizeF = new SizeF(915.6249f, 23f);
		xrLabel7.StylePriority.UseFont = false;
		xrLabel7.StylePriority.UseTextAlignment = false;
		xrLabel7.Text = "xrLabel7";
		xrLabel7.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel5.Font = new Font("Times New Roman", 13f);
		xrLabel5.LocationFloat = new PointFloat(10.00001f, 183.0417f);
		xrLabel5.Name = "xrLabel5";
		xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.SizeF = new SizeF(192.7083f, 23f);
		xrLabel5.StylePriority.UseFont = false;
		xrLabel5.StylePriority.UseTextAlignment = false;
		xrLabel5.Text = "Họ tên người vận chuyển:";
		xrLabel5.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel4.Font = new Font("Times New Roman", 13f);
		xrLabel4.LocationFloat = new PointFloat(10.00001f, 160.0416f);
		xrLabel4.Name = "xrLabel4";
		xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel4.SizeF = new SizeF(583.3333f, 23f);
		xrLabel4.StylePriority.UseFont = false;
		xrLabel4.StylePriority.UseTextAlignment = false;
		xrLabel4.Text = "Công ty cổ phần Vacxin Việt Nam điều động lượng hàng sau:";
		xrLabel4.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel3.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DataTable1.SoPhieuDieuDong]")
		});
		xrLabel3.Font = new Font("Times New Roman", 13f);
		xrLabel3.LocationFloat = new PointFloat(34.37503f, 132.0417f);
		xrLabel3.Name = "xrLabel3";
		xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel3.SizeF = new SizeF(1084f, 23f);
		xrLabel3.StylePriority.UseFont = false;
		xrLabel3.StylePriority.UseTextAlignment = false;
		xrLabel3.Text = "xrLabel3";
		xrLabel3.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel3.TextFormatString = "Số phiếu: {0}";
		xrPictureBox2.ImageSource = new ImageSource("img", componentResourceManager.GetString("xrPictureBox2.ImageSource"));
		xrPictureBox2.LocationFloat = new PointFloat(34.37503f, 10.00001f);
		xrPictureBox2.Name = "xrPictureBox2";
		xrPictureBox2.SizeF = new SizeF(90f, 90f);
		xrPictureBox2.Sizing = ImageSizeMode.StretchImage;
		xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DataTable1.TenCoSo]")
		});
		xrLabel1.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
		xrLabel1.LocationFloat = new PointFloat(148.9583f, 10.00001f);
		xrLabel1.Name = "xrLabel1";
		xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel1.SizeF = new SizeF(538.5416f, 23f);
		xrLabel1.StylePriority.UseFont = false;
		xrLabel1.Text = "xrLabel1";
		xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DataTable1.DiaChi]")
		});
		xrLabel2.Font = new Font("Times New Roman", 13f);
		xrLabel2.LocationFloat = new PointFloat(148.9583f, 33.00001f);
		xrLabel2.Name = "xrLabel2";
		xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.SizeF = new SizeF(538.5416f, 23f);
		xrLabel2.StylePriority.UseFont = false;
		xrLabel2.Text = "xrLabel2";
		xrLabel6.Font = new Font("Times New Roman", 18f, FontStyle.Bold);
		xrLabel6.LocationFloat = new PointFloat(34.37502f, 104.875f);
		xrLabel6.Name = "xrLabel6";
		xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel6.SizeF = new SizeF(1084f, 27.16666f);
		xrLabel6.StylePriority.UseFont = false;
		xrLabel6.StylePriority.UseTextAlignment = false;
		xrLabel6.Text = "LỆNH ĐIỀU ĐỘNG";
		xrLabel6.TextAlignment = TextAlignment.MiddleCenter;
		ReportFooter.Controls.AddRange(new XRControl[1] { footerPanel });
		ReportFooter.HeightF = 208.3333f;
		ReportFooter.Name = "ReportFooter";
		ReportFooter.StylePriority.UseTextAlignment = false;
		ReportFooter.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel27.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DataTable1.NguoiDuyetDeNghi]")
		});
		xrLabel27.Font = new Font("Times New Roman", 13f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xrLabel27.LocationFloat = new PointFloat(421.6248f, 185.3333f);
		xrLabel27.Name = "xrLabel27";
		xrLabel27.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel27.SizeF = new SizeF(268.198f, 23f);
		xrLabel27.StylePriority.UseFont = false;
		xrLabel27.StylePriority.UseTextAlignment = false;
		xrLabel27.Text = "xrLabel18";
		xrLabel27.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel27.TextFormatString = "{0}";
		xrLabel24.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DataTable1.NguoiDeNghi]")
		});
		xrLabel24.Font = new Font("Times New Roman", 13f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xrLabel24.LocationFloat = new PointFloat(850.1765f, 185.3333f);
		xrLabel24.Name = "xrLabel24";
		xrLabel24.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel24.SizeF = new SizeF(268.198f, 23f);
		xrLabel24.StylePriority.UseFont = false;
		xrLabel24.StylePriority.UseTextAlignment = false;
		xrLabel24.Text = "xrLabel18";
		xrLabel24.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel24.TextFormatString = "{0}";
		xrLabel25.Font = new Font("Times New Roman", 13f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xrLabel25.LocationFloat = new PointFloat(850.177f, 85.45837f);
		xrLabel25.Name = "xrLabel25";
		xrLabel25.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel25.SizeF = new SizeF(268.1981f, 23f);
		xrLabel25.StylePriority.UseFont = false;
		xrLabel25.StylePriority.UseTextAlignment = false;
		xrLabel25.Text = "(Ký, ghi rõ họ tên)";
		xrLabel25.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel23.Font = new Font("Times New Roman", 13f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xrLabel23.LocationFloat = new PointFloat(421.6248f, 85.45837f);
		xrLabel23.Name = "xrLabel23";
		xrLabel23.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel23.SizeF = new SizeF(268.1981f, 23f);
		xrLabel23.StylePriority.UseFont = false;
		xrLabel23.StylePriority.UseTextAlignment = false;
		xrLabel23.Text = "(Ký, ghi rõ họ tên)";
		xrLabel23.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel22.Font = new Font("Times New Roman", 13f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xrLabel22.LocationFloat = new PointFloat(9.999974f, 87.45836f);
		xrLabel22.Name = "xrLabel22";
		xrLabel22.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel22.SizeF = new SizeF(268.1981f, 23f);
		xrLabel22.StylePriority.UseFont = false;
		xrLabel22.StylePriority.UseTextAlignment = false;
		xrLabel22.Text = "(Ký, ghi rõ họ tên)";
		xrLabel22.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel21.Font = new Font("Times New Roman", 13f, FontStyle.Bold, GraphicsUnit.Point, 0);
		xrLabel21.LocationFloat = new PointFloat(10.00001f, 62.45835f);
		xrLabel21.Name = "xrLabel21";
		xrLabel21.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel21.SizeF = new SizeF(268.1981f, 23f);
		xrLabel21.StylePriority.UseFont = false;
		xrLabel21.StylePriority.UseTextAlignment = false;
		xrLabel21.Text = "BP Kho";
		xrLabel21.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel20.Font = new Font("Times New Roman", 13f, FontStyle.Bold, GraphicsUnit.Point, 0);
		xrLabel20.LocationFloat = new PointFloat(421.3018f, 62.45835f);
		xrLabel20.Name = "xrLabel20";
		xrLabel20.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel20.SizeF = new SizeF(268.1981f, 23f);
		xrLabel20.StylePriority.UseFont = false;
		xrLabel20.StylePriority.UseTextAlignment = false;
		xrLabel20.Text = "Duyệt đề nghị";
		xrLabel20.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel19.Font = new Font("Times New Roman", 13f, FontStyle.Bold, GraphicsUnit.Point, 0);
		xrLabel19.LocationFloat = new PointFloat(850.177f, 62.45835f);
		xrLabel19.Name = "xrLabel19";
		xrLabel19.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel19.SizeF = new SizeF(268.1981f, 23f);
		xrLabel19.StylePriority.UseFont = false;
		xrLabel19.StylePriority.UseTextAlignment = false;
		xrLabel19.Text = "Người đề nghị";
		xrLabel19.TextAlignment = TextAlignment.MiddleCenter;
		xrTable3.Borders = BorderSide.All;
		xrTable3.Font = new Font("Times New Roman", 13f);
		xrTable3.LocationFloat = new PointFloat(10.00001f, 0f);
		xrTable3.Name = "xrTable3";
		xrTable3.Rows.AddRange(new XRTableRow[1] { xrTableRow3 });
		xrTable3.SizeF = new SizeF(1122f, 26.04167f);
		xrTable3.StylePriority.UseBorders = false;
		xrTable3.StylePriority.UseFont = false;
		xrTable3.StylePriority.UseTextAlignment = false;
		xrTable3.TextAlignment = TextAlignment.MiddleCenter;
		xrTableRow3.Cells.AddRange(new XRTableCell[8] { xrTableCell17, xrTableCell18, xrTableCell19, xrTableCell20, xrTableCell21, xrTableCell22, xrTableCell23, xrTableCell24 });
		xrTableRow3.Name = "xrTableRow3";
		xrTableRow3.Weight = 1.0;
		xrTableCell17.Name = "xrTableCell17";
		xrTableCell17.Weight = 0.11551356291629702;
		xrTableCell18.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
		xrTableCell18.Name = "xrTableCell18";
		xrTableCell18.StylePriority.UseFont = false;
		xrTableCell18.StylePriority.UseTextAlignment = false;
		xrTableCell18.Text = "Tổng:";
		xrTableCell18.TextAlignment = TextAlignment.MiddleLeft;
		xrTableCell18.Weight = 0.3519056496492802;
		xrTableCell19.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumCount([MatHang])")
		});
		xrTableCell19.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
		xrTableCell19.Name = "xrTableCell19";
		xrTableCell19.StylePriority.UseFont = false;
		xRSummary.IgnoreNullValues = true;
		xRSummary.Running = SummaryRunning.Report;
		xrTableCell19.Summary = xRSummary;
		xrTableCell19.Text = "xrTableCell19";
		xrTableCell19.TextFormatString = "{0:n0} khoản";
		xrTableCell19.Weight = 0.6872135843260138;
		xrTableCell20.Name = "xrTableCell20";
		xrTableCell20.Weight = 0.2541078972765835;
		xrTableCell21.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DataTable1.TongCong]")
		});
		xrTableCell21.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
		xrTableCell21.Name = "xrTableCell21";
		xrTableCell21.StylePriority.UseFont = false;
		xRSummary2.FormatString = "{0:n0}";
		xrTableCell21.Summary = xRSummary2;
		xrTableCell21.Text = "xrTableCell21";
		xrTableCell21.Weight = 0.3086784570006881;
		xrTableCell22.Name = "xrTableCell22";
		xrTableCell22.Weight = 0.31985574937391714;
		xrTableCell23.Name = "xrTableCell23";
		xrTableCell23.Weight = 0.3226500571180459;
		xrTableCell24.Name = "xrTableCell24";
		xrTableCell24.Weight = 0.6497989721480489;
		xrLabel18.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DataTable1.NgayDieuDong]")
		});
		xrLabel18.Font = new Font("Times New Roman", 13f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xrLabel18.LocationFloat = new PointFloat(850.177f, 39.45834f);
		xrLabel18.Name = "xrLabel18";
		xrLabel18.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel18.SizeF = new SizeF(268.198f, 23f);
		xrLabel18.StylePriority.UseFont = false;
		xrLabel18.StylePriority.UseTextAlignment = false;
		xrLabel18.Text = "xrLabel18";
		xrLabel18.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel18.TextFormatString = "{0}";
		groupFooterBand1 = new GroupFooterBand();
		groupFooterBand1.HeightF = 26.04167f;
		groupFooterBand1.Name = "groupFooterBand1";
		groupFooterBand1.Controls.Add(xrTable3);
		base.Bands.Add(groupFooterBand1);
		footerPanel.Borders = BorderSide.None;
		footerPanel.CanGrow = false;
		footerPanel.Controls.AddRange(new XRControl[9] { xrLabel18, xrLabel21, xrLabel20, xrLabel19, xrLabel22, xrLabel23, xrLabel25, xrLabel27, xrLabel24 });
		footerPanel.LocationFloat = new PointFloat(0f, 0f);
		footerPanel.Name = "footerPanel";
		footerPanel.SizeF = new SizeF(1142f, 208.3333f);
		base.Bands.AddRange(new Band[5] { Detail, TopMargin, BottomMargin, ReportHeader, ReportFooter });
		base.DataMember = "DataTable2";
		base.Landscape = true;
		base.Margins = new Margins(12, 15, 23, 26);
		base.PageHeight = 827;
		base.PageWidth = 1169;
		base.PaperKind = PaperKind.A4;
		base.Version = "21.2";
		((ISupportInitialize)xrTable2).EndInit();
		((ISupportInitialize)xrTable1).EndInit();
		((ISupportInitialize)xrTable3).EndInit();
		((ISupportInitialize)this).EndInit();
	}
}
