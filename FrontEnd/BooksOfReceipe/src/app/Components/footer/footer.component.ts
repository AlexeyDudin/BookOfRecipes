import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {

  constructor() { }

  logoSrc!: string;

  initialize() {
    this.logoSrc= "./assets/images/Recipes.svg"
  }

  ngOnInit(): void {
    this.initialize();
  }

}
