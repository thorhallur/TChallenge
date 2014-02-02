movieApp.controller('movieDetailsController', ['$scope', '$routeParams', 'MovieDetails', 'MovieTitle', function ($scope, $routeParams, MovieDetails, MovieTitle) {

    if ($routeParams.id) {
        MovieDetails.query({ id: $routeParams.id }, function (response) {
            $scope.storylines = response;     
        });

        MovieTitle.query({ id: $routeParams.id }, function (response) {
            $scope.movie = response;
        });
    }

}]);