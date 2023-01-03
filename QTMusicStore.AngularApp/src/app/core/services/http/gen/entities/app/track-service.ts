//@GeneratedCode
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ApiBaseService } from '@app-core/services/api-base.service';
import { environment } from '@environment/environment';
import { Track } from '@app-core-models/gen/entities/app/track';
//@CustomImportBegin
//@CustomImportEnd
@Injectable({
  providedIn: 'root',
})
export class TrackService extends ApiBaseService<Track> {
  constructor(public override http: HttpClient) {
    super(http, environment.API_BASE_URL + '/tracks');
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
