import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IngridientClass } from 'src/app/Entityes/IngridientClass';
import { Recipe } from 'src/app/Entityes/Recipe';
import { ResipeService } from 'src/app/Services/resipe.service';

@Component({
  selector: 'app-add-recipe',
  templateUrl: './add-recipe.component.html',
  styleUrls: ['./add-recipe.component.css']
})
export class AddRecipeComponent implements OnInit {

  uploadImagePath = "./assets/images/Upload.svg";

  recipe: Recipe = new Recipe();

  constructor(private route: ActivatedRoute, private recipeService: ResipeService) { }

  ngOnInit(): void {

    this.initialize();
  }

  checkOnUserLogin(): void {
    
  }
  
  initialize(): void {
    let currentIdStr = this.route.snapshot.paramMap.get('id')?.toString();
    if (currentIdStr !== null && currentIdStr !== undefined) {
      this.recipe.id = Number.parseInt(currentIdStr);
      this.recipeService.getRecypeById(this.recipe.id).subscribe(res => {
        if (res.code == 0)
          this.recipe = JSON.parse(res.content);
      });
    }
  }

  addIngridient():void {
    this.recipe.ingridients.push(new IngridientClass());
  }

  removeIngridient():void {
    this.recipe.ingridients.pop();
  }
}
