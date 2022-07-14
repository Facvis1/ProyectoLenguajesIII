<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PagoCard.aspx.cs" Inherits="ProyectoLenguajesIII.Checkout.PagoCard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
	<%--<title>Animaciòn a un Input con Html y Css | SLee Dw</title>--%>
	<link rel="stylesheet" href="estilos.css">
    <div class="container">
   
    <div class="row">
        
        <div class="col-md-8 order-md-1">
            <h4 class="mb-3">Informacion </h4>
            <form class="needs-validation" novalidate="">
                <div class="row">
                    <div class="col-md-6 mb-3">
                        <label for="firstName">Nombre</label>
                        <asp:TextBox runat="server" class="form-control" id="firstName" placeholder="" value="" required=""/>                        
                        <div class="invalid-feedback"></div>
                    </div>


                    <div class="col-md-6 mb-3">
                        <label for="lastName">Apellido</label>
                        <asp:TextBox runat="server" class="form-control" id="lastName" placeholder="" value="" required=""/>
                        
                        <div class="invalid-feedback"></div>
                    </div>

                   

                    <div class="col-md-6 mb-3">
                    <label for="email">Email </label>
                    <asp:TextBox runat="server" type="email" class="form-control" id="email" placeholder="" value="" required=""/>       
                    <div class="invalid-feedback"></div>
                </div>
                <div class="col-md-6 mb-3">
                    <label for="address">Direccion</label>     
                    <asp:TextBox runat="server" type="text" class="form-control" id="address" placeholder="" value="" required=""/>       
                    <div class="invalid-feedback"></div>
                </div>

                 <div class="col-md-6 mb-3">
                    <label for="phone">Telefono</label>     
                    <asp:TextBox runat="server" type="text" class="form-control" id="phone" placeholder="" value="" required=""/>       
                    <div class="invalid-feedback"></div>
                </div>
                </div>
                
                 
              
                
               
                <div class="custom-control custom-checkbox">
                    <input type="checkbox" class="custom-control-input" id="save-info">
                    <label class="custom-control-label" for="save-info">Guardar la informacion.</label>
                </div>

                <hr class="mb-4">
                
                <div >
                        <label for="preferences">¿Quieres aclarar algo del pedido?</label>
                        <asp:TextBox runat="server" class="form-control" id="preferencias" placeholder="Carne mas cocida, papas sin sal, etc." value="" />
                        
                        <%--<div class="invalid-feedback"> Apellido requerido. </div>--%>
                    </div>
                

                <hr class="mb-4">
                <h4 class="mb-3">Pago</h4>


                <div class="d-block my-3">
                   
                 
                </div>
                <div class="row">
                    <div class="col-md-6 mb-3">
                        <label for="cc-name">Nombre en la tarjeta</label>
                        <asp:TextBox runat="server" type="text" class="form-control" id="ccname" placeholder="" required=""/>                     
                        <small class="text-muted"></small>
                        <div class="invalid-feedback"></div>
                    </div>
                    <div class="col-md-6 mb-3">
                        <label for="cc-number">Numero de tarjeta</label>
                         <asp:TextBox runat="server" class="form-control" id="ccnumber" placeholder="" required=""/>
                       
                        <div class="invalid-feedback"></div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6 mb-3">
                        <label for="cc-expiration">Expiracion</label>
                         <asp:TextBox runat="server" class="form-control" id="ccexpiration" placeholder="05/22" required=""/>
                        
                        <div class="invalid-feedback"></div>
                    </div>
                    <div class="col-md-6 mb-3">
                        <label for="cc-cvv">CVV</label>
                        <asp:TextBox runat="server" class="form-control" id="cccvv" placeholder="132" required=""/>
               
                        <div class="invalid-feedback"></div>
                    </div>
                </div>
                <div class="mb-4">
      <h4 class="d-flex justify-content-between align-items-center mb-3">
        <span class="text-muted">Carrito</span>
<%--        <span class="badge badge-secondary badge-pill">3</span>--%>
      </h4>
      <ul class="list-group mb-3">
        <li class="list-group-item d-flex justify-content-between ">    
      
            <asp:GridView ID="OrderItemList" runat="server" AutoGenerateColumns="False" Width="500"  BorderStyle="None">              
            <Columns>

                <asp:BoundField DataField="Product.ProductName" HeaderText="Producto" />
                <asp:BoundField ItemStyle-CssClass="text-muted" DataField="Quantity" HeaderText="Cantidad"/>   
            <asp:BoundField ItemStyle-HorizontalAlign="Right" ItemStyle-CssClass="text-muted" DataField="Product.UnitPrice" DataFormatString="{0:c}" HeaderText="Precio U."/>     
               
            </Columns>   
        </asp:GridView> 

        </li>
             
        <li class="list-group-item d-flex justify-content-between">
                    <span>Total a pagar</span>
                    <strong> 
                        <asp:Label ID="lblTotalca" runat="server" EnableViewState="false" Font-Bold="true"></asp:Label>
                    </strong>
                </li>
      </ul>     
    </div>
                <hr class="mb-4">
                <asp:Button runat="server" ID="cardbtn" OnClick="cardbtn_Click" Text="COMPRAR" />

                <asp:Label runat="server" ID="lblcard" Text=""/>
            </form>             
        </div>
    </div>

</div>
</asp:Content>

