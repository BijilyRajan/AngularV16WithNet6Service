import { Component, Input } from '@angular/core';
import { HousingLocation } from '../housingLocation';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-locations',
  standalone: true,
  imports: [RouterModule],
  templateUrl: './locations.component.html',
  styleUrl: './locations.component.scss'
})
export class LocationsComponent {
  @Input() housingLocation! : HousingLocation
}
