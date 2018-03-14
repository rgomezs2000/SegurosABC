<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebSegurosABC._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Seguros ABC</h1>
    </div>

    <div class="row">
        <div class="col-md-12">
            <asp:label runat="server"></asp:label>
            <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" />
            <br />
            <asp:label ID="lblInfo" runat="server"></asp:label>
        </div>
        <br />
        <div class="col-md-12">
            <h2>Historial de pagos</h2>
            <br />
            <div class="table-responsive">
                <asp:Table ID="tablaPagos" CssClass="table-stripped" runat="server"></asp:Table>
            </div>
        </div>
    </div>

</asp:Content>
