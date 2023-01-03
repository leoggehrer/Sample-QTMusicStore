//@GeneratedCode
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ApiBaseService } from '@app-core/services/api-base.service';
import { environment } from '@environment/environment';
import { Genre } from '@app-core-models/gen/entities/app/genre';
//@CustomImportBegin
//@CustomImportEnd
@Injectable({
  providedIn: 'root',
})
export class GenreService extends ApiBaseService<Genre> {
  constructor(public override http: HttpClient) {
    super(http, environment.API_BASE_URL + '/genres');
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
