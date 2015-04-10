Imports System.Data.SqlClient
Imports System.Data
Imports System.Web
Imports System.Configuration

Partial Class HeThong_Nguoi_dung
    Inherits System.Web.UI.Page
    Public chuoiketnoi As String = "workstation id=vocanh1994.mssql.somee.com;packet size=4096;user id=canhvv;pwd=Vocanh02012004;data source=vocanh1994.mssql.somee.com;persist security info=False;initial catalog=vocanh1994"
    Public ketnoi As New SqlConnection(chuoiketnoi)
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        '*********************
        Try
            ketnoi.Open()
            ketnoi.Close()
        Catch MySqlException As SqlException
            lbl_error.Text = "Không kết nối được với Cơ sở dữ liệu !"
            txt_nhap.Focus()
            Exit Sub
        End Try
        '*********************
        Try
            Dim sql As New SqlDataAdapter("select * from NGUOI_DUNG", ketnoi)
            Dim tb As New DataTable
            ketnoi.Open()
            sql.Fill(tb)
            ketnoi.Close()
            layhetdulieu()
        Catch
            lbl_error.Text = "Không thể lấy dữ liệu được !"
        End Try
    End Sub

    Protected Sub btn_timkiem_Click(sender As Object, e As EventArgs) Handles btn_timkiem.Click
        btn_refesh.Visible = True
        '*********************
        Try
            ketnoi.Open()
            ketnoi.Close()
        Catch MySqlException As SqlException
            lbl_error.Text = "Không kết nối được với Cơ sở dữ liệu !"
            txt_nhap.Focus()
            Exit Sub
        End Try
        '*********************
        If txt_nhap.Text = "" Then
            lbl_error.Text = "Chưa nhập từ khóa !"
            Exit Sub
        End If
        Try
            Dim sql As New SqlDataAdapter("select * from NGUOI_DUNG where Ten_dang_nhap='" & txt_nhap.Text & "'", ketnoi)
            Dim tb As New DataTable
            ketnoi.Open()
            sql.Fill(tb)
            ketnoi.Close()
            grv_hienthi.DataSource = tb
            If tb.Rows.Count < 1 Then
                lbl_error.Text = "Không có dữ liệu !"
                SqlDataSource1.ConnectionString = chuoiketnoi
                SqlDataSource1.SelectCommand = "SELECT Ma_nguoi_dung as 'ID', Ten_dang_nhap as 'Tên đăng nhập', Ten_nguoi_dung as 'Tên người dùng' FROM NGUOI_DUNG WHERE Ten_dang_nhap = '" & txt_nhap.Text & "'"
                Exit Sub
            End If
            lbl_error.Text = "Tìm kiếm thành công !"
            SqlDataSource1.ConnectionString = chuoiketnoi
            SqlDataSource1.SelectCommand = "SELECT Ma_nguoi_dung as 'ID', Ten_dang_nhap as 'Tên đăng nhập', Ten_nguoi_dung as 'Tên người dùng' FROM NGUOI_DUNG WHERE Ten_dang_nhap = '" & txt_nhap.Text & "'"
        Catch
            lbl_error.Text = "Không thể lấy dữ liệu được !"
        End Try
    End Sub

    Sub layhetdulieu()
        '*********************
        Try
            ketnoi.Open()
            ketnoi.Close()
        Catch MySqlException As SqlException
            lbl_error.Text = "Không kết nối được với Cơ sở dữ liệu !"
            txt_nhap.Focus()
            Exit Sub
        End Try
        '*********************
        SqlDataSource1.ConnectionString = chuoiketnoi
        SqlDataSource1.SelectCommand = "SELECT Ma_nguoi_dung as 'ID', Ten_dang_nhap as 'Tên đăng nhập', Ten_nguoi_dung as 'Tên người dùng' FROM NGUOI_DUNG"
    End Sub

    Protected Sub btn_refesh_Click(sender As Object, e As EventArgs) Handles btn_refesh.Click
        btn_refesh.Visible = False
        lbl_error.Text = ""
        Response.Redirect("Nguoi_dung.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("../order/Home.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Dang_ky.aspx")
    End Sub
End Class
