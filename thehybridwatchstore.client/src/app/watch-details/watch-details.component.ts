import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { WatchService } from '../services/watch.service';

@Component({
  selector: 'app-watch-details',
  templateUrl: './watch-details.component.html',
  styleUrl: './watch-details.component.css'
})
export class WatchDetailsComponent implements OnInit {
  watch: any;

  constructor(private route: ActivatedRoute, private watchService: WatchService) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      const id = params.get('id');
      if (id !== null) {
        this.loadWatchDetails(+id);
      } else {
        console.error('No ID found in the route parameters');
      }
    });
  }

  private loadWatchDetails(id: number): void {
    this.watchService.searchWatchById(id).subscribe(data => {
      this.watch = data;
    }, error => {
      console.error('Error fetching watch details', error);
    });
  }
}
