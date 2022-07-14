<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="ProyectoLenguajesIII.Admin.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Administracion</h1>
    <hr />
    <h3>Añadir Producto:</h3>
    <table>
        <tr>
            <td><asp:Label ID="LabelAddCategory" runat="server">Categoria:</asp:Label></td>
            <td>
                <asp:DropDownList style="background-color: black" ID="DropDownAddCategory" runat="server" 
                    ItemType="ProyectoLenguajesIII.Models.Category" 
                    SelectMethod="GetCategories" DataTextField="CategoryName" 
                    DataValueField="CategoryID" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddName" runat="server">Nombre:</asp:Label></td>
            <td>
                <asp:TextBox style="background-color: black" ID="AddProductName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* Nombre del producto requerido." ControlToValidate="AddProductName" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddDescription" runat="server">Descripcion:</asp:Label></td>
            <td>
                <asp:TextBox style="background-color: black" ID="AddProductDescription" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="* Descripcion requerida." ControlToValidate="AddProductDescription" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddPrice" runat="server">Precio:</asp:Label></td>
            <td>
                <asp:TextBox style="background-color: black" ID="AddProductPrice" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Text="* Precio requerido." ControlToValidate="AddProductPrice" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Text="* Must be a valid price without $." ControlToValidate="AddProductPrice" SetFocusOnError="True" Display="Dynamic" ValidationExpression="^[0-9]*(\.)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddImageFile" runat="server">Archivo de imagen:</asp:Label></td>
            <td>
                <asp:FileUpload ID="ProductImage" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="* Ruta de la imagen requerida." ControlToValidate="ProductImage" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button ID="AddProductButton" runat="server" Text="Añadir Producto" OnClick="AddProductButton_Click"  CausesValidation="true"/>
    <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
    <p></p>
    <h3>Remover Producto:</h3>
    <table>
        <tr>
            <td><asp:Label ID="LabelRemoveProduct" runat="server">Producto:</asp:Label></td>
            <td><asp:DropDownList style="background-color: black" ID="DropDownRemoveProduct" runat="server" ItemType="ProyectoLenguajesIII.Models.Product" 
                    SelectMethod="GetProducts" AppendDataBoundItems="true" 
                    DataTextField="ProductName" DataValueField="ProductID" >
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <p></p>
    <asp:Button ID="RemoveProductButton" runat="server" Text="Remover Producto" OnClick="RemoveProductButton_Click" CausesValidation="false"/>
    <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label>

    <%--<div class="row">
        <div class="col-md-4 order-md-2 mb-4">
      <h4 class="d-flex justify-content-between align-items-center mb-3">
        <span class="text-muted">Ordenes realizadas</span>
<%--        <span class="badge badge-secondary badge-pill">3</span>--%>
     <%-- </h4>
      <ul class="list-group mb-3">
        <li class="list-group-item d-flex justify-content-between ">--%>


            <%--<asp:SqlDataSource ID="Orders" runat="server"
                ConnectionString="Data Source=|DataDirectory|\Vaca Club (ProyectoLenguajesIII)"
                ProviderName="System.Data.Odbc"
                SelectCommand="SELECT [OrderId], [OrderDate], [Username], [FirstName], [LastName], [Address], [Phone], [Email], [Preferences], [Total] from Orders">

            </asp:SqlDataSource>

            <asp:GridView ID="OrderList" runat="server" AutoGenerateColumns="False" DataKeyNames="id"
                DatasourceID="Orders" Width="340"  BorderStyle="None">
                <Columns>
                    <asp:BoundField DataField="OrderId" HeaderText="Id" />
                    <asp:BoundField DataField="OrderDate" HeaderText="Fecha" />
                    <asp:BoundField DataField="Username" HeaderText="Usuario" />
                    <asp:BoundField DataField="FirstName" HeaderText="Nombre" />
                    <asp:BoundField DataField="LastName" HeaderText="Apellido" />
                    <asp:BoundField DataField="Address" HeaderText="Direccion" />
                    <asp:BoundField DataField="Phone" HeaderText="Telefono" />
                    <asp:BoundField DataField="Email" HeaderText="Correo" />
                    <asp:BoundField DataField="Preferences" HeaderText="Ac. del Pedido" />
                    <asp:BoundField DataField="Total" HeaderText="Total" />                  
                </Columns>
            </asp:GridView>--%>

            
      
           <%--<asp:GridView ID="OrderItemList1" runat="server" AutoGenerateColumns="False" Width="1000"  BorderStyle="None">              
            <Columns>

                    <asp:BoundField DataField="OrderId" HeaderText="Id" />
                    <asp:BoundField DataField="OrderDate" HeaderText="Fecha" />
                    <asp:BoundField DataField="Username" HeaderText="Usuario" />
                    <asp:BoundField DataField="FirstName" HeaderText="Nombre" />
                    <asp:BoundField DataField="LastName" HeaderText="Apellido" />
                    <asp:BoundField DataField="Address" HeaderText="Direccion" />
                    <asp:BoundField DataField="Phone" HeaderText="Telefono" />
                    <asp:BoundField DataField="Email" HeaderText="Correo" />
                    <asp:BoundField DataField="TotalOrden" HeaderText="Total de la orden" />
                    <asp:BoundField DataField="Preferences" HeaderText="Ac. del Pedido" />--%>
                    <%--<asp:BoundField DataField="Total" HeaderText="Total" /> --%>

                <%--<asp:BoundField DataField="Product.ProductName" HeaderText="Producto" />
                <asp:BoundField ItemStyle-CssClass="text-muted" DataField="Quantity" HeaderText="Cantidad"/>   
            <asp:BoundField ItemStyle-HorizontalAlign="Right" ItemStyle-CssClass="text-muted" DataField="Product.UnitPrice" DataFormatString="{0:c}" HeaderText="Precio U."/>--%>     
               
            </Columns>   
        </asp:GridView>

            <h5 class="d-flex justify-content-between align-items-center mb-3">
        <%--<span class="text-muted">Detalles de las Ordenes:</span>--%>
<%--        <span class="badge badge-secondary badge-pill">3</span>--%>
      </h5>
            <%--//Aqui Tambien cambie--%>
                
                <%--<asp:BoundField ItemStyle-CssClass="text-muted" DataField="Quantity" HeaderText="Cantidad"/>   
            <asp:BoundField ItemStyle-HorizontalAlign="Right" ItemStyle-CssClass="text-muted" DataField="Product.UnitPrice" DataFormatString="{0:c}" HeaderText="Precio U."/>--%>     
               
            <%--</Columns>   
        </asp:GridView> --%>

        </li>
             
        <%--<li class="list-group-item d-flex justify-content-between">
                    <span>Total a pagar</span>
                    <strong> 
                        <asp:Label ID="lblTotalca" runat="server" EnableViewState="false" Font-Bold="true"></asp:Label>
                    </strong>
                </li>--%>
      <%--</ul>     
    </div>
        </div>--%>
    <div>
        
    </div>

    <div>
        <td><h3>Seleccionar Cadete:</h3>
                <asp:DropDownList style="background-color: black" ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" 
                     >
                    <asp:ListItem>cadete1@gmail.com</asp:ListItem>
                    <asp:ListItem>cadete2@gmail.com</asp:ListItem>
                </asp:DropDownList>
            </td>
            <h1>Ordenes Pendientes:</h1>
        <asp:GridView class="table thead-dark" ID="tablatrans" runat="server" AutoGenerateColumns="true" ShowHeaderWhenEmpty="true">
            <Columns>
                <asp:TemplateField HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:ImageButton ID="imgbtn1" Visible="true" ImageUrl="~/Images/ace.png" runat="server" ValidationGroup="bg1" CommandArgument='<%#Eval("OrderId") + "," +Eval("Username")%>' OnClick="Aceptar_Click" ToolTip="Aceptar" Width="25px" Height="25px"/>
                        <asp:ImageButton ID="imgbtn2" ImageUrl="~/Images/can.png" runat="server" ValidationGroup="bg1" CommandArgument='<%#Eval("OrderId") + "," +Eval("Username")%>' OnClick="Rechazar_Click" ToolTip="Rechazar" Width="25px" Height="25px"/>
                        <%--<asp:Button ID="Aceptar" style="background-color: #00ff21" Visible="true"  runat="server" CommandArgument='<%#Eval("OrderId") + "," +Eval("Username")%>' Text="Aceptar" OnClick="Aceptar_Click" Width="25px" Height="25px"/>
                        <asp:Button ID="Rechazar" style="background-color: #ff0000" runat="server"  CommandArgument='<%#Eval("OrderId") + "," +Eval("Username")%>' Text="Rechazar" OnClick="Rechazar_Click" Width="25px" Height="25px"/>--%>
                    </ItemTemplate>
                    <EditItemTemplate>

                    </EditItemTemplate>
                    <FooterTemplate>

                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
            <h1>Ordenes Aceptadas:</h1>
                    <asp:GridView class="table thead-dark" ID="tablatrans2" runat="server" AutoGenerateColumns="true" ShowHeaderWhenEmpty="true">
        </asp:GridView>
        <h1>Ordenes Enviadas:</h1>
                    <asp:GridView class="table thead-dark" ID="tablatransenv" runat="server" AutoGenerateColumns="true" ShowHeaderWhenEmpty="true">
        </asp:GridView>
        <h1>Ordenes Entregadas:</h1>
                    <asp:GridView class="table thead-dark" ID="tablatransent" runat="server" AutoGenerateColumns="true" ShowHeaderWhenEmpty="true">
        </asp:GridView>
         <h1>Ordenes Rechazadas:</h1>
                    <asp:GridView class="table thead-dark" ID="GridView1" runat="server" AutoGenerateColumns="true" ShowHeaderWhenEmpty="true">
        </asp:GridView>
    </div>
<%-- <h1>Administration</h1>
    <hr />
    <h3>Add Servicio:</h3>
    <table>
        <tr>
            <td><asp:Label ID="LabelAddTipo" runat="server">Tipo:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownAddTipo" runat="server" 
                    ItemType="WebApplication1.Models.Tipo" 
                    SelectMethod="GetTipos" DataTextField="TipoNombre" 
                    DataValueField="TipoID" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddName" runat="server">Name:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddServicioNombre" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* Servicio name required." ControlToValidate="AddServicioNombre" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddDescription" runat="server">Description:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddServicioDescripcion" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="* Description required." ControlToValidate="AddServicioDescripcion" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddPrice" runat="server">Price:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddServicioPrice" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Text="* Price required." ControlToValidate="AddServicioPrice" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Text="* Must be a valid price without $." ControlToValidate="AddServicioPrice" SetFocusOnError="True" Display="Dynamic" ValidationExpression="^[0-9]*(\.)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddImageFile" runat="server">Image File:</asp:Label></td>
            <td>
                <asp:FileUpload ID="ServicioImage" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="* Image path required." ControlToValidate="ServicioImage" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button ID="AddServicioButton" runat="server" Text="Add Servicio" OnClick="AddServicioButton_Click"  CausesValidation="true"/>
    <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
    <p></p>
    <h3>Remove Servicio:</h3>
    <table>
        <tr>
            <td><asp:Label ID="LabelRemoveServicio" runat="server">Servicio:</asp:Label></td>
            <td><asp:DropDownList ID="DropDownRemoveServicio" runat="server" ItemType="WebApplication1.Models.Servicio" 
                    SelectMethod="GetServicios" AppendDataBoundItems="true" 
                    DataTextField="ServicioNombre" DataValueField="ServicioID" >
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <p></p>
    <asp:Button ID="RemoveServicioButton" runat="server" Text="Remove Servicio" OnClick="RemoveServicioButton_Click" CausesValidation="false"/>
    <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label>--%>

    <div>
        <asp:Button runat="server" ValidationGroup="bg1" ID="Btorddet" OnClick="Btorddet_Click" Text="Mostrar Detalles de las Ordenes" />
            <asp:Button runat="server" ValidationGroup="bg1" ID="Btorddet1" OnClick="Btorddet1_Click" Text="Ocultar Detalles de las Ordenes" />
            

            <asp:GridView ID="OrderItemList2" runat="server" AutoGenerateColumns="False" Width="500"  BorderStyle="Dashed" Visible="false">              
            <Columns>
                    <%--<asp:BoundField DataField="OrderDetailId" HeaderText="Id" />--%>
                    <asp:BoundField DataField="OrderId" HeaderText="Id Orden" />
                    <%--<asp:BoundField DataField="Username" HeaderText="Usuario" />--%>
                    <asp:BoundField DataField="ProductId" HeaderText="Id del Producto" />
                    <asp:BoundField DataField="Username" HeaderText="Nombre del usuario" />
                    <asp:BoundField DataField="Quantity" HeaderText="Cantidad" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="Precio Unitario" />
                    <asp:BoundField DataField="ProductName" HeaderText="Nombre del Producto" />
                    <asp:BoundField DataField="Totalprod" HeaderText="Total" />
            </Columns>
            </asp:GridView>
    </div>

    
    <%--<h3>Seleccionar Cadete:</h3>
    <table>
        <tr>
            <td><asp:Label ID="Label1" runat="server">Categoria:</asp:Label></td>
            <td>
                <asp:DropDownList style="background-color: black" ID="DropDownListcad" runat="server" 
                    ItemType="ProyectoLenguajesIII.Models.Category" 
                    SelectMethod="GetCategories" DataTextField="CategoryName" 
                    DataValueField="CategoryID" >
                </asp:DropDownList>
            </td>
        </tr>--%>

<%--<div>
<iframe src="https://www.google.com/maps/d/u/0/embed?mid=1fGkBn0_AYwic3pTthxkqtE4MQ_4u7Ac&ehbc=2E312F" width="1200" height="600" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>

</div>--%>

</asp:Content>