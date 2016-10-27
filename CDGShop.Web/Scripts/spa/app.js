/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller("schoolController", schoolController);

myApp.directive("cdgShopDirective", cdgShopDirective);

myApp.service('ValidatorService', ValidatorService);

schoolController.$inject = ['$scope', 'ValidatorService'];

function schoolController($scope, ValidatorService) {
    $scope.checkNumber = function () {
        $scope.message = Validator.checkNumber(1);
    }
    $scope.num = 1;
}

function ValidatorService($window) {
    return { checkNumber: checkNumber }

    function checkNumber(input) {
        if (input % 2 == 0) {
            return 'This is even';
        }
        else {
            return 'This is odd';
        }
    }
}
function cdgShopDirective() {
    return {
        restrict: 'A', // giới hạn trị cập cho directive
        templateUrl: "/Scripts/spa/cdgShopDirective.html"
    }
}