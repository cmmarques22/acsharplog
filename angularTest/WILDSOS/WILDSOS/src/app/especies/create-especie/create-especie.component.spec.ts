import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateEspecieComponent } from './create-especie.component';

describe('CreateEspecieComponent', () => {
  let component: CreateEspecieComponent;
  let fixture: ComponentFixture<CreateEspecieComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CreateEspecieComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateEspecieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

