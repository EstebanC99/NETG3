import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

// const API = environment.ApiUrl;
const API = '/api';
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
};

@Injectable({
  providedIn: 'root',
})
export class BaseService {
  constructor(private http: HttpClient) {}

  getAll<T>(section: string, extra?: { [key: string]: string }): Observable<T> {
    return this.http.get<T>(API + '/' + section, extra);
  }
  getOne<T>(
    section: string,
    id: number,
    extra?: { [key: string]: string }
  ): Observable<T> {
    return this.http.get<T>(API + '/' + section + '/' + id, extra);
  }

  postOne(section: string, body: any): Observable<any> {
    return this.http.post(API + '/' + section, body);
  }
}
