import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-top-receipe',
  templateUrl: './top-receipe.component.html',
  styleUrls: ['./top-receipe.component.css']
})
export class TopReceipeComponent implements OnInit {

  constructor() { }
  
  topReceipeImage="./assets/images/Rectangle 8.png";
  likeImage="./assets/images/Like.svg";
  timerImage="./assets/images/timer.svg";

  receipeOfDayLogo="./assets/images/ReceipeOfDay.png";

  likeCount=123;
  timeCount="35 минут"

  ngOnInit(): void {
  }

}
