import { Component, OnInit } from '@angular/core';
import { SmartInfoCard } from 'src/app/Entityes/SmartInfoCard';

@Component({
  selector: 'app-smart-info',
  templateUrl: './smart-info.component.html',
  styleUrls: ['./smart-info.component.css']
})

export class SmartInfoComponent implements OnInit {

  firstImage = "./assets/images/ic-menu.svg";
  
  secondImage = "./assets/images/ic-cook.svg";
  thirdImage = "./assets/images/ic-chef.svg";
  fourthImage = "./assets/images/Vector(2).svg";

  smartInfoCards: SmartInfoCard[] = [];

  constructor() { }

  ngOnInit(): void {
    this.smartInfoCards = [
      {
        imagePath: this.firstImage,
        text: 'Время приготвления таких блюд не более 1 часа',
        title: 'Простые блюда'
      },
      {
        imagePath: this.secondImage,
        text: 'Самые полезные блюда которые можно детям любого возраста',
        title: 'Детское'
      },
      {
        imagePath: this.thirdImage,
        text: 'Требуют умения, времени и терпения, зато как в ресторане',
        title: 'От шеф-поваров'
      },
      {
        imagePath: this.fourthImage,
        text: 'Чем удивить гостей, чтобы все были сыты за праздничным столом',
        title: 'На праздник'
      }
    ]
  }

}