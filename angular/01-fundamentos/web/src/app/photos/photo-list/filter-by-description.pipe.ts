import { Pipe, PipeTransform } from '@angular/core';
import { IPhoto } from '../photo/photo';

@Pipe({
  name: 'filterByDescription',
})
export class FilterByDescriptionPipe implements PipeTransform {
  transform(photos: IPhoto[], descriptionQuery: string) {
    descriptionQuery = descriptionQuery.trim().toLowerCase();

    if (!descriptionQuery) return photos;

    return photos.filter((photo) =>
      photo.description.trim().toLowerCase().includes(descriptionQuery)
    );
  }
}
