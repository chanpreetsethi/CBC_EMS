(function () {
    'use strict';
 
    angular
        .module('cbcapp')
        .controller('Benefit', main);
 


function main() {
    alert('t');
    var vm = this;
    vm.name = 'Loading...';
    var request = new XMLHttpRequest();
    request.open("get", "/api/Benefit");
    request.send();
    alert(request.responseText);
    vm.name = request.responseText;
  
    }
//function main() {
//    var vm = this;
//    vm.name = 'pizza';
//}

})();