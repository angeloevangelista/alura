import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

import { PhotoComponent } from './photo/photo.component';
import { PhotosComponent } from './photo-list/photos/photos.component';
import { PhotoListComponent } from './photo-list/photo-list.component';
import { LoadButtonComponent } from './photo-list/load-button/load-button.component';

import { FilterByDescriptionPipe } from './photo-list/filter-by-description.pipe';

@NgModule({
  declarations: [
    PhotoComponent,
    PhotosComponent,
    PhotoListComponent,
    LoadButtonComponent,
    FilterByDescriptionPipe,
  ],
  exports: [],
  imports: [CommonModule, HttpClientModule],
})
export class PhotosModule {}
