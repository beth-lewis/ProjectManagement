<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add A Contract.aspx.cs" Inherits="Add_A_Contract" %>

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
            top: 311px;
            left: 375px;
            z-index: 1;
            width: 160px;
            bottom: 337px;
            margin-top: 9px;
        }
        .auto-style13 {
            position: absolute;
            top: 320px;
            left: 245px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 365px;
            left: 245px;
            z-index: 1;
        }
        .auto-style17 {
            position: absolute;
            top: 460px;
            left: 240px;
            z-index: 1;
        }
        .auto-style18 {
            position: absolute;
            top: 510px;
            left: 230px;
            z-index: 1;
        }
        .auto-style19 {
            position: absolute;
            top: 555px;
            left: 230px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 370px;
            left: 380px;
            z-index: 1;
        }
        .auto-style20 {
            position: absolute;
            top: 410px;
            left: 245px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 410px;
            left: 375px;
            z-index: 1;
            width: 112px;
            height: 19px;
        }
        .auto-style12 {
            position: absolute;
            top: 460px;
            left: 375px;
            z-index: 1;
            width: 102px;
            height: 21px;
        }
        .auto-style21 {
            position: absolute;
            top: 510px;
            left: 400px;
            z-index: 1;
        }
        .auto-style22 {
            position: absolute;
            top: 555px;
            left: 400px;
            z-index: 1;
        }
        .auto-style24 {
            z-index: 1;
            left: 255px;
            top: 280px;
            position: absolute;
        }
        .auto-style25 {
            z-index: 1;
            left: 585px;
            top: 60px;
            position: absolute;
        }
        .auto-style26 {
            position: absolute;
            top: 270px;
            left: 700px;
            z-index: 1;
        }
        .auto-style27 {
            position: absolute;
            top: 270px;
            left: 615px;
            z-index: 1;
        }
        .auto-style28 {
            position: absolute;
            top: 305px;
            left: 700px;
            z-index: 1;
        }
        .auto-style29 {
            position: absolute;
            top: 345px;
            left: 700px;
            z-index: 1;
        }
        .auto-style30 {
            position: absolute;
            top: 305px;
            left: 570px;
            z-index: 1;
        }
        .auto-style31 {
            position: absolute;
            top: 350px;
            left: 600px;
            z-index: 1;
        }
        .auto-style32 {
            width: 334px;
            height: 297px;
            position: absolute;
            top: 270px;
            left: 875px;
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


                        <h2>Add A Contract</h2>



                </center>


                    <p class="auto-style1">
                      


                        <asp:Button ID="btnSave" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="auto-style2" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnGoBack" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="auto-style3" Text="Go Back" OnClick="btnGoBack_Click" />
                        <asp:TextBox ID="txtPricePerMonth" runat="server" CssClass="auto-style4" Font-Bold="False" TextMode="Number"></asp:TextBox>
                        <asp:DropDownList ID="ddlContractType" runat="server" AutoPostBack="True" CssClass="auto-style9">
                            <asp:ListItem Value="1">Monthly</asp:ListItem>
                            <asp:ListItem>Pay As You Go</asp:ListItem>
                            <asp:ListItem>Sim Free</asp:ListItem>
                            <asp:ListItem>Sim Only</asp:ListItem>
                        </asp:DropDownList>
                <br />

                        <asp:Label ID="lblPricePerMonth" runat="server" CssClass="auto-style13" Font-Bold="True" Text="Price Per Month"></asp:Label>
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

                        <asp:Label ID="lblError" runat="server" CssClass="auto-style25"></asp:Label>

                        <asp:TextBox ID="txtStaffNo" runat="server" CssClass="auto-style26"></asp:TextBox>
                        <asp:Label ID="lblStaffNo" runat="server" CssClass="auto-style27" Text="Staff No"></asp:Label>

                        <asp:Label ID="lblStartDate" runat="server" Text="Start Date" CssClass="auto-style24" Font-Bold="True"></asp:Label>

                        <asp:TextBox ID="txtManufacturerNo" runat="server" CssClass="auto-style28"></asp:TextBox>
                        <asp:TextBox ID="txtCustomerNo" runat="server" CssClass="auto-style29"></asp:TextBox>
                        <asp:Label ID="lblCustomerNo" runat="server" CssClass="auto-style31" Text="CustomerNo"></asp:Label>
                        <asp:Label ID="lblManufacturerNo" runat="server" CssClass="auto-style30" Text="Manufacturer No"></asp:Label>

                        <asp:Calendar ID="StartDateCalendar" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" CssClass="auto-style32" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                            <WeekendDayStyle BackColor="#CCCCFF" />
                        </asp:Calendar>

            </div>

            <div id="footer">
                <h5> &copy; Phone Pal</h5>
            </div>
        </div>
    </div>

    </form>

</body>
</html>

