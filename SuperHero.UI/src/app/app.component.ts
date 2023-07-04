import { Component } from '@angular/core';
import { SuperHero } from './models/super-hero';
import { SuperHeroService } from './services/super-hero.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'SuperHero.UI';

  heroes: SuperHero[] = [];

  constructor(private superHeroService: SuperHeroService){}

  ngOnInit(): void {
    // this.superHeroService.getSuperHeroes().subscribe((x: SuperHero[]) => this.heroes = x);
    this.superHeroService.getSuperHeroes().subscribe({
      next: albums =>{
        this.heroes=albums
      }
    })
    console.log(this.heroes);
  }

}
