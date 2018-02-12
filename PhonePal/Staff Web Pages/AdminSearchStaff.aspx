<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminSearchStaff.aspx.cs" Inherits="AdminSearchStaff" %>

<!DOCTYPE html>
<html>
<head>
    <title>Add Details</title>

    <!--link to stlesheet-->
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>

<body>
    <div id="container">
        <div id="header">
            <table style="width:360px">
                <tr>
                    <td><img src="E:\2nd Year\Project Management and Development\PhoneScreenDesigns\molumen_phone_icon.png" height="50" width="50" /></td>
                    <td><h1>Phone Pal</h1></td>
                </tr>
            </table>
        </div>
        <div id="main">
            

                <h3> Add Staff Details </h3>

                <form id="form1" runat="server">
                        <fieldset>
                            <legend> Search Staff Member </legend>
                            <br />
                                Lastname: <input type="text" name="firstname" />
                            <br />

                            <br />
                                <asp:Button ID="btnSearch" runat="server" Text="Search" />
                            <br />

                        </fieldset>

                </form>

            <br />

        </div>
        <br />
        <div id="footer">
            <h5> &copy; Phone Pal</h5>
        </div>
    </div>

</body>
</html>
