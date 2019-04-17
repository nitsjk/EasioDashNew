<%@ Page Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="conentsidemenu" runat="server" ContentPlaceHolderID="contentSide">

    <div class="left-custom-menu-adp-wrap comment-scrollbar">
                    <nav class="sidebar-nav left-sidebar-menu-pro">
                        <ul class="metismenu" id="menu1">
                            <li class="active">
                                <a  href="Default.aspx">
                                    <i class="fa big-icon fa-home icon-wrap"></i>
                                    <span class="mini-click-non">Dashboard</span>
                                </a>
                                
                            </li>
                            <%--dd--%>
                            <li>
                                <a href="StudentDashboard.aspx" ><i class="fa fa-graduation-cap"></i>&nbsp;&nbsp; Students</a>
                             
                            </li>

                            <li>
                                <a  href="Class.aspx" aria-expanded="false"><i class="fa fa-university"></i><span class="mini-click-non">&nbsp;&nbsp; Class</span></a>
                                <%--<ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="Google Map" href="#"><i class="fa fa-map-marker sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">&nbsp;&nbsp;  Google Map</span></a></li>
                                    <li><a title="Data Maps" href="#"><i class="fa fa-map-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">&nbsp;&nbsp;  Data Maps</span></a></li>
                                    <li><a title="Pdf Viewer" href="#"><i class="fa fa-file-pdf-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">&nbsp;&nbsp;  Pdf Viewer</span></a></li>
                                    <li><a title="X-Editable" href="#"><i class="fa fa-fighter-jet sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">&nbsp;&nbsp; X-Editable</span></a></li>
                                    <li><a title="Code Editor" href="#"><i class="fa fa-code sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">&nbsp;&nbsp;  Code Editor</span></a></li>
                                    <li><a title="Tree View" href="#"><i class="fa fa-frown-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">&nbsp;&nbsp;  Tree View</span></a></li>
                                    <li><a title="Preloader" href="#"><i class="fa fa-circle sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">&nbsp;&nbsp;  Preloader</span></a></li>
                                    <li><a title="Images Cropper" href="#"><i class="fa fa-file-image-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">&nbsp;&nbsp; Images Cropper</span></a></li>
                                </ul>--%>
                            </li>

                            <li>
                                <a  href="Subjects.aspx" aria-expanded="false"><i class="fa fa-book"></i><span class="mini-click-non">&nbsp;&nbsp; Subjects</span></a>
                                <%--<ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="File Manager" href="#"><i class="fa fa-folder sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">File Manager</span></a></li>
                                    <li><a title="Blog" href="#"><i class="fa fa-square sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Blog</span></a></li>
                                    <li><a title="Blog Details" href="#"><i class="fa fa-tags sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Blog Details</span></a></li>
                                    <li><a title="404 Page" href="#"><i class="fa fa-tint sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">404 Page</span></a></li>
                                    <li><a title="500 Page" href="#"><i class="fa fa-tree sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">500 Page</span></a></li>
                                </ul>--%>
                            </li>


                            <li>
                                <a  href="Fee.aspx" aria-expanded="false"><i class="fa fa-money"></i><span class="mini-click-non">&nbsp;&nbsp; Fee</span></a>
                                <%--<ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="Bar Charts" href="#"><i class="fa fa-line-chart sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Bar Charts</span></a></li>
                                    <li><a title="Line Charts" href="#"><i class="fa fa-area-chart sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Line Charts</span></a></li>
                                    <li><a title="Area Charts" href="#"><i class="fa fa-pie-chart sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Area Charts</span></a></li>
                                    <li><a title="Rounded Charts" href="#"><i class="fa fa-signal sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Rounded Charts</span></a></li>
                                    <li><a title="C3 Charts" href="#"><i class="fa fa-barcode sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">C3 Charts</span></a></li>
                                    <li><a title="Sparkline Charts" href="#"><i class="fa fa-sort-amount-desc sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Sparkline Charts</span></a></li>
                                    <li><a title="Peity Charts" href="#"><i class="fa fa-object-ungroup sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Peity Charts</span></a></li>
                                </ul>--%>
                            </li>



                            <li>
                                <a  href="Result.aspx" aria-expanded="false"><i class="fa fa-file-text-o"></i><span class="mini-click-non">&nbsp;&nbsp; Result</span></a>
                                <%--<ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="Peity Charts" href="#"><i class="fa fa-table sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Static Table</span></a></li>
                                    <li><a title="Data Table" href="#"><i class="fa fa-th sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Data Table</span></a></li>
                                </ul>--%>
                            </li>


                            <li>
                                <a  href="Transport.aspx" aria-expanded="false"><i class="fa fa-bus"></i><span class="mini-click-non">&nbsp;&nbsp; Transport</span></a>
                                <%--<ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="Basic Form Elements" href="#"><i class="fa fa-pencil sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Bc Form Elements</span></a></li>
                                    <li><a title="Advance Form Elements" href="#"><i class="fa fa-lightbulb-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Ad Form Elements</span></a></li>
                                    <li><a title="Password Meter" href="#"><i class="fa fa-hourglass sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Meter</span></a></li>
                                    <li><a title="Multi Upload" href="#"><i class="fa fa-hdd-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Multi Upload</span></a></li>
                                    <li><a title="Text Editor" href="#"><i class="fa fa-globe sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Text Editor</span></a></li>
                                    <li><a title="Dual List Box" href="#"><i class="fa fa-hand-paper-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Dual List Box</span></a></li>
                                </ul>--%>
                            </li>




                            <li>
                                <a  href="Attendence.aspx" aria-expanded="false"><i class="fa fa-book"></i><span class="mini-click-non">&nbsp;&nbsp; Attendence</span></a>
                                <%--<ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="Notifications" href="#"><i class="fa fa-external-link-square sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Notifications</span></a></li>
                                    <li><a title="Alerts" href="#"><i class="fa fa-crop sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Alerts</span></a></li>
                                    <li><a title="Modals" href="#"><i class="fa fa-building sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Modals</span></a></li>
                                    <li><a title="Buttons" href="#"><i class="fa fa-adjust sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Buttons</span></a></li>
                                    <li><a title="Tabs" href="#"><i class="fa fa-eye sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Tabs</span></a></li>
                                    <li><a title="Accordion" href="#"><i class="fa fa-life-ring sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Accordion</span></a></li>
                                </ul>--%>
                            </li>



                            <li id="removable">
                                <a  href="#" aria-expanded="false"><i class="fa fa-users"></i><span class="mini-click-non">&nbsp;&nbsp; Employee</span></a>
                                <%--<ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                    <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                    <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>
                                    <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                                </ul>--%>
                            </li>


                            <li><a  title="Landing Page" href="Payroll.aspx" aria-expanded="false"><i class="fa fa-credit-card-alt" aria-hidden="true"></i><span class="mini-click-non">&nbsp;&nbsp; Payroll</span></a>
                                <%--<ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                    <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                    <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>
                                    <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                                </ul>--%>
                            </li>


                            <li><a  title="Landing Page" href="Teacher-Log.aspx" aria-expanded="false"><i class="fa fa-bookmark icon-wrap sub-icon-mg" aria-hidden="true"></i><span class="mini-click-non">&nbsp;&nbsp; Teacher-Log</span></a>
                                <%--<ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a><ul class="submenu-angle" aria-expanded="false">
                                        <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                        <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                        <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>
                                        <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                                    </ul>
                                    </li>
                                    <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a>
                                        <ul class="submenu-angle" aria-expanded="false">
                                            <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a><ul class="submenu-angle" aria-expanded="false">
                                                <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a><ul class="submenu-ang##">
                                                    <i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span>
                                                    </a></li>
                                                <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                                <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a><ul class="submenu-angle" aria-expanded="false">
                                                    <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                                    <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                                    <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a><ul class="submenu-angle" aria-expanded="false">
                                                        <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                                        <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                                        <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a><ul class="submenu-angle" aria-expanded="false">
                                                            <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                                            <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                                            <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a><ul class="submenu-angle" aria-expanded="false">
                                                                <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                                                <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                                                <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>
                                                                <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                                                            </ul>
                                                            </li>
                                                            <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                                                        </ul>
                                                        </li>
                                                        <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                                                    </ul>
                                                    </li>
                                                    <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                                                </ul>
                                                </li>
                                                <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                                            </ul>
                                            </li>
                                            <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a><ul class="submenu-angle" aria-expanded="false">
                                                <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                                <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                                <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>
                                                <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                                            </ul>
                                            </li>
                                            <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>
                                            <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                                        </ul>
                                    </li>
                                    <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                    <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>
                                    <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                                </ul>--%>
                            </li>


                            <li><a title="Lock" href="Lock.aspx"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>


                            <li><a title="Password Recovery" href="PasswordRecovery.aspx"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a>
                                <%--<ul class="submenu-angle" aria-expanded="false">
                                    <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                    <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                    <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>
                                    <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                                </ul>--%>
                            </li>


                        

                        <%--</li>--%>



                        <li><a  title="Landing Page" href="CampusManager.aspx" aria-expanded="false"><i class="fa fa-user" aria-hidden="true"></i><span class="mini-click-non">&nbsp;&nbsp; Campus Manager</span></a>
                            <%--<ul class="submenu-angle" aria-expanded="false">
                            <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                            <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                            <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>
                            <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                        </ul>--%>
                        </li>

                        <li><a  title="Landing Page" href="Library.aspx" aria-expanded="false"><i class="fa fa-sticky-note" aria-hidden="true"></i><span class="mini-click-non">&nbsp;&nbsp; Library</span></a>
                            <ul class="submenu-angle" aria-expanded="false">
                                <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>
                                <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                            </ul>
                        </li>




                        <li><a  title="Landing Page" href="TimeTable.aspx" aria-expanded="false"><i class="fa fa-calendar" aria-hidden="true"></i><span class="mini-click-non">&nbsp;&nbsp; Time-Table</span></a>
                            <%--<ul class="submenu-angle" aria-expanded="false">
                                <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>
                                <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                            </ul>--%>
                        </li>



                        <li><a  title="Landing Page" href="#" aria-expanded="false"><i class="fa fa-wrench" aria-hidden="true"></i><span class="mini-click-non">&nbsp;&nbsp; Settings</span></a>
                            <%--<ul class="submenu-angle" aria-expanded="false">
                                <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>
                                <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                            </ul>--%>
                        </li>




                        <li><a  title="Landing Page" href="#" aria-expanded="false"><i class="fa fa-folder-open" aria-hidden="true"></i><span class="mini-click-non">&nbsp;&nbsp; Accounts</span></a>
                            <%--<ul class="submenu-angle" aria-expanded="false">
                                <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>
                                <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                            </ul>--%>
                        </li>

                        <li><a  title="Landing Page" href="#" aria-expanded="false"><i class="fa fa-empire" aria-hidden="true"></i><span class="mini-click-non">&nbsp;&nbsp; Master-Setting</span></a>
                            <%--<ul class="submenu-angle" aria-expanded="false">
                                <li><a title="Login" href="#"><i class="fa fa-hand-rock-o sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Login</span></a></li>
                                <li><a title="Register" href="#"><i class="fa fa-plane sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Register</span></a></li>
                                <li><a title="Lock" href="#"><i class="fa fa-file sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Lock</span></a></li>
                                <li><a title="Password Recovery" href="#"><i class="fa fa-wheelchair sub-icon-mg" aria-hidden="true"></i><span class="mini-sub-pro">Password Recovery</span></a></li>
                            </ul>--%>
                        </li>
                        </ul>
                    </nav>
                </div>
</asp:Content>

