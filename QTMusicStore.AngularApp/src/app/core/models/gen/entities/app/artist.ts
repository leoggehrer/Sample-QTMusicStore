//@GeneratedCode
import { IVersionEntity } from '@app-core-models/i-version-entity';
import { Album } from '@app-core-models/gen/entities/app/album';
//@CustomImportBegin
//@CustomImportEnd
export interface Artist extends IVersionEntity {
  name: string;
  albums: Album[];
  id: number;
//@CustomCodeBegin
//@CustomCodeEnd
}
