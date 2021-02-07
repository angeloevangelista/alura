import { BehaviorSubject, Subject } from 'rxjs';
import jwtDecode from 'jwt-decode';
import { Injectable } from '@angular/core';

import { IUser } from './user';

import { TokenService } from '../token/token.service';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  private _userSubject: BehaviorSubject<IUser>;

  constructor(private tokenService: TokenService) {
    this._userSubject = new BehaviorSubject(null);

    this.tokenService.hasToken && this.decodeAndNotify();
  }

  setToken(token: string) {
    this.tokenService.setToken(token);

    this.decodeAndNotify();
  }

  getUser() {
    return this._userSubject.asObservable();
  }

  private decodeAndNotify() {
    const token = this.tokenService.getToken();

    const decodedPayload = jwtDecode<IUser>(token);

    this._userSubject.next(decodedPayload);
  }
}
