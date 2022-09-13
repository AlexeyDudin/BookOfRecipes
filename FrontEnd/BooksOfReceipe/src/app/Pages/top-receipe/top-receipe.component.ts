import { Component, OnInit } from '@angular/core';
import { Recipe } from 'src/app/Entityes/Recipe';
import { User } from 'src/app/Entityes/user';

@Component({
  selector: 'app-top-receipe',
  templateUrl: './top-receipe.component.html',
  styleUrls: ['./top-receipe.component.css']
})
export class TopReceipeComponent implements OnInit {

  constructor() { }
  
  topRecipe: Recipe = {
    id: 0,
    owner: new User(),
    imagePath: {
      url:"./assets/images/Test.png", name:"",
    },
    title: "Тыквенный супчик на кокосовом молоке",
    text: "Если у вас осталась тыква, и вы не знаете что с ней сделать, то это решение для вас! Ароматный, согревающий суп-пюре на кокосовом молоке. Можно даже в Пост!",
    likeCount: 123,
    timer: 45,
    persons: 0,
    tags:[],
    ingridients:[],
    step:[]
  }

  // topReceipeImage="./assets/images/Rectangle 8.png";
  likeImage="./assets/images/Like.svg";
  timerImage="./assets/images/timer.svg";

  receipeOfDayLogo="./assets/images/ReceipeOfDay.png";

  // likeCount=123;
  // timeCount="35"

  ngOnInit(): void {
  }

}
