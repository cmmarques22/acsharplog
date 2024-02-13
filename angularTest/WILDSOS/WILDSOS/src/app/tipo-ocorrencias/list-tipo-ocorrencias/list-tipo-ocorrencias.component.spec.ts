import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListTipoOcorrenciasComponent } from './list-tipo-ocorrencias.component';

describe('ListTipoOcorrenciasComponent', () => {
  let component: ListTipoOcorrenciasComponent;
  let fixture: ComponentFixture<ListTipoOcorrenciasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ListTipoOcorrenciasComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ListTipoOcorrenciasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
