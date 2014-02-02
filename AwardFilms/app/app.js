var movieApp = angular.module('movieApp', ['ngResource', 'ngRoute']);

movieApp.config(['$routeProvider', '$locationProvider', function($routeProvider, $locationProvider) {

    $routeProvider.when('/', {
        controller: 'movieSearchController',
        templateUrl: '/app/views/moviesearch.html'
    })
    .when('/details/:id', {
        controller: 'movieDetailsController',
        templateUrl: '/app/views/moviedetails.html'
    })
    .otherwise({
        redirectTo: '/'
    });

    $locationProvider.html5Mode(true);

}]);