(() => {
    angular.module('app.pizza', ['ngRoute'])
        .config([
            '$routeProvider', ($routeProvider) => {
                $routeProvider
                    .when('/users',
                    {
                        templateUrl: 'AngularJs/Views/Users.html',
                        controller: 'usersController'
                    })
                    .when('/newUser',
                    {
                        templateUrl: 'AngularJs/Viwes/newUser.html',
                        controller: 'usersController'
                    })
                     .when("/users/edit/:id",
                    {
                        templateUrl: "AngularJs/Views/EditUser.html",
                        controller: "usersController"
                    })
                .otherwise({
                    redirectTo: '/'
                });
            }
        ]);
})();