import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

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

  constructor(private httpClient: HttpClient) {}

  authenticate({ password, username }: ILoginParams): Observable<ILoginResult> {
    return this.httpClient.post<ILoginResult>(`${this.baseUrl}/user/login`, {
      userName: username,
      password,
    });
  }
}
