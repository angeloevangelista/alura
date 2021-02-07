import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { TokenService } from '../token/token.service';

interface ILoginParams {
  username: string;
  password: string;
}

interface ILoginResult {
  email: string;
  id: number;
  name: string;
}

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private baseUrl = 'http://localhost:3000';

  constructor(
    private httpClient: HttpClient,
    private tokenService: TokenService
  ) {}

  authenticate({ password, username }: ILoginParams) {
    return this.httpClient
      .post<ILoginResult>(
        `${this.baseUrl}/user/login`,
        {
          userName: username,
          password,
        },
        {
          observe: 'response',
        }
      )
      .pipe(
        tap((response) => {
          const authToken = response.headers.get('x-access-token');

          authToken && this.tokenService.setToken(authToken);
        })
      );
  }
}
