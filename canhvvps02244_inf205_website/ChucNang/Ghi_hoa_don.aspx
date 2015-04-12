<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Ghi_hoa_don.aspx.vb" Inherits="ChucNang_Ghi_hoa_don" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ghi hóa đơn | Quản lý bán hàng</title>
    <link rel="icon" href="../img/128px/Finder.ico" type="image/x-icon" />
    <link href="../CSS/Style.css" rel="stylesheet" />
    <link href="../CSS/GhiHD.css" rel="stylesheet" />
	<link href="../CSS/font.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class ="full ghihoadon " >
        <div class ="home">
            <asp:Button CssClass ="myButton2" ID="Button1" runat="server" Text="Trang chủ" />
        </div>
        <div class ="ghiHD">
            <asp:Button CssClass ="myButton2" ID="Button2" runat="server" Text="Xem danh sách" />
        </div>

        <div class ="title "><a>Ghi hóa đơn</a></div>
        <div class ="table_full">
            <table class ="table" border ="0" >
                <tr>
                    <td class ="tieude">
                        <a>Tên sản phẩm :</a>
                    </td>
                    <td class ="nhaplieu">
                        <asp:TextBox CssClass ="inputs " ID="txt_tenSP" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <!----------1--------->
                <tr>
                    <td class ="tieude">
                        <a>Số lượng mua :</a>
                    </td>
                    <td class ="nhaplieu">
                        <asp:TextBox CssClass ="inputs " ID="txt_soluong" runat="server"></asp:TextBox>
                        <asp:Button CssClass ="myButton1" ID="btn_tinhtien" runat="server" Text="Tính tiền" />
                    </td>
                </tr>
                <!----------2--------->
                <tr>
                    <td class ="tieude">
                        <a>Tổng tiền :</a>
                    </td>
                    <td class ="nhaplieu">
                        <asp:Label ID="lbl_tinhtien" runat="server" Text="0 VNĐ"></asp:Label>
                    </td>
                </tr>
                <!----------3--------->
                <tr>
                    <td class ="tieude">
                        <a>Ngày lập hóa đơn :</a>
                    </td>
                    <td class ="nhaplieu">
                        <asp:TextBox CssClass ="inputs " ID="txt_ngaynhap" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <!----------4--------->
                <tr>
                    <td class ="tieude">
                        <a>Tên khách hàng :</a>
                    </td>
                    <td class ="nhaplieu">
                        <asp:TextBox CssClass ="inputs " ID="txt_tenkhachhang" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <!----------5--------->
                <tr>
                    <td class ="tieude">
                        <a>Người nhập hóa đơn :</a>
                    </td>
                    <td class ="nhaplieu">
                        <asp:TextBox CssClass ="inputs " ID="txt_tennguoinhap" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <!----------6--------->
                <tr>
                    <td colspan="2">
                        <asp:Label CssClass ="loi" ID="lbl_error" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button CssClass ="myButton" ID="btn_ghiHD" runat="server" Text="Ghi hóa đơn" />
                    </td>
                    <td>
                        <asp:Button CssClass ="myButton" ID="btn_reset" runat="server" Text="Nhập lại" />
                    </td>
                </tr>
                
            </table>
        </div>
    </div>
    </form>
</body>
</html><noembed/>
