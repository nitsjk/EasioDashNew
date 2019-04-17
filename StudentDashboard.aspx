<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="StudentDashboard.aspx.cs" Inherits="StudentDashboard" %>

<asp:Content ID="content1" runat="server" ContentPlaceHolderID="contentSide">
    <div class="left-custom-menu-adp-wrap comment-scrollbar">
                    <nav class="sidebar-nav left-sidebar-menu-pro">
                        <ul class="metismenu" id="menu1">
                            <li class="active">
                                <a  href="Default.aspx">
                                    <i class="fa big-icon fa-home icon-wrap"></i>
                                    <span class="mini-click-non">Dashboard</span>
                                </a>
                                
                            </li>
                            <li>
                                <a class="has-arrow" href="StudentDashboard.aspx" aria-expanded="false"><i class="fa fa-graduation-cap"></i><span class="mini-click-non">&nbsp;&nbsp; Students</span></a>
                                <ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="Inbox" href="#"><i class="fa fa-plus-square-o" aria-hidden="true"></i><span class="mini-sub-pro">&nbsp;&nbsp; Student Roll</span></a></li>
                                    <li><a title="View Mail" href="#"><i class="fa fa-book" aria-hidden="true"></i><span class="mini-sub-pro">&nbsp;&nbsp; Student Attendence</span></a></li>
                                    <li><a title="Compose Mail" href="#"><i class="fa fa-paper-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">&nbsp;&nbsp; Compose Mail</span></a></li>
                                </ul>
                            </li>
                        </ul>
                    </nav>
                </div>
</asp:Content>
<%-- Add content controls here --%>
