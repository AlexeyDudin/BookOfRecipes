import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { RecipeDto } from 'src/app/Entityes/Recipe';
import { User } from 'src/app/Entityes/user';
import { ResipeService } from 'src/app/Services/resipe.service';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html',
  styleUrls: ['./recipes.component.css']
})
export class RecipesComponent implements OnInit {
  name: string = "recipes";

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private recipeService: ResipeService
  ) {}

  @Input() recipes: RecipeDto[] = [];
  // [
  //   {
  //     id: 1,
  //     title: "first",
  //     text: "first text",
  //     owner: new User(),
  //     imagePath: {
  //       url:"./assets/images/Test.png", name:"",
  //     },
  //     likeCount: 0,
  //     timer: 0,
  //     persons: 0,
  //     tags:  [{text : "Hello"}],
  //     ingridients: [],
  //     step:[
  //       { count:1, description: "Проверка"},
  //       {count:2, description: "Тест"}
  //     ],
  //   },
  //   {
  //     id:2,
  //     title: "second",
  //     text: "first text",
  //     owner: new User(),
  //     imagePath: {
  //       url:"./assets/images/Test.png", name:"",
  //     },
  //     likeCount: 0,
  //     timer: 0,
  //     persons: 0,
  //     tags:  [{text : "Hello"}],
  //     ingridients:[],
  //     step:[],
  //   }
  // ];

  ngOnInit(): void {
    this.initialize();
  }

  initialize(): void {
    this.route.queryParams.subscribe(params => {
      this.name = params['name'];
    });
    this.recipeService.getRecipes().subscribe(res => 
      {
        if (res.code === 0)
          this.recipes = JSON.parse(res.content);
      });
  }

  recipeClick(recipeId: number){
  }

  ViewRecipe(index: any) {
    this.router.navigate(['recipe/', index]);
  }

  GotoAddRecipe() {
    this.router.navigate(['add-recipe']);
  }
}
