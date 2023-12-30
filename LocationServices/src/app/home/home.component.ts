import { Component, inject } from '@angular/core';
import { LocationsComponent } from '../locations/locations.component';
import { HousingLocation } from '../housingLocation';
import { CommonModule } from '@angular/common';
import { HousingService } from '../housing.service';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule, LocationsComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {

  readonly baseUrl = 'https://angular.dev/assets/tutorials/common';
  housingLocationList: HousingLocation[] = [];
  housingService: HousingService = inject(HousingService);
  filteredHousingList: HousingLocation[] = [];

constructor(){
  this.housingService.getAllHousingLocations().then((housingLocationList: HousingLocation[]) => {
    this.housingLocationList = housingLocationList;
    this.filteredHousingList = housingLocationList;
  }) ;
}

filterResults(text:string){
  if(!text) this.filteredHousingList = this.housingLocationList;

  this.filteredHousingList = this.housingLocationList.filter(
    housingLocation => housingLocation.city.toLowerCase().includes(text.toLowerCase())
  ); 
  
}

}
