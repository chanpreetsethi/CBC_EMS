"use strict";
var BenefitListComponent = (function () {
    function BenefitListComponent(heroService) {
        this.heroService = heroService;
        this.mode = 'Observable';
    }
    BenefitListComponent.prototype.ngOnInit = function () { this.getHeroes(); };
    BenefitListComponent.prototype.getHeroes = function () {
        var _this = this;
        this.heroService.getHeroes()
            .subscribe(function (heroes) { return _this.heroes = heroes; }, function (error) { return _this.errorMessage = error; });
    };
    BenefitListComponent.prototype.addHero = function (name) {
        var _this = this;
        if (!name) {
            return;
        }
        this.heroService.addHero(name)
            .subscribe(function (hero) { return _this.heroes.push(hero); }, function (error) { return _this.errorMessage = error; });
    };
    return BenefitListComponent;
}());
exports.BenefitListComponent = BenefitListComponent;
//# sourceMappingURL=Benefit-list.component.js.map