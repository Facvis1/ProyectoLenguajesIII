<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ProyectoLenguajesIII.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%--<%: Title %>.--%>Contacto.</h2>
    <h3>Tu pagina de contacto.</h3>
    <address>
       <%-- One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100--%>
    </address>

    <address>
        <strong>Correo de Contacto:</strong>   <a href="mailto:fakuvis@hotmail.com.ar">VacaClub@correo</a><br />
        <strong>Numero:</strong> <a>3886458944</a>
    </address>
</asp:Content>
