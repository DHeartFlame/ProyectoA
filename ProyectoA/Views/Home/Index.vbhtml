
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <link rel="stylesheet" href="~/Content/bootstrap.css" />
    <title>Index</title>
    <style type="text/css">
        body {
            background-color: beige;
        }
        #Circulo {
            width: 10px;
            height: 10px;
            background: linear-gradient(top, lavender, royalblue,navy);
            background: -webkit-linear-gradient(top, lavender, royalblue, navy);
            background: -moz-linear-gradient(top, lavender, royalblue, navy);
            background: -o-linear-gradient(top, lavender,royalblue, navy);
            background: -ms-linear-gradient(top, lavender, royalblue, navy);
            border-radius: 50%;
            position: relative;
            left: 40%;
            text-align: center;
            color:white;
            top:50px;
        }
        #contenedorLogo{
           position:absolute;
           top:200px;
           text-align:center;
           left:40px;
        }
        .go{ 
            margin: 5% 38%;
            width: 300px;
        }
    </style>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script type="text/javascript" src="script.js"></script>

</head>
<body>
    <div>
            <div id="Circulo"><div id="contenedorLogo"><b id="Logo">Somelogo</b> </div></div>
            <br />
            <div class="go btn btn-info" onclick="">@Html.ActionLink("Inicio", "Inicio", "Home")</div>
    </div>
    <script>

        $(document).ready(function () {
            $("#Circulo").animate({left: "30%", height: "500px", width: "38%" }, 2000);
            $("#Logo").animate({fontSize:"6em"}, 2000);
        });
    </script>
</body>
</html>
