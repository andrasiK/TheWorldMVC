    /* site.js */


////////////////////
// raw javaScript //
////////////////////
/*
(function () {
    var ele = document.getElementById("username");
    ele.innerHTML = "Kristof Andrasi";


// JavaScript event

    var main = document.getElementById("main");
    main.onmouseenter = function () {

        main.style = "background-color: #888;";

    };

    main.onmouseleave = function () {

        main.style = "";

    };
}) (); 
*/

//////////////////
// using jQuery //
//////////////////

(function () {

    //var ele = $("#username");
    //ele.text("Kristof Andrasi");


    //var main = $("#main");
    //main.on( "mouseenter" , function () {

    //    main.css("background-color", "#888");
    //});

    //main.on("mouseleave", function () {

    //    main.css("background-color", "");
    //});

    //var menuitems = $("ul.menu li a");
    //menuitems.on("click", function () {
    //    var me = $(this);
    //    alert(me.text());
    //})


    var $sidebarAndWrapper = $("#sidebar,#wrapper");
    $("#sidebarToggle").on("click", function () {
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            $(this).text("Show Sidebar");
        } else {
            $(this).text("Hide Sidebar");
        }
    });



})();

