//@GeneratedCode
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ApiBaseService } from '@app-core/services/api-base.service';
import { environment } from '@environment/environment';
import { Artist } from '@app-core-models/gen/entities/app/artist';
//@CustomImportBegin
//@CustomImportEnd
@Injectable({
  providedIn: 'root',
})
export class ArtistService extends ApiBaseService<Artist> {
  constructor(public override http: HttpClient) {
    super(http, environment.API_BASE_URL + '/artists');
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
