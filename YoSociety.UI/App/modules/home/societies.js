define(['durandal/app'],function (app) {
    
    var loading = ko.observable(false);    
    var searchStep = ko.observable(true);
    var addStep = ko.observable(false);
    var registerStep = ko.observable(false);    

    var sid = ko.observable();
    var regNo = ko.observable("");
    var name = ko.observable("");
    var flatNo = ko.observable("");
    var memberType = ko.observable("");

    var Society = function (name, regNo) {
        this.SocietyName = name;
        this.RegistrationNo = regNo;
    };

    var SocietyMember = function () {
        this.Name = "NHGG";        
        this.SocietyId = 1;
        this.MemberId = 1;
        this.FlatNo = 10;
        this.MemberType = 0;
    };

    var search = function () {
        var self = this;
        var baseUrl = "http://localhost:9091";
        $.ajax({
            url: baseUrl + "/api/society/" + regNo(),
            type: 'GET',
            contentType: 'application/json',
            dataType: 'json',
            success: function (data) {
                searchStep(false);
                addStep(true);
                name(data.SocietyName);
            },
            error: function (data) {
                self.searchStep(false);
                self.registerStep(true);
            }
        });
    };

    var add = function () {
        var self = this;
        var baseUrl = "http://localhost:9091";
        $.ajax({
            url: baseUrl + "/api/member",
            data: ko.toJSON(new SocietyMember()),
            type: 'POST',
            contentType: 'application/json',
            dataType: 'json',
            success: function (data) {
                self.sid = data.SocietyId;
                self.name = data.SocietyName;                
            },
            error: function (data) {

            }
        });
    };

    var register = function () {
        var self = this;
        var baseUrl = "http://localhost:9091";
        $.ajax({
            url: baseUrl + "/api/society",
            data: ko.toJSON(new Society(self.name(), self.regNo())),
            type: 'POST',
            contentType: 'application/json',
            dataType: 'json',
            success: function (data) {
                self.sid = data.SocietyId;
                self.name = data.SocietyName;
                registerStep(false);
                addStep(true);
            },
            error: function (data) {
                
            }
        });
    };

    return {
        loading: loading,
        searchStep: searchStep,
        addStep: addStep,
        registerStep: registerStep,
        search: search,
        add: add,
        register: register,
        name: name,
        sid:sid,
        regNo: regNo,
        flatNo: flatNo,
        activate: function () {
            searchStep(true);
            addStep(false);
            registerStep(false);
        }
    };

});
