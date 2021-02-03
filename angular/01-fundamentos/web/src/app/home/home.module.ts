import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

import { InputErrorMessageModule } from '../shared/components/input-error-message/input-error-message.module';

import { SignInComponent } from './signin/signin.component';

@NgModule({
  declarations: [SignInComponent],
  imports: [CommonModule, ReactiveFormsModule, InputErrorMessageModule],
})
export class HomeModule {}
