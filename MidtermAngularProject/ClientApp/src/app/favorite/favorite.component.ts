import { Component, OnInit } from '@angular/core';
import { Favorite } from '../Models/Favorite';
import { FavoriteService } from '../favorite.service';

@Component({
  selector: 'app-favorite',
  templateUrl: './favorite.component.html',
  styleUrls: ['./favorite.component.css']
})
export class FavoriteComponent implements OnInit {
  favorite: Favorite[];

  constructor(private favoriteService: FavoriteService) { }

  ngOnInit() {
    this.favoriteService.getFavorite()
      .subscribe(result => {
        this.favorite = result;
      })


  }

}
