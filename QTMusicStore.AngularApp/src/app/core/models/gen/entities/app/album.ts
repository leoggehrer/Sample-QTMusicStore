//@GeneratedCode
import { IVersionEntity } from '@app-core-models/i-version-entity';
import { Artist } from '@app-core-models/gen/entities/app/artist';
//@CustomImportBegin
//@CustomImportEnd
export interface Album extends IVersionEntity {
  artistId: number;
  title: string;
  artist: Artist;
  id: number;
//@CustomCodeBegin
//@CustomCodeEnd
}
