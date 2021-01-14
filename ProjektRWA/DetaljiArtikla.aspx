<%@ Page Title="Detalji artikla" Language="C#" MasterPageFile="~/Masterstr.Master" AutoEventWireup="true" CodeBehind="DetaljiArtikla.aspx.cs" Inherits="ProjektRWA.DetaljiArtikla" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1placeholder" runat="server">
    <section>
        <div class="proizvodi">
            
            <asp:FormView ID="productDetail" 
                runat="server" 
                ItemType="ProjektRWA.Models.Artikal" 
                SelectMethod="GetArtikal" 
                RenderOuterTable="false">

                <EmptyDataTemplate>
                    bruh
                </EmptyDataTemplate>

                <ItemTemplate>
                    <div>
                        <h1><%#:Item.ArtikalIme %></h1>
                    </div>
                    <br />
                    <table>
                        <tr>
                            <td>
                                <img src="test.jpg" style="border:solid; height:300px" alt="<%#:Item.ArtikalIme %>" />
                            </td>
                            <td>&nbsp;</td>
                            <td style="vertical-align:top; text-align:left">
                                <b>Opis:</b><br /><%#:Item.Opis %>
                                <br />
                                <span><b>Cijena:</b>&nbsp;<%#:Item.ArtikalCijena %></span><a>kn</a>
                                <br />
                                <span><b>Broj artikla:</b>&nbsp;<%#:Item.ArtikalID %></span>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>

            </asp:FormView>
        </div>
    </section>
</asp:Content>
