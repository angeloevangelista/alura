import { Component, Input } from '@angular/core';

@Component({
  selector: 'ap-input-error-message',
  templateUrl: './input-error-message.component.html',
})
export class InputErrorMessageComponent {
  @Input() message: string;
}
