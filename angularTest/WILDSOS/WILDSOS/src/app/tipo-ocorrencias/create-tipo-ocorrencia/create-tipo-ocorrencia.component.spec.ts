import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateTipoOcorrenciaComponent } from './create-tipo-ocorrencia.component';

describe('CreateTipoOcorrenciaComponent', () => {
  let component: CreateTipoOcorrenciaComponent;
  let fixture: ComponentFixture<CreateTipoOcorrenciaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CreateTipoOcorrenciaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateTipoOcorrenciaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
