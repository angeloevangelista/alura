import { tap } from 'rxjs/operators';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { UserService } from '../user/user.service';

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
    private userService: UserService
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

          authToken && this.userService.setToken(authToken);
        })
      );
  }
}
