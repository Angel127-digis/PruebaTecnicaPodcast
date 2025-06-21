import { TestBed } from '@angular/core/testing';

import { PeticionPodcastService } from './peticion-podcast.service';

describe('PeticionPodcastService', () => {
  let service: PeticionPodcastService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PeticionPodcastService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
