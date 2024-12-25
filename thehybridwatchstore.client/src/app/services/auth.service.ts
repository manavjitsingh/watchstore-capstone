import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { BehaviorSubject } from 'rxjs';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private loggedIn = new BehaviorSubject<boolean>(false);
  private userEmail = new BehaviorSubject<string | null>(null);
  private apiUrl = 'https://localhost:4200/api/Auth/';
  constructor(private http: HttpClient, private router: Router) { }
  //register(user: any) {
  //  return this.http.post(`${this.apiUrl}/register`, user);
  //}

  get isLoggedIn() {
    return this.loggedIn.asObservable();
  }

  //login(user: any) {
  //  return this.http.post<any>(`${this.apiUrl}/login`, user).subscribe((res) => {
  //    localStorage.setItem('token', res.token);
  //    this.loggedIn.next(true);
  //    this.router.navigate(['/']);
  //  });
  //}
  //login(user: any): Observable<any> {
  //  return this.http.post<any>(`${this.apiUrl}/login`, user);
  //}
  login(user: any): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/login`, user).pipe(
      tap((res: LoginResponse) => {
        localStorage.setItem('token', res.token);
        this.loggedIn.next(true);
        this.userEmail.next(res.email); // Store the email
      })
    );
  }

  register(user: any): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/register`, user);
  }


  logout() {
    localStorage.removeItem('token');
    this.loggedIn.next(false);
    this.userEmail.next(null);
    this.router.navigate(['/login']);
  }
  getToken() {
    return localStorage.getItem('token');
  }
  get currentUserEmail() {
    return this.userEmail.asObservable();
  }

}
interface LoginResponse {
  token: string;
  email: string;
}
