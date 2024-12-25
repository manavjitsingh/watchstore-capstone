import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { WatchDto } from '../models/watch-dto.model';
/*import { HttpParams } from '@angular/common/http';*/
import {HttpParams, HttpResponse } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class WatchService {
  private apiUrl = 'https://localhost:4200/api/Watches/';

  constructor(private http: HttpClient) { }

  searchWatches(query: string): Observable<any> {
    return this.http.get(`${this.apiUrl}/Search?query=${query}`);
  }
  searchWatchById(id: number): Observable<any> {
    return this.http.get(`${this.apiUrl}/${id}`);
  }
  //getAllWatches(pageNumber: number, pageSize: number, sortBy: string, sortDirection: string): Observable<WatchDto[]> {
  //  const params = new HttpParams()
  //    .set('pageNumber', pageNumber.toString())
  //    .set('pageSize', pageSize.toString())
  //    .set('sortBy', sortBy)
  //  .set('sortDirection', sortDirection);


  //  //return this.http.get<WatchDto[]>(`${this.apiUrl}/`);
  //  return this.http.get<WatchDto[]>(`${this.apiUrl}`, { params });
  //  /*return this.http.get<{ totalItems: number, watchDtos: WatchDto[] }>(`${this.apiUrl}`, { params });*/
  //}
  getAllWatches(pageNumber: number, pageSize: number, sortBy: string, sortDirection: string): Observable<HttpResponse<{ watchDtos: WatchDto[], totalItems: number }>> {
    const params = new HttpParams()
      .set('pageNumber', pageNumber.toString())
      .set('pageSize', pageSize.toString())
      .set('sortBy', sortBy)
      .set('sortDirection', sortDirection);

    /*return this.http.get<WatchDto[]>(`${this.apiUrl}`, { params, observe: 'response' });*/
    return this.http.get<{ watchDtos: WatchDto[], totalItems: number }>(`${this.apiUrl}`, { params, observe: 'response' }).pipe(
      tap(response => {
        console.log('Received JSON response:', response.body);
      })
    );
  }

}
