import { IEvento } from './IEvento';
import { IPalestrante } from './IPalestrante';

export interface IRedeSocial {
    Nome: string;
    Url: string;
    EventoId: string;
    Evento: IEvento;
    PalestranteId: number;
    Palestrante: IPalestrante;
}
