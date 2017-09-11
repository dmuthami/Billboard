/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


var container = document.getElementById('popup');
var content = document.getElementById('popup-content');
var closer = document.getElementById('popup-closer');

/**
 * Create an overlay to anchor the popup to the map.
 */
var overlay = new ol.Overlay(/** @type {olx.OverlayOptions} */({
    element: container,
    autoPan: true,
    autoPanAnimation: {
        duration: 250
    }
}));

/**
 * Add a click handler to hide the popup.
 * @return {boolean} Don't follow the href.
 */
closer.onclick = function () {
    overlay.setPosition(undefined);
    closer.blur();
    return false;
};
infoFormat = 'text/javascript'; //  'text/javascript'

function displayInfoFeatures(evt) {
    var coordinate = evt.coordinate;
    //-----------Trial code goes here---
    var viewResolution = view.getResolution();
    var viewProjection = view.getProjection();

    var url = wmsStructures.getGetFeatureInfoUrl(
            evt.coordinate, viewResolution, viewProjection, {
                'INFO_FORMAT': infoFormat,
                'propertyName': 'Type,Ward,Constituency,County,Comment,FaceCount,StructureID,Owner'
            });
    //LR_Name, Block, Plot_Id, Area_Ha, PlotID_Cur, Land_Use, CountyCode
    if (url) {
        //console.log("URL: " + url);
        var parser = new ol.format.GeoJSON();
        $.ajax({
            url: url,
            type: 'POST',
            dataType: 'jsonp',
            jsonpCallback: 'parseResponse'
        }).then(function (response) {
            var result = parser.readFeatures(response);
            //console.log(result);
            if (result.length) {
                var info = [];
                for (var i = 0, ii = result.length; i < ii; ++i) {
                    /***/
                    info.push(result[i].get('Owner'));
                    info.push(result[i].get('Type'));
                    info.push(result[i].get('Ward'));
                    info.push(result[i].get('Constituency'));
                    info.push(result[i].get('County'));
                    info.push(result[i].get('Comment'));
                    info.push(result[i].get('FaceCount'));
                    info.push(result[i].get('StructureID'));
                    
                }
                //console.log("info arr: " + info);
                //var me = info.join(', ');

                var str = '<b>Owner : </b>' + info[0] + '<br>' +
                        '<b>Type : </b>' + info[1] + '<br>' +
                        '<b>Face Count: </b>' + info[6] + '<br>'+
                        '<b>Comment: </b>' + info[5] + '<br>' +
                        '<b>Ward: </b>' + info[2] + '<br>' +
                        '<b>Constituency: </b>' + info[3] + '<br>' +                        
                        '<b>County: </b>' + info[4] + '<br>';
                
                content.innerHTML = str;
                //console.log("url: " + url);
            } else {
                var str = "You might have clicked on a basemap. We are not at the moment able to pull attribute data from a basemap layer";
                content.innerHTML = str + '&nbsp;';
            }
        });
        overlay.setPosition(coordinate);
    }
}
