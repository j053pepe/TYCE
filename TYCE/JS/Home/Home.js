$(function () {

    var HomeFn = {
        init() {

        },
        GetMenu() {
            Global.Api("Home", "GET", "")
                .done(function (data) {
                    $(data).each(function (item) {

                    });
                })
                .fail(function (data) {

                });
        }
    };

    HomeFn.init();
});