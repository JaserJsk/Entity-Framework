<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MovieStoreApp.Pages.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PagesHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PagesContentPlaceHolder" runat="server">

    <!-- ------------------------------------------------------------------------------- -->
    <div class="wrapper wrapper-content animated fadeInRight">
        <div class="row">
            <div class="col-lg-12">
                <h1>
                    Projekt Arbete
                </h1>

                <h3>
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </h3>

                <div class="ibox float-e-margins">
                    <div class="ibox-title">
                        <h5>Available movies</h5>
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
                        <asp:Repeater ID="FilmsTable" OnItemCommand="Repeater1_OnItemCommand" runat="server">
                            <HeaderTemplate>
                                <table class="table">
                                <tr>
                                    <td>Movie ID
                                    </td>
                                    <td>Movie Name
                                    </td>
                                    <td>Director Name
                                    </td>
                                    <td>Movie Genre
                                    </td>
                                    <td>Release Date
                                    </td>
                                    <td>Rent
                                    </td>
                                    <td>Rented
                                    </td>
                                    <td>Return
                                    </td>
                                </tr>
                            </HeaderTemplate>

                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="MovieID"
                                                   Text='<%# Eval("Movy.MovieID") %>' />
                                    </td>
                                    <td>
                                        <asp:Label runat="server" ID="MovieName"
                                                   Text='<%# Eval("Movy.MovieName") %>' />
                                    </td>
                                    <td>
                                        <asp:Label runat="server" ID="DirectorName"
                                                   Text='<%# Eval("Movy.DirectorName") %>' />
                                    </td>

                                    <td>
                                        <asp:Label runat="server" ID="Label1"
                                                   Text='<%# Eval("Movy.Genre.Genre1") %>' />
                                    </td>
                                    <td>
                                        <asp:Label runat="server" ID="ReleaseDate"
                                                   Text='<%# Eval("Movy.ReleaseDate") %>' />
                                    </td>

                                    <td>
                                        <input type="button" value="Rent" onclick="window.location = 'Rent.aspx?MovieID=<%# Eval("Movy.Movieid")%>';" class="btn btn-primary" />

                                    </td>
                                    <td>
                                        <%#  Convert.ToBoolean(Eval("IsRented")) ? Convert.ToDateTime(Eval("RentedTo")).ToString("dd/MM/yyyy") : ""%>
                                    </td>
                                    <td>
                                        <%#  Convert.ToBoolean(Eval("IsRented")) ? Convert.ToDateTime(Eval("RentedTo")).AddDays(7).ToString("dd/MM/yyyy") : ""%>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>

                    </div>

                </div>
            </div>
        </div>
    </div>

</asp:Content>
