import { Component, Input } from '@angular/core';

// ap = alura-pic
@Component({
  selector: 'ap-photo',
  templateUrl: './photo.component.html',
  styleUrls: [],
})
export class PhotoComponent {
  @Input() description = '';

  @Input() url = '';
}
