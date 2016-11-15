

/// <reference path="/Assets/admin/libs/angular/angular.js" />

(function (app) {
    app.factory('apiService', apiService);

    apiService.$inject = ['$http'];

    function apiService($http) {
        return {
            get: get                                          // định nghĩa phuog thưc gét
        }

        function get(url, params, success, failure) {
            $http.get(url, params).then(function (result) {
                success(result);                             // hàm success
            }, function (error) {
                failure(error);                              // hàm error bắt lỗi
            });
        }
    }
})(angular.module('cdgshop.common'));