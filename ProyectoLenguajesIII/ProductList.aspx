<%@ Page Title="Menú" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
         CodeBehind="ProductList.aspx.cs" Inherits="ProyectoLenguajesIII.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%--<table>
        <tr>
            <td><asp:Label ID="LabelAddName" runat="server">Nombre:</asp:Label></td>
            <td ItemType="ProyectoLenguajesIII.Models.Product" SelectMethod="SearchBtn_Click">
                <asp:TextBox style="background-color: black" ID="SearchProductName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* Nombre del producto requerido." ControlToValidate="SearchProductName" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:Button style="background-color: #808080" ID="SearchBtn" runat="server" Text="Buscar" OnClick="SearchBtn_Click" SelectMEthod="PopulateDataGridView" />
            </td>
        </tr>
    </table>--%>


    <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>
    
    

    <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="true" DataSourceID="SqlDataSource2" DataTextField="CategoryName" DataValueField="CategoryName">
            <asp:ListItem Text="Seleccione categoria" Value="" />
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Vaca Club %>"
            SelectCommand="select distinct CategoryName from Products p inner join Categories c on c.CategoryID=p.CategoryID"></asp:SqlDataSource>
    <asp:Button ID="btnFilter" runat="server" Text="Filtrar" OnClick="btnFilter_Click" />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="btnSearch" runat="server" Text="Buscar" OnClick="btnSearch_Click" />
    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" GroupItemCount="5">
        <AlternatingItemTemplate>
             <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Eval("ProductID")%>">
                                        <img src="/Catalog/Images/thumbs/<%#:Eval("ImagePath")%>"
                                            width="300" height="200" style="border: solid" /></a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Eval("ProductID")%>">
                                        <span>
                                            <%#:Eval("ProductName")%>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Precio: </b><%#:String.Format("{0:c}", Eval("UnitPrice"))%>
                                    </span>
                                    <br />
                                    <a href="/AddToCart.aspx?productID=<%#:Eval("ProductID") %>">               
                                        <span class="ProductListItem">
                                            <b>Añadir al carrito<b>
                                        </span>           
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
        </AlternatingItemTemplate>
        <EditItemTemplate>
             <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Eval("ProductID")%>">
                                        <img src="/Catalog/Images/thumbs/<%#:Eval("ImagePath")%>"
                                            width="300" height="200" style="border: solid" /></a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Eval("ProductID")%>">
                                        <span>
                                            <%#:Eval("ProductName")%>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Precio: </b><%#:String.Format("{0:c}", Eval("UnitPrice"))%>
                                    </span>
                                    <br />
                                    <a href="/AddToCart.aspx?productID=<%#:Eval("ProductID") %>">               
                                        <span class="ProductListItem">
                                            <b>Añadir al carrito<b>
                                        </span>           
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="">
                <tr>
                    <td>No se encuentra el producto.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <EmptyItemTemplate>
            <td runat="server" />
        </EmptyItemTemplate>
        <GroupTemplate>
            <tr id="itemPlaceholderContainer" runat="server">
                <td id="itemPlaceholder" runat="server"></td>
            </tr>
        </GroupTemplate>
        <InsertItemTemplate>
             <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Eval("ProductID")%>">
                                        <img src="/Catalog/Images/thumbs/<%#:Eval("ImagePath")%>"
                                            width="300" height="200" style="border: solid" /></a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Eval("ProductID")%>">
                                        <span>
                                            <%#:Eval("ProductName")%>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Precio: </b><%#:String.Format("{0:c}", Eval("UnitPrice"))%>
                                    </span>
                                    <br />
                                    <a href="/AddToCart.aspx?productID=<%#:Eval("ProductID") %>">               
                                        <span class="ProductListItem">
                                            <b>Añadir al carrito<b>
                                        </span>           
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
        </InsertItemTemplate>
        <ItemTemplate>
             <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Eval("ProductID")%>">
                                        <img src="/Catalog/Images/thumbs/<%#:Eval("ImagePath")%>"
                                            width="300" height="200" style="border: solid" /></a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Eval("ProductID")%>">
                                        <span>
                                            <%#:Eval("ProductName")%>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Precio: </b><%#:String.Format("{0:c}", Eval("UnitPrice"))%>
                                    </span>
                                    <br />
                                    <a href="/AddToCart.aspx?productID=<%#:Eval("ProductID") %>">               
                                        <span class="ProductListItem">
                                            <b>Añadir al carrito<b>
                                        </span>           
                                    </a>
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
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                            <tr id="groupPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <%--<tr runat="server">
                    <td runat="server" style="">
                        <asp:DataPager ID="DataPager1" runat="server" PageSize="12">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                <asp:NumericPagerField />
                                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                            </Fields>
                        </asp:DataPager>
                    </td>
                </tr>--%>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
             <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Eval("ProductID")%>">
                                        <img src="/Catalog/Images/thumbs/<%#:Eval("ImagePath")%>"
                                            width="300" height="200" style="border: solid" /></a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Eval("ProductID")%>">
                                        <span>
                                            <%#:Eval("ProductName")%>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Precio: </b><%#:String.Format("{0:c}", Eval("UnitPrice"))%>
                                    </span>
                                    <br />
                                    <a href="/AddToCart.aspx?productID=<%#:Eval("ProductID") %>">               
                                        <span class="ProductListItem">
                                            <b>Añadir al carrito<b>
                                        </span>           
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
        </SelectedItemTemplate>

    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Vaca Club %>"
        SelectCommand="SELECT [ProductID], [ProductName], [UnitPrice], [CategoryName], [ImagePath] FROM Products p inner join Categories c on c.CategoryID=p.CategoryID WHERE ([ProductName] LIKE '%' + @ProductName + '%') AND (CategoryName = @CategoryName OR ISNULL(@CategoryName,'') = '')">
        <SelectParameters>
            <asp:ControlParameter ControlID="TextBox1" Name="ProductName" PropertyName="Text" Type="String" ConvertEmptyStringToNull="false" />
            <asp:ControlParameter ControlID="DropDownList1" Name="CategoryName" PropertyName="SelectedValue" Type="String" ConvertEmptyStringToNull="false" />
        </SelectParameters>
    </asp:SqlDataSource>

    <section>
<%--        aqui comence a cambiar--%>



       <%-- <div class="products__header">
            <div class="search-box">
                <input autofocus="" placeholder="Buscar productos" class="search ng-pristine ng-valid ng-touched">

                <!---->
            </div>
            <select class="ng-untouched ng-pristine ng-valid">
                    <option selected="" value="0: null">Todas las categorías
                    </option>
                <option disabled="" class="separator"></option><optgroup label="Categorías"><!----><!----><!----><option value="2: 10">Bebidas</option><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><!----><option value="3: 12">Platos Principales</option><!----><option value="4: 14"> &nbsp;&nbsp;&nbsp;Aves </option><!----><option value="5: 39"> &nbsp;&nbsp;&nbsp;Calzones </option><!----><option value="6: 15"> &nbsp;&nbsp;&nbsp;Carnes </option><!----><option value="7: 45"> &nbsp;&nbsp;&nbsp;Cerdo </option><!----><option value="8: 16"> &nbsp;&nbsp;&nbsp;Empanadas </option><!----><option value="9: 17"> &nbsp;&nbsp;&nbsp;Ensaladas </option><!----><option value="10: 19"> &nbsp;&nbsp;&nbsp;Guarniciones </option><!----><option value="11: 20"> &nbsp;&nbsp;&nbsp;Pastas </option><!----><option value="12: 21"> &nbsp;&nbsp;&nbsp;Pescados </option><!----><option value="13: 22"> &nbsp;&nbsp;&nbsp;Pizzas </option><!----><option value="14: 23"> &nbsp;&nbsp;&nbsp;Sandwiches </option><!----><!----><!----><option value="15: 13">Postres</option><!----><!----><!----><!----><!----><!----><!----></optgroup></select></div>
 --%>
     <%--adasdasdasd--%>

        <%--<div id="CategoryMenu" style="text-align: center">       
            <asp:ListView ID="categoryList"  
                ItemType="ProyectoLenguajesIII.Models.Category" 
                runat="server"
                SelectMethod="GetCategories" >
                <ItemTemplate>
                    <b style="font-size: large; font-style: normal">
                        <a href="/ProductList.aspx?id=<%#: Item.CategoryID %>">
                        <%#: Item.CategoryName %>
                        </a>
                    </b>
                </ItemTemplate>
                <ItemSeparatorTemplate>  |  </ItemSeparatorTemplate>
            </asp:ListView>
        </div>--%>
<%--        hasta aqui--%>



  <%--      <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>

            <asp:ListView ID="productList" runat="server" 
                DataKeyNames="ProductID" GroupItemCount="2"
                ItemType="ProyectoLenguajesIII.Models.Product" SelectMethod="GetProducts">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No se devolvieron datos.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
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
                                    <a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">
                                        <img src="/Catalog/Images/thumbs/<%#:Item.ImagePath%>"
                                            width="300" height="200" style="border: solid" /></a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">
                                        <span>
                                            <%#:Item.ProductName%>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Precio: </b><%#:String.Format("{0:c}", Item.UnitPrice)%>
                                    </span>
                                    <br />
                                    <a href="/AddToCart.aspx?productID=<%#:Item.ProductID %>">               
                                        <span class="ProductListItem">
                                            <b>Añadir al carrito<b>
                                        </span>           
                                    </a>
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
                    <table style="width:100%;">
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
        </div>--%>
    </section>
</asp:Content>