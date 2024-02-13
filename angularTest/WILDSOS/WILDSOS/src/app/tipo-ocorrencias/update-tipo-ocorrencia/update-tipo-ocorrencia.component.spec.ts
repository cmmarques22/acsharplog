import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateTipoOcorrenciaComponent } from './update-tipo-ocorrencia.component';

describe('UpdateTipoOcorrenciaComponent', () => {
  let component: UpdateTipoOcorrenciaComponent;
  let fixture: ComponentFixture<UpdateTipoOcorrenciaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [UpdateTipoOcorrenciaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(UpdateTipoOcorrenciaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
