<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmLector.aspx.cs" Inherits="Obligatorio2.frmLector" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <div class="col-md-4 col-md-offset-4">
                                <h1>ABM de Lectores</h1>
                            </div>
                        </header>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtId"><b>ID Autor</b></asp:Label><br />
                                        <asp:TextBox runat="server" Enabled="True" name="BrandName" ID="txtId" class="form-control input-sm" placeholder="ID Autor"></asp:TextBox>
                                     </div>
                                 </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtApellido"><b>Apellido</b></asp:Label><br />
                                        <asp:TextBox runat="server" Enabled="True" name="BrandName" ID="txtApellido" class="form-control input-sm" placeholder="Apellido"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtNombre"><b>Nombre</b></asp:Label><br />
                                        <asp:TextBox runat="server" Enabled="True" name="BrandName" ID="txtNombre" class="form-control input-sm" placeholder="Nombre"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                        

                                    
                                      
                                        <div class="row">
                                        <div class="col-md-10 col-md-offset-1">
                                        <div class="form-group">
                                        <asp:Button Text="Guardar" ID="btnAlta"  CssClass="btn btn-success btn-lg" Width="220px" runat="server" OnClick="btnAlta_Click" />
                                        <asp:Button Text="Actualizar" ID="btnModificar"  CssClass="btn btn-primary btn-lg" Width="220px" runat="server" OnClick="btnModificar_Click" />
                                        <asp:Button Text="Eliminar" ID="btnBaja"  CssClass="btn btn-danger btn-lg" Width="220px" runat="server" OnClick="btnBaja_Click" />
                                        <asp:Button Text="Limpiar" ID="btnLimpiar" CssClass="btn btn-warning btn-lg" Width="220px" runat="server" OnClick="btnLimpiar_Click1"  />

                                        <asp:Label Text="" ForeColor="Green" Font-Bold="true" ID="lblMensaje" CssClass="label label-success" runat="server" />
                                        </div>
                                        </div>
        
                                        </div>
                                        <div class="row">
                                        <div class="col-md-10 col-md-offset-1">
                                        <div class="form-group">
                                        <div class="table-responsive">
                                             <asp:ListBox ID="lstLectores" runat="server" Width="322px"></asp:ListBox>
                                             <br />
                                             <asp:Button Text="Seleccionar" ID="Button1" OnClick="btnSeleccionar_Click" CssClass=" btn-primary btn-sm" Width="100px" runat="server" />
                                        </div>
                                        </div>
                                        </div>
                                        </div>
    
                                        </div>
                                        </section>
                                        </div>
                                        </div>
                                        </section>
                                        </section>

</asp:Content>
