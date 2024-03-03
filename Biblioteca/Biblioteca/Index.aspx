<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Biblioteca.Index" %>


<system.webServer>
    <defaultDocument>
        <files>
            <clear />
            <add value="CreateThing.aspx" />
        </files>
    </defaultDocument>
</system.webServer>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Biblioteca</title>
    <link rel="stylesheet" href="Styles.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <h1 class="auto-style1">Gestor de libros</h1>
        <div class="Forms">
            <fieldset class="Field">
                <legend>Agregar un libro</legend>

                <section class="Formulario">
                    <div class="form-group">
                    <label>Nombre del libro: </label>
                    <asp:TextBox ID="txtLibro" runat="server" placeholder="Introduce el nombre libro..." CssClass="controls" autocomplete="off" Required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>ISBN: </label>
                    <asp:TextBox ID="txtISBN" runat="server" placeholder="Introduce el ISBN..." CssClass="controls" autocomplete="off" Required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Edición: </label>
                    <asp:TextBox ID="txtEdicion" runat="server" placeholder="Introduce la edición..." CssClass="controls" autocomplete="off" Required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Año de publicación: </label>
                    <asp:TextBox ID="txtPublicacion" runat="server" placeholder="Introduce el año de publicación..." CssClass="controls" autocomplete="off" Required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Autor(es): </label>
                    <asp:TextBox ID="txtAutores" runat="server" placeholder="Introduce el/los autores..." CssClass="controls" autocomplete="off" Required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Sinopsis: </label>
                    <asp:TextBox ID="txtSinopsis" runat="server" placeholder="Introduce la sinópsis..." CssClass="controls" autocomplete="off" Required="true"></asp:TextBox>
                </div>
                <div class="divCar">
                    <label>Selecciona una carrera</label>
                    <asp:DropDownList ID="ddlCarreras" runat="server" CssClass="Carreras" Required="true">
                        <asp:ListItem Text="Ingenieria en Sistemas Computacionales" Value="Ingenieria en Sistemas Computacionales"></asp:ListItem>
                        <asp:ListItem Text="Ingeniería Electrónica" Value="Ingeniería Electrónica"></asp:ListItem>
                        <asp:ListItem Text="Ingenieria en Sistemas Automotrices" Value="Ingenieria en Sistemas Automotrices"></asp:ListItem>
                        <asp:ListItem Text="Ingeniería Industrial" Value="Ingeniería Industrial"></asp:ListItem>
                        <asp:ListItem Text="Ingeniería Ambiental" Value="Ingeniería Ambiental"></asp:ListItem>
                        <asp:ListItem Text="Ingeniería en Gestión Empresarial" Value="Ingeniería en Gestión Empresarial"></asp:ListItem>
                        <asp:ListItem Text="Gastronomía" Value="Gastronomía"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <label>Materia: 
                    <br />
                    </label>
                    <asp:TextBox ID="txtMateria" runat="server" placeholder="Introduce la materia..." CssClass="controls" autocomplete="off" Required="true"></asp:TextBox>
                    <br />
                </div>
                <div class="form-group">
                    Pais De Publicacion<label>: </label>
                    <asp:TextBox ID="txtPais" runat="server" placeholder="Introduce la materia..." CssClass="controls" autocomplete="off" Required="true"></asp:TextBox>
                    <br />
                <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="boton" OnClick="btnEnviar_Click" />

                </div>

                </section>
            </fieldset>
        </div>

        <div class="container mt-5">
            <asp:GridView ID="GridViewLibros" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false" OnLoad="GridViewLibros_Load">
                <Columns>

                     <asp:BoundField DataField="ID" HeaderText="ID" />
                     <asp:BoundField DataField="ISBN" HeaderText="ISBN" />
                     <asp:BoundField DataField="Titulo" HeaderText="Título" />
                     <asp:BoundField DataField="Edicion" HeaderText="Número de Edición" />
                     <asp:BoundField DataField="Anio" HeaderText="Año de Publicación" />
                     <asp:BoundField DataField="Autores" HeaderText="Nombre de los Autores" />
                     <asp:BoundField DataField="Pais" HeaderText="País de Publicación" />
                     <asp:BoundField DataField="Sinopsis" HeaderText="Sinopsis" />
                     <asp:BoundField DataField="Carrera" HeaderText="Carrera" />
                     <asp:BoundField DataField="Materia" HeaderText="Materia" />

                </Columns>
                
            </asp:GridView>
        </div>
    </form>
</body>
</html>
