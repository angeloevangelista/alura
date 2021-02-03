import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { AuthService } from 'src/app/core/auth.service';

@Component({
  templateUrl: './signin.component.html',
})
export class SignInComponent implements OnInit {
  loginForm: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private authService: AuthService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.loginForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required],
    });
  }

  login() {
    const loginParams = {
      username: this.loginForm.get('username').value,
      password: this.loginForm.get('password').value,
    };

    this.authService.authenticate(loginParams).subscribe({
      next: (loggedUser) => {
        this.router.navigate(['users', loggedUser.name]);
      },
      error: (err) => {
        alert('Invalid username or password.');
        this.loginForm.reset();
        console.log(err);
      },
    });
  }
}
