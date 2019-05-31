<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="FeeDue.aspx.cs" Inherits="FeeDue" %>


<asp:Content ID="Content1" ContentPlaceHolderID="contentSide" runat="Server">
    <link href="../css/StyleSheet.css" rel="stylesheet" />
    <link href="../css/AdminLTE.css" rel="stylesheet" />
    <link href="../css/AdminLTE.min.css" rel="stylesheet" />
    <link href="../css/TestStyle.css" rel="stylesheet" />

    <!-- favicon
		============================================ -->
    <link rel="shortcut icon" type="image/x-icon" href="img/favicon.ico">
    <!-- Google Fonts
		============================================ -->
    <link href="../css/GoogleFonts.css" rel="stylesheet" />

    <!-- Bootstrap CSS
		=========================
        
        =================== -->
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <!-- Bootstrap CSS
		============================================ -->
    <link rel="stylesheet" href="../css/font-awesome.min.css">
    <!-- owl.carousel CSS
		============================================ -->
    <link rel="stylesheet" href="../css/owl.carousel.css">
    <link rel="stylesheet" href="../css/owl.theme.css">
    <link rel="stylesheet" href="../css/owl.transitions.css">
    <!-- animate CSS
		============================================ -->
    <link rel="stylesheet" href="../css/animate.css">
    <!-- normalize CSS
		============================================ -->
    <link rel="stylesheet" href="../css/normalize.css">
    <!-- meanmenu icon CSS
		============================================ -->
    <link rel="stylesheet" href="../css/meanmenu.min.css">
    <!-- main CSS
		============================================ -->
    <link rel="stylesheet" href="../css/main.css">
    <!-- morrisjs CSS
		============================================ -->
    <link rel="stylesheet" href="../css/morrisjs/morris.css">
    <!-- mCustomScrollbar CSS
		============================================ -->
    <link rel="stylesheet" href="../css/scrollbar/jquery.mCustomScrollbar.min.css">
    <!-- metisMenu CSS
		============================================ -->
    <link rel="stylesheet" href="../css/metisMenu/metisMenu.min.css">
    <link rel="stylesheet" href="../css/metisMenu/metisMenu-vertical.css">
    <!-- calendar CSS
		============================================ -->
    <link rel="stylesheet" href="../css/calendar/fullcalendar.min.css">
    <link rel="stylesheet" href="../css/calendar/fullcalendar.print.min.css">
    <!-- style CSS
		============================================ -->
    <link rel="stylesheet" href="../css/style.css">
    <!-- responsive CSS
		============================================ -->
    <link rel="stylesheet" href="../css/responsive.css">
    <!-- modernizr JS
		============================================ -->
    <script src="../js/vendor/modernizr-2.8.3.min.js"></script>


    <!-- jquery
		============================================ -->
    <script src="../js/vendor/jquery-1.11.3.min.js"></script>
    <!-- bootstrap JS
		============================================ -->
    <script src="../js/bootstrap.min.js"></script>
    <!-- wow JS
		============================================ -->
    <script src="../js/wow.min.js"></script>
    <!-- price-slider JS
		============================================ -->
    <script src="../js/jquery-price-slider.js"></script>
    <!-- meanmenu JS
		============================================ -->
    <script src="../js/jquery.meanmenu.js"></script>
    <!-- owl.carousel JS
		============================================ -->
    <script src="../js/owl.carousel.min.js"></script>
    <!-- sticky JS
		============================================ -->
    <script src="../js/jquery.sticky.js"></script>
    <!-- scrollUp JS
		============================================ -->
    <script src="../js/jquery.scrollUp.min.js"></script>
    <!-- mCustomScrollbar JS
		============================================ -->
    <script src="../js/scrollbar/jquery.mCustomScrollbar.concat.min.js"></script>
    <script src="../js/scrollbar/mCustomScrollbar-active.js"></script>
    <!-- metisMenu JS
		============================================ -->
    <script src="../js/metisMenu/metisMenu.min.js"></script>
    <script src="../js/metisMenu/metisMenu-active.js"></script>
    <!-- morrisjs JS
		============================================ -->
    <script src="../js/morrisjs/raphael-min.js"></script>
    <script src="../js/morrisjs/morris.js"></script>
    <script src="../js/morrisjs/morris-active.js"></script>
    <!-- morrisjs JS


		============================================ -->
    <script src="../js/sparkline/jquery.sparkline.min.js"></script>
    <script src="../js/sparkline/jquery.charts-sparkline.js"></script>
    <!-- calendar JS
		============================================ -->
    <script src="../js/calendar/moment.min.js"></script>
    <script src="../js/calendar/fullcalendar.min.js"></script>
    <script src="../js/calendar/fullcalendar-active.js"></script>
    <!-- plugins JS
		============================================ -->
    <script src="../js/plugins.js"></script>
    <!-- main JS
		============================================ -->
    <script src="../js/main.js"></script>

    <link href="../css/TestStyle.css" rel="stylesheet" />



    <script type="text/javascript">
   <!--
    // Form validation code will come here.
    function validate() {

        if (document.myForm.ddlDepartments.value == "") {
            alert("Please provide your name!");
            document.myForm.Name.focus();
            return false;
        }
        if (document.myForm.txtName.value == "") {
            alert("Please provide your Email!");
            document.myForm.EMail.focus();
            return false;
        }
        return (true);
    }
   //-->
    </script>
    <div class="left-custom-menu-adp-wrap comment-scrollbar">


        <div>
            <a href="../Default.aspx">
                <img src="../img/easio-logo2.png" height="110px" width="130px" style="margin-left: 25px" />
            </a>
        </div>



        <nav class="sidebar-nav left-sidebar-menu-pro">
            <ul class="metismenu2" id="menu1">

                <li class="b-inner">
                    <a href="../Fee.aspx" aria-expanded="false"><i class="fa fa-university"></i><span class="mini-click-non">&nbsp;&nbsp; Fee</span></a>
                </li>



                <li class="a-inner" style="display: table-row"><a href="FeeHeads.aspx" class="a-inner-middle" style="display: table-cell; vertical-align: middle;"><span class="inner-span"><i class="fa fa-circle-o" style="font-size: 14px"></i>&nbsp Fee Heads </span></a></li>

                <li class="a-inner" style="display: table-row"><a href="FeeStructure.aspx" class="a-inner-middle" style="display: table-cell; vertical-align: middle;"><span class="inner-span"><i class="fa fa-circle-o" style="font-size: 14px"></i>&nbsp Fee Structure </span></a></li>

                <li class="a-inner" style="display: table-row"><a href="FeeDue.aspx" class="a-inner-middle" style="display: table-cell; vertical-align: middle;"><span class="inner-span"><i class="fa fa-circle-o" style="font-size: 14px"></i>&nbsp Fee Due </span></a></li>
                
                <li class="a-inner" style="display: table-row"><a href="PayFee.aspx" class="a-inner-middle" style="display: table-cell; vertical-align: middle;"><span class="inner-span"><i class="fa fa-circle-o" style="font-size: 14px"></i>&nbsp Pay Fee </span></a></li>
                
                <li class="a-inner" style="display: table-row"><a href="Ledger.aspx" class="a-inner-middle" style="display: table-cell; vertical-align: middle;"><span class="inner-span"><i class="fa fa-circle-o" style="font-size: 14px"></i>&nbsp Ledger </span></a></li>
                 <li class="a-inner" style="display: table-row"><a href="EditFee.aspx" class="a-inner-middle" style="display: table-cell; vertical-align: middle;"><span class="inner-span"><i class="fa fa-circle-o" style="font-size: 14px"></i>&nbsp Edit Fee</span></a></li>
                 <li class="a-inner" style="display: table-row"><a href="EditReceipt.aspx" class="a-inner-middle" style="display: table-cell; vertical-align: middle;"><span class="inner-span"><i class="fa fa-circle-o" style="font-size: 14px"></i>&nbsp Edit Receipt </span></a></li>
                 <li class="a-inner" style="display: table-row"><a href="FeeAdvance.aspx" class="a-inner-middle" style="display: table-cell; vertical-align: middle;"><span class="inner-span"><i class="fa fa-circle-o" style="font-size: 14px"></i>&nbsp Fee Advance</span></a></li>







            </ul>
        </nav>
    </div>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentbody" runat="Server">
    <div class="header-top-area">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">

                    <div class="header-top-wraper">
                        <div class="row">
                            <div class="col-lg-1 col-md-0 col-sm-1 col-xs-12">
                                <div class="menu-switcher-pro">
                                    <button type="button" id="sidebarCollapse" class="btn bar-button-pro header-drl-controller-btn btn-info navbar-btn">
                                        <i class="fa fa-bars"></i>
                                    </button>
                                </div>
                            </div>
                            <div class="col-lg-5 col-md-6 col-sm-6 col-xs-12">
                                <div class="header-top-menu tabl-d-n">
                                    <ul class="nav navbar-nav mai-top-nav">
                                        <li class="nav-item"><a href="#" class="nav-link">Home</a>
                                        </li>
                                        <li class="nav-item"><a href="#" class="nav-link">About</a>
                                        </li>
                                        <li class="nav-item"><a href="#" class="nav-link">Services</a>
                                        </li>
                                        <li class="nav-item"><a href="#" class="nav-link">Support</a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                            <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12" style="padding-right: 11px !important;">
                                <div class="header-right-info">
                                    <ul class="nav navbar-nav mai-top-nav header-right-menu">

                                        <li class="nav-item">
                                            <span style="color: white" class="h4">[<asp:Label ID="lblSession" runat="server" Text="Session"></asp:Label>]</span>
                                        </li>

                                        <li class="nav-item">
                                            <span style="color: white" class="h4">[<asp:Label ID="lblfinancialyear" runat="server" Text="Financial Year"></asp:Label>]</span>
                                        </li>

                                        <li class="nav-item dropdown">
                                            <a href="#" data-toggle="dropdown" role="button" aria-expanded="false" class="nav-link dropdown-toggle"><i class="fa fa-envelope-o adminpro-chat-pro" aria-hidden="true"></i><span class="indicator-ms"></span></a>
                                            <div role="menu" class="author-message-top dropdown-menu animated zoomIn">
                                                <div class="message-single-top">
                                                    <h1>Message</h1>
                                                </div>
                                                <ul class="message-menu">

                                                    <li>
                                                        <a href="#">
                                                            <div class="message-img">
                                                                <img src="img/human-6.png" alt="">
                                                            </div>
                                                            <div class="message-content">
                                                                <span class="message-date">16 Sept</span>
                                                                <h2>Sulaiman din</h2>
                                                                <p>Please done this project as soon possible.</p>
                                                            </div>
                                                        </a>
                                                        <li></li>
                                                        <a href="#">
                                                            <div class="message-img">
                                                                <img src="img/human-4.png" alt="">
                                                            </div>
                                                            <div class="message-content">
                                                                <span class="message-date">16 Sept</span>
                                                                <h2>Victor Jara</h2>
                                                                <p>Please done this project as soon possible.</p>
                                                            </div>
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href="#">
                                                            <div class="message-img">
                                                                <img src="img/human-6.png" alt="">
                                                            </div>
                                                            <div class="message-content">
                                                                <span class="message-date">16 Sept</span>
                                                                <h2>Victor Jara</h2>
                                                                <p>Please done this project as soon possible.</p>
                                                            </div>
                                                        </a>
                                                    </li>
                                                </ul>
                                                <div class="message-view">
                                                    <a href="#">View All Messages</a>
                                                </div>
                                            </div>
                                        </li>
                                        <li class="nav-item"><a href="#" data-toggle="dropdown" role="button" aria-expanded="false" class="nav-link dropdown-toggle"><i class="fa fa-bell-o" aria-hidden="true"></i><span class="indicator-nt"></span></a>
                                            <div role="menu" class="notification-author dropdown-menu animated zoomIn">
                                                <div class="notification-single-top">
                                                    <h1>Notifications</h1>
                                                </div>
                                                <ul class="notification-menu">
                                                    <li>
                                                        <a href="#">
                                                            <div class="notification-icon">
                                                                <i class="fa fa-check adminpro-checked-pro admin-check-pro" aria-hidden="true"></i>
                                                            </div>
                                                            <div class="notification-content">
                                                                <span class="notification-date">16 Sept</span>
                                                                <h2>Advanda Cro</h2>
                                                                <p>Please done this project as soon possible.</p>
                                                            </div>
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href="#">
                                                            <div class="notification-icon">
                                                                <i class="fa fa-cloud adminpro-cloud-computing-down" aria-hidden="true"></i>
                                                            </div>
                                                            <div class="notification-content">
                                                                <span class="notification-date">16 Sept</span>
                                                                <h2>Sulaiman din</h2>
                                                                <p>Please done this project as soon possible.</p>
                                                            </div>
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href="#">
                                                            <div class="notification-icon">
                                                                <i class="fa fa-eraser adminpro-shield" aria-hidden="true"></i>
                                                            </div>
                                                            <div class="notification-content">
                                                                <span class="notification-date">16 Sept</span>
                                                                <h2>Victor Jara</h2>
                                                                <p>Please done this project as soon possible.</p>
                                                            </div>
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href="#">
                                                            <div class="notification-icon">
                                                                <i class="fa fa-line-chart adminpro-analytics-arrow" aria-hidden="true"></i>
                                                            </div>
                                                            <div class="notification-content">
                                                                <span class="notification-date">16 Sept</span>
                                                                <h2>Victor Jara</h2>
                                                                <p>Please done this project as soon possible.</p>
                                                            </div>
                                                        </a>
                                                    </li>
                                                </ul>
                                                <div class="notification-view">
                                                    <a href="#">View All Notification</a>
                                                </div>
                                            </div>
                                        </li>
                                        <li class="nav-item">
                                            <a href="#" data-toggle="dropdown" role="button" aria-expanded="false" class="nav-link dropdown-toggle">
                                                <i class="fa fa-user adminpro-user-rounded header-riht-inf" aria-hidden="true"></i>
                                                <span class="admin-name">Admin Name</span>
                                                <i class="fa fa-angle-down adminpro-icon adminpro-down-arrow"></i>
                                            </a>
                                            <ul role="menu" class="dropdown-header-top author-log dropdown-menu animated zoomIn">
                                                <%--<li><a href="#"><span class="fa fa-home author-log-ic"></span>Register</a>
                                                        </li>--%>
                                                <li><a href="#"><span class="fa fa-user author-log-ic"></span>My Profile</a>
                                                </li>
                                                <%--<li><a href="#"><span class="fa fa-diamond author-log-ic"></span> Lock</a>
                                                        </li>--%>
                                                <li><a href="#"><span class="fa fa-cog author-log-ic"></span>Settings</a>
                                                </li>
                                                <li><a href="#"><span class="fa fa-lock author-log-ic"></span>Log Out</a>
                                                </li>
                                            </ul>
                                        </li>
                                        <li class="nav-item nav-setting-open"><a href="#" data-toggle="dropdown" role="button" aria-expanded="false" class="nav-link dropdown-toggle"><i class="fa fa-tasks"></i></a>

                                            <div role="menu" class="admintab-wrap menu-setting-wrap menu-setting-wrap-bg dropdown-menu animated zoomIn">
                                                <ul class="nav nav-tabs custon-set-tab">
                                                    <%--<li class="active"><a data-toggle="tab" href="#Notes">News</a>
                                                            </li>--%>
                                                    <li class="active"><a data-toggle="tab" href="#Projects">Activity</a>
                                                    </li>
                                                    <li><a data-toggle="tab" href="#Settings">Settings</a>
                                                    </li>
                                                </ul>

                                                <div class="tab-content custom-bdr-nt">

                                                    <div id="Projects" class="tab-pane fade in active">
                                                        <div class="projects-settings-wrap">
                                                            <div class="note-heading-indicate">
                                                                <h2><i class="fa fa-cube"></i>Recent Activity</h2>
                                                                <p>You have 20 Recent Activity.</p>
                                                            </div>
                                                            <div class="project-st-list-area project-st-menu-scrollbar">
                                                                <ul class="projects-st-menu-list">
                                                                    <li>
                                                                        <a href="#">
                                                                            <div class="project-list-flow">
                                                                                <div class="projects-st-heading">
                                                                                    <h2>New User Registered</h2>
                                                                                    <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                    <span class="project-st-time">1 hours ago</span>
                                                                                </div>
                                                                            </div>
                                                                        </a>
                                                                    </li>
                                                                    <li>
                                                                        <a href="#">
                                                                            <div class="project-list-flow">
                                                                                <div class="projects-st-heading">
                                                                                    <h2>New Order Received</h2>
                                                                                    <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                    <span class="project-st-time">2 hours ago</span>
                                                                                </div>
                                                                            </div>
                                                                        </a>
                                                                    </li>
                                                                    <li>
                                                                        <a href="#">
                                                                            <div class="project-list-flow">
                                                                                <div class="projects-st-heading">
                                                                                    <h2>New Order Received</h2>
                                                                                    <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                    <span class="project-st-time">3 hours ago</span>
                                                                                </div>
                                                                            </div>
                                                                        </a>
                                                                    </li>
                                                                    <li>
                                                                        <a href="#">
                                                                            <div class="project-list-flow">
                                                                                <div class="projects-st-heading">
                                                                                    <h2>New Order Received</h2>
                                                                                    <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                    <span class="project-st-time">4 hours ago</span>
                                                                                </div>
                                                                            </div>
                                                                        </a>
                                                                    </li>
                                                                    <li>
                                                                        <a href="#">
                                                                            <div class="project-list-flow">
                                                                                <div class="projects-st-heading">
                                                                                    <h2>New User Registered</h2>
                                                                                    <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                    <span class="project-st-time">5 hours ago</span>
                                                                                </div>
                                                                            </div>
                                                                        </a>
                                                                    </li>
                                                                    <li>
                                                                        <a href="#">
                                                                            <div class="project-list-flow">
                                                                                <div class="projects-st-heading">
                                                                                    <h2>New Order</h2>
                                                                                    <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                    <span class="project-st-time">6 hours ago</span>
                                                                                </div>
                                                                            </div>
                                                                        </a>
                                                                    </li>
                                                                    <li>
                                                                        <a href="#">
                                                                            <div class="project-list-flow">
                                                                                <div class="projects-st-heading">
                                                                                    <h2>New User</h2>
                                                                                    <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                    <span class="project-st-time">7 hours ago</span>
                                                                                </div>
                                                                            </div>
                                                                        </a>
                                                                    </li>
                                                                    <li>
                                                                        <a href="#">
                                                                            <div class="project-list-flow">
                                                                                <div class="projects-st-heading">
                                                                                    <h2>New Order</h2>
                                                                                    <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                    <span class="project-st-time">9 hours ago</span>
                                                                                </div>
                                                                            </div>
                                                                        </a>
                                                                    </li>
                                                                </ul>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div id="Settings" class="tab-pane fade">
                                                        <div class="setting-panel-area">
                                                            <div class="note-heading-indicate">
                                                                <h2><i class="fa fa-gears"></i>Settings Panel</h2>
                                                                <p>You have 20 Settings. 5 not completed.</p>
                                                            </div>
                                                            <ul class="setting-panel-list">
                                                                <li>
                                                                    <div class="checkbox-setting-pro">
                                                                        <div class="checkbox-title-pro">
                                                                            <h2>Show notifications</h2>
                                                                            <div class="ts-custom-check">
                                                                                <div class="onoffswitch">
                                                                                    <input type="checkbox" name="collapsemenu" class="onoffswitch-checkbox" id="example">
                                                                                    <label class="onoffswitch-label" for="example">
                                                                                        <span class="onoffswitch-inner"></span>
                                                                                        <span class="onoffswitch-switch"></span>
                                                                                    </label>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="checkbox-setting-pro">
                                                                        <div class="checkbox-title-pro">
                                                                            <h2>Disable Chat</h2>
                                                                            <div class="ts-custom-check">
                                                                                <div class="onoffswitch">
                                                                                    <input type="checkbox" name="collapsemenu" class="onoffswitch-checkbox" id="example3">
                                                                                    <label class="onoffswitch-label" for="example3">
                                                                                        <span class="onoffswitch-inner"></span>
                                                                                        <span class="onoffswitch-switch"></span>
                                                                                    </label>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="checkbox-setting-pro">
                                                                        <div class="checkbox-title-pro">
                                                                            <h2>Enable history</h2>
                                                                            <div class="ts-custom-check">
                                                                                <div class="onoffswitch">
                                                                                    <input type="checkbox" name="collapsemenu" class="onoffswitch-checkbox" id="example4">
                                                                                    <label class="onoffswitch-label" for="example4">
                                                                                        <span class="onoffswitch-inner"></span>
                                                                                        <span class="onoffswitch-switch"></span>
                                                                                    </label>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="checkbox-setting-pro">
                                                                        <div class="checkbox-title-pro">
                                                                            <h2>Show charts</h2>
                                                                            <div class="ts-custom-check">
                                                                                <div class="onoffswitch">
                                                                                    <input type="checkbox" name="collapsemenu" class="onoffswitch-checkbox" id="example7">
                                                                                    <label class="onoffswitch-label" for="example7">
                                                                                        <span class="onoffswitch-inner"></span>
                                                                                        <span class="onoffswitch-switch"></span>
                                                                                    </label>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="checkbox-setting-pro">
                                                                        <div class="checkbox-title-pro">
                                                                            <h2>Update everyday</h2>
                                                                            <div class="ts-custom-check">
                                                                                <div class="onoffswitch">
                                                                                    <input type="checkbox" name="collapsemenu" checked="" class="onoffswitch-checkbox" id="example2">
                                                                                    <label class="onoffswitch-label" for="example2">
                                                                                        <span class="onoffswitch-inner"></span>
                                                                                        <span class="onoffswitch-switch"></span>
                                                                                    </label>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="checkbox-setting-pro">
                                                                        <div class="checkbox-title-pro">
                                                                            <h2>Global search</h2>
                                                                            <div class="ts-custom-check">
                                                                                <div class="onoffswitch">
                                                                                    <input type="checkbox" name="collapsemenu" checked="" class="onoffswitch-checkbox" id="example6">
                                                                                    <label class="onoffswitch-label" for="example6">
                                                                                        <span class="onoffswitch-inner"></span>
                                                                                        <span class="onoffswitch-switch"></span>
                                                                                    </label>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="checkbox-setting-pro">
                                                                        <div class="checkbox-title-pro">
                                                                            <h2>Offline users</h2>
                                                                            <div class="ts-custom-check">
                                                                                <div class="onoffswitch">
                                                                                    <input type="checkbox" name="collapsemenu" checked="" class="onoffswitch-checkbox" id="example5">
                                                                                    <label class="onoffswitch-label" for="example5">
                                                                                        <span class="onoffswitch-inner"></span><span class="onoffswitch-switch"></span>
                                                                                    </label>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </li>
                                                            </ul>

                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentDisplay" runat="Server">

    <div class="col-md-12 center-block text-center" style="margin-top: 20px;">
        <h3><span style="color: #9d0e0a">Fee</span> Due </h3>
        <hr class="center-block text-center" style="border: 1px solid #808080; text-align: center; background-color: #000000; margin-top: -6px; width: 25%" />
    </div>
    <div style="padding: 15px;">
        <asp:Label ID="lblSuccess" Visible="false" runat="server" CssClass="col-md-12 center-block text-center alert-success" />
        <asp:Label ID="lblError" Visible="false" runat="server" CssClass="col-md-12 center-block text-center alert-danger" />
    </div>
    <asp:MultiView ID="multiview1" ActiveViewIndex="0" runat="server">
        <asp:View ID="view1" runat="server">
            <div class="container-fluid">
                <div class="col-md-12">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <fieldset>
                            <legend style="font-size: 20px;">Search Student</legend>
                            <div class="review-content-section">
                                <div class="input-group review-pro-edt">
                                    <span class="input-group-addon"><i class="fa fa-ticket" aria-hidden="true"></i></span>
                                    <asp:DropDownList ID="ddlStType" AutoPostBack="true" OnSelectedIndexChanged="ddlStType_SelectedIndexChanged" runat="server" class="form-control" Width="80%">
                                        <asp:ListItem Text="--Select Type--" Value="-1" />
                                        <asp:ListItem Text="Student Code" Value="4" />
                                        <asp:ListItem Text="Admission No" Value="2" />
                                        <asp:ListItem Text="U I D" Value="1" Selected="True" />
                                        <asp:ListItem Text="Student Name" Value="3" />
                                        <asp:ListItem Text="Due By Class" Value="5" />
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ErrorMessage="?" InitialValue="-1" SetFocusOnError="true" ForeColor="Red" ControlToValidate="ddlStType" runat="server" ValidationGroup="var" />

                                </div>
                                <br />
                                <div class="input-group review-pro-edt" runat="server" id="textboxdiv">
                                    <span class="input-group-addon"><i class="fa fa-ticket" aria-hidden="true"></i></span>
                                    <asp:TextBox ID="txtSS" runat="server" CssClass="form-control" ForeColor="Black" Width="80%"></asp:TextBox>
                                    <asp:RequiredFieldValidator ErrorMessage="?" ValidationGroup="var" SetFocusOnError="true" ForeColor="Red" ControlToValidate="txtSS" runat="server" />
                                </div>
                                <div class="input-group review-pro-edt" runat="server" id="Classesdiv" visible="false">
                                    <span class="input-group-addon"><i class="fa fa-ticket" aria-hidden="true"></i></span>
                                    <asp:DropDownList ID="ddlCLasses" OnSelectedIndexChanged="ddlCLasses_SelectedIndexChanged" AutoPostBack="true" DataTextField="ClassName" DataValueField="ClassId" runat="server" class="form-control" Width="80%">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ErrorMessage="?" ValidationGroup="ByClass" InitialValue="-1" SetFocusOnError="true" ForeColor="Red" ControlToValidate="ddlCLasses" runat="server" />

                                </div>
                                <br />
                                <div class="input-group review-pro-edt" runat="server" id="SectionsDiv" visible="false">
                                    <span class="input-group-addon"><i class="fa fa-ticket" aria-hidden="true"></i></span>
                                    <asp:DropDownList ID="ddlSection" DataTextField="SectionName" DataValueField="SectionID" runat="server" class="form-control" Width="80%">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ErrorMessage="?" ValidationGroup="ByClass" InitialValue="-1" SetFocusOnError="true" ForeColor="Red" ControlToValidate="ddlSection" runat="server" />

                                </div>
                            </div>
                            <br />
                            <div class="form-group review-pro-edt center-block text-center">
                                <asp:Button ID="btnByClass" OnClick="btnByClass_Click" ValidationGroup="ByClass" runat="server" Text="Next" CssClass="btn btn-success" Visible="false" />

                                <asp:Button ID="btnSS" OnClick="btnSS_Click" runat="server" Text="Search" CssClass="btn btn-success" />
                                <asp:Button ID="btnReset" OnClick="btnReset_Click" runat="server" Text="Reset" CssClass="btn btn-primary" />
                            </div>
                        </fieldset>
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">

                        <asp:GridView ID="gvSearchResult" AutoGenerateColumns="False" runat="server" Style="margin-top: 30px; width: 80%" OnRowCommand="gvSearchResult_RowCommand" CssClass="table table-hover table-responsive" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:TemplateField HeaderText="S_No">
                                    <ItemTemplate>
                                        <%#Container.DataItemIndex+1%>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText=" Code">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("StudentCode") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Name">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("StudentName") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Roll No">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("RollNo") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Class">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("ClassName") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Section">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("SectionName") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="">
                                    <ItemTemplate>
                                        <asp:LinkButton Text="Due Fee" CommandArgument='<%# Eval("StudentID")+","+Eval("classId") +","+Eval("busstopid") %>' CommandName="DueFee" runat="server" />

                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                            <SortedAscendingCellStyle BackColor="#FDF5AC" />
                            <SortedAscendingHeaderStyle BackColor="#4D0000" />
                            <SortedDescendingCellStyle BackColor="#FCF6C0" />
                            <SortedDescendingHeaderStyle BackColor="#820000" />
                        </asp:GridView>

                    </div>
                </div>
            </div>
        </asp:View>
        <asp:View ID="view2" runat="server">
            <script>
                function OpenPopup(CID) {
                    window.open("../Fee/FeeStructure.aspx?Action=" + CID, "List", "toolbar=no, location=no,status=no,menubar=no,scrollbars=no,resizable=no,width=900,height=500,left=430,top=100,channelmode=no,titlebar=no,addressbar=no");
                    return false;
                }
            </script>
            <style>
                fieldset {
                    border: 1px solid #cbcbcb;
                    width: 90%;
                    margin-top: 10px;
                    margin-left: 20px;
                    
                }

                legend {
                    /*border:1px solid #cbcbcb;*/
                    width: auto;
                    padding: 2px !important;
                    margin-bottom: 20px;
                    font-size: 15px;
                    line-height: inherit;
                    margin-left: 33px;
                    font-weight: bold;
                }
            </style>
            <div class="container-fluid">
                <div class="col-md-12">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12 row">
                        <div class="form-inline">
                            <asp:DropDownList ID="ddlFeeHeads" OnSelectedIndexChanged="ddlFeeHeads_SelectedIndexChanged" AutoPostBack="true" DataTextField="FHName" Width="65%" DataValueField="FHID" runat="server" CssClass="form-control"></asp:DropDownList>
                            &nbsp; 
                            <asp:Button runat="server" Text="ADD Fee Structure" ID="btnAddFS" Width="30%" Visible="false" CssClass="btn btn-primary" />

                            <asp:RequiredFieldValidator ErrorMessage="?" InitialValue="-1" ControlToValidate="ddlFeeHeads" ValidationGroup="Due" ForeColor="Red" runat="server" />

                        </div>

                        <div class="row">
                            <div class="col-md-6 row">
                                <div class="col-md-12 row">
                                    <fieldset>
                                        <legend style="border: 1px solid #cbcbcb;">Months
                                            <asp:CheckBox Text="Select All" Style="font-size: 13px" AutoPostBack="true" OnCheckedChanged="CHECKALL_CheckedChanged" ID="CHECKALL" runat="server" />
                                        </legend>
                                        <div class="col-md-12" style="">


                                            <asp:CheckBoxList ID="chklMonths" DataTextField="MonthName" OnSelectedIndexChanged="chklMonths_SelectedIndexChanged" DataValueField="Smid" RepeatDirection="Horizontal" RepeatColumns="3" runat="server">
                                            </asp:CheckBoxList>

                                        </div>
                                    </fieldset>

                                </div>
                            </div>
                            <div class="col-md-6">
                                <br />
                                <div class="form-group">
                                    <asp:DropDownList ID="ddlBussFee" OnSelectedIndexChanged="ddlBussFee_SelectedIndexChanged" Visible="false" AutoPostBack="true" runat="server" CssClass="form-control">
                                        <asp:ListItem Text="--Select--" Value="-1" />
                                        <asp:ListItem Text="Fee Structure" Value="1" />
                                        <asp:ListItem Text="Buss Route" Value="2" />
                                    </asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="txtDueDate" placeholder="Due after" runat="server" CssClass="form-control" />
                                    <asp:RequiredFieldValidator ErrorMessage="?" ControlToValidate="txtDueDate" ValidationGroup="Due" ForeColor="Red" runat="server" />
                                    <asp:RangeValidator ErrorMessage="Value (1-31)" AccessKey="?" ControlToValidate="txtDueDate" MinimumValue="1" MaximumValue="31" ForeColor="Red" runat="server" />
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="txtAmount" placeholder="Rs." ReadOnly="false" runat="server" CssClass="form-control" />

                                    <asp:RequiredFieldValidator ErrorMessage="?" ControlToValidate="txtAmount" ValidationGroup="Due" ForeColor="Red" runat="server" />
                                </div>
                                <div class="form-group">

                                    <asp:TextBox ID="txtRemarks" placeholder="Remarks" TextMode="MultiLine" Rows="4" CssClass="form-control" runat="server" />
                                </div>
                                <div class="form-group  center-block text-center">

                                    <asp:Button Text="Back" ID="btnBack" OnClick="btnBack_Click" CssClass="btn btn-danger" runat="server" UseSubmitBehavior="False" />
                                    <asp:Button Text="Due Fee" ID="btnAdd" OnClick="btnAdd_Click" Enabled="true" ValidationGroup="Due" CssClass="btn btn-success" runat="server" />

                                    <asp:Button Text="Reset" ID="btnFDReset" OnClick="btnFDReset_Click" CssClass="btn btn-info" runat="server" UseSubmitBehavior="False" />
                                    <br />
                                </div>

                            </div>

                        </div>

                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <asp:GridView ID="gvChkDueFees" OnRowCommand="gvChkDueFees_RowCommand" AutoGenerateColumns="False" CssClass="table table-hover table-responsive" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
                            Style="margin-top: 30px">

                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:TemplateField HeaderText="S_No.">
                                    <ItemTemplate>
                                        <%#Container.DataItemIndex+1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="UID">
                                    <ItemTemplate>
                                        <asp:Label runat="server" Text='<%#Eval("StudentIDFK") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText=" FeeH Head">
                                    <ItemTemplate>
                                        <asp:Label runat="server" Text='<%#Eval("FeeHeadName") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText=" Assigned For">
                                    <ItemTemplate>
                                        <asp:Label runat="server" Text='<%#Eval("FeeMonth") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Options">
                                    <ItemTemplate>
                                        <asp:LinkButton ToolTip="Delete" CssClass="fa fa-trash" OnClientClick="return confirm('Are you sure you want to Delete !');" CommandName="DeleteCommand" ID="lnkDelete" CommandArgument='<%#Eval("SFHLID") %>' Style="color: #9a0c0c; font-size: 22px" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />

                            <SortedAscendingCellStyle BackColor="#FDF5AC" />
                            <SortedAscendingHeaderStyle BackColor="#4D0000" />
                            <SortedDescendingCellStyle BackColor="#FCF6C0" />
                            <SortedDescendingHeaderStyle BackColor="#820000" />

                        </asp:GridView>

                    </div>
                </div>
            </div>

        </asp:View>
    </asp:MultiView>


</asp:Content>

