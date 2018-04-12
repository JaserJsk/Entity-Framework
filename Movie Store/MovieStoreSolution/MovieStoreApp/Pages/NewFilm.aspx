<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.Master" AutoEventWireup="true" CodeBehind="NewFilm.aspx.cs" Inherits="MovieStoreApp.Pages.NewFilm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PagesHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PagesContentPlaceHolder" runat="server">

    <!-- ------------------------------------------------------------------------------- -->
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>New Movie</h2>
            <ol class="breadcrumb">
                <li>
                    <a href="index.aspx">Home</a>
                </li>
                <li class="active">
                    <strong>New Movie</strong>
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
                                <asp:Label ID="lblMovieName" runat="server" Text="Movie Name:" class="col-sm-2"></asp:Label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtMovieName" runat="server" class="form-control"></asp:TextBox><br />
                                </div>
                            </div>

                            <div class="form-group">
                                <asp:Label ID="lblDirectorName" runat="server" Text="Director Name:" class="col-sm-2"></asp:Label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtDirectorName" runat="server" class="form-control"></asp:TextBox><br />
                                </div>
                            </div>

                            <div class="form-group">
                                <asp:Label ID="lblReleaseDate" runat="server" Text="Release Date:" class="col-sm-2"></asp:Label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtReleaseDate" runat="server" class="form-control" placeholder="YYYY/MM/DD"></asp:TextBox><br />
                                </div>
                            </div>

                            <div class="form-group">
                                <asp:Label ID="lblGenres" runat="server" Text="Genres:" class="col-sm-2"></asp:Label>
                                <div class="col-sm-10">
                                    <asp:DropDownList ID="Genres" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                            </div>

                            <div class="form-group">
                                <div class="col-sm-4 col-sm-offset-2">
                                    <asp:Button ID="btnAddMovie" runat="server" Text="Add" OnClick="btnAddMovie_Click" UseSubmitBehavior="true" class="btn btn-primary" />
                                </div>
                            </div>

                            <div class="form-group">
                                <asp:Label ID="lblResult" runat="server"></asp:Label>
                            </div>

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
