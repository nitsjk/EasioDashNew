<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="Attendence.aspx.cs" Inherits="Attendenceaspx" %>

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

                            <li>
                                <a  href="#" aria-expanded="false"><i class="fa fa-book"></i><span class="mini-click-non">&nbsp;&nbsp; Attendence</span></a>

                                <ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="Notifications" href="#"><i class="fa fa-external-link-square sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Notifications</span></a></li>
                                   
                                    <li><a title="Buttons" href="#"><i class="fa fa-adjust sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">View Attedence</span></a></li>
                                    <li><a title="Tabs" href="#"><i class="fa fa-eye sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Tabs</span></a></li>
                                    <li><a title="Accordion" href="#"><i class="fa fa-life-ring sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">View Leaves</span></a></li>
                                </ul>
                            </li>

                            </ul>
                        </nav>
          </div>



</asp:Content>

