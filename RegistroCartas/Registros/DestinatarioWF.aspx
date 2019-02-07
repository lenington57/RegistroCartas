<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DestinatarioWF.aspx.cs" Inherits="RegistroCartas.Registros.DestinatarioWF" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>
    <div class="form-row justify-content-center">
        <aside class="col-sm-6">
            <div class="card">
                <div class="card-header text-uppercase text-center">Cuenta Bancaria</div>
                <article class="card-body">
                    <form>
                        <div class="col-md-6 col-md-offset-3">
                            <div class="container">
                                <div class="form-group">
                                    <asp:Label ID="Label3" runat="server" Text="Id"></asp:Label>
                                    <asp:Button class="btn btn-info btn-sm" ID="buscarButton" runat="server" Text="Buscar" OnClick="buscarButton_Click" />
                                    <asp:TextBox class="form-control" ID="destinatarioIdTextBox" type="number" Text="0" runat="server"></asp:TextBox>
                                  </div>
                            </div>
                        </div>
                        <div class="col-md-6 col-md-offset-3">
                            <div class="container">
                                <div class="form-group">
                                    <asp:Label ID="Label10" runat="server" Text="Fecha"></asp:Label>
                                    <asp:TextBox class="form-control" ID="fechaTextBox" type="date" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <!-- form-group// -->
                        <div class="col-md-6 col-md-offset-3">
                            <div class="container">
                                <div class="form-group">
                                    <asp:Label ID="Label4" runat="server" Text="Nombre Completo"></asp:Label>
                                    <asp:TextBox class="form-control" ID="nombresTextBox" placeholder="Nombre" runat="server"></asp:TextBox>
                                  </div>
                            </div>
                        </div>
                        <!-- form-group// -->
                        <!-- form-group// -->
                        <div class="col-md-6 col-md-offset-3">
                            <div class="container">
                                <div class="form-group">
                                    <asp:Label ID="Label1" runat="server" Text="Cantidad de Cartas"></asp:Label>
                                    <asp:TextBox class="form-control" ID="cantCartasTextBox" type="number" Text="0" runat="server"></asp:TextBox>
                                     </div>
                            </div>
                        </div>
                        <!-- form-group// -->
                        <div class="panel-footer">
                            <div class="text-center">
                                <div class="form-group" style="display: inline-block">
                                    <asp:Button Text="Nuevo" class="btn btn-dark btn-sm" runat="server" ID="nuevoButton" OnClick="nuevoButton_Click"/>
                                    <asp:Button Text="Guardar" class="btn btn-success btn-sm" runat="server" ID="guadarButton" OnClick="guadarButton_Click"/>
                                    <asp:Button Text="Eliminar" class="btn btn-danger btn-sm" runat="server" ID="eliminarButton" OnClick="eliminarButton_Click"/>
                                </div>
                            </div>
                        </div>
                        <!-- form-group// -->
                    </form>
                </article>
            </div>
            <!-- card.// -->
            <br>
    </div>
</div>
    </div>
</asp:Content>
