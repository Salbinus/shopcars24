import { __decorate } from "tslib";
import { Component } from '@angular/core';
let AppComponent = class AppComponent {
    constructor(http) {
        this.http = http;
        this.title = 'shop';
        this.results = [];
        this.products = [];
    }
    ngOnInit() {
        this.http.get('/api/Products').subscribe(data => {
            for (let i in data)
                this.results.push(data[i]);
        });
    }
};
AppComponent = __decorate([
    Component({
        selector: 'app-root',
        templateUrl: './app.component.html',
        styleUrls: ['./app.component.css']
    })
], AppComponent);
export { AppComponent };
//# sourceMappingURL=app.component.js.map