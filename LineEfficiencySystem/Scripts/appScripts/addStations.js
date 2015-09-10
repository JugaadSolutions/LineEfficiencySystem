function addStations(stations) {
    //debugger;
    var noOfStations = stations.length;
    $("#BaseContainerDiv").empty();
    if (noOfStations < 4)
    {

        stationRows = 1;
    }
    else
    var stationRows = parseInt(noOfStations / 4, 10).toString();


    for (var i = 0; i < stationRows; i++) {
        var machineRowDiv = $("<div class='row' style='padding-top:5px' id=MachineRow" + i.toString() + "></div>");
        $("#BaseContainerDiv").append(machineRowDiv);

    }


    for (var i = 0; i < noOfStations; i++) {

        var rowId = "MachineRow" + parseInt(i / 4).toString();
        var divId = "MachineDiv" + (i).toString();
        var StationName = stations[i]["Name"];
        var Station = stations[i]["StationId"];


        var StationCol = $("<div class='col-md-3' id=\"" + divId + "\"></div>");
        var StationButton = $("<button class='btn btn-info btn-lg btn-block' ></button>").html(StationName);


        $("#" + rowId).append(StationCol);
        StationCol.append(StationButton);

        StationButton.on("click", function (e) {
            location.href = '/StationInputs/Login/?station=' + Station.toString();
        });
    }
}