$(document).ready(function () {

    idleTime = 0;

    //Increment the idle time counter every second.
    var idleInterval = setInterval(timerIncrement, 150000);

    function timerIncrement() {
        idleTime++;
        if (idleTime > 1) {
            doPreload();
        }
    }
    document.documentElement.onmousemove = function () {
        idleTime = 0;
    }
    document.documentElement.onkeypress = function () {
        idleTime = 0;
    }
    document.documentElement.onclick = function () {
        idleTime = 0;
    }
    //Zero the idle timer on mouse movement.
    //$(this).mousemove(function (e) {
    //    idleTime = 0;
    //});

    function doPreload() {
        window.location.href = 'IS.aspx';
        //alert(idleTime);
        //Preload images, etc.
    }
                


    //Remove the style attributes.
    $(".navbar-nav li, .navbar-nav a, .navbar-nav ul").removeAttr('style');

    //Apply the Bootstrap class to the Submenu.
    $(".dropdown-menu").closest("li").removeClass().addClass("dropdown-toggle");

    //Apply the Bootstrap properties to the Submenu.
    $(".dropdown-toggle").find("a").eq(0).attr("data-toggle", "dropdown").attr("aria-haspopup", "true").attr("aria-expanded", "false").append("<span class='caret'></span>");

    //Apply the Bootstrap "active" class to the selected Menu item.
    $("a.selected").closest("li").addClass("active");
    $("a.selected").closest(".dropdown-toggle").addClass("active");

});

Sys.WebForms.Menu._elementObjectMapper.getMappedObject = function () {
    return false;
};