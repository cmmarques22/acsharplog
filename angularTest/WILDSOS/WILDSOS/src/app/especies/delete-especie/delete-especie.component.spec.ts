import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteEspecieComponent } from './delete-especie.component';

describe('DeleteEspecieComponent', () => {
  let component: DeleteEspecieComponent;
  let fixture: ComponentFixture<DeleteEspecieComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DeleteEspecieComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DeleteEspecieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
