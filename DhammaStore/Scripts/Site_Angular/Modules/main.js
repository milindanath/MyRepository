(function() {
    var dhammaApp = angular.module("dhammaStore", []);

    var dhammaController = function($scope, $http) {
        $scope.message = "Welcome to the dhamma store web page";
    };

    dhammaApp.controller("DhammaController", dhammaController);
}())