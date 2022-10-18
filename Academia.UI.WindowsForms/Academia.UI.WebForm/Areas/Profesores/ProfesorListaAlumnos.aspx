<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Areas/Alumno.Master" CodeBehind="ProfesorListaAlumnos.aspx.cs" Inherits="Academia.UI.WebForm.Areas.Profesores.ProfesorListaAlumnos" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="AlumnoContent" runat="server">

    <div class="container" style="padding-top: 100px;">
    
        <div class="container mt-3">
            <h2>Alumnos</h2>
            <p>Ingrese el nombre del alumno al que desee cargar la nota:</p>  
            <input class="form-control" id="alumnoFiltro" type="text" placeholder="Buscar..">
            <br>

            <form runat="server" method="post">
                <table class="table table-bordered">
                    <thead>
                      <tr>
                        <th>Apellido</th>
                        <th>Nombre</th>
                        <th>Legajo</th>
                        <th>Plan</th>
                        <th>Nota</th>
                        <th></th>
                      </tr>
                    </thead>
                    <tbody id="myTable">
                        <asp:Repeater ID="RepeaterInscriptos" runat="server" ItemType="Academia.UI.ViewModels.AlumnoVM">
                            <ItemTemplate>
                                    <tr>
                                        <td><%# Item.Apellido %></td>
                                        <td><%# Item.Nombre %></td>
                                        <td><%# Item.Legajo %></td>
                                        <td><%# Item.PlanDescripcion %></td>
                                        <td style=<%#Item.Nota.HasValue && Item.Nota.Value >= 6 ? "text-color:green;" : "text-color:red;"%>><%# Item.Nota%></td>
                                        <td>
                                            <asp:LinkButton CommandName="ModificarNota"
                                                CommandArgument="<%# Item.InscripcionID %>"
                                                Text="Modificar Nota"
                                                runat="server"
                                                OnCommand="ModificarNota_Command"
                                                Enabled="true"
                                                Visible="<%# Item.Nota.HasValue %>"
                                                CssClass="link-secondary"></asp:LinkButton>
                                            <asp:LinkButton CommandName="CargarNota" 
                                                CommandArgument="<%# Item.InscripcionID %>"
                                                Text="Cargar Nota"  
                                                runat="server" 
                                                OnCommand="CargarNota_Command"  
                                                Enabled="true"
                                                Visible="<%# !Item.Nota.HasValue %>"
                                                CssClass="link-primary"></asp:LinkButton>
                                        </td>
                                    </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </form>
        </div>

    </div>

    
    <script>
        $(document).ready(function () {
            $("#alumnoFiltro").on("keyup", function () {
                var value = $(this).val().toLowerCase();
                $("#myTable tr").filter(function () {
                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                });
            });
        });
    </script>
</asp:Content>
