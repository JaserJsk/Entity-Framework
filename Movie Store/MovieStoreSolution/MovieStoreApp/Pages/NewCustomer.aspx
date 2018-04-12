<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.Master" AutoEventWireup="true" CodeBehind="NewCustomer.aspx.cs" Inherits="MovieStoreApp.Pages.NewCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PagesHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PagesContentPlaceHolder" runat="server">

    <!-- ------------------------------------------------------------------------------- -->
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>New Customer</h2>
            <ol class="breadcrumb">
                <li>
                    <a href="index.aspx">Home</a>
                </li>
                <li class="active">
                    <strong>New Customer</strong>
                </li>
            </ol>
        </div>
        <div class="col-lg-2">
        </div>
    </div>

    <!-- ------------------------------------------------------------------------------- -->
    <div class="wrapper wrapper-content animated fadeInRight">
        <div class="row">
            <div class="col-lg-12">
                <div class="ibox float-e-margins">
                    <div class="ibox-title">
                        <h5>Add new customer</h5>
                        <div class="ibox-tools">
                            <a class="collapse-link">
                                <i class="fa fa-chevron-up"></i>
                            </a>
                            <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                                <i class="fa fa-wrench"></i>
                            </a>
                            <ul class="dropdown-menu dropdown-user">
                                <li><a href="#">Config option 1</a>
                                </li>
                                <li><a href="#">Config option 2</a>
                                </li>
                            </ul>
                            <a class="close-link">
                                <i class="fa fa-times"></i>
                            </a>
                        </div>
                    </div>

                    <!-- --------------------------------------------------------------- -->
                    <div class="ibox-content">

                        <div class="form-horizontal">

                            <div class="form-group">
                                <asp:Label ID="lblName" runat="server" Text="Name:" class="col-sm-2"></asp:Label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtName" runat="server" class="form-control"></asp:TextBox><br />
                                </div>
                            </div>

                            <div class="form-group">
                                <asp:Label ID="lblAddress" runat="server" Text="Address:" class="col-sm-2"></asp:Label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" class="form-control"></asp:TextBox><br />
                                </div>
                            </div>

                            <div class="form-group">
                                <asp:Label ID="lblPhone" runat="server" Text="Phone:" class="col-sm-2"></asp:Label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtPhone" runat="server" class="form-control"></asp:TextBox><br />
                                </div>
                            </div>

                            <div class="form-group">
                                <div class="col-sm-4 col-sm-offset-2">
                                    <asp:Button ID="btnAddCustomer" runat="server" Text="Add" OnClick="btnAddCustomer_Click" UseSubmitBehavior="true" class="btn btn-primary" />
                                </div>
                            </div>

                            <div class="form-group">
                                <asp:Label ID="lblResult" runat="server" class="col-sm-2"></asp:Label>
                            </div>

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
