import {
  Directive,
  ElementRef,
  HostListener,
  Input,
  Renderer2,
} from '@angular/core';

@Directive({
  selector: '[apDarkenOnHover]',
})
export class DarkenOnHoverDirective {
  @Input() brightness = 7;

  constructor(private elementRef: ElementRef, private renderer: Renderer2) {
    this.renderer.setStyle(
      this.elementRef.nativeElement,
      'transition',
      'filter 0.25s'
    );
  }

  @HostListener('mouseover')
  darkenOn() {
    this.renderer.setStyle(
      this.elementRef.nativeElement,
      'filter',
      `brightness(${this.brightness * 100}%)`
    );
  }

  @HostListener('mouseleave')
  darkenOff() {
    this.renderer.setStyle(
      this.elementRef.nativeElement,
      'filter',
      `brightness(100%)`
    );
  }
}
