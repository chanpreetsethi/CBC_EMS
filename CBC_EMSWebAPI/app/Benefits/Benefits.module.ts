import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule, JsonpModule } from '@angular/http';

import { BenefitsComponent } from './Benefits.component';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        JsonpModule
    ],
    declarations: [BenefitsComponent],
    bootstrap: [BenefitsComponent]
})
export class BenefitsModule { }