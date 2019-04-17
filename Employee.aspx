<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="Employee.aspx.cs" Inherits="Employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentSide" Runat="Server">

      <div class="left-custom-menu-adp-wrap comment-scrollbar">
                    <nav class="sidebar-nav left-sidebar-menu-pro">
                        <ul class="metismenu" id="menu1">
                            <li class="active">
                                <a  href="Default.aspx">
                                    <i class="fa big-icon fa-home icon-wrap"></i>
                                    <span class="mini-click-non">Dashboard</span>
                                </a>                               
                            </li>

                            <li id="removable">
                                <a class="has-arrow" href="#" aria-expanded="false"><i class="fa fa-users"></i><span class="mini-click-non">&nbsp;&nbsp; Employee</span></a>
                                <ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                    <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                    <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>
                                    <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                                </ul>
                            </li>

                            </ul>
                        </nav>
          </div>

</asp:Content>

