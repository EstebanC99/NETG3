import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpHeaders
} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class AuthInterceptor implements HttpInterceptor {

  constructor() {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    const token = localStorage.getItem("token");
    const httpHeader = {
      headers: new HttpHeaders({
        Accept: `application/*`,
      }),
    };
    if (token) {
      request = request.clone({
        headers: httpHeader.headers.set("Authorization", `Bearer ${token}`),
      });
    }
    return next.handle(request);
  }
}
