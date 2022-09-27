import { Component, OnInit } from '@angular/core';
import { Input } from '@angular/core';
import { SmartInfoCard } from 'src/app/Entityes/SmartInfoCard';

@Component({
  selector: 'app-smart-info-card',
  templateUrl: './smart-info-card.component.html',
  styleUrls: ['./smart-info-card.component.css']
})
export class SmartInfoCardComponent implements OnInit {

  constructor() { }

  @Input() card: any;

  ngOnInit(): void {
  }

}
