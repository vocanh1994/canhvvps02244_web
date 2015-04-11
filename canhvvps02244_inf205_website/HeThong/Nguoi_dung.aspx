<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Nguoi_dung.aspx.vb" Inherits="HeThong_Nguoi_dung" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Người dùng | Quản lý bán hàng</title>
    <link rel="icon" href="../img/128px/Finder.ico" type="image/x-icon" />
    <link href="../CSS/NguoiDung.css" rel="stylesheet" />
</head>
<body>
    <form id="Nguoi_dung" runat="server">
    <div class="full">
        <asp:Button CssClass ="home myButton2 " ID="Button1" runat="server" Text="Home" />
        <asp:Button CssClass ="dangky myButton2 " ID="Button2" runat="server" Text="Đăng ký" />
        <div class="text">
            <a>Danh sách tài khoản người dùng</a>
        </div>
        <table border="0px">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Tên tài khoản :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_nhap" CssClass="inputs" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btn_timkiem" CssClass="myButton" runat="server" Text="Tìm kiếm" />
                </td>
            </tr>
            <tr style ="margin :auto ; height:auto ;">
                <td colspan ="3">
                    <asp:Label ID="lbl_error" runat="server" Text=""></asp:Label>
                    <asp:Button ID="btn_refesh" runat="server" Text="Refesh..." Visible ="false" />
                </td>
            </tr>
            <tr style ="margin :auto ;">
                <td colspan ="3">
                    <asp:GridView ID="grv_hienthi" runat="server"></asp:GridView>
                    <asp:GridView ID="GridView1" DataSourceID="SqlDataSource1" runat="server" Width ="100%" />
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
