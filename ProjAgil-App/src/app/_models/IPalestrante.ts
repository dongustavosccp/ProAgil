import { IEvento } from './IEvento';
import { IRedeSocial } from './IRedeSocial';

export interface IPalestrante {

    Id: number;
    Nome: string;
    MiniCurriculo: string;
    ImagemURL: string;
    Telefone: string;
    Email: string;
    RedesSociais: IRedeSocial[];
    PalestrantesEventos: IEvento[];
}

