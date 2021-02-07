import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';

import { IUser } from '../../services/user/user';

import { UserService } from '../../services/user/user.service';

@Component({
  selector: 'ap-header',
  templateUrl: './header.component.html',
})
export class HeaderComponent {
  user$: Observable<IUser>;

  constructor(private userService: UserService, private router: Router) {
    this.user$ = userService.getUser();
  }

  logOut() {
    this.userService.logOut();
    this.router.navigate(['']);
  }
}
