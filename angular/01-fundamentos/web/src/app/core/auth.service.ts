import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

interface ILoginParams {
  username: string;
  password: string;
}

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private baseUrl = 'http://localhost:3000';

  constructor(private httpClient: HttpClient) {}

  authenticate({ password, username }: ILoginParams) {
    return this.httpClient.post(`${this.baseUrl}/user/login`, {
      userName: username,
      password,
    });
  }
}
