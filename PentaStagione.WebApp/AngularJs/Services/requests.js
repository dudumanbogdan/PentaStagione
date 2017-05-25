(() => {
    angular.module('app.pizza').service('requests',
    [
        '$http', function ($http) {
            this.getUsers = function (cb,err) {
                $http.get('https://jsonplaceholder.typicode.com/posts/1').then(cb).catch(err);
            };
            this.UpdateUser = function (user, succ) {
                var url = "http://localhost:4900/api/users";
                $http.post(url,user).then(succ).catch(() => { console.log("error on edit user"); });
            };
            this.DeleteUser = function (id, succ) {
                var url = "http://localhost:4900/api/users/"+id;
                $http.delete(url).then(succ).catch(() => { console.log("error on delete user"); });
            };
        }
    ]);
})()

//http\://localhost:49900/api/pizza