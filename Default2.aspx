<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>


        #welcomepanel{

	height:65px;
	background-color: transparent;
    color:white;
	padding:20px;
    text-align:center;
}

    </style>
<body>
    <form id="form1" runat="server">
   
        <div id="welcomepanel" style="background-color:red"><br />

               <asp:Image runat="server" ID="profilepic" Width="80" Height="80" style="border-radius:40px; margin-left:-25px; " ImageUrl="user.png" />
               <div style="width:25px;height:20px;background-image:url(download.png);background-size:25px 20px;position:absolute;margin-top:-30px;margin-left:30px">
                <asp:FileUpload onchange="submit()" ToolTip="Update Profile Picture " runat="server" ID="filepic" style="width:50px;height:35px;opacity:0"  />
            </div>  <br />
    
   </div>
    </form>
</body>
</html>
