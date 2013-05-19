define(function () {
    var system = require('durandal/system'),
        viewModel = require('durandal/viewModel');
    
    return {
        activeSample:viewModel.activator(),
        samples: [],        
        activate: function (args) {
            var that = this;

            if (!args.name) {
                args.name = 'helloWorld';
            }

            return system.acquire('modules/settings/' + args.name + '/index').then(function (sample) {
                that.activeSample(sample);
            });
        }
    };
});