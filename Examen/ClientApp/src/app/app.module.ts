import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { EvenimenteComponent } from './evenimente/evenimente.component';
import { EditEvenimenteComponent } from './edit-evenimente/edit-evenimente.component';
import { ParticipantiComponent } from './participanti/participanti.component';
import { EditParticipantiComponent } from './edit-participanti/edit-participanti.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    EvenimenteComponent,
    EditEvenimenteComponent,
    ParticipantiComponent,
    EditParticipantiComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'evenimente', component: EvenimenteComponent },
      { path: 'participanti', component: ParticipantiComponent },
      { path: 'evenimente/edit', component: EditEvenimenteComponent },
      { path: 'participanti/edit', component: EditParticipantiComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
