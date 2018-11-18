
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Inicio</title>
    @Styles.Render("~/Content/css")
    <style>
        img{
            width:100px;
            height:50px;
            float:left;
        }
        .navbar-default {
            background: linear-gradient(left, white 50%, paleturquoise) !important;
            background: -webkit-linear-gradient(left, white 50%, paleturquoise);
            background: -moz-linear-gradient(left, white 50%, paleturquoise);
            background: -o-linear-gradient(left, white 50%, paleturquoise);
            background: -ms-linear-gradient(left, white 50%, paleturquoise);
            border:none;
        }
        .busqueda{
            width:100%;
            margin: 10px 20%;
        }
        .buscar{
            width:600px !important;
            float:left;
        }
        .boton{
            width:80px !important;
        }
    </style>
</head>
<body>
    <div class="navbar navbar-default navbar-fixed-top">
        <img src="~/Imagenes/calalogon.png" />

        <div class="container">

            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Calaverita", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Inicio", "Inicio", "Home")</li>
                    <li>@Html.ActionLink("Categoria", "Inicio", "Home")</li>
                    <li>@Html.ActionLink("Mi cuenta", "Contact", "Home")</li>
                    <li>@Html.ActionLink("Acerca de", "Contact", "Home")</li>
                </ul>
            </div>
        </div>
    </div>
    <div class="busqueda">
        <b style="float:left; margin-right:10px;">Encuentre lo que sea en calaverita</b>
        <input type="text" class=" form-control buscar"  placeholder="Escribe algo..."/>
        <input type="submit" class="boton btn btn-info" value="Buscar" />
    </div>
</body>
</html>
