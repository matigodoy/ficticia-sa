<%@ Page Title="" Language="C#" MasterPageFile="~/estatico/paginas/signedin.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="ABMC.estatico.paginas.Personas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="Desafio técnico para Bitsion" />
    <meta name="author" content="Godoy Matias" />
    <link href="../img/logoipsum-logo-50.svg" rel="icon" type="image/x-icon" />
    <title>Ficticia - Personas</title>

    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            user-select: none;
        }

        @media (min-width: 768px) {
            .bd-placeholder-img-lg {
                font-size: 3.5rem;
            }
        }

        .b-example-divider {
            height: 3rem;
            background-color: rgba(0, 0, 0, .1);
            border: solid rgba(0, 0, 0, .15);
            border-width: 1px 0;
            box-shadow: inset 0 .5em 1.5em rgba(0, 0, 0, .1), inset 0 .125em .5em rgba(0, 0, 0, .15);
        }

        .b-example-vr {
            flex-shrink: 0;
            width: 1.5rem;
            height: 100vh;
        }

        .bi {
            vertical-align: -.125em;
            fill: currentColor;
        }

        .nav-scroller {
            position: relative;
            z-index: 2;
            height: 2.75rem;
            overflow-y: hidden;
        }

            .nav-scroller .nav {
                display: flex;
                flex-wrap: nowrap;
                padding-bottom: 1rem;
                margin-top: -1px;
                overflow-x: auto;
                text-align: center;
                white-space: nowrap;
                -webkit-overflow-scrolling: touch;
            }
    </style>


    <!-- Custom styles for this template -->
    <link href="../css/heroes.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <main>

        <!-- Modal Persona -->
        <asp:HiddenField ID="hfIDSeleccionado" runat="server" />
        <div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <asp:UpdatePanel ID="upModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                    <ContentTemplate>
                        <div class="modal-content">
                            <div class="modal-header">
                                <h5 class="modal-title" id="H1" runat="server">
                                    <asp:Label ID="lblModalTitle" runat="server" Text=""></asp:Label></h5>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <div class="modal-body">
                                <div class="col-md-12">
                                    <label class="form-label">Apellido y Nombres (*)</label>
                                    <asp:TextBox type="text" ID="leNombre" runat="server" CssClass="form-control" autocomplete="nope" AutoCompleteType="Disabled"></asp:TextBox>
                                </div>
                                <div class="col-md-12">
                                    <label class="form-label">Identificacion (*)</label>
                                    <asp:TextBox type="text" ID="leIdentificacion" runat="server" CssClass="form-control" autocomplete="nope" AutoCompleteType="Disabled"></asp:TextBox>
                                </div>
                                <div class="col-md-12">
                                    <label class="form-label">Edad</label>
                                    <asp:TextBox type="tel" ID="leEdad" runat="server" CssClass="form-control"  autocomplete="nope" TextMode="Number"></asp:TextBox>
                                </div>
                                <div class="col-md-12">
                                    <label class="form-label" >Genero</label>
                                    <asp:DropDownList ID="ddlGenero" name="Genero" runat="server" CssClass="form-control" >
                                        <asp:ListItem Enabled="true" Text="Seleccione un género" Value= “-1”></asp:ListItem>
                                        <asp:ListItem Text="Femenino" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Masculino" Value="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-12">
                                    <label class="form-label" >Estado</label>
                                    <asp:DropDownList ID="ddlEstado" name="Genero" runat="server" CssClass="form-control" >
                                        <asp:ListItem Enabled="true" Text="Seleccione un estado" Value= “-1”></asp:ListItem>
                                        <asp:ListItem Text="Activo" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Inactivo" Value="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-12">
                                    <label class="form-label" >¿Maneja?</label>
                                    <asp:DropDownList ID="ddlManeja" name="Genero" runat="server" CssClass="form-control" >
                                        <asp:ListItem Enabled="true" Text="Seleccione una opción" Value= “-1”></asp:ListItem>
                                        <asp:ListItem Text="Si" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="No" Value="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-12">
                                    <label class="form-label" >¿Usa lentes?</label>
                                    <asp:DropDownList ID="ddlLentes" name="Genero" runat="server" CssClass="form-control" >
                                        <asp:ListItem Enabled="true" Text="Seleccione una opción" Value= “-1”></asp:ListItem>
                                        <asp:ListItem Text="Si" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="No" Value="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-12">
                                    <label class="form-label" >¿Es diabético/a?</label>
                                    <asp:DropDownList ID="ddlDiabetico" name="Genero" runat="server" CssClass="form-control" >
                                        <asp:ListItem Enabled="true" Text="Seleccione una opción" Value= “-1”></asp:ListItem>
                                        <asp:ListItem Text="Si" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="No" Value="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-12">
                                    <label class="form-label">¿Padece alguna otra enfermedad? ¿Cuál?</label>
                                    <asp:TextBox  ID="txtEnfermedad" runat="server" CssClass="form-control"  autocomplete="nope"></asp:TextBox>
                                </div>
                            </div>
                            <div class="modal-footer">
                                <asp:Button runat="server" ID="btnModificarPersona" CssClass="btn btn-outline-primary" Text="Guardar cambios" OnClick="btnModificarPersona_Click" />
                                <button class="btn btn-outline-danger" data-dismiss="modal" aria-hidden="true">Cancelar</button>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
        <h1 class="visually-hidden">Personas</h1>
        <div class="container my-5">
            <div class="row p-4 pb-0 pe-lg-0 pt-lg-5 align-items-center rounded-3 border shadow-lg">
                <div class="px-4 text-center border-bottom">
                    <h1 class="display-4 fw-bold">Personas</h1>
                    <div class="col-lg-6 mx-auto">
                        <p class="lead mb-4">Se muestra un listado en el que podrá consultar, agregar, editar y eliminar personas a su gusto.</p>
                        <div class="d-grid gap-2 d-sm-flex justify-content-sm-center mb-5">
                            <asp:GridView ID="grvPersonas" runat="server" AllowPaging="true" AutoGenerateColumns="false" AllowSorting="false" OnRowCommand="grvPersonas_RowCommand" OnPageIndexChanging="grvPersonas_PageIndexChanging"
                                OnRowDataBound="grvPersonas_RowDataBound" CssClass="table table-striped table-bordered table-hover" PageSize="10" EditRowStyle-Height="5">
                                <Columns>
                                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="item-col-style info" />
                                    <asp:BoundField DataField="Identificacion" HeaderText="Identificacion" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="item-col-style info" />
                                    <asp:BoundField DataField="Edad" HeaderText="Genero" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="item-col-style info" />
                                    <asp:BoundField DataField="Estado" HeaderText="Estado" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="item-col-style info" />
                                    <asp:BoundField DataField="Maneja" HeaderText="Maneja" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="item-col-style info" />
                                    <asp:BoundField DataField="UsaLentes" HeaderText="UsaLentes" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="item-col-style info" />
                                    <asp:BoundField DataField="Diabetico" HeaderText="Diabetico" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="item-col-style info" />
                                    <asp:BoundField DataField="Enfermedad" HeaderText="Enfermedad" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="item-col-style info" />
                                    <asp:TemplateField HeaderText="Accion" ItemStyle-CssClass="item-col-style d-flex" HeaderStyle-CssClass="header-col-style info " ItemStyle-VerticalAlign="Middle">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="btnModificar" runat="server" CssClass="btn btn-outline-primary" CausesValidation="false" ToolTip="Modificar" CommandArgument='<%# Eval("Id")%>' CommandName="Modificar"><i class="fa fa-pencil-square-o"></i></asp:LinkButton>
                                            <asp:LinkButton ID="btnEliminar" runat="server" CssClass="btn btn-outline-danger" CausesValidation="false" ToolTip="Eliminar" OnClientClick="return DeleteConfirm(this);" CommandArgument='<%# Eval("Id")%>' CommandName="Eliminar"><i class="fa fa-trash"></i></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>



        </div>

        <script>
            function abrirModal() {
                var myModal = new bootstrap.Modal(document.getElementById('myModal'), { keyboard: false });
                myModal.show();
            }

            var obj = { status: false, ele: null };
            function DeleteConfirm(btnDelete) {

                if (obj.status) {
                    obj.status = false;
                    return true;
                };

                Swal.fire({
                    title: 'Estás seguro?',
                    text: "No podrás revertir esto!",
                    type: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Si, eliminalo!'
                }).then((result) => {
                    if (result.value) {
                        obj.status = true;
                        //do postback on success
                        obj.ele.click();

                        Swal.fire({
                            title: 'Eliminado!',
                            text: 'Se eliminó con éxito.',
                            type: 'success',
                            timer: 800
                        })
                    }
                });
                obj.ele = btnDelete;
                return false;
            }
        </script>
    </main>
</asp:Content>
