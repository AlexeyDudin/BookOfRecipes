import { Component, OnInit } from '@angular/core';
import { Input } from '@angular/core';
import { SmartInfoCard } from 'src/app/Classes/CardClass';

@Component({
  selector: 'app-smart-info-card',
  templateUrl: './smart-info-card.component.html',
  styleUrls: ['./smart-info-card.component.css']
})
export class SmartInfoCardComponent implements OnInit {

  constructor() { }

  @Input() card: SmartInfoCard = 
  {
     title: "",
     text: "",
     imagePath: "" 
  };

  // @Input() imageSrc: string = "";
  // @Input() titleText: string = "qwer";
  // @Input() mainText: string = "zzdss";


  ngOnInit(): void {
  }

}
