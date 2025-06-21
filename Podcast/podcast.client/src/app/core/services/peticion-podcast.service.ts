import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { Podcast } from '../models/podcast';
import { Result } from '../models/result';
import { Categoria } from '../models/categoria';
import { Episodio } from '../models/episodio';
import { Idioma } from '../models/idioma';

@Injectable({
  providedIn: 'root'
})
export class PeticionPodcastService {

  constructor(private http: HttpClient) { }

  private URL_PODCAST_GET = 'http://localhost:5225/api/Podcast/getPodcasts'
  private URL_EPISODIOS_GET = 'http://localhost:5225/api/Podcast/getEpisodios'
  private URL_CATEGORIAS_GET = 'http://localhost:5225/api/Podcast/getCategorias'
  private URL_IDIOMAS_GET = 'http://localhost:5225/api/Podcast/getIdiomas'

  getPodcast(): Observable<Podcast[]> {
    return this.http.get<Result>(this.URL_PODCAST_GET).pipe(
      map(result => result.objects)
    )
  }


  getEpisodios(): Observable<Episodio[]> {
    return this.http.get<Result>(this.URL_EPISODIOS_GET).pipe(
      map(result => result.objects)
    )
  }

  getCategoria(): Observable<Categoria[]> {
    return this.http.get<Result>(this.URL_CATEGORIAS_GET).pipe(
      map(result => result.objects)
    )
  }

  getIdiomas(): Observable<Idioma[]> {
    return this.http.get<Result>(this.URL_IDIOMAS_GET).pipe(
      map(result => result.objects)
    )
  }
}
