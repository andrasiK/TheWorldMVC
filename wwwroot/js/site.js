﻿    /* site.js */


var ele = document.getElementById("username");
ele.innerHTML = "Kristof Andrasi";



var main = document.getElementById("main");
main.onmouseenter = function () {

    main.style = "background-color: #888;";

};

main.onmouseleave = function () {

    main.style = "";

};
