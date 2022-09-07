import { Component, OnInit, Output } from '@angular/core';
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

  @Output() resultUser: any;

  public user!: User;

  public passwdConfirm: string = "";

  title!: string;
  text!: string;
  isShowText!:boolean;
  isShowLoginPage!: boolean;
  isShowRegisterPage!: boolean;
  hide!:boolean;

  closeCross = "./assets/images/CloseCross.svg"

  initialize(): void {
    this.user = {
      Login: "",
      Password: "",
      Description: "",
      Username: "",
    };
  
    this.passwdConfirm = "";
  
    this.title = "Войдите в профиль";
    this.text = "Добавлять рецепты могут только зарегистрированные пользователи.";
    this.isShowText = true;
    this.isShowLoginPage = false;
    this.isShowRegisterPage = false;
    this.hide = true;
  
    this.closeCross = "./assets/images/CloseCross.svg"
  }

  ngOnInit(): void {
    this.initialize();
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
    this.resultUser = this.auth.createUser(this.user);
  }
}
