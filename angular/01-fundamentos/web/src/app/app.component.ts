import { Component } from '@angular/core';

import { IPhoto, PhotoService } from './photos/photo/photo.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  photos: IPhoto[] = [];

  constructor(photoService: PhotoService) {
    photoService.listByUser('flavio').subscribe({
      next: (response) => (this.photos = response),
      error: (err) => console.error(err),
    });
  }
}
