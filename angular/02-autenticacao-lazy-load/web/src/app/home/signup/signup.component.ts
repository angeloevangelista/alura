import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import lowerCaseValidator from 'src/app/shared/validators/lower-case.validator';

@Component({
  templateUrl: './signup.component.html',
})
export class SignUpComponent implements OnInit {
  signupForm: FormGroup;

  constructor(private formBuilder: FormBuilder) {}

  ngOnInit(): void {
    this.signupForm = this.formBuilder.group({
      email: ['', [Validators.required, Validators.email]],
      fullname: [
        '',
        [
          Validators.required,
          Validators.minLength(3),
          Validators.maxLength(40),
        ],
      ],
      username: [
        '',
        [
          Validators.required,
          // Validators.pattern(/^[a-z0-9_\-]+$/),
          lowerCaseValidator,
          Validators.minLength(3),
          Validators.maxLength(30),
        ],
      ],
      password: [
        '',
        [
          Validators.required,
          Validators.minLength(6),
          Validators.maxLength(14),
        ],
      ],
    });
  }
}
