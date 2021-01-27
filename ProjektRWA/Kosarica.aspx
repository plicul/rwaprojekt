<%@ Page Title="" Language="C#" MasterPageFile="~/Masterstr.Master" AutoEventWireup="true" CodeBehind="Kosarica.aspx.cs" Inherits="ProjektRWA.Kosarica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content1placeholder" runat="server">
    <div id="KosaricaTitle" runat="server" class="ContentHead"> <h1>Košarica</h1> </div>

    <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4" 
        ItemType="ProjektRWA.Models.CartItem" 
        SelectMethod="GetShoppingCartItems"
        CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="ID" SortExpression="ProductID" />
            <asp:BoundField DataField="Product.ArtikalIme" HeaderText="Ime " />
            <asp:BoundField DataField="Product.ArtikalCijena" HeaderText="Cijena (svaki)" DataFormatString="{0:c}" />
            <asp:TemplateField HeaderText="Količina">
                <ItemTemplate>
                    <%#: String.Format("{0:c}", ((Convert.ToDouble(Item.Quantity)) * Convert.ToDouble(Item.Product.ArtikalCijena))) %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Briši artikal">
                <ItemTemplate>
                    <asp:CheckBox ID="Remove" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

    <div>
        <p></p>
        <strong>
            <asp:Label ID="LabelTotalText" runat="server" Text="Ukupna cijena: "></asp:Label>
            <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
        </strong>
    </div>
    <br />
    <table>
        <tr>
            <td>
                <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" />
            </td>
            <td>
                <!--checkout placeholder-->
            </td>
        </tr>
    </table>
</asp:Content>
