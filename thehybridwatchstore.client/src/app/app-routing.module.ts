import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { WatchDetailsComponent } from './watch-details/watch-details.component'
import { ProductsComponent } from './products/products.component'
import { LoginComponent } from './login/login.component'
import { RegisterComponent } from './register/register.component'
const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'watch/:id', component: WatchDetailsComponent },
  { path: 'products', component: ProductsComponent },
  { path: 'login', component: LoginComponent },           
  { path: 'register', component: RegisterComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
