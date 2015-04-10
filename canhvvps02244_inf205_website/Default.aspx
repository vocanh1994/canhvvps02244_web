<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quản lý bán hàng</title>
    <link href="CSS/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="Default" runat="server">
    <div class="tieu_de"><p>HỆ THỐNG QUẢN LÝ BÁN HÀNG</p></div>
    <div class="bg_login">
        <div class ="Form_login">
            <table border ="0" width="100%" height="250px">
                <TR>
                    <TD class="lbl_tieude"><asp:Label ID="Label1" runat="server" Text="Tên đăng nhập:"></asp:Label></TD>
                    <TD style="text-align:right"><asp:TextBox CssClass="inputs" ID="txt_nhap_user" runat="server"></asp:TextBox></TD>
                </TR>
                <TR>
                    <TD class="lbl_tieude"><asp:Label ID="Label2" runat="server" Text="Mật khẩu:"></asp:Label></TD>
                    <TD style="text-align:right"><asp:TextBox CssClass="inputs" ID="txt_nhap_pass" runat="server" TextMode="Password"></asp:TextBox></TD>
                </TR>
                <tr>
                    <td colspan="2"></td>
                </tr>
                <TR>
                    <TD colspan ="2" style="text-align: center"><asp:Button CssClass="myButton" ID="btn_dangnhap" runat="server" Text="Đăng nhập" /></TD>
                </TR>
            </table>
        </div>
        <p class="baoloi"><asp:Label ID="lbl_error" runat="server" Text=""></asp:Label></p>
    </div>
    <div class="info">
        <p>&copy 04/2015 by Võ Văn Cảnh | Hệ thống quản lý bán hàng cho công ty | vocanh . Inc Vesion 1.0.1</p>
    </div>
    </form>
</body>
</html>
