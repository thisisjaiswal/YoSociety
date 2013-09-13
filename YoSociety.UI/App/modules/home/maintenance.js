define(['durandal/http', 'services/logger'], function (http, logger) {

    var years = [];
    var selectedYear = ko.observable();
    var months = [{ name: " JAN ", value: "01" }, { name: " FEB ", value: "02" }, { name: " MAR ", value: "03" }, { name: " APR ", value: "04" },
                  { name: " MAY ", value: "05" }, { name: " JUN ", value: "06" }, { name: " JUL ", value: "07" }, { name: " AUG ", value: "08" },
                  { name: " SEP ", value: "09" }, { name: " OCT ", value: "10" }, { name: " NOV ", value: "11" }, { name: " DEC ", value: "12" }];   
    var maintenanceBill = ko.observable();

    var getBill = function (args) {
        if (selectedYear() == undefined)
            return;
        maintenanceBill(undefined);
        var month = selectedYear() + args.value;
        var self = this;
        var baseUrl = "http://localhost:9091";
        $.getJSON(baseUrl + "/api/maintenance/1?memberid=1&month=" + month, function (data) {
           maintenanceBill(data);
        });
    };

    return {
        title: 'Maintenance View',
        years: years,
        months: months,
        selectedYear: selectedYear,
        maintenanceBill: maintenanceBill,
        getBill:getBill,
        activate: function () {
            this.years = ["2013", "2012", "2011", "2010" ];            
        }
    };
});