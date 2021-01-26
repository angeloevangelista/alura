import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { IPhoto } from './photo';

@Injectable({
  providedIn: 'root', // uma instancia para todo o app
})
export class PhotoService {
  private baseUrl = 'http://localhost:3000';

  constructor(private httpClient: HttpClient) {}

  listByUser(username: string) {
    return this.httpClient.get<IPhoto[]>(`${this.baseUrl}/${username}/photos`);
  }
}
