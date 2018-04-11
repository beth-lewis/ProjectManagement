<%@ Page Language="C#" AutoEventWireup="true" CodeFile="A Contract.aspx.cs" Inherits="A_Contract" %>

<!DOCTYPE html>
<html>
<head>
    <title>Phone Pal - Contracts</title>
    <link rel="stylesheet" type="text/css" href="../StyleSheet.css" /><!--link to stlesheet-->
    <style type="text/css">
        .auto-style1 {
            height: 393px;
            text-align: center;
        }
        .auto-style2 {
            position: absolute;
            top: 685px;
            left: 625px;
            z-index: 1;
            width: 105px;
        }
        .auto-style3 {
            position: absolute;
            top: 680px;
            left: 770px;
            z-index: 1;
            width: 105px;
            height: 26px;
            margin-top: 0px;
        }
        .auto-style4 {
            position: absolute;
            top: 261px;
            left: 380px;
            z-index: 1;
            width: 160px;
            bottom: 387px;
            margin-top: 9px;
        }
        .auto-style13 {
            position: absolute;
            top: 240px;
            left: 405px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 305px;
            left: 380px;
            z-index: 1;
            height: 24px;
        }
        .auto-style17 {
            position: absolute;
            top: 450px;
            left: 370px;
            z-index: 1;
        }
        .auto-style18 {
            position: absolute;
            top: 535px;
            left: 360px;
            z-index: 1;
        }
        .auto-style19 {
            position: absolute;
            top: 610px;
            left: 365px;
            z-index: 1;
        }
        .auto-style20 {
            position: absolute;
            top: 385px;
            left: 375px;
            z-index: 1;
        }
        .auto-style25 {
            z-index: 1;
            left: 585px;
            top: 60px;
            position: absolute;
        }
        .auto-style26 {
            position: absolute;
            top: 255px;
            left: 855px;
            z-index: 1;
        }
        .auto-style27 {
            position: absolute;
            top: 230px;
            left: 885px;
            z-index: 1;
            width: 80px;
        }
        .auto-style28 {
            position: absolute;
            top: 335px;
            left: 855px;
            z-index: 1;
        }
        .auto-style29 {
            position: absolute;
            top: 420px;
            left: 855px;
            z-index: 1;
        }
        .auto-style30 {
            position: absolute;
            top: 300px;
            left: 855px;
            z-index: 1;
            width: 145px;
            right: 485px;
        }
        .auto-style31 {
            position: absolute;
            top: 385px;
            left: 865px;
            z-index: 1;
        }
        .auto-style32 {
            position: absolute;
            top: 340px;
            left: 360px;
            z-index: 1;
        }
        .auto-style33 {
            position: absolute;
            top: 420px;
            left: 345px;
            z-index: 1;
        }
        .auto-style34 {
            position: absolute;
            top: 495px;
            left: 350px;
            z-index: 1;
        }
        .auto-style35 {
            position: absolute;
            top: 570px;
            left: 360px;
            z-index: 1;
        }
        .auto-style36 {
            position: absolute;
            top: 640px;
            left: 360px;
            z-index: 1;
        }
        </style>
</head>

<body>
    <form id="form1" runat="server">
    <div id="container">
        <div id="header">
            <table style="width:360px">
                <tr>
                         <td><img src="../molumen_phone_icon.png" height="50" width="50" /></td>
                    <td><h1>Phone Pal</h1></td>
                </tr>
            </table>
        </div>
        <div id="content">
            <div id="nav">
                <table style="width:860px">
                    <tr>
                        <td><a href="Home.html"><ins>Home</ins></a></td>
                        <td><a href="Manufacturer.html"><ins>Manufacturers</ins></a></td>
                        <td><a href="Accessories.html"><ins>Accessories</ins></a></td>
                        <td><a href="Contract.html"><ins>Contracts</ins></a></td>
                        <td><a href="Customer.html"><ins>Customer</ins></a></td>
                        <td><a href="Staff.html"><ins>Staff</ins></a></td>
                    </tr>
                </table>

            </div>
            <div id="main">
                <center>


                        <h2>A Contract</h2>



                </center>


                    <p class="auto-style1">
                      


                        <asp:Button ID="btnSave" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="auto-style2" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnGoBack" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="auto-style3" Text="Go Back" OnClick="btnGoBack_Click" />
                        <asp:TextBox ID="txtPricePerMonth" runat="server" CssClass="auto-style4" Font-Bold="False" TextMode="Number"></asp:TextBox>
                <br />

                        <asp:Label ID="lblPricePerMonth" runat="server" CssClass="auto-style13" Font-Bold="True" Text="Price Per Month"></asp:Label>
                        <asp:Label ID="lblDataAllowance" runat="server" CssClass="auto-style17" Font-Bold="True" Text="Data Allowance"></asp:Label>
                        <asp:Label ID="lblDuration" runat="server" CssClass="auto-style20" Font-Bold="True" Text="Duration"></asp:Label>
                        <asp:Label ID="lblNumberOfMinutes" runat="server" CssClass="auto-style18" Font-Bold="True" Text="Number Of Minutes"></asp:Label>
                        <asp:Label ID="lblNumberOfTexts" runat="server" CssClass="auto-style19" Font-Bold="True" Text="Number Of Texts"></asp:Label>
                        <asp:Label ID="lblContractType" runat="server" CssClass="auto-style16" Font-Bold="True" Text="Contract Type"></asp:Label>

                        <asp:Label ID="lblError" runat="server" CssClass="auto-style25"></asp:Label>

                        <asp:Label ID="lblStaffNo" runat="server" CssClass="auto-style27" Text="Staff No" Font-Bold="True"></asp:Label>

                        <asp:TextBox ID="txtManufacturerNo" runat="server" CssClass="auto-style28"></asp:TextBox>
                        <asp:TextBox ID="txtCustomerNo" runat="server" CssClass="auto-style29"></asp:TextBox>
                        <asp:Label ID="lblCustomerNo" runat="server" CssClass="auto-style31" Text="CustomerNo" Font-Bold="True"></asp:Label>
                        <asp:Label ID="lblManufacturerNo" runat="server" CssClass="auto-style30" Text="Manufacturer No" Font-Bold="True"></asp:Label>

                        <asp:TextBox ID="txtStaffNo" runat="server" CssClass="auto-style26"></asp:TextBox>
                        <asp:TextBox ID="txtContractType" runat="server" CssClass="auto-style32"></asp:TextBox>
                        <asp:TextBox ID="txtDuration" runat="server" CssClass="auto-style33"></asp:TextBox>
                        <asp:TextBox ID="txtDataAllowance" runat="server" CssClass="auto-style34"></asp:TextBox>
                        <asp:TextBox ID="txtNumberOfMins" runat="server" CssClass="auto-style35"></asp:TextBox>
                        <p class="auto-style1">
                      


                            <asp:TextBox ID="txtNumberOfTexts" runat="server" CssClass="auto-style36"></asp:TextBox>
            </div>

            <div id="footer">
                <h5> &copy; Phone Pal</h5>
            </div>
        </div>
    </div>

    </form>

</body>
</html>

