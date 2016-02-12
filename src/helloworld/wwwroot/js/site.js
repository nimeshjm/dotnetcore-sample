(function() {
    var $widebarAndWrapper = $("#sidebar,#wrapper");

    $("#sidebarToggle").on("click", function() {
        $widebarAndWrapper.toggleClass("hide-sidebar");
        if ($widebarAndWrapper.hasClass("hide-sidebar")) {
            $(this).text("Show Sidebar");
        } else {
            $(this).text("Hide Sidebar");
        }
    });
})();