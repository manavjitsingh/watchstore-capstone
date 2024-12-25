//import { Component } from '@angular/core';
//import { WatchService } from '../services/watch.service';
//import { AuthService } from '../services/auth.service';
//@Component({
//  selector: 'app-nav-menu',
//  templateUrl: './nav-menu.component.html',
//  styleUrl: './nav-menu.component.css'
//})
//export class NavMenuComponent {

//  searchResults: any[] = [];
//  isSidebarVisible = false;
//  constructor(private watchService: WatchService) { }

//  onSearch(query: string): void {
//    console.log('Search triggered with query:', query);
//    if (!query) {
//      this.searchResults = [];  // Clear results if the search query is empty
//      return;
//    }
//    if (query) {
//      this.watchService.searchWatches(query).subscribe(
//        results => {
//          this.searchResults = results;
//          console.log(this.searchResults); // For debugging
//        },
//        error => console.error('Error searching watches', error)
//      );
//    }
//  }
//  onResultClick(): void {
//    // Clear the search results when a search result is clicked
//    this.searchResults = [];
//  }
//  toggleSidebar() {
//    console.log('navi function fired');
//    this.isSidebarVisible = !this.isSidebarVisible;
//  }
//}
import { Component } from '@angular/core';
import { WatchService } from '../services/watch.service';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css'] // Corrected typo: styleUrl -> styleUrls
})
export class NavMenuComponent {
  isLoggedIn = this.authService.isLoggedIn;
  searchResults: any[] = [];
  isSidebarVisible = false;
  userEmail = this.authService.currentUserEmail;

  constructor(private watchService: WatchService, private authService: AuthService) { } // Inject AuthService

  onSearch(query: string): void {
    console.log('Search triggered with query:', query);
    if (!query) {
      this.searchResults = [];  // Clear results if the search query is empty
      return;
    }
    if (query) {
      this.watchService.searchWatches(query).subscribe(
        results => {
          this.searchResults = results;
          console.log(this.searchResults); // For debugging
        },
        error => console.error('Error searching watches', error)
      );
    }
  }

  onResultClick(): void {
    // Clear the search results when a search result is clicked
    this.searchResults = [];
  }

  toggleSidebar() {
    console.log('navi function fired');
    this.isSidebarVisible = !this.isSidebarVisible;
  }

  logout(): void {
    this.authService.logout(); // Log the user out
  }
}

