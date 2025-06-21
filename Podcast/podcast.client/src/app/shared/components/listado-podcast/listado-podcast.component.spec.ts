import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListadoPodcastComponent } from './listado-podcast.component';

describe('ListadoPodcastComponent', () => {
  let component: ListadoPodcastComponent;
  let fixture: ComponentFixture<ListadoPodcastComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ListadoPodcastComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListadoPodcastComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
