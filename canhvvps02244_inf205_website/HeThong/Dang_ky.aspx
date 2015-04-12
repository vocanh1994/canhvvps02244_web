<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Dang_ky.aspx.vb" Inherits="HeThong_Dang_ky" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng ký | Quản lý bán hàng</title>
    <link rel="icon" href="../img/128px/Finder.ico" type="image/x-icon" />
    <link href="../CSS/DangKy.css" rel="stylesheet" />
	<link href="../CSS/font.css" rel="stylesheet" />
</head>
<body>
    <form id="Dang_ky" runat="server">
    <div class ="full">
        <asp:Button CssClass ="dangky myButton2 " ID="Button2" runat="server" Text="Danh sách tài khoản" />
        <br/>
        <div class ="title">
            <a>Đăng ký tài khoản người dùng</a>
        </div> 
        <table border ="0" >
            <tr>
                <td class="lbltieude">
                    <a>Tên đăng nhập : </a> 
                </td>
                <td>
                    <asp:TextBox CssClass ="inputs " ID="txt_user" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="lbltieude">
                    <a>Mật khẩu : </a> 
                </td>
                <td>
                    <asp:TextBox CssClass ="inputs " ID="txt_pass1" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="lbltieude">
                    <a>Nhập lại mật khẩu : </a> 
                </td>
                <td>
                    <asp:TextBox CssClass ="inputs " ID="txt_pass2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="lbltieude">
                    <a>Tên của bạn : </a> 
                </td>
                <td>
                    <asp:TextBox CssClass ="inputs " ID="txt_name" runat="server"></asp:TextBox>
                </td>
            </tr
            <tr>
                <td class="lbltieude">
                    <a>Nhập câu trả lời : </a> 
                    <asp:Label ID="lbl_cauhoi" runat="server" Text="Câu hỏi"></asp:Label>
                </td>
                <td>
                    <asp:TextBox CssClass ="inputs " ID="txt_ma" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan ="2">
                    <asp:Label ID="lbl_error" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="buttom" colspan ="2">
                    <asp:Button CssClass ="myButton " ID="Button1" runat="server" Text="Đăng ký" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html><noembed/>
