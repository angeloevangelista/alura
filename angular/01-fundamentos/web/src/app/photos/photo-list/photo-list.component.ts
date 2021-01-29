import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { IPhoto } from '../photo/photo';
import { PhotoService } from '../photo/photo.service';

@Component({
  selector: 'ap-photo-list',
  templateUrl: './photo-list.component.html',
})
export class PhotoListComponent {
  username: string;
  photos: IPhoto[] = [];

  filter = '';

  constructor(
    private photoService: PhotoService,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.username = this.route.snapshot.params['username'];

    this.photoService.listByUser(this.username).subscribe({
      next: (response) => (this.photos = response),
      error: (err) => console.error(err),
    });
  }
}
