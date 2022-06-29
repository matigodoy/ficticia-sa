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
    <main>
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
                                            <asp:LinkButton ID="btnEliminar" runat="server" CssClass="btn btn-outline-danger" CausesValidation="false" ToolTip="Eliminar" CommandArgument='<%# Eval("Id")%>' CommandName="Eliminar"><i class="fa fa-trash"></i></asp:LinkButton>                                            
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>

                </div>
            </div>
        </div>

    </main>
</asp:Content>
