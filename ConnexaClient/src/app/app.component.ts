import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { firstValueFrom, lastValueFrom } from 'rxjs';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  private _http = inject(HttpClient);
  title = 'ConnexaClient';
  protected members=signal<any>([]);

  async ngOnInit() {
    this.members.set(await this.getMembers());
  }

  async getMembers(){
    try {
      return await firstValueFrom(this._http.get("http://localhost:5000/api/members/GetMembers"));
    }catch(err) {
      throw err;
    }
  }
}