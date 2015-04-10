Imports System.Data.SqlClient
Imports System.Data
Imports System.Web
Imports System.Configuration

Partial Class HeThong_Dang_ky
    Inherits System.Web.UI.Page
    Public chuoiketnoi As String = "workstation id=vocanh1994.mssql.somee.com;packet size=4096;user id=canhvv;pwd=Vocanh02012004;data source=vocanh1994.mssql.somee.com;persist security info=False;initial catalog=vocanh1994"
    Public ketnoi As New SqlConnection(chuoiketnoi)

    Dim x As Integer
    Dim y As Integer

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_cauhoi.Text = ""
        Randomize()
        x = Int(Rnd() * 100)
        y = Int(Rnd() * 100)
        lbl_cauhoi.Text = "" & x & " + " & y & " ="
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_user.Text = "" Then
            lbl_error.Text = "Bạn chưa nhập tên tài khoản"
            txt_user.Focus()
            Exit Sub
        ElseIf txt_pass1.Text = "" Then
            lbl_error.Text = "Bạn chưa nhập mật khẩu"
            txt_pass1.Focus()
            Exit Sub
        ElseIf txt_pass2.Text = "" Then
            lbl_error.Text = "Bạn chưa nhập lại mật khẩu"
            txt_pass1.Focus()
            Exit Sub
        ElseIf txt_name.Text = "" Then
            lbl_error.Text = "Bạn phải nhập tên của bạn vào"
            txt_name.Focus()
            Exit Sub
        ElseIf txt_ma.Text = "" Then
            lbl_error.Text = "Bạn chưa nhập câu trả lời"
            txt_ma.Focus()
            Exit Sub
        End If
        '*****************
        If txt_pass1.Text <> txt_pass2.Text Then
            lbl_error.Text = "2 mật khẩu không trùng khớp"
            txt_pass1.Focus()
            Exit Sub
            lbl_error.Text = "Câu trả lời của bạn sai rồi"
            txt_ma.Text = ""
            txt_ma.Focus()
            Exit Sub
        End If
        '*********************
        Try
            ketnoi.Open()
            ketnoi.Close()
        Catch MySqlException As SqlException
            lbl_error.Text = "Không kết nối được với Cơ sở dữ liệu !"
            Exit Sub
        End Try
        '*********************
        Try
            Dim sql1 As New SqlDataAdapter("SELECT * FROM NGUOI_DUNG WHERE Ten_dang_nhap='" & txt_user.Text & "'", ketnoi)
            Dim tb1 As New DataTable
            ketnoi.Open()
            sql1.Fill(tb1)
            ketnoi.Close()
            If tb1.Rows.Count() > 0 Then
                lbl_error.Text = "Tài khoản đã tồn tại, xin hãy đăng ký lại"
                txt_user.Focus()
                Exit Sub
            End If
            Dim sql As New SqlDataAdapter("INSERT INTO NGUOI_DUNG VALUES ('" & txt_user.Text & "','" & txt_pass1.Text & "','" & txt_name.Text & "')", ketnoi)
            Dim tb As New DataTable
            ketnoi.Open()
            sql.Fill(tb)
            ketnoi.Close()
            '*********************
        Catch
            lbl_error.Text = "Đăng ký tài khoản thất bại, hãy thử lại"
        End Try
        lbl_error.Text = "Đăng ký tài khoản thành công"
        txt_user.Text = ""
        txt_pass1.Text = ""
        txt_pass2.Text = ""
        txt_name.Text = ""
        txt_ma.Text = ""
        txt_user.Focus()
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Nguoi_dung.aspx")
    End Sub
End Class
