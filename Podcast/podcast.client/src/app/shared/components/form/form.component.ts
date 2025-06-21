import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators, FormsModule } from '@angular/forms';
import { Podcast } from '../../../core/models/podcast';
import { RouterModule } from '@angular/router';
import { PeticionPodcastService } from '../../../core/services/peticion-podcast.service';
import { Episodio } from '../../../core/models/episodio';
import { Categoria } from '../../../core/models/categoria';
import { Idioma } from '../../../core/models/idioma';

@Component({
  selector: 'app-form',
  standalone: true,
  templateUrl: './form.component.html',
  styleUrl: './form.component.css',
  imports: [FormsModule, RouterModule]
})
export class FormComponent implements OnInit {

  public podcast: Podcast = {
    nombre: '',
    episodio: {
      idEpisodio: 0,
      numeroEpisodio: ''
    },
    descripcion: '',
    fechaDePublicacion: '',
    fechaDeCaducidad: '',
    audioURL: '',
    categoria: {
      idCategoria: 0,
      nombreCategoria: ''
    },
    imagen: '',
    duracion: 0,
    idioma: {
      idIdioma: 0,
      nombreIdioma: ''
    }
  }

  public episodios: Episodio[] = []

  public categorias: Categoria[] = []

  public idiomas: Idioma[] = []

  constructor(private peticion: PeticionPodcastService) { }

  ngOnInit() {
    this.getEpisodios()
    this.getCategorias()
    this.getIdioma()
  }

  getEpisodios() {
    this.peticion.getEpisodios().subscribe({
      next: result => {
        this.episodios = result
        console.log(result)
      },
      error: error => {
        console.error(error)
      }
    })
  }

  getCategorias() {
    this.peticion.getCategoria().subscribe({
      next: result => {
        this.categorias = result
        console.log(result)
      },
      error: error => {
        console.error(error)
      }
    })
  }

  getIdioma() {
    this.peticion.getIdiomas().subscribe({
      next: result => {
        this.idiomas = result
        console.log(result)
      },
      error: error => {
        console.error(error)
      }
    })
  }

  Submit(form: NgForm) { }
}
