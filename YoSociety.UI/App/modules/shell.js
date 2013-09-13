define(['durandal/plugins/router', 'durandal/http'], function (router,http) {
    
    var isAuthenticated = ko.observable(true);

    var confirmPassword = ko.observable("");

    var account = {        
        UserId: "",        
        Password: ""        
    }

    var login = function () {
        var baseUrl = "http://localhost:9091";
        $.ajax({
            url: baseUrl + "/api/account/" + this.account.UserId,            
            type: 'GET',
            contentType: 'application/json',
            dataType: 'json',
            success: function (data) {
                //if (data.Password == account.Password) {
                    isAuthenticated(true);
                    sessionStorage.setItem("userId", account.UserId);
                //}                
            },
            error: function (data) {
                var k = 0;
            }
        });        
    };

    var logout = function () {        
        sessionStorage.removeItem("userId");
        isAuthenticated(false);
    };
    
    var register = function (info) {

        if (this.account.Password != confirmPassword())
            return;

        var baseUrl = "http://localhost:9091";
        $.ajax({
            url: baseUrl + "/api/account/",
            data: ko.toJSON(this.account),
            type: 'POST',
            contentType: 'application/json',
            dataType: 'json',
            success: function (data) {
                isAuthenticated(true);
                sessionStorage.setItem("userId", account.UserId);
            },
            error: function (data) {
                var k = 0;
            }
        });        
    };

    var activate = function () {

        sessionStorage.setItem("memberId", 1);

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
        account: account,
        confirmPassword:confirmPassword,
        register: register,
        logout: logout,
        isAuthenticated: isAuthenticated,
        
    };
});