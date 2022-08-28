import { Component, Input, OnInit } from '@angular/core';
import { Recipe } from 'src/app/Entityes/Recipe';

@Component({
  selector: 'app-edit-recipe',
  templateUrl: './edit-recipe.component.html',
  styleUrls: ['./edit-recipe.component.css']
})
export class EditRecipeComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  @Input() recipe: Recipe = {
      id: 0,
      title: "first",
      text: "first text",
      imagePath: "",
      likeCount: 0,
      timer: 0,
      persons: 0,
      tags:  [{text : "Hello"}],
      ingridients:[],
      step:[
        { count:1, description: "Проверка"},
        {count:2, description: "Тест"}
      ],
  }

}
