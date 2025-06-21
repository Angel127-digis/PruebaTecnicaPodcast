import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListadoPodcastComponent } from './shared/components/listado-podcast/listado-podcast.component';
import { FormComponent } from './shared/components/form/form.component';

const routes: Routes = [
  { path: "", component: ListadoPodcastComponent },
  { path: "getPodcast", loadComponent: () => import('./shared/components/listado-podcast/listado-podcast.component').then(m => m.ListadoPodcastComponent) },
  { path: "agregar", loadComponent: () => import('./shared/components/form/form.component').then(m => m.FormComponent) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
