import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateEspecieComponent } from './update-especie.component';

describe('UpdateEspecieComponent', () => {
  let component: UpdateEspecieComponent;
  let fixture: ComponentFixture<UpdateEspecieComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [UpdateEspecieComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(UpdateEspecieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
