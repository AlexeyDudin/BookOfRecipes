import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BaseService {
  host: string = "https://localhost:7119";

  constructor(private http: HttpClient) { }

  sendPost(routing: string, obj: any) {
    let result;
    this.http.post(this.host + routing, obj, {responseType: "json"}).subscribe(data => {result = data});
    return result 
  }

  sendGet() {

  }
}
