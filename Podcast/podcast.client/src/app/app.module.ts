import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListadoPodcastComponent } from './shared/components/listado-podcast/listado-podcast.component';
import { FormComponent } from './shared/components/form/form.component';

@NgModule({
  declarations: [
    AppComponent,
    
    
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule, ListadoPodcastComponent, FormComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
