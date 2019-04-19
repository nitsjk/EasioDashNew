<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="AddStudent.aspx.cs" Inherits="AddStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentSide" Runat="Server">
    <link href="css/c3/c3.min.css" rel="stylesheet" />
     <link href="css/TestStyle.css" rel="stylesheet" />esheet" />
    <div class="left-custom-menu-adp-wrap comment-scrollbar">
                    <nav class="sidebar-nav left-sidebar-menu-pro">
                        <ul class="metismenu" id="menu1">
                            <li class="active">
                                <a  href="Default.aspx">
                                    <i class="fa big-icon fa-home icon-wrap"></i>
                                    <span class="mini-click-non">Dashboard</span>
                                </a>
                                
                            </li>

                            <li class="b-inner">
                                <a href="StudentDashboard.aspx"><i class="fa fa-graduation-cap"></i>&nbsp;&nbsp; Students</a>                              
                            </li>
                                
                            <li class="a-inner" > <a href="AddStudent.aspx"s><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > Add Student </span></a> </li>
                        
                            <li class="a-inner" > <a><i class="fa fa-caret-square-o-right i-class" ></i><span class="inner-span" > Student Report</span></a> </li>
                            
                                   <li class="a-inner" > <a><i class="fa fa-caret-square-o-right text-right i-class"></i>
                                       <span class="inner-span"> Student</span> </a> </li>

                                   
                                   <li class="a-inner" > <a ><i class="fa fa-caret-square-o-right i-class"></i> <span class="inner-span" > Student Report</span></a> </li>
                            </ul>                              
                        
                    </nav>
                </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentbody" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentDisplay" Runat="Server">
   <div class="col-md-12">
        <asp:Label ID="lblSucess" CssClass="alert-success" runat="server"></asp:Label>

       <asp:Label ID="lblDanger" CssClass="alert-danger" runat="server"></asp:Label>
       <br /> <br />
       Enter Name :
       <asp:TextBox ID="txtName" runat="server" CssClass="form-control" Width="250px" ></asp:TextBox>
        <br /> <br />
       Enter Gender :
       <%--<asp:TextBox ID="txtGender" runat="server" CssClass="form-control" Width="250px" ></asp:TextBox>--%>

       <asp:DropDownList ID="dllGender" runat="server">
           <asp:ListItem Value="-1">--Select Gender--</asp:ListItem>
           <asp:ListItem Value="1">Male</asp:ListItem>
           <asp:ListItem Value="2">Female</asp:ListItem>
       </asp:DropDownList>

       <br />  <br />

       <asp:Button ID="btnSubmit" Text="Submit" CssClass=" btn btn-primary" runat="server" OnClick="btnSubmit_Click" />


   </div>
</asp:Content>


