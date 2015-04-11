Imports System.Data.SqlClient
Imports System.Data
Imports System.Web
Imports System.Configuration

Partial Class ChucNang_Xem_hoa_don
    Inherits System.Web.UI.Page
    Public chuoiketnoi As String = "workstation id=vocanh1994.mssql.somee.com;packet size=4096;user id=canhvv;pwd=Vocanh02012004;data source=vocanh1994.mssql.somee.com;persist security info=False;initial catalog=vocanh1994"
    Public ketnoi As New SqlConnection(chuoiketnoi)

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        SqlDataSource1.ConnectionString = chuoiketnoi
        SqlDataSource1.SelectCommand = "select Ma_hoa_don as 'ID',Ten_khach_hang as 'Tên khách hàng',Ten_san_pham as 'Sản phẩm mua',CHI_TIET_HOA_DON.So_luong as 'Số lượng mua',REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,Tong_tien),1), '.00','') as 'Tổng tiền (VNĐ)',FORMAT(Ngay_lap,'dd/MM/yyyy') as 'Ngày lập hóa đơn',Sdt as 'Điện thoại',Dia_chi as 'Địa chỉ',Ten_dang_nhap as 'Người tạo hóa đơn', Ten_loai as 'Loại' from HOA_DON inner join KHACH_HANG on HOA_DON.KHACH_HANG_Ma_khach_hang = KHACH_HANG.Ma_khach_hang inner join NGUOI_DUNG on HOA_DON.NGUOI_DUNG_Ma_nguoi_dung = NGUOI_DUNG.Ma_nguoi_dung inner join CHI_TIET_HOA_DON on HOA_DON.Ma_hoa_don = CHI_TIET_HOA_DON.HOA_DON_Ma_hoa_don inner join SAN_PHAM on HOA_DON.Ma_hoa_don = CHI_TIET_HOA_DON.HOA_DON_Ma_hoa_don and SAN_PHAM.Ma_san_pham = CHI_TIET_HOA_DON.SAN_PHAM_Ma_san_pham inner join LOAI_SAN_PHAM on HOA_DON.Ma_hoa_don = CHI_TIET_HOA_DON.HOA_DON_Ma_hoa_don and SAN_PHAM.Ma_san_pham = CHI_TIET_HOA_DON.SAN_PHAM_Ma_san_pham and LOAI_SAN_PHAM.Ma_loai = SAN_PHAM.LOAI_SAN_PHAM_Ma_loai ORDER BY ID ASC"
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("../order/Home.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Ghi_hoa_don.aspx")
    End Sub
End Class
