import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteTipoOcorrenciaComponent } from './delete-tipo-ocorrencia.component';

describe('DeleteTipoOcorrenciaComponent', () => {
  let component: DeleteTipoOcorrenciaComponent;
  let fixture: ComponentFixture<DeleteTipoOcorrenciaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DeleteTipoOcorrenciaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DeleteTipoOcorrenciaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
