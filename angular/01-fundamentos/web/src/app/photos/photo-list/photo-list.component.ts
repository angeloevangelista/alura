import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subject } from 'rxjs';
import { debounceTime } from 'rxjs/operators';

import { IPhoto } from '../photo/photo';

@Component({
  selector: 'ap-photo-list',
  templateUrl: './photo-list.component.html',
})
export class PhotoListComponent implements OnInit, OnDestroy {
  username: string;
  photos: IPhoto[] = [];

  filter = '';
  debounce = new Subject<string>();

  constructor(private route: ActivatedRoute) {}

  ngOnInit(): void {
    this.photos = this.route.snapshot.data['photos'];

    this.debounce
      .pipe(debounceTime(400))
      .subscribe((filter) => (this.filter = filter));
  }

  ngOnDestroy(): void {
    this.debounce.unsubscribe();
  }
}
