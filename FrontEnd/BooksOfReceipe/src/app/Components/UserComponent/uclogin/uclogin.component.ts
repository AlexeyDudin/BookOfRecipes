import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroupDirective, NgForm, Validators} from '@angular/forms';
import {ErrorStateMatcher} from '@angular/material/core';
import { User } from 'src/app/Entityes/user';
import { AuthService } from 'src/app/Services/auth.service';

@Component({
  selector: 'app-uclogin',
  templateUrl: './uclogin.component.html',
  styleUrls: ['./uclogin.component.css']
})
export class UcLoginComponent implements OnInit {

  constructor(private auth: AuthService) { }
  public user: User = {
    Login: "AlexeyD93",
    Password: "1",
    Description: "",
    Username: "Alexey",
  };

  title = "Войдите в профиль";
  text = "Добавлять рецепты могут только зарегистрированные пользователи.";
  isShowText:boolean = true;
  isShowLoginPage: boolean = false;
  isShowRegisterPage: boolean = false;
  hide = true;

  closeCross = "./assets/images/CloseCross.svg"

  ngOnInit(): void {
  }

  loginClick() {
    this.title = "Войти";
    this.isShowText = false;
    this.isShowLoginPage = true;
  }

  registerClick() {
    this.title = "Регистрация";
    this.isShowText = false;
    this.isShowRegisterPage = true;
  }

  loginPostClick() {

  }

  registerPostClick() {
    let jwt = this.auth.createUser(this.user);
  }
}
