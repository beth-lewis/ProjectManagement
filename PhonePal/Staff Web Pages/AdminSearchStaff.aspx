<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSearchStaff.aspx.cs" Inherits="PhonePal.Staff_Web_Pages.AdminSearchStaff" %>

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
            <center>

                <p> <h3> Add Staff Details </h3> </p>

                <form>
                        <fieldset>
                            <legend> Search Staff Member </legend>
                            <br />
                            Lastname: <input type="text" name="firstname" />
                            <br />

                            <p> <button class="button" href=""> Submit </button> </p>
                        </fieldset>

                </form>


            </center>
            <br />

        </div>
        <br />
        <div id="footer">
            <h5> &copy; Phone Pal</h5>
        </div>
    </div>
    </div>

</body>
</html>
