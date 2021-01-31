import { HttpClient, HttpParams } from '@angular/common/http';
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

  listByUserPaginated(username: string, page: number) {
    const params = new HttpParams().set('page', String(page));

    return this.httpClient.get<IPhoto[]>(`${this.baseUrl}/${username}/photos`, {
      params,
    });
  }
}
