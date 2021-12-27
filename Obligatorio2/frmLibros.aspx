<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmLibros.aspx.cs" Inherits="Obligatorio2.frmLibros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <div class="col-md-4 col-md-offset-4">
                                <h1>ABM de libros</h1>
                            </div>
                        </header>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtId"><b>ID Libro</b></asp:Label><br />
                                        <asp:TextBox runat="server" Enabled="True" name="BrandName" ID="txtId" class="form-control input-sm" placeholder="ID Libro"></asp:TextBox>
                                     </div>
                                 </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtTitulo"><b>Titulo</b></asp:Label><br />
                                        <asp:TextBox runat="server" Enabled="True" name="BrandName" ID="txtTitulo" class="form-control input-sm" placeholder="Titulo"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtAnio"><b>Anio</b></asp:Label><br />
                                        <asp:TextBox runat="server" TextMode="Date" Enabled="True" name="BrandName" ID="txtAnio" class="form-control input-sm" placeholder="Anio "></asp:TextBox>
                                    </div>
                                 </div>
                                        <div class="col-md-4 col-md-offset-1">
                                            <div class="form-group">
                                                <asp:Label runat="server" AssociatedControlID="lstGeneroLibro" ><b>Genero</b></asp:Label><br />
                                                <asp:ListBox ID="lstGeneroLibro" Width="280px" runat="server"></asp:ListBox>
                                                
                                            </div>
                                        </div>
                                        </div>
                                        <div class="row">
                                        <div class="col-md-4 col-md-offset-1">
                                        <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="lstAutoresLibro"><b>Autor</b></asp:Label><br />
                                            <asp:ListBox ID="lstAutoresLibro" Width="280px" runat="server"></asp:ListBox>
                                        </div>
                                        </div>
                                        <div class="col-md-4 col-md-offset-1">
                                        <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtComentario"><b>Comentario</b></asp:Label><br />
                                        <asp:TextBox runat="server" Enabled="True" name="BrandName" ID="txtComentario" class="form-control input-sm" placeholder=" Comentario "></asp:TextBox>
    
                                        </div>
                                        </div>
                                        </div>

                                        <div class="row">
                                        <div class="col-md-4 col-md-offset-1">
                                        <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtPrecio"><b>Precio</b></asp:Label><br />
                                        <asp:TextBox runat="server" TextMode="Number" Enabled="True" name="BrandName" ID="txtPrecio" class="form-control input-sm" placeholder="Precio"></asp:TextBox>
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
                                            <asp:ListBox ID="lstLibro" runat="server" Width="322px" Rows="5"></asp:ListBox>
                                            <br/>
                                            <asp:Button Text="Seleccionar" ID="Seleccionar" CssClass=" btn-primary btn-sm" Width="100px" runat="server" OnClick="Seleccionar_Click"/>
                                        </div>
                                        </div>
                                        </div>
                                            <div class="col-md-4 col-md-offset-1">
                                        <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="lstLibrosOrdenados"><b>Libros Ordenados</b></asp:Label><br />
                                            <asp:ListBox ID="lstLibrosOrdenados" Width="322px" runat="server"></asp:ListBox>
                                            <asp:Button Text="Refresh" ID="Refresh" CssClass="btn btn-primary btn-sm" Width="220px" runat="server" OnClick="Refresh_Click" />

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