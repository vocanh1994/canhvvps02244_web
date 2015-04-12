<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Huong_dan.aspx.vb" Inherits="order_Huong_dan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hướng dẫn | Quản lý bán hàng</title>
    <link rel="icon" href="../img/128px/Finder.ico" type="image/x-icon" />
    <link href="../CSS/Style.css" rel="stylesheet" />
	<link href="../CSS/font.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class ="full">
        <embed src="../Document/Huong_dan.pdf" width=100% height=500px>
        <asp:Button CssClass ="myButton huongdan" ID="Button1" runat="server" Text="Về trang chủ" />
    </div>
    </form>
</body>
</html><noembed/>
