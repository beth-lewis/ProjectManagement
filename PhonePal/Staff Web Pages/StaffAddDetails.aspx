<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffAddDetails.aspx.cs" Inherits="StaffAddDetails" %>

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
                    <td><img src="molumen_phone_icon.png" height="50" width="50" /></td>
                    <td><h1>Phone Pal</h1></td>
                </tr>
            </table>
        </div>
        <div id="main">
            

                <p>  Add Staff Details  </p>

                <form id="form1" runat="server">
                    <div id="Left">
                        <fieldset>
                            <legend> Contact Details </legend>
                            Firstname: <input type="text" name="firstname" />
                            <br />
                            Surname: <input type="text" name="firstname" />
                            <br />
                            Email: <input type="text" name="firstname" />
                            <br />
                            Telephone: <input type="text" name="firstname" />
                        </fieldset>
                    </div>
                    <div id="Right">
                        <fieldset>
                            <legend> Address </legend>
                                Address Line 1: <input type="text" name="firstname" />
                            <br />
                                Address Line 2: <input type="text" name="firstname" />
                            <br />
                                Postcode: <input type="text" name="firstname" />
                            <br />
                            <br />
                                <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                            <br />
                        </fieldset>
                    </div>

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