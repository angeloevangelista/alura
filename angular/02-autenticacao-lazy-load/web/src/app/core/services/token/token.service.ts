import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class TokenService {
  private token_key = 'AL_AUTH_TOKEN';

  get hasToken(): boolean {
    return !!this.getToken();
  }

  setToken(token: string) {
    window.localStorage.setItem(this.token_key, token);
  }

  getToken() {
    return window.localStorage.getItem(this.token_key);
  }

  removeToken() {
    if (this.hasToken) window.localStorage.removeItem(this.token_key);
  }
}
