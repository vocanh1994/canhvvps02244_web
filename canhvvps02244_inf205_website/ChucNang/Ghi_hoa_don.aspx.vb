Imports System.Data.SqlClient
Imports System.Data
Imports System.Web
Imports System.Configuration

Partial Class ChucNang_Ghi_hoa_don
    Inherits System.Web.UI.Page
    Public chuoiketnoi As String = "workstation id=vocanh1994.mssql.somee.com;packet size=4096;user id=canhvv;pwd=Vocanh02012004;data source=vocanh1994.mssql.somee.com;persist security info=False;initial catalog=vocanh1994"
    Public ketnoi As New SqlConnection(chuoiketnoi)

    Protected Sub btn_tinhtien_Click(sender As Object, e As EventArgs) Handles btn_tinhtien.Click
        Try
            If txt_tenSP.Text = "" Then
                lbl_error.Text = "Bạn chưa nhập tên Sản phẩm !"
                lbl_tinhtien.Text = "0 VNĐ"
                Exit Sub
            ElseIf txt_soluong.Text = "" Then
                lbl_error.Text = "Bạn chưa nhập số lượng sản phẩm !"
                lbl_tinhtien.Text = "0 VNĐ"
                Exit Sub
            End If
            '*********************
            Try
                ketnoi.Open()
                ketnoi.Close()
            Catch MySqlException As SqlException
                lbl_error.Text = "Không kết nối được với Cơ sở dữ liệu !"
                lbl_tinhtien.Text = "0 VNĐ"
                Exit Sub
            End Try
            '*********************
            Dim sql As New SqlDataAdapter("SELECT Don_gia, So_luong FROM SAN_PHAM WHERE Ten_san_pham='" & txt_tenSP.Text & "'", ketnoi)
            Dim tb As New DataTable
            ketnoi.Open()
            sql.Fill(tb)
            ketnoi.Close()
            If tb.Rows.Count() < 1 Then
                lbl_error.Text = "Không có sản phẩm trên !"
                lbl_tinhtien.Text = "0 VNĐ"
                txt_tenSP.Focus()
                Exit Sub
            ElseIf Int(txt_soluong.Text) < 1 Then
                lbl_error.Text = "Số lượng bạn mua phải lớn hơn 0 !"
                lbl_tinhtien.Text = "0 VNĐ"
                txt_soluong.Focus()
                Exit Sub
            ElseIf Int(txt_soluong.Text) > Int(tb.Rows(0).Item(1).ToString) Then
                lbl_error.Text = "Số lượng bạn mua nhiều hơn số lượng trong kho hàng !"
                lbl_tinhtien.Text = "0 VNĐ"
                txt_soluong.Focus()
                Exit Sub
            End If
            lbl_tinhtien.Text = String.Format("{0:0,0 VNĐ}", Int(txt_soluong.Text) * Int(tb.Rows(0).Item(0).ToString))
        Catch
            lbl_error.Text = "Bạn đã nhập sai số lượng mua, xin hãy nhập lại !"
            lbl_tinhtien.Text = "0 VNĐ"
            txt_soluong.Text = ""
            txt_soluong.Focus()
            Exit Sub
        End Try
    End Sub

    Protected Sub btn_ghiHD_Click(sender As Object, e As EventArgs) Handles btn_ghiHD.Click
        Try
            If txt_tenSP.Text = "" Then
                lbl_error.Text = "Bạn chưa nhập tên sản phẩm !"
                Exit Sub
            ElseIf txt_soluong.Text = "" Then
                lbl_error.Text = "Bạn chưa nhập số lượng sản phẩm !"
                Exit Sub
            ElseIf lbl_tinhtien.Text = "0 VNĐ" Then
                lbl_error.Text = "Bạn chưa tính tiền sản phẩm!"
                Exit Sub
            ElseIf txt_ngaynhap.Text = "" Then
                lbl_error.Text = "Bạn chưa nhập ngày viết hóa đơn !"
                Exit Sub
            ElseIf txt_tenkhachhang.Text = "" Then
                lbl_error.Text = "Bạn chưa nhập tên khách hàng !"
                Exit Sub
            ElseIf txt_tennguoinhap.Text = "" Then
                lbl_error.Text = "Bạn chưa nhập tên nhân viên !"
                Exit Sub
            End If
            '*********************
            Try
                ketnoi.Open()
                ketnoi.Close()
            Catch MySqlException As SqlException
                lbl_error.Text = "Không kết nối được với Cơ sở dữ liệu !"
                lbl_tinhtien.Text = "0 VNĐ"
                Exit Sub
            End Try
            '*********************
            Dim sql1 As New SqlDataAdapter("SELECT Don_gia, Ma_san_pham FROM SAN_PHAM WHERE Ten_san_pham='" & txt_tenSP.Text & "'", ketnoi)
            Dim tb1 As New DataTable
            ketnoi.Open()
            sql1.Fill(tb1)
            ketnoi.Close()
            Dim tien As Integer
            If tb1.Rows.Count < 1 Then
                lbl_error.Text = "Không có sản phẩm trên trong kho hàng, xin hãy nhập lại !"
                Exit Sub
            End If
            tien = Int(txt_soluong.Text) * Int(tb1.Rows(0).Item(0).ToString)
            '*********************
            Dim sql2 As New SqlDataAdapter("SELECT Ma_khach_hang FROM KHACH_HANG WHERE Ten_khach_hang='" & txt_tenkhachhang.Text & "'", ketnoi)
            Dim tb2 As New DataTable
            ketnoi.Open()
            sql2.Fill(tb2)
            ketnoi.Close()
            If tb2.Rows.Count < 1 Then
                lbl_error.Text = "Không có khách hàng này trong danh sách, xin hãy nhập lại !"
                Exit Sub
            End If
            '*********************
            Dim sql3 As New SqlDataAdapter("SELECT Ma_nguoi_dung FROM NGUOI_DUNG WHERE Ten_dang_nhap='" & txt_tennguoinhap.Text & "'", ketnoi)
            Dim tb3 As New DataTable
            ketnoi.Open()
            sql3.Fill(tb3)
            ketnoi.Close()
            If tb3.Rows.Count < 1 Then
                lbl_error.Text = "Không có nhân viên này trong danh sách, xin hãy nhập lại !"
                Exit Sub
            End If
            '*********************
            Try
                Dim sql_hoadon As New SqlDataAdapter("INSERT INTO HOA_DON VALUES (" & tien & ",'" & Convert.ToDateTime(txt_ngaynhap.Text) & "', " & Convert.ToInt32(tb2.Rows(0).Item(0).ToString) & ", " & Convert.ToInt32(tb3.Rows(0).Item(0).ToString) & ")", ketnoi)
                Dim tb_hoadon As New DataTable
                ketnoi.Open()
                sql_hoadon.Fill(tb_hoadon)
                ketnoi.Close()
            Catch
                lbl_error.Text = "Định dạng ngày sai, hãy nhập lại !"
                txt_ngaynhap.Focus()
                Exit Sub
            End Try

            '*********************
            Dim sql4 As New SqlDataAdapter("SELECT Ma_hoa_don FROM HOA_DON", ketnoi)
            Dim tb4 As New DataTable
            ketnoi.Open()
            sql4.Fill(tb4)
            ketnoi.Close()
            '*********************
            Dim sql_chitiet As New SqlDataAdapter("INSERT INTO CHI_TIET_HOA_DON VALUES (" & Convert.ToInt32(txt_soluong.Text) & ", " & Convert.ToInt32(tb1.Rows(0).Item(1).ToString) & ", " & Convert.ToInt32(tb4.Rows((tb4.Rows.Count) - 1).Item(0).ToString) & ")", ketnoi)
            Dim tb_chitiet As New DataTable
            ketnoi.Open()
            sql_chitiet.Fill(tb_chitiet)
            ketnoi.Close()
            lbl_error.Text = "Ghi hóa đơn thành công !"
            xoa()
        Catch
            lbl_error.Text = "Ghi thất bại, hãy làm lại !"
            txt_ngaynhap.Focus()
            Exit Sub
        End Try
    End Sub
    Sub xoa()
        txt_tenSP.Text = ""
        txt_soluong.Text = ""
        lbl_tinhtien.Text = "0 VNĐ"
        txt_ngaynhap.Text = ""
        txt_tenkhachhang.Text = ""
        txt_tennguoinhap.Text = ""
    End Sub
    Protected Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click

    End Sub
End Class
