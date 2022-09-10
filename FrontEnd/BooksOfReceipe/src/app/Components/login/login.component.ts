import { Component, OnInit } from '@angular/core';
import {MatDialog, MatDialogRef} from '@angular/material/dialog';
import { User } from 'src/app/Entityes/user';
import { UcLoginComponent } from '../UserComponent/uclogin/uclogin.component';
import jwt_decode from 'jwt-decode';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginSrc!: string;
  user: any;

  constructor(public dialog: MatDialog) { }

  getDecodedAccessToken(token: string): any {
    try {
      return jwt_decode(token);
    } catch(Error) {
      return null;
    }
  }

  initialize() {
    this.loginSrc = "./assets/images/login.svg";
    let memoryInfo = localStorage.getItem("recipeBookUser");
    if (!(memoryInfo === null || memoryInfo === "undefined"))
    {
      const tokenInfo = this.getDecodedAccessToken(memoryInfo);
      var currentTimeInMilliseconds=Date.now();
      const expireDate = tokenInfo.exp;
      if (currentTimeInMilliseconds > expireDate)
      {
        localStorage.removeItem("recipeBookUser");
        this.user = null;
        return;
      }
      this.user = new User(); 
      this.user.Login = tokenInfo.name;
    }
    else
      this.user = null;
  }

  ngOnInit(): void {
    this.initialize();
  }

  unLoginUser() {
    localStorage.removeItem("recipeBookUser");
    this.user = null;
  }
  
  openLoginDialog() {
    let result = this.dialog.open(UcLoginComponent);
    localStorage.setItem("recipeBookUser", result.componentInstance.resultUser);
    //TODO
    //localStorage.setItem("recipeBookUser", resultUser);
  }
}