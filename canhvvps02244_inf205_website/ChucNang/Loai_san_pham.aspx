<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Loai_san_pham.aspx.vb" Inherits="ChucNang_Loai_san_pham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Loại sản phẩm | Quản lý bán hàng</title>
    <link rel="icon" href="../img/128px/Finder.ico" type="image/x-icon" />
    <link href="../CSS/Style.css" rel="stylesheet" />
    <link href="../CSS/Style_show.css" rel="stylesheet" />
	<link href="../CSS/font.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class ="full Show">
        <div class ="home">
            <asp:Button CssClass ="myButton" ID="Button1" runat="server" Text="Trang chủ" />
        </div>
        <div class =" title">Danh sách các loại sản phẩm</div>
        <div class ="hienthi">
            <asp:GridView CssClass ="GridView1" ID="GridView1" runat="server" DataSourceID ="SqlDataSource1"></asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        </div>
    </div>
    </form>
</body>
</html><noembed/>
