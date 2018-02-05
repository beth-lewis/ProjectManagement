<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Upgrade Contract.aspx.cs" Inherits="Upgrade_Contract" %>

<!DOCTYPE html>
<html>
<head>
    <title>Phone Pal - Contracts</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" /><!--link to stlesheet-->
    <style type="text/css">
        .auto-style1 {
            height: 509px;
        }
        .auto-style7 {
            position: absolute;
            top: 310px;
            left: 670px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 355px;
            left: 670px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 270px;
            left: 670px;
            z-index: 1;
            width: 160px;
            bottom: 467px;
            margin-top: 0px;
        }
        .auto-style3 {
            position: absolute;
            top: 600px;
            left: 770px;
            z-index: 1;
            width: 105px;
            height: 29px;
            margin-top: 0px;
        }
        .auto-style13 {
            position: absolute;
            top: 270px;
            left: 555px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 310px;
            z-index: 1;
            left: 585px;
        }
        .auto-style15 {
            position: absolute;
            top: 355px;
            left: 530px;
            z-index: 1;
            height: 20px;
        }
        .auto-style16 {
            position: absolute;
            top: 400px;
            left: 535px;
            z-index: 1;
        }
        .auto-style17 {
            position: absolute;
            top: 480px;
            left: 530px;
            z-index: 1;
        }
        .auto-style20 {
            position: absolute;
            top: 450px;
            left: 545px;
            z-index: 1;
        }
        .auto-style18 {
            position: absolute;
            top: 510px;
            left: 520px;
            z-index: 1;
        }
        .auto-style19 {
            position: absolute;
            top: 550px;
            left: 525px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 400px;
            left: 680px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 445px;
            left: 680px;
            z-index: 1;
            width: 112px;
            height: 19px;
        }
        .auto-style12 {
            position: absolute;
            top: 475px;
            left: 680px;
            z-index: 1;
            width: 102px;
            height: 21px;
        }
        .auto-style21 {
            position: absolute;
            top: 510px;
            left: 685px;
            z-index: 1;
        }
        .auto-style22 {
            position: absolute;
            top: 550px;
            left: 680px;
            z-index: 1;
        }
        </style>
    </head>

<body>
    <form id="form1" runat="server">
    <div id="container">
        <div id="header">
                      
                        <asp:Label ID="lblCustomerNo" runat="server" CssClass="auto-style13" Font-Bold="True" Text="Customer No"></asp:Label>
            <table style="width:360px">
                <tr>
     <td><img src="molumen_phone_icon.png" height="50" width="50" /></td>
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


                        <h2>Upgrade Contract</h2>


                    <p class="auto-style1">
                        <asp:TextBox ID="txtStaffNo" runat="server" CssClass="auto-style7" Font-Bold="True" Width="160px"></asp:TextBox>
                        <asp:TextBox ID="txtManufacturerNo" runat="server" CssClass="auto-style8" Font-Bold="True" Width="160px" Wrap="False"></asp:TextBox>
                        <asp:DropDownList ID="ddlContractType" runat="server" AutoPostBack="True" CssClass="auto-style9">
                            <asp:ListItem Value="1">Monthly</asp:ListItem>
                            <asp:ListItem>Pay As You Go</asp:ListItem>
                            <asp:ListItem>Sim Free</asp:ListItem>
                            <asp:ListItem>Sim Only</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlDuration" runat="server" CssClass="auto-style10">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>3 Months</asp:ListItem>
                            <asp:ListItem>6 Months</asp:ListItem>
                            <asp:ListItem>1 Year</asp:ListItem>
                            <asp:ListItem>2 Years</asp:ListItem>
                            <asp:ListItem>3 Years</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlDataAllowance" runat="server" CssClass="auto-style12" Height="25px">
                            <asp:ListItem>500MB</asp:ListItem>
                            <asp:ListItem>1GB</asp:ListItem>
                            <asp:ListItem>2GB</asp:ListItem>
                            <asp:ListItem>3GB</asp:ListItem>
                            <asp:ListItem>4GB</asp:ListItem>
                            <asp:ListItem>5GB+</asp:ListItem>
                            <asp:ListItem>Unlimited</asp:ListItem>
                        </asp:DropDownList>
                    

                        <asp:DropDownList ID="ddlNumberOfMins" runat="server" CssClass="auto-style21">
                            <asp:ListItem>100 Mins</asp:ListItem>
                            <asp:ListItem>200 Mins</asp:ListItem>
                            <asp:ListItem>300 Mins</asp:ListItem>
                            <asp:ListItem>400 Mins</asp:ListItem>
                            <asp:ListItem>500 Mins+</asp:ListItem>
                            <asp:ListItem>Unlimited</asp:ListItem>
                        </asp:DropDownList>
                        <asp:TextBox ID="txtCustomerNo" runat="server" CssClass="auto-style4" Font-Bold="True"></asp:TextBox>
                        <asp:Button ID="btnGoBack" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="auto-style3" Text="Go Back" Width="105px" OnClick="btnGoBack_Click" />
                        <asp:Label ID="lblStaffNo" runat="server" CssClass="auto-style14" Font-Bold="True" Text="Staff No"></asp:Label>
                        <asp:Label ID="lblManufacturerNo" runat="server" CssClass="auto-style15" Font-Bold="True" Text="Manufacturer No"></asp:Label>
                        <asp:Label ID="lblContractType" runat="server" CssClass="auto-style16" Font-Bold="True" Text="Contract Type"></asp:Label>
                        <asp:Label ID="lblDataAllowance" runat="server" CssClass="auto-style17" Font-Bold="True" Text="Data Allowance"></asp:Label>
                        <asp:Label ID="lblDuration" runat="server" CssClass="auto-style20" Font-Bold="True" Text="Duration"></asp:Label>
                        <asp:Label ID="lblNumberOfMinutes" runat="server" CssClass="auto-style18" Font-Bold="True" Text="Number Of Minutes"></asp:Label>
                        <asp:Label ID="lblNumberOfTexts" runat="server" CssClass="auto-style19" Font-Bold="True" Text="Number Of Texts"></asp:Label>
                        <asp:DropDownList ID="ddlNumberOfTexts" runat="server" CssClass="auto-style22">
                            <asp:ListItem>1000 Texts</asp:ListItem>
                            <asp:ListItem>2000 Texts</asp:ListItem>
                            <asp:ListItem>3000 Texts</asp:ListItem>
                            <asp:ListItem>4000 Texts</asp:ListItem>
                            <asp:ListItem>5000 Texts+</asp:ListItem>
                            <asp:ListItem>Unlimited</asp:ListItem>
                        </asp:DropDownList>
                        </p>


                </center>
                <br />

            </div>

            <div id="footer">
                <h5> &copy; Phone Pal</h5>
            </div>
        </div>
    </div>

    </form>

</body>
</html>

