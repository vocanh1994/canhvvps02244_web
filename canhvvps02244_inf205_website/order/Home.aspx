<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Home.aspx.vb" Inherits="order_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home | Quản lý bán hàng</title>
    <link rel="icon" href="../img/128px/Finder.ico" type="image/x-icon" />
    <link href="../CSS/Home.css" rel="stylesheet" />
</head>
<body>
    <form id="Home" runat="server">

    <div class="GioiThieu">
        <div class="small text"><a>Hệ thống</a></div>
        <div class="large text"><a>QUẢN LÝ BÁN HÀNG</a></div>
        <div class="line text"><a>&copy 2015 vocanh . Inc</a></div>
    </div>

    <div class ="DanhMuc">
            <div class="muc">
                <a href="../ChucNang/Ghi_hoa_don.aspx">
                    <img class="icon" src ="../img/128px/clipboard.png"/>
                    <a class="title_icon">Ghi hóa đơn</a>
                </a>
            </div>
            <div class="muc">
                <a href="../ChucNang/Xem_hoa_don.aspx">
                    <img class="icon" src ="../img/128px/magnifyingglass.png"/>
                    <a class="title_icon">Xem hóa đơn</a>
                </a>
            </div>
            <div class="muc">
                <a href="../ChucNang/Khach_hang.aspx">
                    <img class="icon" src ="../img/128px/contacts.png"/>
                    <a class="title_icon">Khách hàng</a>
                </a>
            </div>
            <div class="muc">
                <a href="../ChucNang/San_pham.aspx">
                    <img class="icon" src ="../img/128px/present.png"/>
                    <a class="title_icon">Sản phẩm</a>
                </a>
            </div>
            <div class="muc">
                <a href="../ChucNang/Loai_san_pham.aspx">
                    <img class="icon" src ="../img/128px/colorwheel.png"/>
                    <a class="title_icon">Loại sản phẩm</a>
                </a>
            </div>
            <div class="muc">
                <a href="../HeThong/Nguoi_dung.aspx">
                    <img class="icon" src ="../img/128px/profle.png"/>
                    <a class="title_icon">Người dùng</a>
                </a>
            </div>
            <div class="muc">
                <a href="Huong_dan.aspx">
                    <img class="icon" src ="../img/128px/booklet.png"/>
                    <a class="title_icon">Hướng dẫn</a>
                </a>
            </div>
            <div class="muc">
                <a href="Thong_tin.aspx">
                    <img class="icon" src ="../img/128px/star.png"/>
                    <a class="title_icon">Thông tin</a>
                </a>
            </div>
                <div class="muc">
                <a href="../Default.aspx">
                    <img class="icon" src ="../img/128px/denied.png"/>
                    <a class="title_icon">Đăng xuất</a>
                </a>
            </div>
    </div>
    
    <div class ="Info">
        <a>&copy 04/2015 by Võ Văn Cảnh | </a><a style ="color :#ffffff" href ="https://vocanh1994.wordpress.com/">https://vocanh1994.wordpress.com/</a><a> | Hệ thống quản lý bán hàng cho công ty | vocanh . Inc Vesion 1.0.1</a>
    </div>

    </form>
</body>
</html>
