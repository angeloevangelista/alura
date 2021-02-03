import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { InputErrorMessageComponent } from './input-error-message.component';

@NgModule({
  imports: [CommonModule],
  declarations: [InputErrorMessageComponent],
  exports: [InputErrorMessageComponent],
})
export class InputErrorMessageModule {}
