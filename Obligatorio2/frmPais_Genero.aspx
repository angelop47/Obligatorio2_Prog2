<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmPais_Genero.aspx.cs" Inherits="Obligatorio2.Pais_Genero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <div class="col-md-4 col-md-offset-4">
                                <h1>ABM de Paises</h1>
                            </div>
                        </header>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtIdPais"><b>ID Autor</b></asp:Label><br />
                                        <asp:TextBox runat="server" Enabled="True" name="BrandName" ID="txtIdPais" class="form-control input-sm" placeholder="ID Autor"></asp:TextBox>
                                     </div>
                                 </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtNombrePais"><b>Nombre Pais</b></asp:Label><br />
                                        <asp:TextBox runat="server" Enabled="True" name="BrandName" ID="txtNombrePais" class="form-control input-sm" placeholder="Nombre Pais"></asp:TextBox>
                                    </div>
                                </div>
                            </div>                 
                            <div class="row">
                                <div class="col-md-10 col-md-offset-1">
                                     <div class="form-group">
                                        <asp:Button Text="Guardar" ID="btnAltaPais"  CssClass="btn btn-success btn-lg" Width="220px" runat="server" OnClick="btnAltaPais_Click"  />
                                        <asp:Button Text="Actualizar" ID="btnModificarPais"  CssClass="btn btn-primary btn-lg" Width="220px" runat="server" OnClick="btnModificarPais_Click"  />
                                        <asp:Button Text="Eliminar" ID="btnBajaPais"  CssClass="btn btn-danger btn-lg" Width="220px" runat="server" OnClick="btnBajaPais_Click"  />
                                        <asp:Button Text="Limpiar" ID="btnLimpiarPais" CssClass="btn btn-warning btn-lg" Width="220px" runat="server" OnClick="btnLimpiarPais_Click"   />

                                        <asp:Label Text="" ForeColor="Green" Font-Bold="true" ID="lblMensaje" CssClass="label label-success" runat="server" />
                                    </div>
                               </div>  
                           </div>
                           <div class="row">
                              <div class="col-md-10 col-md-offset-1">
                                 <div class="form-group">
                                    <div class="table-responsive">
                                       <asp:ListBox ID="lstPaises" runat="server" Width="322px"></asp:ListBox>
                                        <br />
                                        <asp:Button Text="Seleccionar Pais" ID="SeleccionarPais" CssClass=" btn-primary btn-sm" Width="150px" runat="server" />
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
         
    <section id="main-content1">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <div class="col-md-4 col-md-offset-4">
                                <h1>ABM de Genero</h1>
                            </div>
                        </header>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtIdGenero"><b>ID Autor</b></asp:Label><br />
                                        <asp:TextBox runat="server" Enabled="True" name="BrandName" ID="txtIdGenero" class="form-control input-sm" placeholder="ID Autor"></asp:TextBox>
                                     </div>
                                 </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtNombreGenero"><b>Genero</b></asp:Label><br />
                                        <asp:TextBox runat="server" Enabled="True" name="BrandName" ID="txtNombreGenero" class="form-control input-sm" placeholder="Genero"></asp:TextBox>
                                    </div>
                                </div>
                     
                            </div>
            
                            <div class="row">
                                <div class="col-md-10 col-md-offset-1">
                                     <div class="form-group">
                                        <asp:Button Text="Guardar" ID="btnAltaGenero"  CssClass="btn btn-success btn-lg" Width="220px" runat="server" OnClick="btnAltaGenero_Click"  />
                                        <asp:Button Text="Actualizar" ID="btnModificarGenero"  CssClass="btn btn-primary btn-lg" Width="220px" runat="server" OnClick="btnModificarGenero_Click"  />
                                        <asp:Button Text="Eliminar" ID="btnBajaGenero"  CssClass="btn btn-danger btn-lg" Width="220px" runat="server" OnClick="btnBajaGenero_Click"  />
                                        <asp:Button Text="Limpiar" ID="btnLimpiarGenero" CssClass="btn btn-warning btn-lg" Width="220px" runat="server" OnClick="btnLimpiarGenero_Click"  />

                                        <asp:Label Text="" ForeColor="Green" Font-Bold="true" ID="lblMensajeGenero" CssClass="label label-success" runat="server" />
                                    </div>
                               </div>  
                           </div>
                           <div class="row">
                              <div class="col-md-10 col-md-offset-1">
                                 <div class="form-group">
                                    <div class="table-responsive">
                                       <asp:ListBox ID="lstGenero" runat="server" Width="322px"></asp:ListBox>
                                        <br />
                                        <asp:Button Text="Seleccionar Genero" ID="SeleccionarGenero"  CssClass=" btn-primary btn-sm" Width="150px" runat="server" />
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
