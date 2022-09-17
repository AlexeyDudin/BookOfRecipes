import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ServerResponse } from 'src/app/Entityes/ServerResponse'
import { AppSettings } from 'src/app/constants'

@Injectable({
  providedIn: 'root'
})
export class BaseService {
  result: any;

  constructor(private http: HttpClient) { }

  sendPost(routing: string, obj: any):Observable<ServerResponse> {
    //Todo сделать шаблонным
    return this.http.post<any>(AppSettings.hostAddress + routing, obj, {responseType: "json"});
    // this.http.post<any>(this.host + routing, obj, {responseType: "json"}).subscribe({
    //   next: data => {this.result = data},
    //   error: error => {
    //     console.error(error);
    //   }
    // });
    // return this.result; 
  }

  sendGet() {

  }
}
