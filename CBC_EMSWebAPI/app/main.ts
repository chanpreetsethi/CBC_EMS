import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app.module';
import { BenefitsModule } from './Benefits/Benefits.module'
const platform = platformBrowserDynamic();
platform.bootstrapModule(AppModule);
platform.bootstrapModule(BenefitsModule);