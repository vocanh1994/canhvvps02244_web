<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Xem_hoa_don.aspx.vb" Inherits="ChucNang_Xem_hoa_don" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Xem hóa đơn | Quản lý bán hàng</title>
    <link rel="icon" href="../img/128px/Finder.ico" type="image/x-icon" />
    <link href="../CSS/Style.css" rel="stylesheet" />
    <link href="../CSS/Style_show.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class ="full Show">
        <div class ="home">
            <asp:Button CssClass ="myButton" ID="Button1" runat="server" Text="Trang chủ" />
        </div>
        <div class ="ghiHD">
            <asp:Button CssClass ="myButton" ID="Button2" runat="server" Text="Ghi hóa đơn" />
        </div> 
        <div class =" title">Danh sách hóa đơn được ghi nhận</div>
        <div class ="hienthi">
            <asp:GridView ID="GridView1" runat="server" DataSourceID ="SqlDataSource1"></asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        </div>
    </div>
    </form>
</body>
</html>
