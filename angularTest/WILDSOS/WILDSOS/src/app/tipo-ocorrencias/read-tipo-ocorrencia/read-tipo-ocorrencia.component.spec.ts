import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReadTipoOcorrenciaComponent } from './read-tipo-ocorrencia.component';

describe('ReadTipoOcorrenciaComponent', () => {
  let component: ReadTipoOcorrenciaComponent;
  let fixture: ComponentFixture<ReadTipoOcorrenciaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ReadTipoOcorrenciaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ReadTipoOcorrenciaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
