import { Component, OnInit } from '@angular/core';
import {MatDialog, MatDialogRef} from '@angular/material/dialog';
import { UcLoginComponent } from '../dialog-forms/uclogin/uclogin.component';
import { LoginComponent } from '../login/login.component';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  logoSrc!:string;
  loginSrc!:string;

  constructor(public dialog: MatDialog) { }
  
  initialize() {
    this.logoSrc = "./assets/images/Recipes.svg";
    this.loginSrc = "./assets/images/login.svg";
  }

  ngOnInit(): void {
    this.initialize();
  }
}