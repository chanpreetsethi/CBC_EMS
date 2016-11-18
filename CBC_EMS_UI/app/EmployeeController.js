angular.module('BenefitApp', [])
    .controller('BenefitCtrl', function ($scope, $http) {
        $scope.userName = "";
        $scope.ShowEmployeeButton = false;
        $scope.ShowEmployeeData = false;
        $scope.EmployeeName = "";
        $scope.Salary = "";
        $scope.Benefits = "";
        $scope.RemainingVacationDays = 0;
        $scope.userData = "";
        $scope.password = "";
        $scope.loggedin = false;
        $scope.name = "First Record";
        $scope.correctAnswer = false;
        $scope.working = false;

        $scope.validateUser = function () {
            $scope.working = true;
            $scope.answered = true;
            var userinfo =  $scope.userName + "," + $scope.password;
            //$http.post('/api/Employee', { "data": $scope.userName.toString() + "," + $scope.password.toString() }).success
            $http({
                url: '/api/Employee',
                method: 'POST',
                data: JSON.stringify(userinfo),
                headers: { 'Content-Type': 'application/json' },
            }).success(function (data, status, headers, config) {
                
                $scope.loggedin = (data === true);
                if ($scope.loggedin === true)
                {
                    $scope.ShowEmployeeButton = true;
                }
                else
                {
                    $scope.ShowEmployeeButton = false;
                }
                $scope.working = false;
            }).error(function (data, status, headers, config) {
                alert('some error');
                $scope.title = "Oops... something went wrong";
                $scope.working = false;
            });
        };

        $scope.GetEmployeeInfo = function () {
            
            $scope.working = true;
            $scope.answered = false;
            $scope.title = "loading Employee Data...";

            $http.get("/api/Employee/" + $scope.userName).success(function (data, status, headers, config) {
                $scope.userData = data;
                var empData = data.toString().split(",");
                $scope.EmployeeName = empData[0];
                $scope.Salary = empData[1];
                $scope.Benefits = empData[2];
                $scope.RemainingVacationDays = empData[3];
                $scope.ShowEmployeeData = true;
                $scope.answered = false;
                $scope.working = false;
            }).error(function (data, status, headers, config) {
                $scope.title = "Oops... something went wrong";
                $scope.working = false;
            });
        };

    });