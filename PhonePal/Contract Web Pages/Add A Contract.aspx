<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add A Contract.aspx.cs" Inherits="Add_A_Contract" %>

<!DOCTYPE html>
<html>
<head>
    <title>Phone Pal - Contracts</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" /><!--link to stlesheet-->
    <style type="text/css">
        .auto-style1 {
            height: 393px;
            text-align: center;
        }
        .auto-style2 {
            position: absolute;
            top: 590px;
            left: 625px;
            z-index: 1;
            width: 105px;
        }
        .auto-style3 {
            position: absolute;
            top: 590px;
            left: 775px;
            z-index: 1;
            width: 105px;
            height: 26px;
            margin-top: 0px;
        }
        .auto-style4 {
            position: absolute;
            top: 241px;
            left: 670px;
            z-index: 1;
            width: 160px;
            bottom: 407px;
            margin-top: 9px;
        }
        .auto-style7 {
            position: absolute;
            top: 295px;
            left: 670px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 328px;
            left: 670px;
            z-index: 1;
            margin-top: 2px;
        }
        .auto-style13 {
            position: absolute;
            top: 250px;
            left: 560px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 295px;
            left: 575px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 330px;
            left: 530px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 370px;
            left: 545px;
            z-index: 1;
        }
        .auto-style17 {
            position: absolute;
            top: 455px;
            left: 530px;
            z-index: 1;
        }
        .auto-style18 {
            position: absolute;
            top: 495px;
            left: 520px;
            z-index: 1;
        }
        .auto-style19 {
            position: absolute;
            top: 530px;
            left: 525px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 370px;
            left: 675px;
            z-index: 1;
        }
        .auto-style20 {
            position: absolute;
            top: 410px;
            left: 550px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 410px;
            left: 675px;
            z-index: 1;
            width: 112px;
            height: 19px;
        }
        .auto-style12 {
            position: absolute;
            top: 455px;
            left: 675px;
            z-index: 1;
            width: 102px;
            height: 21px;
        }
        .auto-style21 {
            position: absolute;
            top: 495px;
            left: 685px;
            z-index: 1;
        }
        .auto-style22 {
            position: absolute;
            top: 535px;
            left: 680px;
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


                        <h2>Add A Contract</h2>



                </center>


                    <p class="auto-style1">
                      


                        <asp:Button ID="btnSave" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="auto-style2" Text="Save" />
                        <asp:Button ID="btnGoBack" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="auto-style3" Text="Go Back" OnClick="btnGoBack_Click" />
                        <asp:TextBox ID="txtCustomerNo" runat="server" CssClass="auto-style4" Font-Bold="True"></asp:TextBox>
                        <asp:TextBox ID="txtStaffNo" runat="server" CssClass="auto-style7" Font-Bold="True" Width="160px"></asp:TextBox>
                        <asp:TextBox ID="txtManufacturerNo" runat="server" CssClass="auto-style8" Font-Bold="True" Width="160px" Wrap="False"></asp:TextBox>
                        <asp:DropDownList ID="ddlContractType" runat="server" AutoPostBack="True" CssClass="auto-style9">
                            <asp:ListItem Value="1">Monthly</asp:ListItem>
                            <asp:ListItem>Pay As You Go</asp:ListItem>
                            <asp:ListItem>Sim Free</asp:ListItem>
                            <asp:ListItem>Sim Only</asp:ListItem>
                        </asp:DropDownList>
                <br />

                        <asp:Label ID="lblCustomerNo" runat="server" CssClass="auto-style13" Font-Bold="True" Text="Customer No"></asp:Label>
                        <asp:Label ID="lblStaffNo" runat="server" CssClass="auto-style14" Font-Bold="True" Text="Staff No"></asp:Label>
                        <asp:Label ID="lblManufacturerNo" runat="server" CssClass="auto-style15" Font-Bold="True" Text="Manufacturer No"></asp:Label>
                        <asp:Label ID="lblDataAllowance" runat="server" CssClass="auto-style17" Font-Bold="True" Text="Data Allowance"></asp:Label>
                        <asp:Label ID="lblDuration" runat="server" CssClass="auto-style20" Font-Bold="True" Text="Duration"></asp:Label>
                        <asp:Label ID="lblNumberOfMinutes" runat="server" CssClass="auto-style18" Font-Bold="True" Text="Number Of Minutes"></asp:Label>
                        <asp:Label ID="lblNumberOfTexts" runat="server" CssClass="auto-style19" Font-Bold="True" Text="Number Of Texts"></asp:Label>
                        <asp:Label ID="lblContractType" runat="server" CssClass="auto-style16" Font-Bold="True" Text="Contract Type"></asp:Label>
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
                        <asp:DropDownList ID="ddlNumberOfTexts" runat="server" CssClass="auto-style22">
                            <asp:ListItem>1000 Texts</asp:ListItem>
                            <asp:ListItem>2000 Texts</asp:ListItem>
                            <asp:ListItem>3000 Texts</asp:ListItem>
                            <asp:ListItem>4000 Texts</asp:ListItem>
                            <asp:ListItem>5000 Texts+</asp:ListItem>
                            <asp:ListItem>Unlimited</asp:ListItem>
                        </asp:DropDownList>

            </div>

            <div id="footer">
                <h5> &copy; Phone Pal</h5>
            </div>
        </div>
    </div>

    </form>

</body>
</html>

