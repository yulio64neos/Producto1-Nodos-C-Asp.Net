<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FrontEnd.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Main</title>
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous" />
    <link href="css/Estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <!--Este bloque es del navbar-->
            <nav class="navbar navbar-expand-lg">
                <div class="container-fluid">
                    <%--<a class="navbar-brand" href="#">Navbar</a>--%>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="navbarNav">
                        <ul class="navbar-nav">
                            <li class="nav-item">
                                <a class="nav-link" href="#">Home</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#inse">Insertar</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#">Buscar</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#">Eliminar</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#">Arbol Binario</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
            <!--Fin del bloque navbar-->
            <!--Presentación del proyecto-->
            <div class="mt-2">
                <div class="row">
                    <div class="col">
                        <h1 class="titulo display-1">Producto
                            <br />
                            1
                        </h1>
                        <h2 class="sub display-2">Reporte del caso de estudio Árbol Binario
                        </h2>
                    </div>
                    <div class="col">
                        <img class="rounded mx-auto d-block" width="500" src="Images/legoBloques.png" />
                    </div>
                </div>
            </div>
            <!--Fin de la presentación-->
            <!--Cartas del proyecto-->
            <div class="mt-5">
                <div class="row">
                    <div class="col-sm-3 mb-3">
                        <div class="card" style="width: 18rem">
                            <div class="card-body">
                                <h5 class="card-title">Insertar</h5>
                                <p class="card-text">Puede hacer la insercion a un nuevo nodo.</p>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3 mb-3">
                        <div class="card" style="width: 18rem">
                            <div class="card-body">
                                <h5 class="card-title">Mostrar</h5>
                                <p class="card-text">Muestra el contenido de los nodos en una lista.</p>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-3 mb-3">
                        <div class="card" style="width: 18rem">
                            <div class="card-body">
                                <h5 class="card-title">Buscar</h5>
                                <p class="card-text">Encuentra por parámetro los nodos que se solicite en su busqueda.</p>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3 mb-3">
                        <div class="card" style="width: 18rem">
                            <div class="card-body">
                                <h5 class="card-title">Eliminar</h5>
                                <p class="card-text">Podemos eliminar el nodo que seleccionemos.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!--Fin de las cartas del proyecto-->
            <!--Insertar nodos-->
            <div class="inse">
                <div class="card mb-3">
                    <img src="Images/insertar-google-form.jpg" class="img-fluid imagen" alt="Insert"/>
                    <div class="card-body">
                        <h5 class="card-title">Insertar Nodo</h5>
                        <div class="mb-3">
                            <label class="form-label">Clave</label>
                            <asp:TextBox ID="txtClave" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label class="form-label">Categoría</label>
                            <asp:TextBox ID="txtCate" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label class="form-label">Modelo</label>
                            <asp:TextBox ID="txtModel" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label class="form-label">Marca</label>
                            <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label class="form-label">Serie</label>
                            <asp:TextBox ID="txtSerie" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label class="form-label">Descripción</label>
                            <asp:TextBox ID="txtDesc" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Button ID="txtInsertar" runat="server" Text="Insertar Nodo" CssClass="btn btn-primary" OnClick="txtInsertar_Click"/>
                        <asp:Button ID="txtMostrar" runat="server" Text="Mostrar Nodos" CssClass="btn btn-success ml-2" OnClick="txtMostrar_Click" />
                    </div>
                </div>
            </div>
            <!--Fin de la inserción-->
            <!--Mostrar Lista-->
            <div class="lista">
                <div class="mb-3">
                    <p>Listado de los elementos</p>
                    <asp:ListBox ID="listNodos" runat="server" Width="1202px"></asp:ListBox>
                </div>                
            </div>
            <!--Fin de la etiqueta Lista-->
            <!--Buscar nodo-->
            <div class="busq">
                <div class="mb-3">
                    <label class="form-label">Buscar Nodo</label>
                    <asp:TextBox ID="txtBusClav" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar Nodo"  CssClass="btn btn-light mt-2" OnClick="btnBuscar_Click"/>
                </div>
            </div>
            <!--Fin de la busqueda -->
            <!--Eliminar nodo -->
            <div class="elim">
                <div class="mb-3">
                    <label class="form-label">Eliminar Nodo</label>
                    <asp:TextBox ID="txtElimNodo" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Nodo" CssClass="btn btn-danger mt-2" OnClick="btnEliminar_Click" />
                </div>
            </div>
            <!--Fin del eliminado -->
        </div>
    </form>
    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</body>
</html>
