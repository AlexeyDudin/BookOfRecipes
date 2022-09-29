import { Component, OnInit } from '@angular/core';
import { RecipeDto } from 'src/app/Entityes/Recipe';
import { User } from 'src/app/Entityes/user';
import { ResipeService } from 'src/app/Services/resipe.service';

@Component({
  selector: 'app-top-receipe',
  templateUrl: './top-receipe.component.html',
  styleUrls: ['./top-receipe.component.css']
})
export class TopReceipeComponent implements OnInit {

  constructor(private recipeService: ResipeService) { }
  
  topRecipe: RecipeDto | null = null; 
  // {
  //   id: 0,
  //   owner: new User(),
  //   imagePath: {
  //     url:"./assets/images/Test.png", name:"",
  //   },
  //   title: "Тыквенный супчик на кокосовом молоке",
  //   text: "Если у вас осталась тыква, и вы не знаете что с ней сделать, то это решение для вас! Ароматный, согревающий суп-пюре на кокосовом молоке. Можно даже в Пост!",
  //   likeCount: 123,
  //   timer: 45,
  //   persons: 0,
  //   tags:[],
  //   ingridients:[],
  //   step:[]
  // }

  likeImage="./assets/images/Like.svg";
  timerImage="./assets/images/timer.svg";

  receipeOfDayLogo="./assets/images/ReceipeOfDay.png";

  ngOnInit(): void {
    this.initialize();
  }

  private initialize():void {
    this.recipeService.getTopRecipe().subscribe(result => 
      {
        if (result.content !== null)
          this.topRecipe = JSON.parse(result.content)
      });
  }

}
