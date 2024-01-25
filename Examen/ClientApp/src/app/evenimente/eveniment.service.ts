import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Eveniment } from './eveniment';

@Injectable({
  providedIn: 'root'
})
export class EvenimentService {
  private readonly route = 'api/eveniment';
  constructor(private http: HttpClient) { }

  add(item: any) {
    var url = "/api/eveniment/create";
    
    return this.http.post<any>(url, item);
  }
}
