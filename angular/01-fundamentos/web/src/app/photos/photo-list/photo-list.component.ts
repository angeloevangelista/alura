import { Subject } from 'rxjs';
import { debounceTime } from 'rxjs/operators';
import { ActivatedRoute } from '@angular/router';
import { Component, OnDestroy, OnInit } from '@angular/core';

import { IPhoto } from '../photo/photo';
import { PhotoService } from '../photo/photo.service';

@Component({
  selector: 'ap-photo-list',
  templateUrl: './photo-list.component.html',
})
export class PhotoListComponent implements OnInit, OnDestroy {
  photos: IPhoto[] = [];

  filter = '';
  username: '';
  hasMore = true;
  currentPage = 1;

  debounce = new Subject<string>();

  constructor(
    private route: ActivatedRoute,
    private photoService: PhotoService
  ) {}

  ngOnInit(): void {
    this.photos = this.route.snapshot.data['photos'];
    this.username = this.route.snapshot.params['username'];

    this.debounce
      .pipe(debounceTime(400))
      .subscribe((filter) => (this.filter = filter));
  }

  ngOnDestroy(): void {
    this.debounce.unsubscribe();
  }

  loadPhotos() {
    this.photoService
      .listByUserPaginated(this.username, ++this.currentPage)
      .subscribe((photos) => {
        this.photos = [...this.photos, ...photos];

        this.hasMore = !!photos.length;
      });
  }
}
