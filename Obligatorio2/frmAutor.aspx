<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmAutor.aspx.cs" Inherits="Obligatorio2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <div class="col-md-4 col-md-offset-4">
                                <h1>ABM de Autores</h1>
                            </div>
                        </header>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtId"><b>ID Autor</b></asp:Label><br />
                                        <asp:TextBox runat="server"  Enabled="True" name="BrandName" ID="txtId" class="form-control input-sm" placeholder="ID Autor"></asp:TextBox>

                                     </div>
                                 </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtNombre"><b>Nombre</b></asp:Label><br />
                                        <asp:TextBox runat="server"  Enabled="True" name="BrandName" ID="txtNombre" class="form-control input-sm" placeholder="Nombre"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtApellido"><b>Apellido</b></asp:Label><br />
                                        <asp:TextBox runat="server"  Enabled="True" name="BrandName" ID="txtApellido" class="form-control input-sm" placeholder="Apellido"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtNacionalidad"><b>Nacionalidad</b></asp:Label><br />
                                        <asp:TextBox runat="server"  Enabled="True" name="BrandName" ID="txtNacionalidad" class="form-control input-sm" placeholder="Nacionalidad"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtAnioNac"><b>Fecha Nacimiento</b></asp:Label><br />
                                        <asp:TextBox runat="server"  TextMode="Date" Enabled="True" name="BrandName" ID="txtAnioNac" class="form-control input-sm" placeholder="Anio Nacimiento"></asp:TextBox>
                                    </div>
                                 </div>
                                 <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtAnioFall"><b>Fecha Fallecimiento</b></asp:Label><br />
                                        <asp:TextBox runat="server"  TextMode="Date" Enabled="True" name="BrandName" ID="txtAnioFall" class="form-control input-sm" placeholder="Anio Fallecimiento"></asp:TextBox>
                                    </div>
                                 </div>    
                                        </div>                                                                            
                                        <div class="row">
                                        <div class="col-md-10 col-md-offset-1">
                                        <div class="form-group">
                                        <asp:Button Text="Guardar" ID="btnAlta" OnClick="btnsave_Click" CssClass="btn btn-success btn-lg" Width="220px" runat="server" />
                                        <asp:Button Text="Actualizar" ID="btnModificar" OnClick="btnupdate_Click" CssClass="btn btn-primary btn-lg" Width="220px" runat="server" />
                                        <asp:Button Text="Eliminar" ID="btnBaja" OnClick="btndlt_Click" CssClass="btn btn-danger btn-lg" Width="220px" runat="server" />
                                        <asp:Button Text="Limpiar" ID="btnLimpiar" OnClick="btnLimpiar_Click" CssClass="btn btn-warning btn-lg" Width="220px" runat="server" />

                                        <asp:Label Text="" ForeColor="Green" Font-Bold="true" ID="lblMensaje" CssClass="label label-success" runat="server" />
                                        </div>
                                        </div>
        
                                        </div>
                                        <div class="row">
                                        <div class="col-md-10 col-md-offset-1">
                                        <div class="form-group">
                                        <div class="table-responsive">
                                            <asp:ListBox ID="lstAutores" runat="server" Width="322px"></asp:ListBox>
                                            <br/>
                                            <asp:Button Text="Seleccionar" ID="SeleccionarAutor" CssClass=" btn-primary btn-sm" Width="100px" runat="server" OnClick="SeleccionarAutor_Click"/>
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
