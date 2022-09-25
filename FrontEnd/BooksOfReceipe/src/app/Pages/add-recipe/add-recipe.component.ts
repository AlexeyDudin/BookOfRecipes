import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { LoginComponent } from 'src/app/Components/login/login.component';
import { IngridientClass } from 'src/app/Entityes/IngridientClass';
import { Recipe } from 'src/app/Entityes/Recipe';
import { User } from 'src/app/Entityes/user';
import { ResipeService } from 'src/app/Services/resipe.service';
import { StorageService } from 'src/app/Services/storage.service';

@Component({
  selector: 'app-add-recipe',
  templateUrl: './add-recipe.component.html',
  styleUrls: ['./add-recipe.component.css']
})
export class AddRecipeComponent implements OnInit {

  uploadImagePath = "./assets/images/Upload.svg";

  recipe: Recipe = new Recipe();

  constructor(private route: ActivatedRoute, private recipeService: ResipeService, public login: LoginComponent) { }

  ngOnInit(): void {
    this.checkOnUserLogin();
    this.initialize();
  }

  checkOnUserLogin(): void {
    if (!this.login.isUserAuthorized())
      this.login.openLoginDialog();
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
