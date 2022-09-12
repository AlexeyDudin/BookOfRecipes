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
  user: User | null = null;

  constructor(public dialog: MatDialog) { }

  getDecodedAccessToken(token: string): any {
    try {
      return jwt_decode(token);
    } catch(Error) {
      return null;
    }
  }

  initUser() {
    let memoryInfo = localStorage.getItem("recipeBookUser");
    if (!(memoryInfo === null || memoryInfo === "undefined"))
    {
      const tokenInfo = this.getDecodedAccessToken(memoryInfo);
      var currentTimeInMilliseconds=(Date.now() / 1000);
      const expireDate = tokenInfo.exp;
      if (currentTimeInMilliseconds > expireDate)
      {
        localStorage.removeItem("recipeBookUser");
        this.user = null;
        return;
      }
      this.user = new User(); 
      this.user.Login = tokenInfo.login;
      this.user.Username = tokenInfo.userName;
    }
    else
      this.user = null;
  }

  initialize() {
    this.loginSrc = "./assets/images/login.svg";
    this.initUser();
  }

  ngOnInit(): void {
    this.initialize();
  }

  unLoginUser() {
    localStorage.removeItem("recipeBookUser");
    this.user = null;
  }

  saveToStorage(storageInfo: string) {
    localStorage.setItem("recipeBookUser", storageInfo);
  }

  onChangeUser(user: string) {
    localStorage.setItem("recipeBookUser", user);
    this.initUser();
  }
  
  openLoginDialog() {
    let result = this.dialog.open(UcLoginComponent, {
      data: { loginComponent: this},
    });
    result.beforeClosed().subscribe(result => {this.saveToStorage(result.componentInstance.resultUser); this.initUser()});
    
    //TODO
    //localStorage.setItem("recipeBookUser", resultUser);
  }
}