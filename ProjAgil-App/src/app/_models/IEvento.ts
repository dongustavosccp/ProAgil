import { ILote } from './ILote';
import { IRedeSocial } from './IRedeSocial';
import { IPalestrante } from './IPalestrante';

export interface IEvento {

    local: string;
    dataEvento: Date;
    tema: string  ;
    quantidade: number;
    imagemURL: string ;
    telefone: string;
    email: string ;
    lotes: ILote[];
    redesSociais: IRedeSocial[];
    palestrantesEventos: IPalestrante[];

}
