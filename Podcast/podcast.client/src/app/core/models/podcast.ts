import { Categoria } from "./categoria"
import { Episodio } from "./episodio"
import { Idioma } from "./idioma"

export interface Podcast {
  nombre: string
  episodio: Episodio
  descripcion: string
  fechaDePublicacion: string
  fechaDeCaducidad: string
  audioURL: string
  categoria: Categoria
  imagen: string
  duracion: number
  idioma: Idioma
}
