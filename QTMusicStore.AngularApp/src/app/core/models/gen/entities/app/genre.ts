//@GeneratedCode
import { IVersionEntity } from '@app-core-models/i-version-entity';
import { Track } from '@app-core-models/gen/entities/app/track';
//@CustomImportBegin
//@CustomImportEnd
export interface Genre extends IVersionEntity {
  name: string;
  tracks: Track[];
  id: number;
//@CustomCodeBegin
//@CustomCodeEnd
}
