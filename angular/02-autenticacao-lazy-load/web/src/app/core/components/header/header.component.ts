import { Component } from '@angular/core';
import { Observable } from 'rxjs';

import { IUser } from '../../services/user/user';

import { UserService } from '../../services/user/user.service';

@Component({
  selector: 'ap-header',
  templateUrl: './header.component.html',
})
export class HeaderComponent {
  user$: Observable<IUser>;
  user: IUser;

  constructor(private userService: UserService) {
    this.user$ = userService.getUser();
    this.user$.subscribe((user) => (this.user = user));
  }
}
