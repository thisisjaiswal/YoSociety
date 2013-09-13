define(function () {
    var system = require('durandal/system'),
        viewModel = require('durandal/viewModel');
       
    return {
        activeSample:viewModel.activator(),
        samples: [{
            name: 'Notice Board',
            hash: '#/home/noticeBoard',
            moduleId: 'modules/home/noticeBoard'
        },{
            name: 'Maintenance',
            hash: '#/home/maintenance',
            moduleId: 'modules/home/maintenance'
        },{
            name: 'Complain Box',
            hash: '#/home/complainBox',
            moduleId: 'modules/home/complainBox'
        }, {
            name: 'Admin - Maintenance',
            hash: '#/home/adminMaintenance',
            moduleId: 'modules/home/adminMaintenance'
        }],
        societies: ko.observableArray(),
        selectedSociety: ko.observable(),
        activate: function (args) {
            var that = this;

            var mId = sessionStorage.getItem("memberId");

            var baseUrl = "http://localhost:9091";
            $.ajax({
                url: baseUrl + "/api/member/" + mId,
                type: 'GET',
                contentType: 'application/json',
                dataType: 'json',
                success: function (data) {
                    $.each(data, function (i,k) {
                        that.societies.push(k);
                    });
                },
                error: function (data) {

                }
            });            

            if (!args.name) {
                args.name = 'noticeBoard';
            }

            return system.acquire('modules/home/' + args.name).then(function (sample) {
                that.activeSample(sample);
            });
        }
    };
});


