(() => {
    angular.module('app.pizza').controller('usersController',
    [
        '$scope', '$location','$routeParams', 'requests', function($scope, $location, $routeParams, requests) {
            requests.getUsers(function(data) {
                    $scope.users = data;
                    $scope.users = [
                        {"UserName":"Ion", "Role":"admin", "Id":"100"},
                        {"UserName":"Ion1", "Role":"user", "Id":"101"},
                        {"UserName":"Ion2", "Role":"user", "Id":"102"},
                    ];
                    angular.forEach($scope.users,
                        function(user) {
                            if ($routeParams.id == user.Id) {
                                $scope.currentUser = user;
                                breakAfter();
                            }
                        });
                },
                function() {console.log("err")}
            );
            $scope.edit = function(id) {
                $location.path("users/edit/" + id);
            };
            $scope.save = function(user) {
                requests.UpdateUser(user, function(data) {
                    $location.path("/users");
                });
            };
            $scope.delete = function(id) {
                requests.DeleteUser(id, () => {
                    $location.path("/users");
                });
            };
        }
    ]);
})();