import { Component, Pipe } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { IPhoto } from '../photo/photo';

@Component({
  selector: 'ap-photo-list',
  templateUrl: './photo-list.component.html',
})
export class PhotoListComponent {
  username: string;
  photos: IPhoto[] = [];

  filter = '';

  constructor(private route: ActivatedRoute) {}

  ngOnInit(): void {
    this.photos = this.route.snapshot.data['photos'];
  }
}
