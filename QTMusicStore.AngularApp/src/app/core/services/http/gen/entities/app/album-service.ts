//@GeneratedCode
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ApiBaseService } from '@app-core/services/api-base.service';
import { environment } from '@environment/environment';
import { Album } from '@app-core-models/gen/entities/app/album';
//@CustomImportBegin
//@CustomImportEnd
@Injectable({
  providedIn: 'root',
})
export class AlbumService extends ApiBaseService<Album> {
  constructor(public override http: HttpClient) {
    super(http, environment.API_BASE_URL + '/albums');
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
