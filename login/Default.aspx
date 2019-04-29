<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="login_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <link href="css/bootstrap3.4.0.min.css" rel="stylesheet" />
    <script src="js/jquery1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <link href="css/font-awesome.min.css" rel="stylesheet" />
     
<!------ Include the above in your HEAD tag ---------->
    <link href="css/login.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body>
        <form id="form1" runat="server">
        
<div class="container login-container center-block"  >
            <div class="row">
                <div class="col-md-4 login-form-1 col-md-push-2" style="background-color:#3AB19B ">
                    <div class="col-md-12 center-block text-center">
                        <asp:Label id="lblError" Visible="false" CssClass="alert-danger center-block" runat="server" />
                         <asp:Label id="lblSuccess" Visible="false" CssClass="alert-success center-block" runat="server" />
                    </div>

                      <div ><img  src="Images/easio-logo2.png" height="110px" width="100%" /></div>
                    <br />
                    <h3 style="color:#fff;">Welcome</h3>
                    <br />


                    <p style="color:white;text-align:center"> Sign In To A Better Life </p>
                     <div class="sidebar-header">
                    <a href="#">
                                                   
                            
                        

                        </a>           
                                 

                </div>
                  
                </div>
                <div class="col-md-4 login-form-2 col-md-push-2"">
                    <h3 style="color:#3AB19B;"><b>Login </b></h3>
                    
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="txtUserName" class="form-control" placeholder="Your Email *"/>
                            <asp:RequiredFieldValidator ErrorMessage="?" ValidationGroup="login" ControlToValidate="txtUserName" SetFocusOnError="true" ForeColor="Red" runat="server" />

                        </div>
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="txtUserPassword" TextMode="Password" class="form-control" placeholder="Your Password *"/>
                            <asp:RequiredFieldValidator ErrorMessage="?" ValidationGroup="login" SetFocusOnError="true" ForeColor="Red" ControlToValidate="txtUserPassword" runat="server" />
                        </div>
                        <div class="form-inline">
                            <asp:CheckBox Text="Remember Me" class="ForgetPwd" runat="server" />
                            <a href="#" class="ForgetPwd" style="text-align:right; float:right ">Forget Password?</a>
                        </div>
                        <div class="form-group center-block text-center">
                            <asp:Button Text="SignIn" class="btnSubmit" ValidationGroup="login" ID="btnSignIn" OnClick="btnSignIn_Click" runat="server" />
                        </div>
                    <br /> <br />   
                    <div class="col-md-12">
                        <a href="http://www.nationalitsolutions.com"><img src="Images/nitsbanner.jpg" alt="Company Banner"   class="img-rounded img-responsive"/></a>
                    </div>
                </div>
            </div>
        </div>
    </form>

</body>
</html>
