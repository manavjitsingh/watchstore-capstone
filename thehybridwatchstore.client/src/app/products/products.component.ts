import { Component, OnInit } from '@angular/core';
import { WatchDto } from '../models/watch-dto.model';
import { WatchService } from '../services/watch.service';
import { Router } from '@angular/router';
import { ActivatedRoute } from '@angular/router';
@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrl: './products.component.css'
})
export class ProductsComponent implements OnInit {
  Math = Math;
  isFilterMenuVisible = false; 
  watches: WatchDto[] = [];
  filteredWatches: WatchDto[] = [];
  brands: string[] = [];
  movement: string[] = [];

  filters: { [key in 'gender' | 'brand' | 'movement']: string[] } = {
    gender: [],
    brand: [],
    movement: []
  };

  currentPage = 1;
  pageSize = 10;
  totalItems = 0;
  sortBy = 'Name';
  sortDirection = 'asc';
  showGenderFilter = true;
  constructor(private watchService: WatchService, private router: Router, private route: ActivatedRoute) { }

  //ngOnInit(): void {
  //  this.loadWatches();
  //}
  ngOnInit(): void {
    this.route.queryParams.subscribe(params => {
      const gender = params['gender'];
      if (gender) {
        this.filters.gender = [gender, 'Unisex'];
        this.showGenderFilter = false; 
      } else {
        this.filters.gender = []; // If no gender filter, show all
        this.showGenderFilter = true;
      }
      this.loadWatches();
    });
  }

  //loadWatches(): void {
  //  this.watchService.getAllWatches(this.currentPage, this.pageSize, this.sortBy, this.sortDirection).subscribe(data => {
  //    this.watches = data;
  //    this.extractUniqueBrands();
  //    this.extractMovement();
  //    this.applyFilters();
  //  });
  //}
  loadWatches(): void {
    this.watchService.getAllWatches(this.currentPage, this.pageSize, this.sortBy, this.sortDirection)
      .subscribe({
        next: (response) => {
          console.log('Full Response:', response);
          this.watches = response.body?.watchDtos ?? []; 
          this.totalItems = response.body?.totalItems ?? 0;
          console.log('Response body:', this.watches);
          console.log('Total Items:', this.totalItems);
          this.extractUniqueBrands();
          this.extractMovement();
          //this.applyFilters();
        },
        error: (err) => {
          console.error('Error loading watches', err);
        }
      });
  }
  loadFitlteredWatches(): void {
    this.totalItems = this.filteredWatches.length;
    this.extractUniqueBrands();
    this.extractMovement();
    this.applyFilters();
  }

  toggleFilterMenu() {
    console.log('toggleFilterMenu function fired');  // Confirm the function is firing
    this.isFilterMenuVisible = !this.isFilterMenuVisible;
    console.log('isFilterMenuVisible:', this.isFilterMenuVisible);  // Log the current state
  }
  onSortChange(event: Event): void {
    console.log('onSortChange function fired'); 
    const selectElement = event.target as HTMLSelectElement;
    const value = selectElement.value;
    console.log('Sorting by:', value, 'Direction:', this.sortDirection); 
    this.sortBy = value;
    this.sortDirection = this.sortDirection === 'asc' ? 'desc' : 'asc';
    this.loadWatches();
  }

  onPageChange(pageNumber: number): void {
    this.currentPage = pageNumber;
    console.log('Before loading watches:', this.watches);
    console.log('Before loading watches:', this.totalItems);
    this.loadWatches();
    console.log('After loading watches:', this.watches);
    console.log('After loading watches:', this.totalItems);
  }

  extractUniqueBrands(): void {
    this.brands = [...new Set(this.watches.map(watch => watch.brand))];
  }
  
  extractMovement(): void {
    this.movement = [...new Set(this.watches.map(watch => watch.movement))];
  }
  
  toggleFilter(type: 'gender' | 'brand' | 'movement', value: string): void {
    const index = this.filters[type].indexOf(value);
    if (index > -1) {
      this.filters[type].splice(index, 1);
    } else {
      this.filters[type].push(value);
    }
    this.applyFilters();
  }

  applyFilters(): void {
    this.filteredWatches = this.watches.filter(watch => {
      const genderMatch = this.filters.gender.length ? this.filters.gender.includes(watch.gender) : true;
      const brandMatch = this.filters.brand.length ? this.filters.brand.includes(watch.brand) : true;
      const movementMatch = this.filters.movement.length ? this.filters.movement.includes(watch.movement) : true;
      return genderMatch && brandMatch && movementMatch;
    });
  }
  
  viewDetails(id: number): void {
    // Navigate to the details page for the selected watch
    this.router.navigate(['/watch', id]);
  }
  
}
