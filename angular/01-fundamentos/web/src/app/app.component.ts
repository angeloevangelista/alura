import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

interface IPhoto {
  url: string;
  description: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  photos: IPhoto[] = [
    // {
    //   description: 'Leão',
    //   url:
    //     'https://images.unsplash.com/photo-1517649281203-dad836b4abe5?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=750&q=80',
    // },
    // {
    //   description: 'Baleia',
    //   url:
    //     'https://images.unsplash.com/photo-1512419944406-9e8e4d4fee8a?ixlib=rb-1.2.1&ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&auto=format&fit=crop&w=750&q=80',
    // },
  ];

  constructor(private httpClient: HttpClient) {
    console.log(this.httpClient);
  }
}
