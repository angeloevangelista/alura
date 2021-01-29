import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';

import { PhotoComponent } from './photo/photo.component';
import { PhotoListComponent } from './photo-list/photo-list.component';
import { PhotosComponent } from './photo-list/photos/photos.component';
import { FilterByDescriptionPipe } from './photo-list/filter-by-description.pipe';

@NgModule({
  declarations: [
    PhotoComponent,
    PhotoListComponent,
    PhotosComponent,
    FilterByDescriptionPipe,
  ],
  exports: [],
  imports: [CommonModule, HttpClientModule],
})
export class PhotosModule {}
