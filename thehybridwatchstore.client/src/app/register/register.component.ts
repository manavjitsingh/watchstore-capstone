//import { Component } from '@angular/core';
//import { Router } from '@angular/router';
//import { FormBuilder, FormGroup, Validators } from '@angular/forms';
//import { AuthService } from '../services/auth.service';

//@Component({
//  selector: 'app-register',
//  templateUrl: './register.component.html',
//  styleUrl: './register.component.css'
//})
//export class RegisterComponent {
//  registerForm: FormGroup;

//  constructor(private fb: FormBuilder, private router: Router, private authService: AuthService) {
//    this.registerForm = this.fb.group({
//      email: ['', [Validators.required, Validators.email]],
//      password: ['', [Validators.required, Validators.minLength(6)]],
//      confirmPassword: ['', [Validators.required]]
//    }, { validator: this.passwordMatchValidator });
//  }

//  passwordMatchValidator(formGroup: FormGroup) {
//    const password = formGroup.get('password')?.value;
//    const confirmPassword = formGroup.get('confirmPassword')?.value;

//    return password === confirmPassword ? null : { mismatch: true };
//  }

//  onSubmit() {
//    if (this.registerForm.valid) {
//      this.authService.register(this.registerForm.value).subscribe(
//        () => {
//          // Navigate to the login page on successful registration
//          this.router.navigate(['/login']);
//        },
//        error => {
//          // Handle error case
//          console.error('Registration error: ', error);
//        }
//      );
//    }
//  }

//  navigateToLogin() {
//    this.router.navigate(['/login']);
//  }
//}

import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  registerForm: FormGroup;
  errorMessage: string = ''; // Add a property to store the error message

  constructor(private fb: FormBuilder, private router: Router, private authService: AuthService) {
    this.registerForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(6)]],
      confirmPassword: ['', [Validators.required]]
    }, { validator: this.passwordMatchValidator });
  }

  passwordMatchValidator(formGroup: FormGroup) {
    const password = formGroup.get('password')?.value;
    const confirmPassword = formGroup.get('confirmPassword')?.value;

    return password === confirmPassword ? null : { mismatch: true };
  }

  onSubmit() {
    console.log("submit hit")
    if (this.registerForm.valid) {
      this.authService.register(this.registerForm.value).subscribe(
        () => {
          // Navigate to the login page on successful registration
          this.router.navigate(['/login']);
        },
        (error) => {
          // Handle error case
          if (error.status === 400) {
            this.errorMessage = 'Email already in use. Please use a different email.';
          } else if (error.status === 409) {
            this.errorMessage = 'Email already in use. Please use a different email.';
          } else {
            this.errorMessage = 'An unexpected error occurred. Please try again later.';
          }
        }
      );
    }
  }

  navigateToLogin() {
    this.router.navigate(['/login']);
  }
}

