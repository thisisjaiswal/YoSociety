define(['durandal/http', 'services/logger'], function (http, logger) {

    return {

        title: 'Maintenance View',

        activate: function () {
            var self = this;

            self.MaintenanceList = ko.observable([]);

            self.MaintenanceDetailList = ko.observable([]);

            self.getDetails = function (info) {
                var baseUrl = "http://localhost:9091";
                $.getJSON(baseUrl+ "/api/maintenance/" + info.BillFor._latestValue + "/?societyId=123", function (data) {
                    self.MaintenanceDetailList($.map($.makeArray(data), function (item) { return new Maintenance(item) }));
                });
            };

            var baseUrl = "http://localhost:9091";
            $.getJSON(baseUrl + "/api/maintenance/?societyId=123", function (data) {
                self.MaintenanceList($.map(data, function (item) { return new MaintenanceInfo(item); }));
            });

            //logger.log('Maintenance View Activated', null, 'maintenance', true);
        }
    };

    function MaintenanceInfo(data) {
        this.BillFor = ko.observable(data.BillFor);
        this.Amount = ko.observable(data.Amount);
        this.DueDate = ko.observable(data.DueDate);
        this.Status = ko.observable(data.PaymetStatus);
    }

    function Maintenance(data) {
        this.BillFor = ko.observable(data.BillFor);
        this.Amount = ko.observable(data.Amount);
        this.DueDate = ko.observable(data.DueDate);
        this.Status = ko.observable(data.PaymetStatus);
    }
});


