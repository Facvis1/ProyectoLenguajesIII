<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AccountOrders.aspx.cs" Inherits="ProyectoLenguajesIII.AccountOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
            <h1>Ordenes Pendientes:</h1>
        <asp:GridView class="table thead-dark" ID="tabladesp" runat="server" AutoGenerateColumns="true" ShowHeaderWhenEmpty="true">
            <Columns>
                <asp:TemplateField HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
<%--                        <asp:ImageButton ID="imgbtn1" Visible="true" ImageUrl="~/Images/ace.png" runat="server" ValidationGroup="bg1" CommandArgument='<%#Eval("OrderId") + "," +Eval("Username")%>' Onclick="Aceptardesp_Click" ToolTip="Enviar" Width="25px" Height="25px"/>--%>
<%--                        <asp:ImageButton ID="imgbtn2" ImageUrl="~/Images/can.png" runat="server" ValidationGroup="bg1" CommandArgument='<%#Eval("OrderId") + "," +Eval("Username")%>' OnClick="Rechazardesp_Click" ToolTip="Rechazar" Width="25px" Height="25px"/>--%>
                    </ItemTemplate>
                    <EditItemTemplate>

                    </EditItemTemplate>
                    <FooterTemplate>

                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <h1>Ordenes Aceptadas:</h1>
                    <asp:GridView class="table thead-dark" ID="GridView2" runat="server" AutoGenerateColumns="true" ShowHeaderWhenEmpty="true">
        </asp:GridView>

        <h1>Ordenes Enviadas:</h1>
        <asp:GridView class="table thead-dark" ID="tablatransenv" runat="server" AutoGenerateColumns="true" ShowHeaderWhenEmpty="true">
            <Columns>
                <asp:TemplateField HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
<%--                        <asp:ImageButton ID="imgbtn1" Visible="true" ImageUrl="~/Images/ace.png" runat="server" ValidationGroup="bg1" CommandArgument='<%#Eval("OrderId") + "," +Eval("Username")%>' Onclick="Entregar_Click" ToolTip="Entregar" Width="25px" Height="25px"/>--%>
                        <%--<asp:ImageButton ID="imgbtnr" ImageUrl="~/Images/can.png" runat="server" ValidationGroup="bg1" CommandArgument='<%#Eval("OrderId") + "," +Eval("Username")%>' OnClick="Rechazardesp_Click" ToolTip="Rechazar" Width="25px" Height="25px"/>--%>
                    </ItemTemplate>
                    <EditItemTemplate>

                    </EditItemTemplate>
                    <FooterTemplate>

                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <h1>Ordenes Entregadas:</h1>
                    <asp:GridView class="table thead-dark" ID="tablatransent" runat="server" AutoGenerateColumns="true" ShowHeaderWhenEmpty="true">
        </asp:GridView>
        <h1>Ordenes Rechazadas:</h1>
                    <asp:GridView class="table thead-dark" ID="GridView1" runat="server" AutoGenerateColumns="true" ShowHeaderWhenEmpty="true">
        </asp:GridView>
        </div>


    <div>
        <asp:Button runat="server" ValidationGroup="bg1" ID="Btorddet" OnClick="Btorddet_Click1" Text="Mostrar Detalles de las Ordenes" />
            <asp:Button runat="server" ValidationGroup="bg1" ID="Btorddet1" OnClick="Btorddet1_Click" Text="Ocultar Detalles de las Ordenes" />
            

            <asp:GridView ID="OrderItemList2" runat="server" AutoGenerateColumns="False" Width="500"  BorderStyle="Dashed" Visible="false">              
            <Columns>
                    <%--<asp:BoundField DataField="OrderDetailId" HeaderText="Id" />--%>
                    <asp:BoundField DataField="OrderId" HeaderText="Id Orden" />
                    <%--<asp:BoundField DataField="Username" HeaderText="Usuario" />--%>
                    <asp:BoundField DataField="ProductId" HeaderText="Id del Producto" />
                    <asp:BoundField DataField="Username" HeaderText="Nombre de Usuario" />
                    <asp:BoundField DataField="Quantity" HeaderText="Cantidad" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="Precio Unitario" />
                    <asp:BoundField DataField="ProductName" HeaderText="Nombre del Producto" />
                    <asp:BoundField DataField="Totalprod" HeaderText="Total" />
            </Columns>
            </asp:GridView>
    </div>
</asp:Content>
