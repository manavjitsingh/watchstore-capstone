import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  loginForm: FormGroup;
  errorMessage: string = '';

  constructor(private fb: FormBuilder, private authService: AuthService, private router: Router) {
    this.loginForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(6)]],
    });
  }

  //onSubmit() {
  //  this.authService.login(this.loginForm.value);
  //}
  onSubmit() {
    if (this.loginForm.valid) {
      // Perform the login operation
      this.authService.login(this.loginForm.value).subscribe(
        (res) => {
          localStorage.setItem('token', res.token);
          this.router.navigate(['/']);
        },
        (error) => {
          if (error.status === 401) {
            this.errorMessage = 'Invalid email or password. Please try again.';
          } else {
            this.errorMessage = 'An unexpected error occurred. Please try again later.';
          }
        }
      );
    }
  }
  navigateToRegister() {
    this.router.navigate(['/register']);
  }
}
