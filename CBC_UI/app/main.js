(function () {
    'use strict';
 
    angular
        .module('cbcapp')
        .controller('Benefit', main);
 
    function main() {
        var vm = this;
        vm.name = 'pizza';
    }
 
})();