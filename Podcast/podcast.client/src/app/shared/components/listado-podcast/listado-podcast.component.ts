import { Component, OnInit } from '@angular/core';
import { Podcast } from '../../../core/models/podcast'
import { PeticionPodcastService } from '../../../core/services/peticion-podcast.service';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-listado-podcast',
  standalone: true,
  templateUrl: './listado-podcast.component.html',
  styleUrl: './listado-podcast.component.css',
  imports: [RouterModule]
})
export class ListadoPodcastComponent implements OnInit{

  constructor(private peticion: PeticionPodcastService) { }

  public podcast: Podcast[] = []

  ngOnInit() {
    this.getPodcast()
  }

  getPodcast() {
    this.peticion.getPodcast().subscribe({
      next: result => {
        this.podcast = result
        console.log(this.podcast)
      }
    })
  }
}
