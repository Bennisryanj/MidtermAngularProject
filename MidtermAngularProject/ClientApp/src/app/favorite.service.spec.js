"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var favorite_service_1 = require("./favorite.service");
describe('FavoriteService', function () {
    beforeEach(function () { return testing_1.TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = testing_1.TestBed.get(favorite_service_1.FavoriteService);
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=favorite.service.spec.js.map