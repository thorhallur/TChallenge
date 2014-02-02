movieApp.factory('MovieTitles', ['$resource', function ($resource) {
    return $resource('/api/titles', {}, { query: { method: 'GET', params: { q: '' }, isArray: true } });
}]);

movieApp.factory('MovieDetails', ['$resource', function ($resource) {
    return $resource('/api/storylines/:id', {}, { query: { method: 'GET', params: { id: '@id' }, isArray: true } });
}]);

movieApp.factory('MovieTitle', ['$resource', function ($resource) {
    return $resource('/api/titles/:id', {}, { query: { method: 'GET', params: { id: '@id' }, isArray: false } });
}]);