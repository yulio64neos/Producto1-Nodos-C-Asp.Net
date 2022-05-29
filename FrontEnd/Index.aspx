<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FrontEnd.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Main</title>
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous" />

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
                                <a class="nav-link" href="#">Insertar</a>
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
                    <div class="col primary">
                        <h1>
                            Producto1. Reporte del caso de estudio Árbol Binario
                        </h1>
                    </div>
                    <div class="col alert">
                        <img class="rounded mx-auto d-block" width="500" src="Images/legoBloques.png" />
                    </div>
                </div>
            </div>
            <!--Fin de la presentación-->
        </div>
    </form>
    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2" crossorigin="anonymous"></script>
</body>
</html>
