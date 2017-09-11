/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
var extent, format, osmLayer, layers, view;
var wmsSourceChorongi_Poly, wmsSourceChorongi_Line,
        wmsSourceChorongi_Node, wmsSourceChorongi_Centroid;
var map, _globalURL = false;
var attribution;

function instantiateGlobalVariables() {
    //An array of numbers representing an extent: [minx, miny, maxx, maxy]

    //extent = [-919335.054, -421034.721, 5489455.831, 4323205.57]; //farmcoordinate_to_farmer_evw
    extent = [4089350, -146345,  4100094, -139959]; //Structures



    format = 'image/png';
    var myURL;
    if (_globalURL === true) {
        myURL = "http://52.168.94.223:8888/geoserver/KISIP/wms";
    } else {
        myURL = "http://localhost:8080/geoserver/Billboard/wms";
    }

    //console.log("Config: "+ myConfig.farmerWMS());

    /*Chorongi Poly
     * http://52.168.94.223:8888/geoserver/KISIP/wms
     * http://localhost:8080/geoserver/KISIP/wms
     */
    wmsStructures = new ol.source.ImageWMS({
        url: myURL,
        params: {'LAYERS': 'Billboard:structure_admin_evw'},
        //params: {
        //    'FORMAT': format,
        //    'VERSION': '1.1.1',
        //    tiled: true,
        //    STYLES: 'farmers3',
        //    LAYERS: 'adims:farmcoordinate_to_farmer_evw'
        //},
        serverType: 'geoserver'
                //,crossOrigin: 'anonymous'
    });

    /*Chorongi Line*/
    wmsSourceChorongi_Line = new ol.source.ImageWMS({
        url: myURL,
        params: {'LAYERS': 'KISIP:Chorongi_line'},
        //params: {
        //    'FORMAT': format,
        //    'VERSION': '1.1.1',
        //    tiled: true,
        //    STYLES: 'farmers3',
        //    LAYERS: 'adims:farmcoordinate_to_farmer_evw'
        //},
        serverType: 'geoserver'
                //,crossOrigin: 'anonymous'
    });

    /*Chorongi Node*/
    wmsSourceChorongi_Node = new ol.source.ImageWMS({
        url: myURL,
        params: {'LAYERS': 'KISIP:Chorongi_node'},
        //params: {
        //    'FORMAT': format,
        //    'VERSION': '1.1.1',
        //    tiled: true,
        //    STYLES: 'farmers3',
        //    LAYERS: 'adims:farmcoordinate_to_farmer_evw'
        //},
        serverType: 'geoserver'
                //,crossOrigin: 'anonymous'
    });

    /*Chorongi Centroid*/
    wmsSourceChorongi_Centroid = new ol.source.ImageWMS({
        url: myURL,
        params: {'LAYERS': 'KISIP:Chorongi_centroid'},
        //params: {
        //    'FORMAT': format,
        //    'VERSION': '1.1.1',
        //    tiled: true,
        //    STYLES: 'farmers3',
        //    LAYERS: 'adims:farmcoordinate_to_farmer_evw'
        //},
        serverType: 'geoserver'
                //,crossOrigin: 'anonymous'
    });

    osmLayer = new ol.layer.Tile({
        source: new ol.source.OSM()
    });

    layers = [osmLayer,
        new ol.layer.Image({source: wmsStructures})
//                , new ol.layer.Image({source: wmsSourceChorongi_Line})
//                , new ol.layer.Image({source: wmsSourceChorongi_Node})
//                , new ol.layer.Image({source: wmsSourceChorongi_Centroid})
    ];

    view = new ol.View({
        center: ol.proj.transform([36.78093, -1.28475], 'EPSG:4326', 'EPSG:3857'),
        extent: extent,
        zoom: 14
    });
}
;

function popupFunctions() {
    //Add overlay
    map.addOverlay(overlay);

    //Wire singleclick event to dispayfearuresinfo handler


    /**
     * Add a click handler to the map to render the popup.
     */
    map.on('singleclick', function (evt) {
        //Call function to renderer popup was a single click event is fired up
        displayInfoFeatures(evt);


    });
}
function checkSize() {
    var small = map.getSize()[0] < 600;
    attribution.setCollapsible(small);
    attribution.setCollapsed(small);
}
function attribution() {
    attribution = new ol.control.Attribution({
        collapsible: false
    });


}

function addControls() {
    map.addControl(new ol.control.Zoom());
    map.addControl(new ol.control.FullScreen());
    map.addControl(new ol.control.ZoomSlider());
    map.addControl(new ol.control.OverviewMap());
    
    //scaleline
    var scaleLineControl = new ol.control.ScaleLine();
    map.addControl(scaleLineControl);
}

$(function () {

    //call function to instantiate map objects
    instantiateGlobalVariables();

    attribution();//Attribution control

    /**
     * Create the map.
     */
    map = new ol.Map({
        layers: layers,
        controls: ol.control.defaults({attribution: false}).extend([attribution]),
        //overlays: [overlay],
        target: 'map',
        view: view
    });

    //Add controls
    addControls();

    //Call map related components
    popupFunctions();

    window.addEventListener('resize', checkSize);
    checkSize();

});
