movieApp.controller('movieSearchController', ['$scope', 'MovieTitles', function ($scope, MovieTitles) {

    $scope.searchMovies = function () {
        var search = $scope.movieSearchStr;
        if (search.length > 0) {
            MovieTitles.query({ q: search }, function (response) {
                $scope.movies = response;
            });
        }
        else
            $scope.movies = '';
    };
}]);