(function (app) {
    app.controller('rootController', rootController);

    rootController.$inject = ['$state', '$scope'];

    function rootController($state, $scope) {
        $scope.logout = function () {            
            $state.go('login');
        }
    }
})(angular.module('tranninshop'));