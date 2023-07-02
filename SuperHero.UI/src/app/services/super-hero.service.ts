import { Injectable } from '@angular/core';
import { SuperHero } from '../models/super-hero';

@Injectable({
  providedIn: 'root'
})
export class SuperHeroService {

  constructor() { }

  public getSuperHeroes() : SuperHero [] {
    let hero = new SuperHero();

    hero.id
    hero.firstName
    hero.lastName
    hero.name
    hero.place

    return [hero];
  }
}
