import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

interface IPhoto {
  allowComments: boolean;
  comments: number;
  description: string;
  id: number;
  likes: number;
  postDate: Date;
  url: string;
  userId: number;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  photos: IPhoto[] = [];

  constructor(private httpClient: HttpClient) {
    this.httpClient
      .get<IPhoto[]>('http://localhost:3000/flavio/photos')
      .subscribe({
        next: (response) => (this.photos = response),
        error: (err) => console.error(err),
      });
  }
}
