<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="Employee.aspx.cs" Inherits="Employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentSide" Runat="Server">

    <div class="sidebar-header">
                    <a href="#">         
                            
                        <div><img  src="img/easio-logo2.png" height="110px" width="130px" /></div>

                        </a>           
                                 

                </div>

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

                            <%--<li id="removable">
                                <a  href="#" aria-expanded="false"><i class="fa fa-users"></i><span class="mini-click-non">&nbsp;&nbsp; Employee</span></a>
                                <ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                    <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                    <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">View Employee</span></a></li>
                                    <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Delete Employee</span></a></li>
                                </ul>
                            </li>--%>


                            <li class="b-inner">
                                <a href="Employee.aspx"><i class="fa fa-graduation-cap"></i>&nbsp;&nbsp; Employee</a>                              
                            </li>                          
                        
                            <li class="a-inner" > <a><i class="fa fa-caret-square-o-right i-class" ></i><span class="inner-span" > Add Employee</span></a> </li>
                            
                                   <li class="a-inner" > <a><i class="fa fa-caret-square-o-right text-right i-class"></i>
                                       <span class="inner-span"> Delete Employee</span> </a> </li>

                                   <li class="a-inner" > <a><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > View Employee </span></a> </li>



                            </ul>
                        </nav>
          </div>

</asp:Content>

