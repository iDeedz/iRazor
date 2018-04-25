﻿<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>signalR Simple Users On Line</title>
    <!-- GOOGLE Chart Reference-->
    <script type='text/javascript' src='https://www.google.com/jsapi'></script>
    <!-- jQuery Reference-->
    <script src="~/Scripts/jquery-1.6.4.min.js"></script>
    <!-- signalR Reference-->
    <script src="~/Scripts/jquery.signalR-1.2.2.min.js"></script>
    <!-- signalR Hubs Reference-->
    <script src="/signalR/hubs"></script>
    <script type='text/javascript'>
        google.load('visualization', '1', { packages: ['gauge'] });
    </script>

</head>
<body>
    <h2>signalR Simple Users On Line</h2>
    <div id="chart_div" style="width: 300px; height: 300px;"></div>
    <ul id="message"></ul>
    <script type="text/javascript">
        var usrGraph;
        $(function () {
            var usr = $.connection.usersOnLine;

            $.connection.hub.start().done(function () {
                console.warn("Connected.")
            });

            usr.client.log = function (message) {
                console.warn("message")
                $('#message').append('<li>' + message + '</li>');
            };
            usr.client.showUsersOnLine = function (data) {
                drawOnLine(data);
                console.warn(data);
            };

        });

        /*function drawOnLine(usrCount) {
            var data = google.visualization.arrayToDataTable([
                ['Label', 'Value'],
                ['Users', usrCount]
            ]);
            var options = {
                width: 250, height: 250,
                redFrom: 90, redTo: 100,
                yellowFrom: 75, yellowTo: 90,
                minorTicks: 5
            };

            if (!(usrGraph)) {
                usrGraph = new google.visualization.Gauge(document.getElementById('chart_div'));
            }
            usrGraph.draw(data, options);
        }*/


    </script>
    @*<a href="client.html" target="_blank">Open new client</a>*@
</body>
</html>