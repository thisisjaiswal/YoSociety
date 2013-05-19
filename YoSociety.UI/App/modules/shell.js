define(['durandal/plugins/router'], function (router) {
    
    var isAuthenticated = ko.observable(true);

    var request = {
        MobileNo: "9833189399",
        Password: "skdljflsadkfj"
    }

    var login = function () {        
        $.ajax("/api/account/login", {
            data: ko.toJSON(this.request),
            type: "post", contentType: "application/json",
            success: function (result) {
                isAuthenticated(result);
                if (result) { sessionStorage.setItem("userId", this.request.MobileNo); }
            }
        });
    };

    var register = function (info) {
        alert("Registration is in progress...");
    };

    var activate = function () {

        userId = sessionStorage.getItem("userId");
        if (userId != null && userId != "") {
            isAuthenticated(true);
        }

        router.map([
            { url: 'aboutyo/:name', moduleId: 'modules/aboutyo/index', name: 'YO! Society' },
            { url: 'aboutyo', moduleId: 'modules/aboutyo/index', name: 'YO! Society', visible: true },
            { url: 'home/:name', moduleId: 'modules/home/index', name: 'Home' },
            { url: 'home', moduleId: 'modules/home/index', name: 'Home', visible: true },
            { url: 'profile/:name', moduleId: 'modules/profile/index', name: 'Profile' },
            { url: 'profile', moduleId: 'modules/profile/index', name: 'Profile', visible: true },
            { url: 'settings/:name', moduleId: 'modules/settings/index', name: 'Settings' },
            { url: 'settings', moduleId: 'modules/settings/index', name: 'Settings', visible: true },
        ]);

        return router.activate('home');
    }; 

    return {
        router: router,
        activate: activate,
        login: login,
        register: register,
        isAuthenticated: isAuthenticated,
        request: request
    };
});