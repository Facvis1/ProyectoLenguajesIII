<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="ProyectoLenguajesIII.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="ShoppingCartTitle" runat="server" class="ContentHead"><h1>Carrito de compras</h1></div>
    <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4"
        ItemType="ProyectoLenguajesIII.Models.CartItem" SelectMethod="GetShoppingCartItems" 
        CssClass="table table-striped table-bordered" >   
        <Columns>
        <asp:BoundField DataField="ProductID" HeaderText="ID" SortExpression="ProductID" />        
        <asp:BoundField DataField="Product.ProductName" HeaderText="Nombre" />        
        <asp:BoundField DataField="Product.UnitPrice" HeaderText="Precio (unidad)" DataFormatString="{0:c}"/>     
        <asp:TemplateField   HeaderText="Cantidad">            
                <ItemTemplate>
                    <asp:TextBox style="background-color: black" ID="PurchaseQuantity" Width="40" runat="server" Text="<%#: Item.Quantity %>"></asp:TextBox> 
                </ItemTemplate>        
        </asp:TemplateField>    
        <asp:TemplateField HeaderText="Total">            
                <ItemTemplate>
                    <%#: String.Format("{0:c}", ((Convert.ToDouble(Item.Quantity)) *  Convert.ToDouble(Item.Product.UnitPrice)))%>
                </ItemTemplate>        
        </asp:TemplateField> 
        <asp:TemplateField HeaderText="Remover orden">            
                <ItemTemplate>
                    <asp:CheckBox id="Remove" runat="server"></asp:CheckBox>
                </ItemTemplate>        
        </asp:TemplateField>    
        </Columns>    
    </asp:GridView>
    <div>
        <p></p>
        <strong>
            <asp:Label ID="LabelTotalText" runat="server" Text="Total de la orden: "></asp:Label>
            <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
        </strong> 
    </div>
    <br />
    <table> 
    <tr>
      <td>
        <asp:Button style="background-color: #808080" ID="UpdateBtn" runat="server" Text="Actualizar" OnClick="UpdateBtn_Click" />
        <asp:Button style="background-color: #808080" runat="server" ID="Buybtn" Text="Pagar con tarjeta" OnClick="Buybtn_Click1"/>
        <asp:Button style="background-color: #808080" runat="server" ID="Button1" Text="Pagar en efectivo" OnClick="Button1_Click"/>
        <%--<asp:Button style="background-color: #808080" ID="buyBtn" runat="server" Text="Comprar" OnClick="buyBtn_Click" />--%>
      </td>
      <td>
        <!--Checkout Placeholder -->
      </td>
    </tr>
    </table>
</asp:Content>