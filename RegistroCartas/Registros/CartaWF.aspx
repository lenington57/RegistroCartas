<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CartaWF.aspx.cs" Inherits="RegistroCartas.Registros.CartaWF" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>
    <div class="form-row justify-content-center">
        <aside class="col-sm-6">
            <div class="card">
                <div class="card-header text-uppercase text-center">Carta</div>
                <article class="card-body">
                    <form>
                        <div class="col-md-6 col-md-offset-3">
                            <div class="container">
                                <div class="form-group">
                                    <asp:Label ID="Label3" runat="server" Text="Id"></asp:Label>
                                    <asp:Button class="btn btn-info btn-sm" ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click1"/>
                                    <asp:TextBox class="form-control" ID="cartaIdTextBox" type="number" Text="0" runat="server" Width="111px"></asp:TextBox>
                                 </div>
                            </div>
                        </div>
                        <div class="col-md-6 col-md-offset-3">
                            <div class="container">
                                <div class="form-group">
                                    <asp:Label ID="Label10" runat="server" Text="Fecha"></asp:Label>
                                    <asp:TextBox class="form-control" ID="fechaTextBox" type="date" runat="server" Width="152px"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6 col-md-offset-3">
                            <div class="container">
                                <div class="form-group">
                                    <asp:Label ID="Label7" runat="server" Text="Destinatario"></asp:Label>
                                    <asp:DropDownList class="form-control" ID="destinatarioDropDownList" runat="server" Width="152px">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <!-- form-group// -->
                        <div class="col-md-6 col-md-offset-3">
                            <div class="container">
                                <div class="form-group">
                                    <asp:Label ID="Label4" runat="server" Text="Cuerpo de la Carta"></asp:Label>
                                    <asp:TextBox class="form-control" ID="cuerpoTextBox" runat="server" Height="252px" TextMode="MultiLine" Width="436px"></asp:TextBox>
                                 </div>
                            </div>
                        </div>
                        <!-- form-group// -->
                        <div class="panel-footer">
                            <div class="text-center">
                                <div class="form-group" style="display: inline-block">
                                    <asp:Button Text="Nuevo" class="btn btn-warning btn-sm" runat="server" ID="nuevoButton" OnClick="nuevoButton_Click1" />
                                    <asp:Button Text="Guardar" class="btn btn-success btn-sm" runat="server" ID="guadarButton" OnClick="guadarButton_Click1" />
                                    <asp:Button Text="Eliminar" class="btn btn-danger btn-sm" runat="server" ID="eliminarButton" OnClick="eliminarButton_Click1" />
                                </div>
                            </div>
                        </div>
                        <!-- form-group// -->
                    </form>
                </article>
            </div>
            <!-- card.// -->
    </div>
    </div>
</div>
    </div>
</div>
    </div>
</asp:Content>
