<%@ Page Title="Proizvodi" Language="C#" MasterPageFile="~/Masterstr.Master" AutoEventWireup="true" CodeBehind="ListaArtikala.aspx.cs" Inherits="ProjektRWA.ListaArtikala" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1placeholder" runat="server">
    <section>
        <div class="proizvodi">
            <hgroup>
                <h2> <%: Page.Title %> </h2>
            </hgroup>

            <asp:ListView ID="listaProizvoda" 
                runat="server"
                DataKeyNames="ArtikalID" 
                GroupItemCount="4"
                ItemType="ProjektRWA.Models.Artikal"
                SelectMethod="GetArtikli">
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>Nema proizvoda.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                
                <EmptyItemTemplate>
                    <td />
                </EmptyItemTemplate>

                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>

                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="DetaljiArtikla.aspx?productID=<%#Item.ArtikalID %>">
                                        <img src="test.jpg" width="100" height="75" style="border: solid" />
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="DetaljiArtikla.aspx?productID=<%#:Item.ArtikalID %>">
                                        <span>
                                            <%#:Item.ArtikalIme %>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Cijena: </b><%#Item.ArtikalCijena %><a>kn</a>
                                    </span>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>

                <LayoutTemplate>
                    <table style="width:100%">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>

            </asp:ListView>
        </div>
    </section>
</asp:Content>
