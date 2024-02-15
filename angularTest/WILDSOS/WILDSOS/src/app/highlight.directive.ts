import { Directive, ElementRef, HostListener } from "@angular/core";

@Directive({
  standalone: true,
  selector: '[appHighlight]',
})
export class HighlightDirective {
  constructor(private el: ElementRef) {}

  @HostListener('mouseenter') onMouseEnter() {
    this.highlight('yellow');
    this.fontcolor('blue');
  }

  @HostListener('mouseleave') onMouseLeave() {
    this.highlight('');
  }

  private highlight(color: string) {
    this.el.nativeElement.style.backgroundColor = color;

  }
  private fontcolor(color: string) {
    this.el.nativeElement.style.color = color;

  }
}