import { ThisReceiver } from '@angular/compiler';
import { Component, Input, OnInit } from '@angular/core';
import { mixinInitialized } from '@angular/material/core';
import { ActivatedRoute } from '@angular/router';
import { Recipe } from 'src/app/Entityes/Recipe';
import { User } from 'src/app/Entityes/user';
import { ResipeService } from 'src/app/Services/resipe.service';

@Component({
  selector: 'app-edit-recipe',
  templateUrl: './edit-recipe.component.html',
  styleUrls: ['./edit-recipe.component.css']
})
export class EditRecipeComponent implements OnInit {

  constructor(private route: ActivatedRoute, private recipeService: ResipeService) { }

  initialize() {
    this.recipe = new Recipe();//{id = Number.parseInt(window.location.href.replace('http://localhost:7119/recipes/', ''))};
    this.recipe.id = Number.parseInt(window.location.href.replace('https://localhost:7119/recipe/', ''));
    this.recipeService.getRecypeById(this.recipe.id).subscribe(res => {
      if (res.code == 0)
        this.recipe = JSON.parse(res.content);
    });
  }

  ngOnInit(): void {
    this.initialize();
  }

  public recipe!: Recipe;/* = {
       id: 0,
       title: "first",
       text: "first text",
       imagePath: {url: "./assets/images/Test.png", name : ""},
       likeCount: 0,
       timer: 0,
       persons: 0,
       tags:  [{text : "Hello"}],
       ingridients:[ {text:"Test1", count:10, typeOfCount:"мл"}],
       step:[
         { count:1, description: "Проверка"},
         { count:2, description: "Тест"}
       ],
       owner: new User(),
   }; //| null = null;*/
}
