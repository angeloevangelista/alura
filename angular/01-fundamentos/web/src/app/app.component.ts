import { Component, OnInit } from '@angular/core';

import { IPhoto } from './photos/photo/photo';
import { PhotoService } from './photos/photo/photo.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  photos: IPhoto[] = [];

  constructor(private photoService: PhotoService) {}

  ngOnInit(): void {
    this.photoService.listByUser('flavio').subscribe({
      next: (response) => (this.photos = response),
      error: (err) => console.error(err),
    });
  }
}
