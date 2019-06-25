<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="Fee.aspx.cs" Inherits="Fee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentSide" Runat="Server">

    <div class="sidebar-header">
                    <a href="#">         
                            
                        <div><img  src="img/easio-logo2.png" height="110px" width="130px" /></div>

                        </a>           
                                 

                </div>

     <link href="css/TestStyle.css" rel="stylesheet" />stylesheet" />

      <div class="left-custom-menu-adp-wrap comment-scrollbar">
                    <nav class="sidebar-nav left-sidebar-menu-pro">
                        <ul class="metismenu2" id="menu1">
                            <li class="active">
                                <a  href="Default.aspx">
                                    <i class="fa big-icon fa-home icon-wrap"></i>
                                    <span class="mini-click-non">Dashboard</span>
                                </a>                               
                            </li>

                            <li class="b-inner">
                                <a  href="Fee.aspx" aria-expanded="false"><i class="fa fa-money"></i><span class="mini-click-non">&nbsp;&nbsp; Fee</span></a>
                                </li>

                               <%-- <ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="Bar Charts" href="#"><i class="fa fa-line-chart sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Fee Details</span></a></li>
                                    <li><a title="Line Charts" href="#"><i class="fa fa-area-chart sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Fee Paid</span></a></li>
                                    <li><a title="Area Charts" href="#"><i class="fa fa-pie-chart sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Fee Pending</span></a></li>
                                    <li><a title="Rounded Charts" href="#"><i class="fa fa-signal sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Late Fee</span></a></li>
                                  </ul>--%>

                            <li class="a-inner" > <a href="Fee/FeeHeads.aspx"><i class="fa fa-caret-square-o-right i-class" ></i><span class="inner-span" >  Add Fee</span></a> </li>
                            
                                   <li class="a-inner" > <a href="Fee/FeeStructure.aspx"><i class="fa fa-caret-square-o-right text-right i-class"></i>
                                       <span class="inner-span">  Fee Structure</span> </a> </li>

                                   <li class="a-inner" > <a href="Fee/FeeDue.aspx"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > Fee Due </span></a> </li>
                              <li class="a-inner" > <a href="Fee/PayFee.aspx"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" >  Pay Fee</span></a> </li>

                              <li class="a-inner" > <a href="Fee/StudentLedger.aspx"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > Student Ledger </span></a> </li>

                               <li class="a-inner" > <a href="Fee/FeeAdvance.aspx"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" >  Fee Advance </span></a> </li>
                             <li class="a-inner" > <a href="Fee/Editreceipt.aspx"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" >  Edit Receipt </span></a> </li>
                             <li class="a-inner" > <a href="Fee/EditFee.aspx"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" >  Edit Fee </span></a> </li>
                             <li class="a-inner" > <a href="Fee/HalfTransportFee"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > Update Transport Fee </span></a> </li>
                            <li class="a-inner" > <a href="Fee/NewCashCollection.aspx"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > Cash Collection </span></a> </li>
                              <li class="a-inner" > <a href="Fee/"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > Fee Rebate </span></a> </li>
                              <li class="a-inner" > <a href="Fee/DayBook.aspx"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > Day Book </span></a> </li>
                            <li class="a-inner" > <a href="Fee/"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > Cancel Receipt </span></a> </li>
                            <li class="a-inner" > <a href="Fee/"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > Manage Transport </span></a> </li>
                            <li class="a-inner" > <a href="Fee/IncomeCertificate"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > Income Certificate </span></a> </li>
                            <li class="a-inner" > <a href="Fee/Defaulters.aspx"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > Defaulters </span></a> </li>
                            <li class="a-inner" > <a href="Fee/"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > Bus Defaulters </span></a> </li>
                            <li class="a-inner" > <a href="Fee/"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > Discount Report </span></a> </li>
                            <li class="a-inner" > <a href="Fee/"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > Delete Receipt </span></a> </li>
                        </ul>
                    </nav>
      </div>


</asp:Content>

