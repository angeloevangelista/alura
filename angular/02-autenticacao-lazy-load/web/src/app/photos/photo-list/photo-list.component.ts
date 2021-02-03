import { ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';

import { IPhoto } from '../photo/photo';
import { PhotoService } from '../photo/photo.service';

@Component({
  selector: 'ap-photo-list',
  templateUrl: './photo-list.component.html',
})
export class PhotoListComponent implements OnInit {
  photos: IPhoto[] = [];

  filter = '';
  username: '';
  hasMore = true;
  currentPage = 1;

  constructor(
    private route: ActivatedRoute,
    private photoService: PhotoService
  ) {}

  ngOnInit(): void {
    this.photos = this.route.snapshot.data['photos'];
    this.username = this.route.snapshot.params['username'];
  }

  loadPhotos() {
    this.photoService
      .listByUserPaginated(this.username, ++this.currentPage)
      .subscribe((photos) => {
        this.photos = [...this.photos, ...photos];

        this.hasMore = !!photos.length;

        this.filter = '';
      });
  }
}
