Imports System.Data.SqlClient
Imports System.Data
Imports System.Web
Imports System.Configuration

Partial Class ChucNang_Loai_san_pham
    Inherits System.Web.UI.Page
    Public chuoiketnoi As String = "workstation id=vocanh1994.mssql.somee.com;packet size=4096;user id=canhvv;pwd=Vocanh02012004;data source=vocanh1994.mssql.somee.com;persist security info=False;initial catalog=vocanh1994"
    Public ketnoi As New SqlConnection(chuoiketnoi)

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        SqlDataSource1.ConnectionString = chuoiketnoi
        SqlDataSource1.SelectCommand = "SELECT * FROM LOAI_SAN_PHAM"
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("../order/Home.aspx")
    End Sub
End Class
