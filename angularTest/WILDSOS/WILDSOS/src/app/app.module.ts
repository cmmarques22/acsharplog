import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { TipoOcorrenciasModule } from './tipo-ocorrencias/tipo-ocorrencias.module';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    AppComponent,
    //html
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    TipoOcorrenciasModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
