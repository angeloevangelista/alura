import { Component } from '@angular/core';

import { IPhoto } from '../photo/photo';
import { PhotoService } from '../photo/photo.service';

@Component({
  selector: 'ap-photo-list',
  templateUrl: './photo-list.component.html',
})
export class PhotoListComponent {
  photos: IPhoto[] = [];

  constructor(private photoService: PhotoService) {}

  ngOnInit(): void {
    this.photoService.listByUser('flavio').subscribe({
      next: (response) => (this.photos = response),
      error: (err) => console.error(err),
    });
  }
}
