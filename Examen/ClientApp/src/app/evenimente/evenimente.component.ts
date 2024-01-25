import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-evenimente',
  templateUrl: './evenimente.component.html',
  styleUrls: ['./evenimente.component.css']
})
export class EvenimenteComponent {
  public evenimente: Eveniment[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Eveniment[]>(baseUrl + 'api/eveniment/all').subscribe(result => {
      this.evenimente = result;
    }, error => console.error(error));
  }

}
interface Eveniment {
  id: string;
  denumire: string;
}
