angular
    .module('myApp', [
        'myApp.ctrl.home',
        'myApp.ctrl.contact',
        'myApp.ctrl.about'
    ])
    .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        $routeProvider.when('/', {
            templateUrl: '/home/home',
            controller: 'homeCtrl',
        });
        $routeProvider.when('/about', {
            templateUrl: 'home/about',
            controller: 'aboutCtrl',
        });
        $routeProvider.when('/contact', {
            templateUrl: 'home/contact',
            controller: 'contactCtrl'
        });
        $routeProvider.otherwise({
            redirectTo: '/'
        });

        // Specify HTML5 mode (using the History APIs) or HashBang syntax.
        $locationProvider.html5Mode(false).hashPrefix('!');

    }]);
