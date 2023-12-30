import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { DetailsComponent } from './details/details.component';

export const routes: Routes = [
    { path:'', component:HomeComponent},
    { path:'details/:id', component:DetailsComponent}, 
    { path: 'about', component:AboutComponent}
];
