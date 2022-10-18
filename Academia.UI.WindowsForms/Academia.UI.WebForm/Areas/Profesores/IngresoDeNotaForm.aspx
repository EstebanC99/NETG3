<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Areas/Alumno.Master" CodeBehind="IngresoDeNotaForm.aspx.cs" Inherits="Academia.UI.WebForm.Areas.Profesores.IngresoDeNotaForm" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="AlumnoContent" runat="server">

    <div class="row" style="padding-top: 100px;">
    </div>

    <div class="row">
        <label class="col-sm-2 col-md-2 col-lg-2"><b>Curso:</b></label>
        <asp:Label runat="server" ID="CursoDescripcion" CssClass="col-sm-4 col-md-4 col-lg-4"></asp:Label>
    </div>

    <div class="row">
        <label class="col-sm-2 col-md-2 col-lg-2"><b>Alumno:</b></label>
        <asp:Label runat="server" ID="AlumnoInfo" CssClass="col-sm-4 col-md-4 col-lg-4"></asp:Label>
    </div>
    
    <form runat="server" onsubmit="CargarNota" id="CargarNotasForm">
        <div class="form-row">
            <label class="col-sm-2 col-md-2 col-lg-2" for="txtNota">Nota:</label>
            <asp:TextBox ID="txtNota" 
                CssClass="col-sm-2 col-md-2 col-lg-2"
                placeholder="0-10"
                required="required"
                runat="server"></asp:TextBox>
        </div>

        <div class="form-row">
            <asp:Button runat="server" 
                CssClass="btn btn-secondary btn-sm" 
                style="padding:2px;" 
                OnClick="Cancelar_Click" 
                Text="Cancelar"/>
            <button type="submit" class="btn btn-primary btn-sm">Cargar nota</button>
        </div>
    </form>

</asp:Content>