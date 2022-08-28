import { Component, Input, OnInit } from '@angular/core';
import { Recipe } from 'src/app/Entityes/Recipe';

@Component({
  selector: 'app-expanded-smart-info-card',
  templateUrl: './expanded-smart-info-card.component.html',
  styleUrls: ['./expanded-smart-info-card.component.css']
})
export class ExpandedSmartInfoCardComponent implements OnInit {

  constructor() {
    
   }

  starImage = "./asset/";

  // recipe: Recipe = 
  // {
  //     title: "",
  //     text: "",
  //     imagePath: "",
  //     likeCount: 0,
  //     timer: 0,
  //     persons: 0,
  //     tags: [],
  // };

  @Input() recipe: Recipe = {
    id: 0,
    title: "",
    text: "",
    imagePath: "",
    likeCount: 0,
    timer: 0,
    persons: 0,
    tags: [
        {
            text : ""
        }],
    ingridients:[],
    step:[]
  }
  ngOnInit(): void {
  }

}
