import { Injectable } from '@angular/core';
import { Recipe } from '../Entityes/Recipe';
import { User } from '../Entityes/user';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class ResipeService {

  constructor(private baseService: BaseService) { }

  getRecypeById(recipe: Recipe) {
    return this.baseService.sendPost('/api/recipe/byId', recipe);
  }

  getUserRecypes(user: User) {
    
  }
}
