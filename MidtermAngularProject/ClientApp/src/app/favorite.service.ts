import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Favorite } from './Models/Favorite';

@Injectable({
  providedIn: 'root'
})
export class FavoriteService {
  apiUrl: string = "http://localhost:46877/api/Favorites";
  constructor(private httpClient: HttpClient) { }

  //need a get questions
  getFavorite(): Observable<Favorite[]> {
    return this.httpClient.get<Favorite[]>(this.apiUrl);
  }

  postFavorite(favorite: Favorite): Observable<Favorite> {
    return this.httpClient.post<Favorite>(this.apiUrl, favorite);
  }


}
