<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="Library.aspx.cs" Inherits="Library" %>

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
                        <li><a title="Landing Page" href="Library.aspx" aria-expanded="false"><i class="fa fa-sticky-note" aria-hidden="true"></i><span class="mini-click-non">&nbsp;&nbsp; Library</span></a>
                            <ul class="submenu-angle" aria-expanded="false">
                                <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro"> Total Books</span></a></li>
                                <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Books Issued</span></a></li>
                                <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Fine On Books</span></a></li>
                               
                            </ul>
                        </li>

                            </ul>
                        </nav>
          </div>



</asp:Content>

