import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReadEspecieComponent } from './read-especie.component';

describe('ReadEspecieComponent', () => {
  let component: ReadEspecieComponent;
  let fixture: ComponentFixture<ReadEspecieComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ReadEspecieComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ReadEspecieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
