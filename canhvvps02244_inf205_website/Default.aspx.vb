Imports System.Data.SqlClient
Imports System.Data
Imports System.Web
Imports System.Configuration

Partial Class _Default
    Inherits System.Web.UI.Page

    Public ketnoi As New SqlConnection("workstation id=vocanh1994.mssql.somee.com;packet size=4096;user id=canhvv;pwd=Vocanh02012004;data source=vocanh1994.mssql.somee.com;persist security info=False;initial catalog=vocanh1994")

    Protected Sub btn_dangnhap_Click(sender As Object, e As EventArgs) Handles btn_dangnhap.Click
        '*********************
        Try
            ketnoi.Open()
            ketnoi.Close()
        Catch MySqlException As SqlException
            lbl_error.Text = "Không kết nối được với Cơ sở dữ liệu !"
            txt_nhap_user.Focus()
            Exit Sub
        End Try
        '*********************
        Dim nguoidung As String
        Dim matkhau As String
        nguoidung = txt_nhap_user.Text
        matkhau = txt_nhap_pass.Text
        If nguoidung = "" And matkhau = "" Then
            lbl_error.Text = "Bạn chưa nhập dữ liệu và ô"
            txt_nhap_user.Focus()
        ElseIf nguoidung = "" And matkhau <> "" Then
            lbl_error.Text = "Chưa nhập tài khoản người dùng"
            txt_nhap_user.Focus()
        ElseIf nguoidung <> "" And matkhau = "" Then
            lbl_error.Text = "Chưa nhập mật khẩu"
            txt_nhap_pass.Focus()
        Else
            ket_noi_database()
        End If
    End Sub

    Public myVariable As String = ConfigurationSettings.AppSettings("Variable")
    Public id_nguoidung As Integer

    Sub ket_noi_database()

        Dim sql As New SqlDataAdapter("select * from NGUOI_DUNG where Ten_dang_nhap='" & txt_nhap_user.Text & "' and Mat_khau='" & txt_nhap_pass.Text & "'", ketnoi)
        Dim tb As New DataTable
        ketnoi.Open()
        sql.Fill(tb)
        ketnoi.Close()
        If tb.Rows.Count > 0 Then
            Response.Redirect("order/Home.aspx")
            id_nguoidung = Convert.ToInt32(tb.Rows(0).Item(0).ToString)
        Else
            lbl_error.Text = "Truy cập bị từ chối, xin hãy kiểm tra lại tài khoản :("
            txt_nhap_user.Text = ""
            txt_nhap_pass.Text = ""
            txt_nhap_user.Focus()
        End If
    End Sub

    Private Function messagebox() As Object
        Throw New NotImplementedException
    End Function

End Class
