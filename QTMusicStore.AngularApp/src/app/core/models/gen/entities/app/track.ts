//@GeneratedCode
import { IVersionEntity } from '@app-core-models/i-version-entity';
import { Album } from '@app-core-models/gen/entities/app/album';
import { Genre } from '@app-core-models/gen/entities/app/genre';
//@CustomImportBegin
//@CustomImportEnd
export interface Track extends IVersionEntity {
  albumId: number;
  generId: number;
  title: string;
  composer: string;
  millisconds: number;
  bytes: number;
  unitPrice: number;
  album: Album;
  genre: Genre;
  id: number;
//@CustomCodeBegin
//@CustomCodeEnd
}
