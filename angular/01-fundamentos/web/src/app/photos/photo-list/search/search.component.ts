import { Subject } from 'rxjs';
import { debounceTime } from 'rxjs/operators';
import {
  Component,
  EventEmitter,
  Input,
  OnDestroy,
  OnInit,
  Output,
} from '@angular/core';

@Component({
  selector: 'ap-search',
  templateUrl: 'search.component.html',
})
export class SearchComponent implements OnInit, OnDestroy {
  @Output() onTyping = new EventEmitter<string>();

  @Input() value = '';

  debounce = new Subject<string>();

  ngOnInit(): void {
    this.debounce
      .pipe(debounceTime(400))
      .subscribe((filter) => this.onTyping.emit(filter));
  }

  ngOnDestroy(): void {
    this.debounce.unsubscribe();
  }
}
