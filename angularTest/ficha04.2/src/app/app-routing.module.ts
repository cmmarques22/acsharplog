import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MostrarOcultarComponent } from './mostrar-ocultar/mostrar-ocultar.component';
import { AvaliacaoComponent} from './avaliacao/avaliacao.component'
const routes: Routes = [
  {path: 'MostrarOcultarComponent', component: MostrarOcultarComponent},
  {path: 'AvaliacaoComponent' , component: AvaliacaoComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

