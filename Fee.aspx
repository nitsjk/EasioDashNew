<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="Fee.aspx.cs" Inherits="Fee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentSide" Runat="Server">

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
                                <a  href="Fee.aspx" aria-expanded="false"><i class="fa fa-money"></i><span class="mini-click-non">&nbsp;&nbsp; Fee</span></a>
                                </li>

                                <%--<ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="Bar Charts" href="#"><i class="fa fa-line-chart sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Fee Details</span></a></li>
                                    <li><a title="Line Charts" href="#"><i class="fa fa-area-chart sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Fee Paid</span></a></li>
                                    <li><a title="Area Charts" href="#"><i class="fa fa-pie-chart sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Fee Pending</span></a></li>
                                    <li><a title="Rounded Charts" href="#"><i class="fa fa-signal sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Late Fee</span></a></li>
                                  </ul>--%>

                            <li class="a-inner" > <a><i class="fa fa-caret-square-o-right i-class" ></i><span class="inner-span" > Add Fee</span></a> </li>
                            
                                   <li class="a-inner" > <a><i class="fa fa-caret-square-o-right text-right i-class"></i>
                                       <span class="inner-span"> Delete Fee</span> </a> </li>

                                   <li class="a-inner" > <a><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > View Fee </span></a> </li>

                        </ul>
                    </nav>
      </div>


</asp:Content>

