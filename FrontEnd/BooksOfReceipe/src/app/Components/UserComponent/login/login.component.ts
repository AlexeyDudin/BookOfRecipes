import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroupDirective, NgForm, Validators} from '@angular/forms';
import {ErrorStateMatcher} from '@angular/material/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor() { }

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
}
