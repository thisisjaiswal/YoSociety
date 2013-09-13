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
        }],
        links: [{
            name: 'Add Society',
            hash: '#/home/addSociety',
            moduleId: 'modules/home/addSociety'
        }, {
            name: 'Register Society',
            hash: '#/home/registerSociety',
            moduleId: 'modules/home/registerSociety'
        }],
        societies: [{
            name: 'NG Shelter'            
        },{
            name: 'Lodha Splendora'          
        }],        
        activate: function (args) {
            var that = this;

            if (!args.name) {
                args.name = 'noticeBoard';
            }

            return system.acquire('modules/home/' + args.name).then(function (sample) {
                that.activeSample(sample);
            });
        }
    };
});